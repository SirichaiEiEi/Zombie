using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource sr;
    public AudioClip ac;
    public GameObject Zombie;
    void Start()
    {
        sr = GetComponent<AudioSource>();
        ac = GetComponent<AudioClip>();
        Zombie = GetComponent<GameObject>();
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
                if (hit.collider.gameObject.name.CompareTo("Zombie") == 0)
                {
                    sr.Play();
                }
            }
        }
    }
}
