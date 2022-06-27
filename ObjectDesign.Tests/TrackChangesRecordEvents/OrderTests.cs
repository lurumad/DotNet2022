using FluentAssertions;
using ObjectDesign.TrackChangesRecordEvents;

namespace ObjectDesign.Tests
{
    public class order_should
    {
        [Fact]
        public void allow_to_be_cancelled()
        {
            var order = Order.Place(new OrderId(Guid.NewGuid()));
            order.Cancel();
            order.Events.Last().Should().BeOfType<OrderCancelled>();
        }
    }
}

