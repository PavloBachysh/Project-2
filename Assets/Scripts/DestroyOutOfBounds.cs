using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBounds = 30.0f;
    private float lowerBounds = -10.0f;
    private float verticalBounds = 20.0f;
    public Player player;

    void Update()
    {
        CheckVerticalBounds();
        CheckHorizontalBounds();
    }

    private void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    private void CheckVerticalBounds()
    {
        if (transform.position.z > topBounds)
        {
            if (gameObject.CompareTag("Cookie"))
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        else if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
            player.Missed();
        }
    }

    private void CheckHorizontalBounds()
    {
        if (transform.position.x > verticalBounds)
        {
            if (gameObject.CompareTag("Cookie"))
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        else if (transform.position.x < -verticalBounds)
        {
            Destroy(gameObject);
        }
    }


}
