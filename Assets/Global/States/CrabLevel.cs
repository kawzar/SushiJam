using UnityEngine;

namespace Global.States
{
    public class CrabLevel: Level
    {
        public override void SetTarget()
        {
            TargetSelection.Instance.DestroyCurrent();
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Crab);
            GameManager.Instance.crabRecipeImg.gameObject.SetActive(true);
            TargetSelection.Instance.SetGameObject(GameManager.Instance.crabRecipeImg);
        }
    }
}