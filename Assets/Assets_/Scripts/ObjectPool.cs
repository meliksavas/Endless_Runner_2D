using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance; // Her yerden ulaþýlabilir referans

    // Havuzda hangi objeyi biriktireceðiz? (Kaktüs Prefab'ý)
    [SerializeField] private GameObject objectToPool;

    // Baþlangýçta kaç tane üretelim? (Örn: 10)
    [SerializeField] private int amountToPool = 10;

    private List<GameObject> pooledObjects;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject tempGameObject = Instantiate(objectToPool);

            tempGameObject.SetActive(false);

            pooledObjects.Add(tempGameObject);
        }
    }

    public GameObject GetPooledObject()
    {
        foreach (GameObject poolItem in pooledObjects)
        {
            if (!poolItem.activeInHierarchy)
            {
                return poolItem;
            }
            
        }
        return null;
    }

}