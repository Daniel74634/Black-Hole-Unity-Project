using UnityEngine;

namespace DTET.VisualPrototype
{
    /// <summary>A fixed synthetic emitter, independent of its apparent image(s).
    /// Positions and sizes are exhibit units, not astronomical metres. Tint is authored, not a spectrum.</summary>
    public sealed class StellarSource : MonoBehaviour
    {
        internal bool CachedActive;
        public int SourceId { get; private set; }
        public float DisplayRadius { get; private set; }
        public Color RestTint { get; private set; }

        public void Initialize(int id, float radius, Color tint)
        {
            SourceId = id;
            DisplayRadius = radius;
            RestTint = tint;
            transform.hasChanged = true;
        }
    }
}
