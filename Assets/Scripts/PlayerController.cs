using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    private float speed = 15.0f;
    private float xRange = 11.0f;
    private float zRange = 15f;
    private ObjectPooling objectPool;

    private GameObject projectilePrefab;

    void Awake()
    {
        objectPool = GetComponent<ObjectPooling>();
    }

    // Update is called once per frame
    void Update()
    {
        OutOfXBound();
        OutOfZBound();

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            projectilePrefab = objectPool.GetPooledObject();
            if (projectilePrefab != null)
            {
                projectilePrefab.transform.position = gameObject.transform.position;
                projectilePrefab.transform.rotation = gameObject.transform.rotation;
                projectilePrefab.SetActive(true);
            }
        }

    }


    private void OutOfXBound()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    private void OutOfZBound()
    {
        if (transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}
