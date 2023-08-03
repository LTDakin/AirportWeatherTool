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
        Task<WeatherReport> wReport = fetchWeatherObj(conditionAPIUrl + airportID);
        Task<AirportReport> aReport = fetchAirportObj(airportDataAPIUrl + airportID);
        Console.WriteLine(aReport.Result.City);
        return JsonSerializer.Serialize<FinalReport>(buildConsice(wReport.Result.Report, aReport.Result));
    }

    // take the objects and builds the deliverable FinalReport object for the frontend
    public FinalReport buildConsice(Report wReport, AirportReport aReport)
    {
        FinalReport newReport = new FinalReport();
        // Fill out the fields, I think there might be a better way by creating an object with selections but not sure
        newReport.Identifier = wReport.Conditions.Ident;
        return newReport;
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