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
        private GameObject _currentGameObject;
        public static TargetSelection Instance => _instance = _instance ?? new TargetSelection();

        public void HitTarget()
        {
            if (_currentTarget == _correctTarget)
            {
                GameStats.Instance.Increment();
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


        public void SetGameObject(GameObject obj)
        {
            _currentGameObject = obj;
        }

        public void DestroyCurrent()
        {
            if(_currentGameObject!=null) GameObject.Destroy(_currentGameObject);
        }
    }
}