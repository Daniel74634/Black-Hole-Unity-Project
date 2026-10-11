Shader "DTET/ConceptualAccretion"
{
    Properties
    {
        _Tint ("Outer tint", Color) = (0.4, 0.8, 1, 1)
        _InnerTint ("Inner tint", Color) = (1, 0.6, 0.25, 1)
        _Opacity ("Opacity", Range(0, 1)) = 0.65
        _FlowSpeed ("Illustrative flow", Float) = 0.4
    }
    SubShader
    {
        Tags { "RenderPipeline"="UniversalPipeline" "Queue"="Transparent" "RenderType"="Transparent" }
        Pass
        {
            Name "Conceptual disk"
            Tags { "LightMode"="SRPDefaultUnlit" }
            Blend SrcAlpha One
            ZWrite Off
            Cull Off

            HLSLPROGRAM
            #pragma vertex Vertex
            #pragma fragment Fragment
            #pragma multi_compile_instancing
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _Tint;
                float4 _InnerTint;
                float _Opacity;
                float _FlowSpeed;
            CBUFFER_END
            float _StoryDisplayTime;

            struct Attributes
            {
                float4 positionOS : POSITION;
                float2 uv : TEXCOORD0;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct Varyings
            {
                float4 positionHCS : SV_POSITION;
                float2 uv : TEXCOORD0;
                UNITY_VERTEX_OUTPUT_STEREO
            };

            Varyings Vertex(Attributes input)
            {
                Varyings output;
                UNITY_SETUP_INSTANCE_ID(input);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(output);
                output.positionHCS = TransformObjectToHClip(input.positionOS.xyz);
                output.uv = input.uv;
                return output;
            }

            float Hash(float3 p)
            {
                p = frac(p * 0.1031);
                p += dot(p, p.yzx + 33.33);
                return frac((p.x + p.y) * p.z);
            }

            float Noise(float3 p)
            {
                float3 i = floor(p), f = frac(p);
                f = f * f * (3.0 - 2.0 * f);
                return lerp(lerp(lerp(Hash(i), Hash(i + float3(1,0,0)), f.x),
                    lerp(Hash(i + float3(0,1,0)), Hash(i + float3(1,1,0)), f.x), f.y),
                    lerp(lerp(Hash(i + float3(0,0,1)), Hash(i + float3(1,0,1)), f.x),
                    lerp(Hash(i + float3(0,1,1)), Hash(i + float3(1,1,1)), f.x), f.y), f.z);
            }

            half4 Fragment(Varyings input) : SV_Target
            {
                UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(input);
                float radius = saturate(input.uv.x);
                float angle = input.uv.y * 6.2831853;
                float time = _StoryDisplayTime * _FlowSpeed;
                // Cartesian coordinates stay periodic at the UV seam. Detail fades below a pixel.
                float swirl = angle - time * 0.8 + radius * 3.0;
                float3 p = float3(cos(swirl), sin(swirl), radius * 2.5) * 3.8;
                float footprint = max(length(ddx(p)), length(ddy(p)));
                float coarse = Noise(p);
                float fine = lerp(0.5, Noise(p * 2.0 + 7.1), 1.0 - smoothstep(0.12, 0.8, footprint));
                float structure = 0.34 + 0.32 * coarse + 0.13 * fine;
                float edge = smoothstep(0.01, 0.14, radius) * (1.0 - smoothstep(0.78, 1.0, radius));
                float hotspot = 1.0 + 0.22 * sin(angle + 0.8);
                float3 color = lerp(_InnerTint.rgb, _Tint.rgb, radius);
                float alpha = saturate(_Opacity * edge * structure * hotspot);
                return half4(color * (1.35 - 0.3 * radius), alpha);
            }
            ENDHLSL
        }
    }
}
