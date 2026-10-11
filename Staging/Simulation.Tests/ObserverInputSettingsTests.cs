using DTET.VisualPrototype;

internal static class ObserverInputSettingsTests
{
    public static void Run()
    {
        var settings = new ObserverInputSettings();
        Check(settings.Look == 1 && settings.Scroll == 3, "Default look unchanged; scroll tripled");
        settings.SetLook(-1); settings.SetScroll(-1);
        Check(settings.Look == 0.25f && settings.Scroll == 0.25f, "Positive lower bounds");
        settings.SetLook(100); settings.SetScroll(100);
        Check(settings.Look == 4 && settings.Scroll == 10, "Upper bounds");
        foreach (var invalid in new[] { float.NaN, float.PositiveInfinity, float.NegativeInfinity })
            Check(!settings.SetLook(invalid) && !settings.SetScroll(invalid)
                && settings.Look == 4 && settings.Scroll == 10, "Reject nonfinite input without mutation");
        settings.SetLook(1.75f); settings.SetScroll(4.5f);
        Check(settings.Look == 1.75f && settings.Scroll == 4.5f, "Independent continuous settings");
        settings.Reset();
        Check(settings.Look == 1 && settings.Scroll == 3, "Defaults reset");
        Console.WriteLine("PASS: observer input sensitivity defaults, independent values, bounds, reset and invalid inputs");
    }

    private static void Check(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
}
