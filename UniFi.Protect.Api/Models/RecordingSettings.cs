namespace UniFi.Protect.Api.Models;

using Newtonsoft.Json;

public class RecordingSettings
{
    [JsonConstructor]
    public RecordingSettings(
        int prePaddingSecs,
        int postPaddingSecs,
        int minMotionEventTrigger,
        int endMotionEventDelay,
        bool suppressIlluminationSurge,
        string mode,
        string geofencing,
        string motionAlgorithm,
        bool enablePirTimelapse,
        bool useNewMotionAlgorithm)
    {
        this.PrePaddingSecs = prePaddingSecs;
        this.PostPaddingSecs = postPaddingSecs;
        this.MinMotionEventTrigger = minMotionEventTrigger;
        this.EndMotionEventDelay = endMotionEventDelay;
        this.SuppressIlluminationSurge = suppressIlluminationSurge;
        RecordingMode parsedMode = RecordingMode.Unknown;
        if (Enum.TryParse<RecordingMode>(mode, out parsedMode))
        {
            this.Mode = parsedMode;
        }

        this.Geofencing = geofencing;
        this.MotionAlgorithm = motionAlgorithm;
        this.EnablePirTimelapse = enablePirTimelapse;
        this.UseNewMotionAlgorithm = useNewMotionAlgorithm;
    }

    public int PrePaddingSecs { get; }

    public int PostPaddingSecs { get; }

    public int MinMotionEventTrigger { get; }

    public int EndMotionEventDelay { get; }

    public bool SuppressIlluminationSurge { get; }

    public RecordingMode Mode { get; }

    public string Geofencing { get; }

    public string MotionAlgorithm { get; }

    public bool EnablePirTimelapse { get; }

    public bool UseNewMotionAlgorithm { get; }
}