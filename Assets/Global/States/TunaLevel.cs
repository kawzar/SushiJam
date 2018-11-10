using UnityEngine;

namespace Global.States
{
    public class TunaLevel: Level
    {
        public override void SetTarget()
        {
            
            TargetSelection.Instance.DestroyCurrent();
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Tuna);
            GameManager.Instance.tunaRecipeImg.gameObject.SetActive(true);
            TargetSelection.Instance.SetGameObject(GameManager.Instance.tunaRecipeImg);
        }
    }
}