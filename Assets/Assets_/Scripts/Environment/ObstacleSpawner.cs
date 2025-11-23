using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;
    [SerializeField]
    private float spawnRate = 2f;

    private float nextSpawnTime;

    private void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
            nextSpawnTime = Time.time + spawnRate;
        }
    }
}
