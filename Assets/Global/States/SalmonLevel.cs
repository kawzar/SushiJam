namespace Global.States
{
    public class SalmonLevel:Level
    {
        protected override void SetTarget()
        {
            TargetSelection.Instance.SetCorrect(GiverFIsh.Instance.Salmon);
        }
    }
}