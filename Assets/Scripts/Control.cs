using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Camera cam;
    public GameObject currentPlayer, newCurrentPlayer;
    [SerializeField] Vector3 F1, F2;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    int counter;

    public void playerCollisionHappened(GameObject collidingPlayer)
    {
        counter++;
        Debug.Log(collidingPlayer);
        
        if (collidingPlayer != currentPlayer) {
            newCurrentPlayer = collidingPlayer;
        }
        if (counter == 2)
        {
            currentPlayer = newCurrentPlayer;
            counter = 0;
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.S))
            currentPlayer.GetComponent<Rigidbody>().velocity += F1;
        if (Input.GetKey(KeyCode.W))
            currentPlayer.GetComponent<Rigidbody>().velocity -= F1;
        if (Input.GetKey(KeyCode.A))
            currentPlayer.GetComponent<Rigidbody>().velocity += F2;
        if (Input.GetKey(KeyCode.D))
            currentPlayer.GetComponent<Rigidbody>().velocity -= F2;

        Vector3 desiredPosition = currentPlayer.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(cam.transform.position, desiredPosition, smoothSpeed);
        cam.transform.position = smoothedPosition;
        cam.transform.LookAt(currentPlayer.transform);

    }
}
