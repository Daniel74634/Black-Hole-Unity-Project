namespace DTET.VisualPrototype
{
    /// <summary>Presentation data, not a second simulation clock. Null physical values mean unavailable.</summary>
    public readonly struct LessonHudSnapshot
    {
        public readonly float Progress, PlaybackRate, VisualSeparationRatio;
        public readonly bool Playing;
        public readonly double? SeparationKm, OrbitsPerSecond, WaveFrequencyHz;
        public bool ConceptualEndpoint => Progress >= 0.98f;
        public float PlaybackSecondsLeft => (1f - Progress) * 40f / PlaybackRate;

        public LessonHudSnapshot(float progress, float playbackRate, float visualSeparationRatio, bool playing,
            double? separationKm = null, double? orbitsPerSecond = null, double? waveFrequencyHz = null)
        {
            Progress = progress;
            PlaybackRate = playbackRate;
            VisualSeparationRatio = visualSeparationRatio;
            Playing = playing;
            SeparationKm = separationKm;
            OrbitsPerSecond = orbitsPerSecond;
            WaveFrequencyHz = waveFrequencyHz;
        }
    }

    public interface ILessonHudProvider
    {
        LessonHudSnapshot CaptureHudSnapshot();
        void TogglePlayback();
        void ResetPlayback();
        void SeekStoryboard(float progress);
        void SetHudPlaybackRate(float rate);
        void SetLearningVisible(bool visible);
    }
}
