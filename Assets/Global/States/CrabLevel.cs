namespace Global.States
{
    public class CrabLevel: Level
    {
        protected override void SetTarget()
        {
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Crab);
        }
    }
}