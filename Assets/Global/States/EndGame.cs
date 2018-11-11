namespace Global.States
{
    public class EndGame:GameState
    {
        public void Start()
        {
            SacredMusic.Instance.WinSound();
            GameManager.Instance.gameOverScreen.ShowGameOverScreen();
        }

        public void Next()
        {
            GameManager.Instance.gameOverScreen.Hide();
            var playerTurn = new PlayerTurn();
            playerTurn.Start();
        }
    }
}