// this is the class that will be converted to json and sent to the frontend that has all the data ready to go
public class FinalReport
{
    // Airport info
    public string Identifier { get; set; }
    public string Name { get; set; }
    // not available in my current one, most likely will need to combine the api calls into this leaving as an int for now
    public double AvailableRunways { get; set; }
    public double Lat { get; set; }
    public double Long { get; set; }
    public double Temperature { get; set; }
    public double RelativeHumidity { get; set; }
    public string CloudCoverageSummary { get; set; }
    public double VisibilityMiles { get; set; }
    public List<Period> Forecast { get; set; }
}

// Used for the forecasted two future periods
public class Period
{
    public double TimeOffset { get; set; }
    public double WindSpeedMPH { get; set; }
    public string WindDirection { get; set; }


}