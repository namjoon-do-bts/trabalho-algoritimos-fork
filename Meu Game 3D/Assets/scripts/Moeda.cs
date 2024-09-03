using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moeda : MonoBehaviour
{
    public int velocidadeGiro = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(eulers: Vector3.forward * velocidadeGiro * Time.deltaTime);
    }
    
}
