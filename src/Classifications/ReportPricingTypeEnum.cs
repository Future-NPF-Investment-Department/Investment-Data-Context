﻿/* ===========================================================================================================================
  Отчеты с портфелями (.csv) могут содержать данные либо в реальных ценах, либо в справедливых ценах.
 
  Например в период с февраля по октябрь 2022 г. группа фондов воспользовалась послаблением Банка России в соответствии с 
  которым цены для активов, которые находились или приобретались в инвестиционные портфели группы, были зафиксированы. 
  За такой период фонд получал от УК 2 отчета с портфелем на одну и ту же отчетную дату. Первый содержал данные в реальных 
  (фиксированных) ценах, а второй содержал данные в справедливых ценах. Оба отчета портфеля подлежали загрузке в одну и ту 
  же таблицу SQL, но с разными флагами. Значение этих флагов зависит от значения перечисления ReportPricingType, см. ниже.
============================================================================================================================= */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InvestmentDataContext.Classifications
{
    /// <summary>
    ///     Represents pricing type of source report. 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportPricingType
    {
        RealPrices,
        FairPrices
    }
}
