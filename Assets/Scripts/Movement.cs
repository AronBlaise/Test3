using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Vector3 F1, F2;
    void FixedUpdate()
    {
        if (gameObject.GetComponent<IsPlayer>().isPlayer == true) { 
            if (Input.GetKey(KeyCode.S))
                GetComponent<Rigidbody>().velocity += F1;
            if (Input.GetKey(KeyCode.W))
                GetComponent<Rigidbody>().velocity -= F1;
            if (Input.GetKey(KeyCode.A))
                GetComponent<Rigidbody>().velocity += F2;
            if (Input.GetKey(KeyCode.D))
                GetComponent<Rigidbody>().velocity -= F2;
        }

    }
}
