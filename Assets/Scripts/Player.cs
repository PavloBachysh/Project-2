using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int lives;
    public int score;



    public void Missed()
    {
        if (lives > 0)
        {
            lives--;
            Debug.Log("Lives: " + lives);
        }
        else
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }

    public void Hitted()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}
