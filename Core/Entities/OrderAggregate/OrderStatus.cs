namespace Core.Entities.OrderAggregate;

public enum OrderStatus
{
    Pending,
    PaymentReceived,
    PyamentFailed,
    PaymentMismatch
}
