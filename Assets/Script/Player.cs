using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource sr;
    public AudioClip ac;
    void Start()
    {
        sr = GetComponent<AudioSource>();
        ac = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            sr.PlayOneShot(ac);
    }
}
