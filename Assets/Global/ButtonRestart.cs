using System.Collections;
using System.Collections.Generic;
using Global.States;
using UnityEngine;

public class ButtonRestart : MonoBehaviour {

	public void OnClick()
	{
        print("CLICK");
		GameManager.Instance.gameOverScreen.Hide();
        ScorePlates.Instance.Hide();
		var playerTurn = new PlayerTurn();
		playerTurn.Start();
	}
}
