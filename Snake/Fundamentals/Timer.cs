using SFML.System;

namespace Snake.Fundamentals
{
    public class Timer
    {
        private float tickInterval;
        private Clock clock;
        public float TickInterval
        {
            get => tickInterval;

            set
            {
                if (value > 0) tickInterval = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public Timer(float tickInterval)
        {
            this.tickInterval = tickInterval;
            this.clock = new Clock();
        }

        public bool Tick()
        {
            if (clock.ElapsedTime.AsMilliseconds() >= tickInterval)
            {
                clock.Restart();
                return true;
            }

            return false;
        }
    }
}
