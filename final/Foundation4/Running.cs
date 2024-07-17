namespace ExerciseTracking
{
    class Running : Activity
    {
        private double DistanceInMiles { get; }

        public Running(DateTime date, int lengthInMinutes, double distanceInMiles)
            : base(date, lengthInMinutes)
        {
            DistanceInMiles = distanceInMiles;
        }

        public override double GetDistance()
        {
            return DistanceInMiles;
        }

        public override double GetSpeed()
        {
            return (DistanceInMiles / (LengthInMinutes / 60.0));
        }

        public override double GetPace()
        {
            return LengthInMinutes / DistanceInMiles;
        }
    }
}
