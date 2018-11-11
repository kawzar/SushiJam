using Global.Stats;
using UnityEngine;
using UnityEngine.UI;

namespace Global
{
    public class TargetSelection
    {
        private Fish _correctTarget;
        private Fish _currentTarget;

        private static TargetSelection _instance;
        private Image _currentImage;
        public static TargetSelection Instance => _instance = _instance ?? new TargetSelection();
        public bool _inPosition { get; set; }= false;

        public void HitTarget()
        {
            if (_inPosition && (_currentTarget == _correctTarget))
            {
                GameStats.Instance.Increment();
            }
            else
            {
                GameStats.Instance.Decrement();
            }
        }

        public void SetTarget(Fish target)
        {
            _currentTarget = target;
        }

        public void SetCorrect(Fish fish)
        {
            _correctTarget = fish;
        }


        public void SetGameObject(Image obj)
        {
            _currentImage = obj;
        }

        public void DestroyCurrent()
        {
            if (_currentImage != null)
            {
                _currentImage.gameObject.SetActive(false);
            }
        }
    }
}