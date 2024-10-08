﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InvestmentDataModel.Model.Configurations
{
    /// <summary>
    ///     Configures <see cref="SourceFile"/> entity for Entity Framework.
    /// </summary>
    public class SourceFileEntityConfigurer : IEntityTypeConfiguration<SourceFile>
    {
        public void Configure(EntityTypeBuilder<SourceFile> builder)
        {
            builder.ToTable("Reports", "idep");
            builder.HasKey(rep => rep.Id);
            builder.HasAlternateKey(rep => rep.FileName);

            builder.Property(rep => rep.FileDirectoryName)
            .HasColumnName("FullPath");

            builder.Property(rep => rep.PricingType)
            .HasConversion(pt => pt.ToString(),
            str => str.ToEnum<ReportPricingType>());

            builder.Property(rep => rep.Destination)
            .HasConversion(pt => pt.ToString(),
            str => str.ToEnum<SqlTargetTable>());
        }
    }
}
