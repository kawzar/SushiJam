using RookBirdTools.MoreTools;

namespace Global.States
{
    public class InitializerTurn : GameState
    {
        public void Start()
        {
            //Desactivar menu de entrada
            SacredMusic.Instance.PlayIntro();
            TimeStuff.DoAfter(Next,5);
        }

        public void Next()
        {
            SacredMusic.Instance.StopIntro();
            var next= new PlayerTurn();
            next.Start();
        }
    }
}