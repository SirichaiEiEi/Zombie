using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int heal = 100;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void Damede(int amount)
    {
        heal -= amount;
        print(heal);

    }
    void D1()
    {
        if (Input.GetMouseButtonDown(0))
        Debug.Log("Damage10");
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name.CompareTo("Zombie") == 0)
                {
                    Damede(10);


                }
            }
        }
    }
}

