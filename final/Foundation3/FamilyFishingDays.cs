namespace FishingEventPlanning
{
    class FamilyFishingDay : Event
    {
        private string ContactEmail;

        public FamilyFishingDay(string title, string description, string date, string time, Address eventAddress, string contactEmail)
            : base(title, description, date, time, eventAddress)
        {
            ContactEmail = contactEmail;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Family Fishing Day\nContact Email: {ContactEmail}";
        }

        public override string GetShortDescription()
        {
            return $"Type: Family Fishing Day\nTitle: {Title}\nDate: {Date}";
        }
    }
}
