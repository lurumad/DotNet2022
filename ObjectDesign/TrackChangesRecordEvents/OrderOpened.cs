namespace ObjectDesign.TrackChangesRecordEvents
{
    public class OrderOpened : IEvent
    {
        public static OrderOpened Create()
        {
            return new OrderOpened();
        }
    }
}
