using DG.Tweening;
using RookBirdTools.Patterns;
using UnityEngine;

public class SacredMusic : ScriptSingleton<SacredMusic>
{

    public AudioSource 
        FeverMode,
        IntroTema,
        LoopTema,
        LoopTemaFever,
        Lose,
        Waterfall,
        Win;

    public void PlayIntro()
    {
        IntroTema.Play();
        IntroTema.volume = 0;
    }

    public void StopIntro()
    {
        IntroTema.Stop();
    } 

    public void PlayLoopTema()
    {
        LoopTema.Play();
        LoopTemaFever.Play();
        LoopTemaFever.volume = 0;
        
    }

    public void PlayLoopTemaFever()
    {
        FeverMode.Play();
        LoopTemaFever.volume = 1;
    }

    public void StopLoopTemaFever()
    {
        LoopTemaFever.volume = 0;
    }
	
    public void StopPlayLoop()
    {
        LoopTema.Stop();
        LoopTemaFever.Stop();
    }
    
    public void PlayWaterfall()
    {
        Waterfall.Play();
    }
	
    public void StopWaterfall()
    {
        Waterfall.Stop();
    }

    public void WinSound() => Win.Play();
    public void StopWinSound() => Win.Stop();
    public void LoseSound() => Lose.Play();
    public void StopLoseSound() => Lose.Stop();
	
	

}
