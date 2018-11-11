using UnityEngine;

namespace Global
{
    public class Crab : Fish
    {
        public Crab()
        {
            _sprite = GameManager.Instance.crabImg;
            _sprite.transform.position = GameManager.Instance.StartPoint.position;
        }
    }
}