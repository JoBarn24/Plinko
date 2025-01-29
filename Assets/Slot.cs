using System;
using UnityEngine;

public class Slot : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Trigger");
    }
}
