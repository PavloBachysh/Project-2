using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    public Player player;

    private void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            player.Hitted();
        }
    }

}
