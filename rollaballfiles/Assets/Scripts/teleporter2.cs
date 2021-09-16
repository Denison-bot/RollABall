using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter2 : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        thePlayer.GetComponent<Rigidbody>().velocity = Vector2.zero;
    }

}