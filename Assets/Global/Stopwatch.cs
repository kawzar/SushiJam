namespace Assets.Global
{
    public class Stopwatch
    {
        private bool isTimeRunning;
        private float currentTime;

        public float RemainingTime { get; private set; }
        public float MaxTime { get; set; }

        public Stopwatch()
        {
            MaxTime = 60f;
            RemainingTime = MaxTime;
            isTimeRunning = false;
        }

        public void Start()
        {
            isTimeRunning = true;
        }

        public void UpdateClock(float deltaTime)
        {
            if (isTimeRunning)
            {
                currentTime += deltaTime;
                RemainingTime = MaxTime - currentTime;

                isTimeRunning = RemainingTime > 0;
            }
        }

        private void StopWatch()
        {
            isTimeRunning = false;
        }
    }
}
