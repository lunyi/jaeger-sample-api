using System.Diagnostics;

namespace jaeget_sample_api
{
    public static class DiagnosticsConfig
    {
        public const string ServiceName = "jaeget-sample-api";
        public static ActivitySource ActivitySource = new ActivitySource(ServiceName);
    }
}
