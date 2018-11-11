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
<<<<<<< HEAD
            SwipeManager.OnSwipeHappened += PlayerSwipe;

        }

        private void PlayerSwipe(InputAction direction)
        {
            TargetSelection.Instance.HitTarget();
=======
            TargetGiver.Instance.Get();    
>>>>>>> 5eeb7ec5eeb815c771728af3a6b779b3f50c595e
        }

        public void Next()
        {
            
        }
    }
}