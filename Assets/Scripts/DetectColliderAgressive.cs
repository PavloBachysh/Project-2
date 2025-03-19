using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColliderAgressive : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over By Collision");
    }
}
