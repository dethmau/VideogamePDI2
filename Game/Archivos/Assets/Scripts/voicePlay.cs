using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voicePlay : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;

    AudioSource fuente;

    // Start is called before the first frame update
    void Start()
    {
        fuente = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            fuente.clip = clip1;
            fuente.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            fuente.clip = clip2;
            fuente.Play();
        }
    }
}
