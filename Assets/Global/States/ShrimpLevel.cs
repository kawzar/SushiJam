using UnityEngine;

namespace Global.States
{
    public class ShrimpLevel: Level

    {
        protected override void SetTarget()
        {
            TargetSelection.Instance.DestroyCurrent();
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Shrimp);
            GameObject obj = GameManager.Instance.shrimpPrefab.gameObject;
            GameObject.Instantiate(obj);
            TargetSelection.Instance.SetGameObject(obj);
        }
    }
}