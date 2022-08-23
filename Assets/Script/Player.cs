using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource sr;
    public AudioClip ac;
    private int z1;
    private int z2;
    private int z3;
    void Start()
    {
        sr = GetComponent<AudioSource>();
        ac = GetComponent<AudioClip>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Zombie"))
                {
                    sr.Play();
                }
            }
        }
    }
}
