using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://answers.unity.com/questions/904981/how-to-play-an-audio-file-after-another-finishes.html
// https://johnleonardfrench.com/articles/ultimate-guide-to-playscheduled-in-unity/

//[RequireComponent(typeof(AudioSource))]
public class QueueAudioClip : MonoBehaviour
{
    // Use two Audio Sources in an Array
    public AudioSource[] audioSourceArray;
    public AudioClip[] audioClipArray;

    int toggle;
    int nextClip;
    public double nextStartTime = 0;

    void Update()
    {

        if (AudioSettings.dspTime > nextStartTime - 1)
        {
            
            AudioClip clipToPlay = audioClipArray[nextClip];

            // Loads the next Clip to play and schedules when it will start
            audioSourceArray[toggle].clip = clipToPlay;
            audioSourceArray[toggle].PlayScheduled(nextStartTime);

            // Checks how long the Clip will last and updates the Next Start Time with a new value
            //double duration = (double)clipToPlay.timeSamples / clipToPlay.frequency;
            //double duration = clipToPlay.length;
            double duration = 60;
            nextStartTime = nextStartTime + duration;

            // Switches the toggle to use the other Audio Source next
            toggle = 1 - toggle;

            // Increase the clip index number, reset if it runs out of clips
            nextClip = nextClip < audioClipArray.Length - 1 ? nextClip + 1 : 0;
        }

    }

}
