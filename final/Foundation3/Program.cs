using System;

namespace FishingEventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of each event type
            FishingTournament tournament = new FishingTournament("Big Bass Bash", "A competitive bass fishing tournament.", "2024-08-01", "6:00 AM", new Address("Lakeview Dock", "Fishing Town", "FT", "12345"), "Captain Hook", 50);
            FamilyFishingDay familyDay = new FamilyFishingDay("Family Fishing Day", "A fun day for families to fish together.", "2024-09-15", "8:00 AM", new Address("Riverside Park", "Rivertown", "RT", "67890"), "info@familyfishing.com");
            OutdoorFishingGathering outdoorGathering = new OutdoorFishingGathering("Community Fish Fry", "A community gathering with fishing and a fish fry.", "2024-07-20", "11:00 AM", new Address("Greenfield Lake", "Greenville", "GV", "54321"), "Sunny");

            // Display marketing messages for each event
            DisplayEventDetails(tournament);
            DisplayEventDetails(familyDay);
            DisplayEventDetails(outdoorGathering);
        }

        static void DisplayEventDetails(Event eventItem)
        {
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine();
        }
    }
}
