using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeInterval = 1.0f;
    private float timeFromPreviousSpawn;

    // Update is called once per frame
    void Update()
    {
        timeFromPreviousSpawn += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeFromPreviousSpawn >= timeInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeFromPreviousSpawn = 0;
        }
    }
}
