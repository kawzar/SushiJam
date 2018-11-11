using System.Collections;
using System.Collections.Generic;
using Global.Stats;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlates : MonoBehaviour
{
    public static ScorePlates Instance;
    [SerializeField]
    Image smallPlate;

    [SerializeField]
    Image mediumPlate;

    [SerializeField]
    Image largePlate;

    private void Awake()
    {
        Instance = this;
    }
    public void ShowScorePlates()
    {
        var score = GameStats.Instance.GetScore();
        
        if(score < 400)
        {
            smallPlate.enabled = true;
        }
        else if (score >= 400 && score < 700)
        {
            mediumPlate.enabled = true;
        }
        else
        {
            largePlate.enabled = true;
        }
    }

    public void Hide()
    {
        smallPlate.enabled = false;
        mediumPlate.enabled = false;
        largePlate.enabled = false;
    }

}
