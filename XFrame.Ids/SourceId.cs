using XFrame.ValueObjects.SingleValueObjects;

namespace XFrame.Ids
{
    public class SourceId : SingleValueObject<string>, ISourceId
    {
        public static ISourceId New => new SourceId(Guid.NewGuid().ToString("D"));

        public SourceId(string value) : base(value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));
        }
    }
}
