namespace XFrame.Ids.Extensions
{
    public static class SourceIdExtensions
    {
        public static bool IsNone(this ISourceId sourceId)
        {
            return string.IsNullOrEmpty(sourceId?.Value);
        }
    }
}
