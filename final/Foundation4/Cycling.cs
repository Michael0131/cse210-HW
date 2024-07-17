namespace ExerciseTracking
{
    class Cycling : Activity
    {
        private double SpeedInMph { get; }

        public Cycling(DateTime date, int lengthInMinutes, double speedInMph)
            : base(date, lengthInMinutes)
        {
            SpeedInMph = speedInMph;
        }

        public override double GetDistance()
        {
            return (SpeedInMph * (LengthInMinutes / 60.0));
        }

        public override double GetSpeed()
        {
            return SpeedInMph;
        }

        public override double GetPace()
        {
            return 60 / SpeedInMph;
        }
    }
}
