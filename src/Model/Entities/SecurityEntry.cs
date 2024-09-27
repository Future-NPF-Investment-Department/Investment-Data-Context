﻿#pragma warning disable IDE0090

using RuDataAPI.Extensions;

namespace InvestmentDataModel
{
    /// <summary>
    ///     Represents general market information about specific security.
    /// </summary>
    public record SecurityEntry
    {
        public SecurityEntry() { }

        private SecurityEntry(InstrumentInfo secinfo, AssetClass assetClass, RiskType riskType)
        {
            Isin = secinfo.Isin;
            Name = secinfo.Name;
            IssuerName = secinfo.Issuer;
            AssetClass = assetClass;
            FaceValue = secinfo.InitialFaceValue;
            Currency = secinfo.Currency;
            CouponType = secinfo.CouponType.ToString();
            CouponPeriod = secinfo.CouponLength.ToString();
            Reference = secinfo.CouponReference;
            MaturityDate = secinfo.MaturityDate;
            Status = secinfo.Status.ToString();
            IssueVolume = secinfo.MarketVolume;
            IssuerSector = secinfo.IssuerSector.ToString();
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
        public virtual ICollection<AssetEntry> Portfolio { get; set; } = null!;
        public virtual ICollection<FlowEntry> Flows { get; set; } = null!;

        public static SecurityEntry New(InstrumentInfo secinfo, AssetClass assetClass, RiskType riskType)
            => new SecurityEntry(secinfo, assetClass, riskType);
    }
}
