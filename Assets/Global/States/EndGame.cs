namespace Global.States
{
    public class EndGame:GameState
    {
        public void Start()
        {
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