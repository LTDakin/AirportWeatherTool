// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using AirportRep;
//
//    var airportReport = AirportReport.FromJson(jsonString);

namespace AirportRep
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AirportReport
    {
        [JsonProperty("siteNumberCode")]
        public string SiteNumberCode { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }

        [JsonProperty("iata")]
        public object Iata { get; set; }

        [JsonProperty("faaCode")]
        public string FaaCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("keywordPrefixes")]
        public string[] KeywordPrefixes { get; set; }

        [JsonProperty("artccID")]
        public string ArtccId { get; set; }

        [JsonProperty("artccName")]
        public string ArtccName { get; set; }

        [JsonProperty("artccResponsibleID")]
        public string ArtccResponsibleId { get; set; }

        [JsonProperty("artccResponsibleName")]
        public string ArtccResponsibleName { get; set; }

        [JsonProperty("flightServiceStationID")]
        public string FlightServiceStationId { get; set; }

        [JsonProperty("flightServiceStationName")]
        public string FlightServiceStationName { get; set; }

        [JsonProperty("flightServiceStationPhone")]
        public string FlightServiceStationPhone { get; set; }

        [JsonProperty("flightServiceStationAlternateID")]
        public object FlightServiceStationAlternateId { get; set; }

        [JsonProperty("flightServiceStationAlternateName")]
        public object FlightServiceStationAlternateName { get; set; }

        [JsonProperty("flightServiceStationAlternatePhone")]
        public object FlightServiceStationAlternatePhone { get; set; }

        [JsonProperty("flightServiceStationIssuingNotamsID")]
        public object FlightServiceStationIssuingNotamsId { get; set; }

        [JsonProperty("nearby")]
        public object[] Nearby { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("airportType")]
        public string AirportType { get; set; }

        [JsonProperty("operationalStatus")]
        public string OperationalStatus { get; set; }

        [JsonProperty("airportAccess")]
        public string AirportAccess { get; set; }

        [JsonProperty("latitudeSecsNorth")]
        public double LatitudeSecsNorth { get; set; }

        [JsonProperty("longitudeSecsEast")]
        public double LongitudeSecsEast { get; set; }

        [JsonProperty("elevation")]
        public long Elevation { get; set; }

        [JsonProperty("magneticVariationWest")]
        public long MagneticVariationWest { get; set; }

        [JsonProperty("trafficPatternAltitudeMsl")]
        public object TrafficPatternAltitudeMsl { get; set; }

        [JsonProperty("runways")]
        public Runway[] Runways { get; set; }

        [JsonProperty("frequencies")]
        public Frequency[] Frequencies { get; set; }

        [JsonProperty("remoteFrequencies")]
        public Frequency[] RemoteFrequencies { get; set; }

        [JsonProperty("procedures")]
        public Diagram[] Procedures { get; set; }

        [JsonProperty("fuelTypes")]
        public object[] FuelTypes { get; set; }

        [JsonProperty("extraServices")]
        public object[] ExtraServices { get; set; }

        [JsonProperty("remarks")]
        public Remark[] Remarks { get; set; }

        [JsonProperty("serviceProviders")]
        public object[] ServiceProviders { get; set; }

        [JsonProperty("fbos")]
        public object[] Fbos { get; set; }

        [JsonProperty("businesses")]
        public object[] Businesses { get; set; }

        [JsonProperty("trafficPatternAltitudes")]
        public object[] TrafficPatternAltitudes { get; set; }

        [JsonProperty("sectionalName")]
        public string SectionalName { get; set; }

        [JsonProperty("managersName")]
        public object ManagersName { get; set; }

        [JsonProperty("managersAddress")]
        public object ManagersAddress { get; set; }

        [JsonProperty("managersCityStateZip")]
        public object ManagersCityStateZip { get; set; }

        [JsonProperty("managersPhoneNumber")]
        public object ManagersPhoneNumber { get; set; }

        [JsonProperty("afdFilename")]
        public string AfdFilename { get; set; }

        [JsonProperty("diagramAvailable")]
        public bool DiagramAvailable { get; set; }

        [JsonProperty("diagram")]
        public Diagram Diagram { get; set; }

        [JsonProperty("notamDServiceAvailable")]
        public bool NotamDServiceAvailable { get; set; }

        [JsonProperty("towered")]
        public bool Towered { get; set; }

        [JsonProperty("pdc")]
        public bool Pdc { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("attributes")]
        public Attribute[] Attributes { get; set; }

        [JsonProperty("schedule")]
        public Schedule[] Schedule { get; set; }

        [JsonProperty("cycle")]
        public Cycle Cycle { get; set; }

        [JsonProperty("timezone")]
        public Timezone Timezone { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("longestRunway")]
        public Runway LongestRunway { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("procedureTypes")]
        public string ProcedureTypes { get; set; }

        [JsonProperty("hardSurfaceAvailable")]
        public bool HardSurfaceAvailable { get; set; }

        [JsonProperty("longestRunwayLength")]
        public long LongestRunwayLength { get; set; }

        [JsonProperty("latitudeInDegrees")]
        public double LatitudeInDegrees { get; set; }

        [JsonProperty("longitudeInDegrees")]
        public double LongitudeInDegrees { get; set; }

        [JsonProperty("magneticVariationWestOrEstimate")]
        public long MagneticVariationWestOrEstimate { get; set; }
    }

    public partial class Attribute
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }
    }

    public partial class Contact
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public object Organization { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("phones")]
        public Phone[] Phones { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("label")]
        public object Label { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("rel")]
        public object Rel { get; set; }

        [JsonProperty("uri")]
        public object Uri { get; set; }

        [JsonProperty("physicalAddress")]
        public object PhysicalAddress { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("state")]
        public object State { get; set; }

        [JsonProperty("postalCode")]
        public object PostalCode { get; set; }

        [JsonProperty("latitude")]
        public object Latitude { get; set; }

        [JsonProperty("longitude")]
        public object Longitude { get; set; }

        [JsonProperty("address")]
        public string[] AddressAddress { get; set; }
    }

    public partial class Phone
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("rel")]
        public object Rel { get; set; }

        [JsonProperty("uri")]
        public object Uri { get; set; }
    }

    public partial class Cycle
    {
        [JsonProperty("version")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Version { get; set; }

        [JsonProperty("dateUpdated")]
        public DateTimeOffset DateUpdated { get; set; }

        [JsonProperty("dateEffective")]
        public DateTimeOffset DateEffective { get; set; }

        [JsonProperty("dateExpires")]
        public DateTimeOffset DateExpires { get; set; }
    }

    public partial class Diagram
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("airportIcao")]
        public string AirportIcao { get; set; }

        [JsonProperty("defaultPage")]
        public long? DefaultPage { get; set; }

        [JsonProperty("associatedRunwayNames")]
        public string[] AssociatedRunwayNames { get; set; }

        [JsonProperty("georefPages")]
        public GeorefPage[] GeorefPages { get; set; }

        [JsonProperty("changedThisCycle")]
        public bool ChangedThisCycle { get; set; }

        [JsonProperty("fileHash")]
        public object FileHash { get; set; }

        [JsonProperty("pageCount")]
        public long PageCount { get; set; }

        [JsonProperty("dateLabel")]
        public object DateLabel { get; set; }

        [JsonProperty("rotation")]
        public long Rotation { get; set; }

        [JsonProperty("lastCycleChanged")]
        public object LastCycleChanged { get; set; }

        [JsonProperty("georefHash")]
        public object GeorefHash { get; set; }

        [JsonProperty("procuid")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Procuid { get; set; }

        [JsonProperty("cycle")]
        public Cycle Cycle { get; set; }

        [JsonProperty("procedureUrl")]
        public object ProcedureUrl { get; set; }

        [JsonProperty("resources")]
        public PageRotations Resources { get; set; }

        [JsonProperty("pageRotations")]
        public PageRotations PageRotations { get; set; }

        [JsonProperty("icaocode")]
        public string Icaocode { get; set; }

        [JsonProperty("iatacode")]
        public object Iatacode { get; set; }

        [JsonProperty("aipcode")]
        public object Aipcode { get; set; }

        [JsonProperty("diagram")]
        public bool DiagramDiagram { get; set; }
    }

    public partial class GeorefPage
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("pageNumber")]
        public long PageNumber { get; set; }

        [JsonProperty("coord1Lat")]
        public double Coord1Lat { get; set; }

        [JsonProperty("coord1Lon")]
        public double Coord1Lon { get; set; }

        [JsonProperty("coord2Lat")]
        public double Coord2Lat { get; set; }

        [JsonProperty("coord2Lon")]
        public double Coord2Lon { get; set; }

        [JsonProperty("p1PctX")]
        public double P1PctX { get; set; }

        [JsonProperty("p1PctY")]
        public double P1PctY { get; set; }

        [JsonProperty("p2PctX")]
        public double P2PctX { get; set; }

        [JsonProperty("p2PctY")]
        public double P2PctY { get; set; }

        [JsonProperty("orientation")]
        public long Orientation { get; set; }

        [JsonProperty("drawTopPct")]
        public double DrawTopPct { get; set; }

        [JsonProperty("drawBottomPct")]
        public double DrawBottomPct { get; set; }

        [JsonProperty("drawLeftPct")]
        public double DrawLeftPct { get; set; }

        [JsonProperty("drawRightPct")]
        public double DrawRightPct { get; set; }

        [JsonProperty("validWithinX")]
        public long ValidWithinX { get; set; }

        [JsonProperty("validWithinY")]
        public long ValidWithinY { get; set; }

        [JsonProperty("validWithinRadius")]
        public long ValidWithinRadius { get; set; }

        [JsonProperty("excludedArea")]
        public object ExcludedArea { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public partial class PageRotations
    {
    }

    public partial class Frequency
    {
        [JsonProperty("frequency")]
        public double FrequencyFrequency { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("sectorDescription")]
        public string SectorDescription { get; set; }

        [JsonProperty("altitudeDescription")]
        public object AltitudeDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("localFrequency")]
        public bool LocalFrequency { get; set; }
    }

    public partial class Runway
    {
        [JsonProperty("ident")]
        public string Ident { get; set; }

        [JsonProperty("length")]
        public long Length { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("surfaceType")]
        public string SurfaceType { get; set; }

        [JsonProperty("surfaceQuality")]
        public string SurfaceQuality { get; set; }

        [JsonProperty("edgeLightsIntensity")]
        public string EdgeLightsIntensity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("trueHeading")]
        public long TrueHeading { get; set; }

        [JsonProperty("magneticHeading")]
        public long MagneticHeading { get; set; }

        [JsonProperty("latitudeBase")]
        public double LatitudeBase { get; set; }

        [JsonProperty("longitudeBase")]
        public double LongitudeBase { get; set; }

        [JsonProperty("approachSlopeSideBase")]
        public string ApproachSlopeSideBase { get; set; }

        [JsonProperty("approachSlopeIndicatorBase")]
        public string ApproachSlopeIndicatorBase { get; set; }

        [JsonProperty("approachLightingSystemBase")]
        public string ApproachLightingSystemBase { get; set; }

        [JsonProperty("rightTrafficBase")]
        public bool RightTrafficBase { get; set; }

        [JsonProperty("rightTrafficRecip")]
        public bool RightTrafficRecip { get; set; }

        [JsonProperty("recipTrueHeading")]
        public long RecipTrueHeading { get; set; }

        [JsonProperty("recipMagneticHeading")]
        public long RecipMagneticHeading { get; set; }

        [JsonProperty("recipName")]
        public string RecipName { get; set; }

        [JsonProperty("latitudeRecip")]
        public double LatitudeRecip { get; set; }

        [JsonProperty("longitudeRecip")]
        public double LongitudeRecip { get; set; }

        [JsonProperty("approachSlopeSideRecip")]
        public string ApproachSlopeSideRecip { get; set; }

        [JsonProperty("approachSlopeIndicatorRecip")]
        public string ApproachSlopeIndicatorRecip { get; set; }

        [JsonProperty("approachLightingSystemRecip")]
        public string ApproachLightingSystemRecip { get; set; }

        [JsonProperty("displacedThresholdBase")]
        public bool DisplacedThresholdBase { get; set; }

        [JsonProperty("displacedThresholdRecip")]
        public bool DisplacedThresholdRecip { get; set; }

        [JsonProperty("gradientBase")]
        public double GradientBase { get; set; }

        [JsonProperty("gradientRecip")]
        public double GradientRecip { get; set; }

        [JsonProperty("displacedThresholdLengthBase")]
        public long? DisplacedThresholdLengthBase { get; set; }

        [JsonProperty("displacedThresholdLengthRecip")]
        public long? DisplacedThresholdLengthRecip { get; set; }

        [JsonProperty("displacedThresholdLatitudeBase")]
        public double? DisplacedThresholdLatitudeBase { get; set; }

        [JsonProperty("displacedThresholdLatitudeRecip")]
        public double? DisplacedThresholdLatitudeRecip { get; set; }

        [JsonProperty("displacedThresholdLongitudeBase")]
        public double? DisplacedThresholdLongitudeBase { get; set; }

        [JsonProperty("displacedThresholdLongitudeRecip")]
        public double? DisplacedThresholdLongitudeRecip { get; set; }

        [JsonProperty("elevationRunwayEndBase")]
        public long ElevationRunwayEndBase { get; set; }

        [JsonProperty("elevationRunwayEndRecip")]
        public long ElevationRunwayEndRecip { get; set; }

        [JsonProperty("elevationThresholdBase")]
        public long? ElevationThresholdBase { get; set; }

        [JsonProperty("elevationThresholdRecip")]
        public long? ElevationThresholdRecip { get; set; }

        [JsonProperty("elevationTouchdownZoneBase")]
        public long ElevationTouchdownZoneBase { get; set; }

        [JsonProperty("elevationTouchdownZoneRecip")]
        public long ElevationTouchdownZoneRecip { get; set; }

        [JsonProperty("glidePathAngleBase")]
        public long GlidePathAngleBase { get; set; }

        [JsonProperty("glidePathAngleRecip")]
        public long GlidePathAngleRecip { get; set; }

        [JsonProperty("ldaFtDayBase")]
        public long LdaFtDayBase { get; set; }

        [JsonProperty("ldaFtDayRecip")]
        public long LdaFtDayRecip { get; set; }

        [JsonProperty("ldaFtNightBase")]
        public long LdaFtNightBase { get; set; }

        [JsonProperty("ldaFtNightRecip")]
        public long LdaFtNightRecip { get; set; }

        [JsonProperty("toraFtDayBase")]
        public long ToraFtDayBase { get; set; }

        [JsonProperty("toraFtDayRecip")]
        public long ToraFtDayRecip { get; set; }

        [JsonProperty("toraFtNightBase")]
        public long ToraFtNightBase { get; set; }

        [JsonProperty("toraFtNightRecip")]
        public long ToraFtNightRecip { get; set; }

        [JsonProperty("todaFtDayBase")]
        public long TodaFtDayBase { get; set; }

        [JsonProperty("todaFtDayRecip")]
        public long TodaFtDayRecip { get; set; }

        [JsonProperty("todaFtNightBase")]
        public long TodaFtNightBase { get; set; }

        [JsonProperty("todaFtNightRecip")]
        public long TodaFtNightRecip { get; set; }

        [JsonProperty("asdaFtDayBase")]
        public long AsdaFtDayBase { get; set; }

        [JsonProperty("asdaFtDayRecip")]
        public long AsdaFtDayRecip { get; set; }

        [JsonProperty("asdaFtNightBase")]
        public long AsdaFtNightBase { get; set; }

        [JsonProperty("asdaFtNightRecip")]
        public long AsdaFtNightRecip { get; set; }

        [JsonProperty("overrunFtBase")]
        public long OverrunFtBase { get; set; }

        [JsonProperty("overrunFtRecip")]
        public long OverrunFtRecip { get; set; }

        [JsonProperty("markingsType")]
        public object MarkingsType { get; set; }

        [JsonProperty("markingsCondition")]
        public object MarkingsCondition { get; set; }

        [JsonProperty("attributes")]
        public object Attributes { get; set; }

        [JsonProperty("edgeLightIntensityKnown")]
        public bool EdgeLightIntensityKnown { get; set; }

        [JsonProperty("edgeLightUserPresentable")]
        public string EdgeLightUserPresentable { get; set; }

        [JsonProperty("approachSlopeIndicatorBaseAvailable")]
        public bool ApproachSlopeIndicatorBaseAvailable { get; set; }

        [JsonProperty("approachSlopeIndicatorRecipAvailable")]
        public bool ApproachSlopeIndicatorRecipAvailable { get; set; }

        [JsonProperty("approachLightingSystemBaseAvailable")]
        public bool ApproachLightingSystemBaseAvailable { get; set; }

        [JsonProperty("approachLightingSystemRecipAvailable")]
        public bool ApproachLightingSystemRecipAvailable { get; set; }
    }

    public partial class Remark
    {
        [JsonProperty("remarkText")]
        public string RemarkText { get; set; }
    }

    public partial class Schedule
    {
        [JsonProperty("months")]
        public string Months { get; set; }

        [JsonProperty("days")]
        public string Days { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }

        [JsonProperty("unattended")]
        public bool Unattended { get; set; }

        [JsonProperty("irregular")]
        public bool Irregular { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }

    public partial class Timezone
    {
        [JsonProperty("dstOffset")]
        public long DstOffset { get; set; }

        [JsonProperty("gmtOffset")]
        public long GmtOffset { get; set; }

        [JsonProperty("timezoneId")]
        public string TimezoneId { get; set; }
    }

    public partial class AirportReport
    {
        public static AirportReport FromJson(string json) => JsonConvert.DeserializeObject<AirportReport>(json, AirportRep.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AirportReport self) => JsonConvert.SerializeObject(self, AirportRep.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
