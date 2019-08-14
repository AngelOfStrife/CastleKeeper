using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    void IgnorePause()
    {
        // Use an Audio Source when the Listener is paused
        //AudioSource.ignoreListenerPause = true;
    }

    void StopAudio()
    {
        // Stop a scheduled Audio Source
        //AudioSource.Stop();
    }
}
