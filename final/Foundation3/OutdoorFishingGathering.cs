namespace FishingEventPlanning
{
    class OutdoorFishingGathering : Event
    {
        private string WeatherForecast;

        public OutdoorFishingGathering(string title, string description, string date, string time, Address eventAddress, string weatherForecast)
            : base(title, description, date, time, eventAddress)
        {
            WeatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Outdoor Fishing Gathering\nWeather: {WeatherForecast}";
        }

        public override string GetShortDescription()
        {
            return $"Type: Outdoor Fishing Gathering\nTitle: {Title}\nDate: {Date}";
        }
    }
}
