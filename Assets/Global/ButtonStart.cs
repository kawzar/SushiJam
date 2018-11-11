using Global.States;
using UnityEngine;

namespace Global
{
    public class ButtonStart : MonoBehaviour
    {
        public void OnClick()
        {
            GameManager.Instance.StartScreen.HideStartScreen();
            SacredMusic.Instance.StopIntro();
            var next= new PlayerTurn();
            next.Start();
        }

        public void OnExitClick()
        {
            Application.Quit();
        }

        private void Update()
        {
#if UNITY_EDITOR
            Time.timeScale = Input.GetKey(KeyCode.P) ? 50 : 1;
#endif
        }
    }
}