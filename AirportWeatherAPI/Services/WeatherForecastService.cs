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
        // Fill out the fields, thought about making a constructor but I thought this would look cleaner
        // think there is also some other way of spreading out the reports and generating a new object from a set of them
        newReport.Identifier = wReport.Conditions.Ident;
        newReport.Name = aReport.Name;
        newReport.AvailableRunways = aReport.Runways.Length;
        newReport.Lat = aReport.Latitude;
        newReport.Long = aReport.Longitude;
        newReport.Temperature = (wReport.Conditions.TempC * 9 / 5) + 32;
        newReport.RelativeHumidity = wReport.Conditions.RelativeHumidity;
        newReport.CloudCoverageSummary = mostCommonCoverage(wReport.Conditions.CloudLayers);
        newReport.VisibilityMiles = wReport.Conditions.Visibility.DistanceSm;
        newReport.Forecast = buildForecastList(wReport.Forecast.Conditions);

        return newReport;
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