using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Transform target;
    public Camera cam;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        if (gameObject.GetComponent<IsPlayer>().isPlayer == true)
        {
            Vector3 desiredPosition = transform.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(cam.transform.position, desiredPosition, smoothSpeed);
            cam.transform.position = smoothedPosition;
            cam.transform.LookAt(transform);
        }
    }
}
