using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_colision : MonoBehaviour
{
    public AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 0.0)
        {
            audioData.Play();
        }
    }
}
