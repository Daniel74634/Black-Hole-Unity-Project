using UnityEngine;
using UnityEngine.UI;

namespace DTET.VisualPrototype
{
    public sealed class HudProgressGraphic : MaskableGraphic
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
            var radius = Mathf.Min(rect.width, rect.height) * 0.5f - 4;
            const int segments = 120;
            for (var i = 0; i < segments; i++)
            {
                var a = Mathf.PI * 0.5f - i * Mathf.PI * 2f / segments;
                var b = Mathf.PI * 0.5f - (i + 1) * Mathf.PI * 2f / segments;
                HudSignalGraphic.Stroke(mesh, rect.center + new Vector2(Mathf.Cos(a), Mathf.Sin(a)) * radius,
                    rect.center + new Vector2(Mathf.Cos(b), Mathf.Sin(b)) * radius, 5,
                    (i + 1) / (float)segments <= progress ? color : new Color(color.r, color.g, color.b, 0.12f));
            }
        }
    }
}
