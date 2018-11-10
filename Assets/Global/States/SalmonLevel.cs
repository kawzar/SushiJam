using UnityEngine;

namespace Global.States
{
    public class SalmonLevel:Level
    {
        public override void SetTarget()
        {
            TargetSelection.Instance.DestroyCurrent();
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Salmon);
            var obj = GameManager.Instance.salmonPrefab.gameObject;
            obj.transform.position = GameManager.Instance.RecipiesStartPoint.position;
            GameObject.Instantiate(obj);
            TargetSelection.Instance.SetGameObject(obj);
            
        }
    }
}