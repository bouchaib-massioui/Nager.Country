﻿using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// French Southern and Antarctic Lands
    /// </summary>
    public class FrenchSouthernAndAntarcticLandsCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "French Southern and Antarctic Lands";
        ///<inheritdoc/>
        public string OfficialName => "Territory of the French Southern and Antarctic Lands";
        ///<inheritdoc/>
        public string NativeName => "Territoire des Terres australes et antarctiques françaises";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TF;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ATF;
        ///<inheritdoc/>
        public int NumericCode => 260;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".tf" };

        ///<inheritdoc/>
        public Region Region => Region.Antarctic;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.None;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new string[0];
    }
}
