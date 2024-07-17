namespace FishingEventPlanning
{
    abstract class Event
    {
        protected string Title;
        protected string Description;
        protected string Date;
        protected string Time;
        protected Address EventAddress;

        protected Event(string title, string description, string date, string time, Address eventAddress)
        {
            Title = title;
            Description = description;
            Date = date;
            Time = time;
            EventAddress = eventAddress;
        }

        public virtual string GetStandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {EventAddress}";
        }

        public abstract string GetFullDetails();

        public abstract string GetShortDescription();
    }
}
