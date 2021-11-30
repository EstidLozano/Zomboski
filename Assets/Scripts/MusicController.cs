using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    
    public void MuteMusic(){
        gameObject.GetComponent<AudioSource>().mute=true;
    }
    public void PlayMusic(){
        gameObject.GetComponent<AudioSource>().mute=false;
    }
    
    

    
}
