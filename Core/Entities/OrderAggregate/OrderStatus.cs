using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,

        [EnumMember(Value = "Payment Received")]
        PaymentReceived,

        [EnumMember(Value = "Payment failed")]
        PaymentFailed,

        //extra enums

        [EnumMember(Value = "Order shipped")]
        Shipped,

        //extra enums
        [EnumMember(Value = "Order completed")]
        Completed
    }
}
