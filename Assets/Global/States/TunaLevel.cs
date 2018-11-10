namespace Global.States
{
    public class TunaLevel: Level
    {
        protected override void SetTarget()
        {
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Tuna);
        }
    }
}