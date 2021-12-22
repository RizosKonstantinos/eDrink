using System.ComponentModel;

namespace eDrinkCore.Models
{
    public enum PaymentMethod
    {
        [Description("Cash")]
        method1,
        [Description("Credit card")]
        method2,
        [Description("PayPal")]
        method3,
        [Description("Apple Pay")]
        method4
    }
}
