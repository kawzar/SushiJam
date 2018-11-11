using System.Collections;
using System.Collections.Generic;
using Global.States;
using UnityEngine;

public class ButtonRestart : MonoBehaviour {

	public void OnClick()
	{
		GameManager.Instance.gameOverScreen.Hide();
		var playerTurn = new PlayerTurn();
		playerTurn.Start();
	}
}
