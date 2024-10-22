using ArrowSphereApiDotNet.Models.Partners;
using System;

namespace ArrowSphereApiDotNet
{
    public interface IPartners
    {
        Task<WhoAmI> WhoAmI();
    }
}
