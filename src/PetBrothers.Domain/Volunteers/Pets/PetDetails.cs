namespace PetBrothers.Domain.Volunteers.Pets;

public record PetDetails
{
    public List<PaymentDetail> PaymentDetails { get; private set; } = [];

    //private readonly List<PaymentDetail> _paymentDetails = [];

    //public IReadOnlyList<PaymentDetail> Value => _paymentDetails;

    //public Result AddPaymentDetails(PaymentDetail paymentDetails)
    //{
    //    _paymentDetails.Add(paymentDetails);
    //    return Result.Success();
    //}
}
