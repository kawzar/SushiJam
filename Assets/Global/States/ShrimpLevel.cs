using UnityEngine;

namespace Global.States
{
    public class ShrimpLevel: Level

    {
        public override void SetTarget()
        {
            TargetSelection.Instance.DestroyCurrent();
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Shrimp);
            var obj = GameManager.Instance.shrimpPrefab.gameObject;
            GameObject.Instantiate(obj);
            TargetSelection.Instance.SetGameObject(obj);
        }
    }
}