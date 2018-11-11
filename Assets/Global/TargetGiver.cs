using System;

namespace Global
{
    public class TargetGiver
    {
        private static TargetGiver _instance;

        public static TargetGiver Instance => _instance = _instance ?? new TargetGiver();

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
        
        

    }
}