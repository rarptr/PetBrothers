using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record VolunteerDetails
{
    public List<SocialNetwork> SocialNetworks { get; private set; } = [];
    public List<PaymentDetail> PaymentDetails { get; private set; } = [];

    //private readonly List<SocialNetwork> _socialNetworks = [];
    //private readonly List<PaymentDetail> _paymentDetails = [];

    ///// <summary>
    ///// Социальные сети
    ///// </summary>
    //public IReadOnlyList<SocialNetwork> SocialNetworks => _socialNetworks;

    ///// <summary>
    ///// Реквизиты для финансовой помощи
    ///// </summary>
    //public IReadOnlyList<PaymentDetail> PaymentDetails => _paymentDetails;

    //public Result AddSocialNetwork(SocialNetwork socialNetwork)
    //{
    //    _socialNetworks.Add(socialNetwork);
    //    return Result.Success();
    //}

    //public Result AddPaymentDetail(PaymentDetail paymentDetail)
    //{
    //    _paymentDetails.Add(paymentDetail);
    //    return Result.Success();
    //}
}
