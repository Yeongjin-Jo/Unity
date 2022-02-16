using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSource_Unity : MonoBehaviour
{
    private AudioSource theAudio;

    [SerializeField] private AudioClip[] clip;
    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    public void playSE()
    {
        int _temp = Random.Range(0,4);

        theAudio.clip = clip[_temp];
        theAudio.Play();
    }
}
