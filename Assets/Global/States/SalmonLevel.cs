using UnityEngine;

namespace Global.States
{
    public class SalmonLevel:Level
    {
        public override void SetTarget()
        {
            TargetSelection.Instance.DestroyCurrent();
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Salmon);
            GameManager.Instance.salmonRecipeImg.gameObject.SetActive(true);
            TargetSelection.Instance.SetGameObject(GameManager.Instance.salmonRecipeImg);

        }
    }
}