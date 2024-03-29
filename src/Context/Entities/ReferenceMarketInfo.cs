﻿#pragma warning disable IDE0090

using InvestmentData.Classifications;
using RuDataAPI.Extensions;

namespace InvestmentData.Context.Entities
{
    /// <summary>
    ///     Represents general market information about specific security.
    /// </summary>
    public record ReferenceMarketInfo
    {
        public ReferenceMarketInfo() { }

        private ReferenceMarketInfo(EfirSecurity secinfo, AssetClass assetClass, RiskType riskType)
        {
            Isin = secinfo.Isin;
            Name = secinfo.ShortName;
            IssuerName = secinfo.IssuerName;
            AssetClass = assetClass;
            FaceValue = secinfo.Notional;
            Currency = secinfo.Currency;
            CouponType = secinfo.CouponType;
            CouponPeriod = secinfo.CouponPeriod;
            Reference = secinfo.CouponReferenceRateName;
            MaturityDate = secinfo.MaturityDate;
            Status = secinfo.Status;
            IssueVolume = secinfo.IssueVolume;
            IssuerSector = secinfo.IssueSector;
            RiskType = riskType;
        }

        public string? Isin { get; set; }
        public string? Name { get; set; }
        public string? IssuerName { get; set; }
        public AssetClass AssetClass { get; set; }
        public double? FaceValue { get; set; }
        public string? Currency { get; set; }
        public string? CouponType { get; set; }
        public string? CouponPeriod { get; set; }
        public string? Reference { get; set; }
        public DateTime? MaturityDate { get; set; }
        public DateTime? OfferDate { get; set; }
        public string? Status { get; set; }
        public double? IssueVolume { get; set; }
        public string? IssuerSector { get; set; }
        public RiskType RiskType { get; set; }
        public virtual ICollection<AssetValue> Portfolio { get; set; } = null!;
        public virtual ICollection<AssetFlow> Flows { get; set; } = null!;

        public static ReferenceMarketInfo New(EfirSecurity secinfo, AssetClass assetClass, RiskType riskType)
            => new ReferenceMarketInfo(secinfo, assetClass, riskType);
    }
}
