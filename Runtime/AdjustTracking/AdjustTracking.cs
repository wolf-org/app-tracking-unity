namespace VirtueSky.Tracking
{
    public struct AdjustTracking
    {
        public static void TrackEvent(string eventToken)
        {
#if VIRTUESKY_ADJUST
            AdjustSdk.Adjust.TrackEvent(new AdjustSdk.AdjustEvent(eventToken));
#endif
        }
    }
}