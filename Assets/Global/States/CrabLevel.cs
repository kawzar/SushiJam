using UnityEngine;

namespace Global.States
{
    public class CrabLevel: Level
    {
        public override void SetTarget()
        {
            TargetSelection.Instance.DestroyCurrent();
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Crab);
            var obj = GameManager.Instance.crabPrefab.gameObject;
            obj.transform.position = GameManager.Instance.RecipiesStartPoint.position;
            GameObject.Instantiate(obj);
            TargetSelection.Instance.SetGameObject(obj);
        }
    }
}