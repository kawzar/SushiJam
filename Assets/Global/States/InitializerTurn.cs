namespace Global.States
{
    public class InitializerTurn : GameState
    {
        public void Start()
        {
            //Desactivar menu de entrada
            Next();
            
        }

        public void Next()
        {
            var next= new PlayerTurn();
            next.Start();
        }
    }
}