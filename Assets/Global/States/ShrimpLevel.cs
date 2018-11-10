using UnityEngine;

namespace Global.States
{
    public class ShrimpLevel: Level

    {
        public override void SetTarget()
        {
            TargetSelection.Instance.DestroyCurrent();
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Shrimp);
            GameManager.Instance.shrimpRecipeImg.enabled = true;
            TargetSelection.Instance.SetGameObject(GameManager.Instance.shrimpRecipeImg);
        }
    }
}