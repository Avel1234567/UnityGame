using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButton : MonoBehaviour
{
    
    bool audioEnabled = true;
    public bool AudioEnabled { get { return audioEnabled; } set { SetAudio(value); } }

   

   

    void SetAudio(bool enabled)
    {
        if (enabled)
        {
            AudioListener.volume = 1f;
           
        }
        else
        {
            AudioListener.volume = 0f;
           
        }
        audioEnabled = enabled;
    }

    public void SwitchAudio()
    {
        AudioEnabled = !AudioEnabled;
    }
}
