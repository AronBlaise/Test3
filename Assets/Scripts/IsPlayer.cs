using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayer : MonoBehaviour
{
    public bool isPlayer = false;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<IsPlayer>() != null)
            isPlayer = !isPlayer;
    }
}
