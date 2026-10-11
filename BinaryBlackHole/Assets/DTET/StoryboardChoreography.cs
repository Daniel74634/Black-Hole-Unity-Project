using System;

namespace DTET.VisualPrototype
{
    /// <summary>Deterministic artistic staging, NOT physical orbital phase or an inspiral solver.</summary>
    public static class StoryboardChoreography
    {
        public static double Phase(double progress)
        {
            if (double.IsNaN(progress) || double.IsInfinity(progress)) throw new ArgumentException("Progress must be finite.");
            var p = Math.Max(0, Math.Min(1, progress));
            // Four visible turns, with a fourfold increase in illustrative angular speed.
            return 8 * Math.PI * (0.4 * p + 0.6 * p * p);
        }
    }
}
