using System;

namespace Assets.Global
{
    public class Stopwatch
    {
        private bool isTimeRunning;
        private float currentTime;

        public float RemainingTime { get; private set; }
        public float MaxTime { get; set; }
        private Action _onStop;

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

                isTimeRunning = RemainingTime > 0.01;
                
                    
            }
            if (!isTimeRunning)
            {
                _onStop?.Invoke();
            }
        }

        private void StopWatch()
        {
            isTimeRunning = false;
            RemainingTime = 0.0f;
        }

        public void OnStop(Action onStop)
        {
            _onStop = onStop;
        }
    }
}
