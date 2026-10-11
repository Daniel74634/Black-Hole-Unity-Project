using UnityEngine;
using UnityEngine.UI;

namespace DTET.VisualPrototype
{
    /// <summary>Qualitative increasing-frequency artwork; never represents detector strain or Hz.</summary>
    public sealed class HudSignalGraphic : MaskableGraphic
    {
        private float progress;
        public void SetProgress(float value)
        {
            if (Mathf.Approximately(progress, value)) return;
            progress = value;
            SetVerticesDirty();
        }

        protected override void OnPopulateMesh(VertexHelper mesh)
        {
            mesh.Clear();
            var rect = rectTransform.rect;
            var muted = new Color(color.r, color.g, color.b, 0.19f);
            Stroke(mesh, new Vector2(rect.xMin, rect.center.y), new Vector2(rect.xMax, rect.center.y), 1, muted);
            const int samples = 400;
            for (var i = 0; i < samples; i++)
            {
                var t = i / (float)samples;
                var next = (i + 1) / (float)samples;
                var a = new Vector2(rect.xMin + t * rect.width, rect.center.y + Wave(t) * rect.height * 0.44f);
                var b = new Vector2(rect.xMin + next * rect.width, rect.center.y + Wave(next) * rect.height * 0.44f);
                Stroke(mesh, a, b, 1.8f, next <= progress ? color : muted);
            }
            var cursorX = Mathf.Lerp(rect.xMin, rect.xMax, progress);
            Stroke(mesh, new Vector2(cursorX, rect.yMin), new Vector2(cursorX, rect.yMax), 1.5f, new Color(0.95f, 0.70f, 0.36f));
        }

        private static float Wave(float t) => Mathf.Sin(2f * Mathf.PI * (3f * t + 11f * t * t * t)) * Mathf.Lerp(0.18f, 1f, t * t);

        internal static void Stroke(VertexHelper mesh, Vector2 a, Vector2 b, float thickness, Color color)
        {
            var direction = (b - a).normalized;
            var normal = new Vector2(-direction.y, direction.x) * thickness * 0.5f;
            var index = mesh.currentVertCount;
            mesh.AddVert(a - normal, color, Vector2.zero);
            mesh.AddVert(a + normal, color, Vector2.zero);
            mesh.AddVert(b + normal, color, Vector2.zero);
            mesh.AddVert(b - normal, color, Vector2.zero);
            mesh.AddTriangle(index, index + 1, index + 2);
            mesh.AddTriangle(index, index + 2, index + 3);
        }
    }
}
