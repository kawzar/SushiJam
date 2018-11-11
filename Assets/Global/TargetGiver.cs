using System;
using UnityEngine;

namespace Global
{
    public class TargetGiver
    {
        private static TargetGiver _instance;

        public static TargetGiver Instance => _instance = _instance ?? new TargetGiver();

        public float NormalSpeed = 0.5f;
        public float FeverSpeed = 0.2f;
        

        public void Get()
        {
            var fish = GiverFIsh.Instance.Random();
            TargetSelection.Instance.SetTarget(fish);
            fish.Move();


        }
        
        public void Get(Action onCOmplete)
        {
            var fish = GiverFIsh.Instance.Random();
            TargetSelection.Instance.SetTarget(fish);
            fish.Move(onCOmplete);
        }
        
        public void GetOnFever(Action onCOmplete)
        {
            var fish = TargetSelection.Instance.GetCorrect();
            TargetSelection.Instance.SetTarget(fish);
            Debug.Log(fish.GetType());
            fish.MoveFever(onCOmplete);
        }
        
        

    }
}