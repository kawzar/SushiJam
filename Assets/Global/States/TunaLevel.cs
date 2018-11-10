using UnityEngine;

namespace Global.States
{
    public class TunaLevel: Level
    {
        public override void SetTarget()
        {
            
            TargetSelection.Instance.DestroyCurrent();
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Tuna);
            var obj = GameManager.Instance.tunaPrefab.gameObject;
            obj.transform.position = GameManager.Instance.RecipiesStartPoint.position;
            GameObject.Instantiate(obj);
            TargetSelection.Instance.SetGameObject(obj);
        }
    }
}