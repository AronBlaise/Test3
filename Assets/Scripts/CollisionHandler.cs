using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    GameObject control;
    private void Start()
    {
        control = GameObject.Find("Control");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<CollisionHandler>() != null)
            control.GetComponent<Control>().playerCollisionHappened(gameObject);
    }
}
