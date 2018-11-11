using System;
using UnityEngine;

namespace Global.States
{
    public class PlayerTurn:GameState
    {
        public void Start()
        {
            Debug.Log("Holis player turn");
            var level = GiverLevels.Instance.GetRandom();
            level.SetTarget();
            SwipeManager.OnSwipeHappened += PlayerSwipe;

        }

        private void PlayerSwipe(InputAction direction)
        {
            TargetSelection.Instance.HitTarget();
        }

        public void Next()
        {
            
        }
    }
}