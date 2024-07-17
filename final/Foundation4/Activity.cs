using System;

namespace ExerciseTracking
{
    abstract class Activity
    {
        private DateTime Date { get; }
        protected int LengthInMinutes { get; }

        protected Activity(DateTime date, int lengthInMinutes)
        {
            Date = date;
            LengthInMinutes = lengthInMinutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({LengthInMinutes} min)- " +
                   $"Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}
