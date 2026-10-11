using DTET.VisualPrototype;

internal static class RelativityClockTests
{
    public static void Run()
    {
        var absent = new RelativityClockSnapshot("staging", 1, 2, RelativityFidelity.Unavailable);
        Require(!absent.VisitorProperSeconds.HasValue && !absent.ReferenceProperSeconds.HasValue
            && !absent.DifferenceSeconds.HasValue && !absent.VisitorToReferenceRate.HasValue, "No invented clock values");
        var clocks = new RelativityClockSnapshot("test-only", 3, 4, RelativityFidelity.Relativistic, 8, 10, 0.8);
        Require(clocks.DifferenceSeconds == -2, "Clock difference sign");
        Require(clocks.Matches("test-only", 3, 4), "Current clock snapshot");
        Require(!clocks.Matches("test-only", 4, 4), "Seek/reset epoch invalidates clock history");
        Require(!clocks.Matches("test-only", 3, 5), "Teleport invalidates worldline history");
        Require(!clocks.Matches("other-model", 3, 4), "Different metric rejected");
        foreach (Action invalid in new Action[] {
            () => new RelativityClockSnapshot("staging", 0, 0, RelativityFidelity.Unavailable, 0, 0, 1),
            () => new RelativityClockSnapshot("test-only", 0, 0, RelativityFidelity.Relativistic),
            () => new RelativityClockSnapshot("test-only", 0, 0, RelativityFidelity.Approximate, double.NaN, 1, 1),
            () => new RelativityClockSnapshot("test-only", 0, 0, RelativityFidelity.Approximate, 1, double.PositiveInfinity, 1),
            () => new RelativityClockSnapshot("test-only", 0, 0, RelativityFidelity.Approximate, -1, 1, 1),
            () => new RelativityClockSnapshot("test-only", 0, 0, RelativityFidelity.Approximate, 1, 1, 0),
            () => new RelativityClockSnapshot("test-only", 0, 0, RelativityFidelity.Approximate, 1, 1, double.NaN),
            () => new RelativityClockSnapshot("test-only", -1, 0, RelativityFidelity.Approximate, 1, 1, 1),
            () => new RelativityClockSnapshot("", 0, 0, RelativityFidelity.Unavailable)
        })
        {
            bool rejected = false;
            try { invalid(); } catch (ArgumentException) { rejected = true; }
            Require(rejected, "Invalid clock snapshot rejected");
        }
        Console.WriteLine("PASS: proper-time snapshot availability, units contract, differences, stale history and validation");
    }

    private static void Require(bool condition, string description)
    { if (!condition) throw new Exception(description); }
}
