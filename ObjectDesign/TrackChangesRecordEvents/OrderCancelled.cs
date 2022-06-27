namespace ObjectDesign.TrackChangesRecordEvents
{
    public class OrderCancelled : IEvent
    {
        public static OrderCancelled Create()
        {
            return new OrderCancelled();
        }
    }
}
