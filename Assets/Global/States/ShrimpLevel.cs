using UnityEngine;

namespace Global.States
{
    public class ShrimpLevel: Level

    {
        public override void SetTarget()
        {
            TargetSelection.Instance.DestroyCurrent();
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Shrimp);
            GameManager.Instance.shrimpRecipeImg.gameObject.SetActive(true);
            TargetSelection.Instance.SetGameObject(GameManager.Instance.shrimpRecipeImg);
        }
    }
}