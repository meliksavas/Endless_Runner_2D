using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    
    [SerializeField]
    private float spawnRate = 2f;

    private float nextSpawnTime;

    private void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            GameObject cactus = ObjectPool.instance.GetPooledObject();
            // Havuzda boþta eleman var mý kontrol et
            if (cactus != null)
            {
                cactus.transform.position = transform.position;
                cactus.transform.rotation = Quaternion.identity;
                cactus.SetActive(true); // Uyuya prensesi uyandýr
            }
            nextSpawnTime = Time.time + spawnRate;
        }
        
    }
}
