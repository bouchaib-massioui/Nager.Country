﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Republic of the Congo
    /// </summary>
    public class RepublicOfTheCongoCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Republic of the Congo";
        ///<inheritdoc/>
        public string OfficialName => "Republic of the Congo";
        ///<inheritdoc/>
        public string NativeName => "République démocratique du Congo";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.CG;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.COG;
        ///<inheritdoc/>
        public int NumericCode => 178;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".cg" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.AO,
            Alpha2Code.CM,
            Alpha2Code.CF,
            Alpha2Code.CD,
            Alpha2Code.GA,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new XafCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "242" };
    }
}
