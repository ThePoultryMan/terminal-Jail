using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectSystem : MonoBehaviour
{

    public AudioSource oneOrTwo;
    public AudioSource q;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            oneOrTwo.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            oneOrTwo.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            q.Play();
        }
    }
}
