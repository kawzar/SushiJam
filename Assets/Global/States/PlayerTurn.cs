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
            TargetGiver.Instance.Get();
            SwipeManager.OnSwipeHappened += PlayerSwipe;

        }

        private void PlayerSwipe(InputAction direction)
        {
            Debug.Log("holis");

            TargetSelection.Instance.HitTarget();
        }

        public void Next()
        {
            
        }
    }
}
