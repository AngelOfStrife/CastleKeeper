using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    void PauseAudio() {
        // Pause all Audio Sources
        AudioListener.pause = true;
    }
    
}
