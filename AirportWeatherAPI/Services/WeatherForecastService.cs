using System.Text.Json;
using WeatherRep;
using AirportRep;

public class WeatherForecastService
{
    // API info
    string conditionAPIUrl = "https://qa.foreflight.com/weather/report/";
    string airportDataAPIUrl = "https://qa.foreflight.com/airports/";
    string ffuser = "ff-interview";
    string ffpass = "@-*KzU.*dtP9dkoE7PryL2ojY!uDV.6JJGC9";

    // takes airport id and then returns a json string with final report
    public string GetAirportForecast(String airportID)
    {
        // TODO handle null reports aka the airport name was entered incorrectly
        // Call the APIs and get the objects back
        Task<WeatherReport?> wReport = fetchWeatherObj(conditionAPIUrl + airportID);
        Task<AirportReport?> aReport = fetchAirportObj(airportDataAPIUrl + airportID);
        // Build the Report with information for the frontend and Serialize it into a json string
        return JsonSerializer.Serialize<FinalReport>(buildConsice(wReport.Result.Report, aReport.Result));
    }

    // take the objects and builds the deliverable FinalReport object for the frontend
    public FinalReport buildConsice(Report wReport, AirportReport aReport)
    {
        FinalReport newReport = new FinalReport();
        newReport.Identifier = wReport.Conditions.Ident;
        newReport.Name = aReport.Name;
        newReport.AvailableRunways = aReport.Runways.Length;
        newReport.Lat = aReport.Latitude;
        newReport.Long = aReport.Longitude;
        newReport.Temperature = (wReport.Conditions.TempC * 9 / 5) + 32;
        newReport.RelativeHumidity = wReport.Conditions.RelativeHumidity;
        newReport.CloudCoverageSummary = mostCommonCoverage(wReport.Conditions.CloudLayers);
        newReport.VisibilityMiles = wReport.Conditions.Visibility.DistanceSm;
        newReport.BestRunway = pickBestRunway(aReport.Runways, wReport.Forecast.Conditions[0].Wind.Direction);
        newReport.CurrentWindDirection = wReport.Forecast.Conditions[0].Wind.Direction;
        newReport.Forecast = buildForecastList(wReport.Forecast.Conditions);

        return newReport;
    }

    // find the runway name where it is the closest to the wind direction
    private string pickBestRunway(Runway[] runways, long windDirection){
        Console.WriteLine(windDirection);
        long smallest = 360;
        string closestRunway = "";
        // loop through runways
        foreach(Runway r in runways){
            string runwayName = r.Name;
            // convert name to degrees
            string chopped = runwayName.Substring(0, runwayName.Length-1);
            long runwayDirection = long.Parse(chopped)*10;
            // Calculate the absolute difference between the target and the current number on the circle
            long difference = Math.Abs((windDirection - runwayDirection + 180 + 360) % 360 - 180);
            // check if difference smaller than smallest
            if (difference < smallest)
            {
                // if it is then replace bestRunway
                smallest = difference;
                closestRunway = runwayName;
            }
        }
        Console.WriteLine(closestRunway);
        return closestRunway;
    }

    // Helper function that builds a list of Periods for the FinalReport
    private List<Period> buildForecastList(PurpleCondition[] conditions)
    {
        List<Period> newPList = new List<Period>();
        foreach (PurpleCondition c in conditions)
        {
            // build a period
            Period newPeriod = new Period();
            newPeriod.TimeOffset = c.Period.DateEnd;
            newPeriod.WindSpeedMPH = c.Wind.SpeedKts;
            newPeriod.WindDirection = c.Wind.Direction;
            // add the new period to the plist
            newPList.Add(newPeriod);
        }
        return newPList;
    }

    // helper function to count the frequency of cloud layers and return most common
    private string mostCommonCoverage(CloudLayer[] cloudLayers)
    {
        String? mostCommon = cloudLayers
            .GroupBy(CloudLayer => CloudLayer.Coverage)
            .OrderByDescending(group => group.Count())
            .FirstOrDefault()?.Key;

        if (mostCommon == null) return "no coverage data";
        else return mostCommon;
    }

    // call weather api supplied and deserilizes json into object
    public async Task<WeatherReport?> fetchWeatherObj(String apiurl)
    {
        // Create an instance of HttpClient
        using (HttpClient client = new HttpClient())
        {
            // Set the 'ff-coding-exercise' header to the value '1'
            client.DefaultRequestHeaders.Add("ff-coding-exercise", "1");
            try
            {
                // Send the GET request and add airport id
                HttpResponseMessage response = await client.GetAsync(apiurl);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content and convert to obj
                    string responseData = await response.Content.ReadAsStringAsync();
                    return WeatherReport.FromJson(responseData);

                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        return null;
    }

    // hate to duplicate a method but don't want to bother creating a parent class and inheriting the reports
    public async Task<AirportReport?> fetchAirportObj(String apiurl)
    {
        // Create an instance of HttpClient
        using (HttpClient client = new HttpClient())
        {
            // Set the 'ff-coding-exercise' header to the value '1'
            client.DefaultRequestHeaders.Add("ff-coding-exercise", "1");

            // Add Basic Authentication header
            string authHeaderValue = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{ffuser}:{ffpass}"));
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + authHeaderValue);

            try
            {
                // Send the GET request and add airport id
                HttpResponseMessage response = await client.GetAsync(apiurl);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content and convert to obj
                    string responseData = await response.Content.ReadAsStringAsync();
                    return AirportReport.FromJson(responseData);

                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        return null;
    }
}