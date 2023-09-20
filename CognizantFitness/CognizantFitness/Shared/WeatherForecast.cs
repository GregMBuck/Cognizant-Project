namespace CognizantFitness.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public int TestVariableForTimBrance = 50;

        public int TestMethod()
        {
            return TestVariableForTimBrance + 30;
        }
    
    }
    public class User
    {
        string userFirstName;
        string userLastName;
        int userWeight;
        string userNickname;
        string userEmail;
        string userPhoneNumber;
        int userHeight;
        string userPassword;

    }
}