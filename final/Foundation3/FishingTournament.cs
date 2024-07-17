namespace FishingEventPlanning
{
    class FishingTournament : Event
    {
        private string Organizer;
        private int Capacity;

        public FishingTournament(string title, string description, string date, string time, Address eventAddress, string organizer, int capacity)
            : base(title, description, date, time, eventAddress)
        {
            Organizer = organizer;
            Capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Fishing Tournament\nOrganizer: {Organizer}\nCapacity: {Capacity}";
        }

        public override string GetShortDescription()
        {
            return $"Type: Fishing Tournament\nTitle: {Title}\nDate: {Date}";
        }
    }
}
