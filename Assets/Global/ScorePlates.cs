using System.Collections;
using System.Collections.Generic;
using Global.Stats;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlates : MonoBehaviour
{

    [SerializeField]
    Image smallPlate;

    [SerializeField]
    Image mediumPlate;

    [SerializeField]
    Image largePlate;

   public void ShowScorePlates()
    {
        var score = GameStats.Instance.GetScore();
        
        if(score < 15 * 50)
        {
            smallPlate.enabled = true;
        }
        else if (score >= 15 * 50 && score < 30 * 50)
        {
            mediumPlate.enabled = true;
        }
        else
        {
            largePlate.enabled = true;
        }

    }

}
