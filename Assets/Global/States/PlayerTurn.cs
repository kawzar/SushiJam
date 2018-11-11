

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
        }

        public void Next()
        {
            
        }
    }
}