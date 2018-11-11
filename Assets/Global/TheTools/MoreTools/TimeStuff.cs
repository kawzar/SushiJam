using System.Collections;
using RookBirdTools.Listeners;
using UnityEngine;

namespace RookBirdTools.MoreTools
{


    public class TimeStuff
    {
        public static MonoBehaviour refe;

        private static void CheckRefe()
        {
            if (!refe)
            {
                refe = Updater.Instance;
            }
        }

        public static void DoAfter(Runnable.Lambda p, float v)
        {
            CheckRefe();
            refe.StartCoroutine(Future(p, v));
        }
        public static void DoAfter(Runnable p, float v)
        {
            CheckRefe();
            refe.StartCoroutine(Future(p, v));
        }

        public static void DoAfterFrames(Runnable p, int frames)
        {
            CheckRefe();
            refe.StartCoroutine(WaitFramesAndDo(frames, p));
        }
        public static void DoAfterFrames(Runnable.Lambda p, int frames)
        {
            CheckRefe();
            refe.StartCoroutine(WaitFramesAndDo(frames, p));
        }

        private static IEnumerator WaitFramesAndDo(int frames, Runnable.Lambda f)
        {
            yield return Frames(frames);
            f?.Invoke();
        }
        private static IEnumerator WaitFramesAndDo(int frames, Runnable f)
        {
            yield return Frames(frames);
            f?.Invoke();
        }

        private static IEnumerator Future(Runnable p, float v)
        {
            yield return new WaitForSecondsRealtime(v);
            p?.Invoke();
        }
        private static IEnumerator Future(Runnable.Lambda p, float v)
        {
            yield return new WaitForSecondsRealtime(v);
            p?.Invoke();
        }

        public static IEnumerator Frames(int frames)
        {
            for (int i = 0; i < frames; i++)
            {
                yield return new WaitForEndOfFrame();
            }
        }
    }
}