﻿using Microsoft.EntityFrameworkCore;

namespace InvestmentDataModel
{
    public class AssetsQueryBuilder : InvestDataQueryBuilder<NetAssetValue, AssetsQueryBuilder>
    {
        public AssetsQueryBuilder(InvestData context) : base(context)
            => _query = _context.Assets.AsNoTracking();

        private protected override AssetsQueryBuilder Builder
            => this;


        public AssetsQueryBuilder WithAccountingMethod(AccountingMethod? method)
        {
            _query = (method is not null)
                ? _query.Where(q => q.AccountingMethod == method)
                : _query;

            return this;
        }

        public AssetsQueryBuilder WithRealPrices()
        {
            _query = _query.Where(q => q.UseRealPricing);
            return this;
        }

        public AssetsQueryBuilder WithFairPrices()
        {
            _query = _query.Where(q => q.UseFairPricing);
            return this;
        }
    }
}
