namespace Global.States
{
    public class ShrimpLevel: Level

    {
        protected override void SetTarget()
        {
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Shrimp);
        }
    }
}