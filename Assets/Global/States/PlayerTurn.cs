using System;
using Assets.Global;
using Global.Stats;
using UnityEngine;

namespace Global.States
{
    public class PlayerTurn:GameState
    {
        private bool stop=false;
        private Action ActionBear;
        
        
        public void Start()
        {
            SacredMusic.Instance.PlayLoopTema();
            SacredMusic.Instance.PlayWaterfall();
            ActionBear = Normal;
            var level = GiverLevels.Instance.GetRandom();
            GameStats.Instance.Reset();
            level.SetTarget();
            TargetGiver.Instance.Get(AnotherFish);
            GameObject.FindObjectOfType<HandMovement>().CanMove=true;
            Watch.Instance.Init((() => stop=true));
            NailScript.Instance.OnFever(ChangeToFever);
            NailScript.Instance.OnNormal(ChangeToNormal);
            SwipeManager.OnSwipeHappened += PlayerSwipe;

        }

        private void AnotherFish()
        {
            if (!stop)
            {
                ActionBear.Invoke();
            }
            else
            {
                Next();
            }
            
        }

        public void Normal()
        {
            TargetGiver.Instance.Get(AnotherFish);
        }

        public void Fever()
        {
            TargetGiver.Instance.GetOnFever(AnotherFish);
        }

        public void ChangeToFever()
        {
            ActionBear = Fever;
            
        }

        public void ChangeToNormal()
        {
            ActionBear = Normal;
        }

        private void PlayerSwipe(InputAction direction)
        {
            TargetSelection.Instance.HitTarget();
        }

        public void Next()
        {
            SwipeManager.OnSwipeHappened -= PlayerSwipe;
            GameObject.FindObjectOfType<HandMovement>().CanMove=false;
            SacredMusic.Instance.StopPlayLoop();
            var next= new EndGame();
            next.Start();
        }
    }
}
