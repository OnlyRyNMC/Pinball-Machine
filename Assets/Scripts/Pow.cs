using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pow : MonoBehaviour {
    [SerializeField] private float radius = 1f;
    [SerializeField] private float power = 50f;

    //Class my "explo's" call 
    public void Run() {
        Boom();
    }


    // Code to push my pinball up the shoot
    void Boom() {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider hit in colliders) {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
                rb.AddExplosionForce(power, transform.position, radius, 3.0f);
            }
        }
    }
     



