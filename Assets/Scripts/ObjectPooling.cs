using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{

    public static ObjectPooling SharedInstance;
    private List<GameObject> pooledObjects;
    [SerializeField] private int amountToPool;
    [SerializeField] private GameObject pooledObject;



    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(pooledObject);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }

    }


    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
