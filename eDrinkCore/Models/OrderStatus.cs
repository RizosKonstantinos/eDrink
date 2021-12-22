using System.ComponentModel;

namespace eDrinkCore.Models
{
    public enum OrderStatus
    {
        [Description("Order pending")]
        stage1,
        [Description("Order placed")]
        stage2,
        [Description("We've found you a driver")]
        stage3,
        [Description("Driver is on the way to you")]
        stage4,
        [Description("Hurrah! Driver has arrived")]
        stage5
    }
}
