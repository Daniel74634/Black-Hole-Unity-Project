using DTET.VisualPrototype;

internal static class StoryboardChoreographyTests
{
    public static void Run()
    {
        static void Require(bool condition, string label)
        {
            if (!condition) throw new Exception(label);
        }
        Require(StoryboardChoreography.Phase(-1) == 0, "Lower visual phase bound");
        Require(Math.Abs(StoryboardChoreography.Phase(2) - 8 * Math.PI) < 1e-12,
            "Upper visual phase bound is four illustrative turns");
        var earlier = StoryboardChoreography.Phase(0.4);
        _ = StoryboardChoreography.Phase(0.9);
        Require(StoryboardChoreography.Phase(0.4) == earlier, "Seek is stateless and repeatable");
        var firstStep = StoryboardChoreography.Phase(0.01) - StoryboardChoreography.Phase(0);
        var finalStep = StoryboardChoreography.Phase(1) - StoryboardChoreography.Phase(0.99);
        Require(finalStep > firstStep * 3.8, "Illustrative angular speed accelerates");
        var previous = -1.0;
        for (var i = 0; i <= 1000; i++)
        {
            var phase = StoryboardChoreography.Phase(i / 1000.0);
            Require(double.IsFinite(phase) && phase > previous, "Finite monotonic visual phase");
            previous = phase;
        }
        foreach (var invalid in new[] { double.NaN, double.PositiveInfinity, double.NegativeInfinity })
        {
            try { StoryboardChoreography.Phase(invalid); throw new Exception("Accepted non-finite progress"); }
            catch (ArgumentException) { }
        }
        Console.WriteLine("PASS: deterministic accelerating storyboard phase, replay and input bounds (not orbital physics)");
    }
}
