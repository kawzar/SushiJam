using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MyScreen : MonoBehaviour
{
    [UnityEngine.Serialization.FormerlySerializedAs("fadeDuration")]
    [SerializeField] private float fadeInDuration = 0.25f;
    [SerializeField] private float fadeOutDuration = 0.25f;

    private Graphic[] graphics;

    public delegate void UIEvent();
    public event UIEvent FadeInStarted;
    public event UIEvent FadeInFinished;
    public event UIEvent FadeOutStarted;
    public event UIEvent FadeOutFinished;
    public event UIEvent Showed;
    public event UIEvent Hid;

    private void Awake()
    {
        graphics = GetComponentsInChildren<Graphic>();
    }

    public void Show()
    {
        foreach(Graphic g in graphics)
        {
            g.enabled = true;
        }

        Showed?.Invoke();
    }

    public void Hide()
    {
        foreach(Graphic g in graphics)
        {
            g.enabled = false;
        }

        Hid?.Invoke();
    }

    public void FadeIn()
    {
        FadeInStarted?.Invoke();

        Show();

        //graphics[0].color = new Color(1, 1, 1, 0);
        graphics[0].DOFade(1, fadeInDuration)
            .OnComplete(() => FadeInFinished?.Invoke());

        for (int i = 1; i < graphics.Length; i++)
        {
            Graphic g = graphics[i];
            g.color = new Color(1, 1, 1, 0);            
            g.DOFade(1, fadeInDuration);
        }
    }

    public void FadeOut()
    {
        FadeOutStarted?.Invoke();

        graphics[0].DOFade(0, fadeOutDuration)
            .OnComplete(() =>
            {
                Hide();
                FadeOutFinished?.Invoke();
            });

        for(int i = 1; i < graphics.Length; i++)
        {
            Graphic g = graphics[i];
            g.DOFade(0, fadeOutDuration);
        }
    }
}
