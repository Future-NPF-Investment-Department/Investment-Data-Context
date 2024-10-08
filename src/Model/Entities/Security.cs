﻿
namespace InvestmentDataModel
{
    /// <summary>
    ///     Represents general market information about specific security.
    /// </summary>
    public record Security
    {
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
        public virtual ICollection<NetAssetValue> Portfolio { get; set; } = null!;
        public virtual ICollection<Flow> Flows { get; set; } = null!;
    }
}
