using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Andorra
    /// </summary>
    public class AndorraCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "Andorra";
        ///<inheritdoc/>
        public string OfficialName => "Principality of Andorra";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AD;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.AND;
        ///<inheritdoc/>
        public int NumericCode => 020;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".ad" };

        ///<inheritdoc/>
        public Region Region => Region.Europe;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.FR,
            Alpha2Code.ES,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new EurCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "376" };
    }
}
