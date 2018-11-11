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
    }
}