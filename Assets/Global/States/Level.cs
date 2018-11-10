namespace Global.States
{
    public abstract class Level
    {
        protected Level()
        {
            SetTarget();
        }
        
        protected abstract void SetTarget();

    }
}