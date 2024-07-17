namespace ExerciseTracking
{
    class Swimming : Activity
    {
        private int Laps { get; }

        public Swimming(DateTime date, int lengthInMinutes, int laps)
            : base(date, lengthInMinutes)
        {
            Laps = laps;
        }

        public override double GetDistance()
        {
            return (Laps * 50) / 1000.0 * 0.62;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / (LengthInMinutes / 60.0));
        }

        public override double GetPace()
        {
            return LengthInMinutes / GetDistance();
        }
    }
}
