using System;
using Assets.Global;
using UnityEngine;

namespace Global.States
{
    public class PlayerTurn:GameState
    {
        private bool stop=false;
        
        
        public void Start()
        {
            Debug.Log("Holis player turn");
            var level = GiverLevels.Instance.GetRandom();
            level.SetTarget();
            TargetGiver.Instance.Get(AnotherFish);
            Watch.Instance.Init((() => stop=true));
            
            SwipeManager.OnSwipeHappened += PlayerSwipe;

        }

        private void AnotherFish()
        {
            if (!stop)
            {
                TargetGiver.Instance.Get(AnotherFish);    
            }
            else
            {
                Next();
            }
            
        }

        private void PlayerSwipe(InputAction direction)
        {
            Debug.Log("holis");

            TargetSelection.Instance.HitTarget();
        }

        public void Next()
        {
            var next= new EndGame();
            next.Start();
        }
    }
}
