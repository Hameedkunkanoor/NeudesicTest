using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace NeudesicTest.Models
{
    public class CountryDetails
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("topLevelDomain")]
        public List<string> TopLevelDomain { get; set; }

        [JsonProperty("alpha2Code")]
        public string Alpha2Code { get; set; }

        [JsonProperty("alpha3Code")]
        public string Alpha3Code { get; set; }

       // [JsonProperty("callingCodes")]
       // public long[] CallingCodes { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

     //   [JsonProperty("altSpellings")]
     //   public string[] AltSpellings { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("population")]
        public long Population { get; set; }

      //  [JsonProperty("latlng")]
      //  public long[] Latlng { get; set; }

        [JsonProperty("demonym")]
        public string Demonym { get; set; }

        [JsonProperty("area")]
        public long Area { get; set; }

        [JsonProperty("gini")]
        public double Gini { get; set; }

       // [JsonProperty("timezones")]
        //public string[] Timezones { get; set; }

     //   [JsonProperty("borders")]
      //  public string[] Borders { get; set; }

        [JsonProperty("nativeName")]
        public string NativeName { get; set; }

        [JsonProperty("numericCode")]
        public long NumericCode { get; set; }

        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; }

        [JsonProperty("languages")]
        public List<Language> Languages { get; set; }

        [JsonProperty("translations")]
        public Translations Translations { get; set; }

        [JsonProperty("flag")]
        public Uri Flag { get; set; }

        [JsonProperty("regionalBlocs")]
        public RegionalBloc[] RegionalBlocs { get; set; }

        [JsonProperty("cioc")]
        public string Cioc { get; set; }
    }

    public partial class Currency
    {
        [JsonProperty("code")]
        public string Codes { get; set; }

        [JsonProperty("name")]
        public string Namee { get; set; }

        [JsonProperty("symbol")]
        public string Symboll { get; set; }
    }

    public partial class Language
    {
        [JsonProperty("iso639_1")]
        public string lIso6391 { get; set; }

        [JsonProperty("iso639_2")]
        public string lIso6392 { get; set; }

        [JsonProperty("name")]
        public string lName { get; set; }

        [JsonProperty("nativeName")]
        public string lNativeName { get; set; }
    }

    public partial class RegionalBloc
    {
        [JsonProperty("acronym")]
        public string rAcronym { get; set; }

        [JsonProperty("name")]
        public string RName { get; set; }

        [JsonProperty("otherAcronyms")]
        public object[] ROtherAcronyms { get; set; }

        [JsonProperty("otherNames")]
        public object[] ROtherNames { get; set; }
    }

    //public partial class Translations
    //{
    //    [JsonProperty("de")]
    //    public string De { get; set; }

    //    [JsonProperty("es")]
    //    public string Es { get; set; }

    //    [JsonProperty("fr")]
    //    public string Fr { get; set; }

    //    [JsonProperty("ja")]
    //    public string Ja { get; set; }

    //    [JsonProperty("it")]
    //    public string It { get; set; }

    //    [JsonProperty("br")]
    //    public string Br { get; set; }

    //    [JsonProperty("pt")]
    //    public string Pt { get; set; }

    //    [JsonProperty("nl")]
    //    public string Nl { get; set; }

    //    [JsonProperty("hr")]
    //    public string Hr { get; set; }

    //    [JsonProperty("fa")]
    //    public string Fa { get; set; }
    //}
}
