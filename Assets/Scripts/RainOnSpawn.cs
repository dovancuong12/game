using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainOnSpawn : MonoBehaviour
{
    public GameObject rainOn;
    public GameObject rainOnSpawn;
    public float spawnDelay ;
    public float destroyDelay = 3f;
    private void Start()
    {
        StartCoroutine(SpawnAndDestroyObjectsRain());
    }
    private IEnumerator SpawnAndDestroyObjectsRain()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            // Lấy kích thước của Box Collider 2D
            Vector2 size = rainOnSpawn.GetComponent<BoxCollider2D>().size;
            // Random vị trí trong Box Collider 2D
            Vector3 randomPosition = new Vector3(
                Random.Range(-size.x / 2, size.x / 2),
                Random.Range(-size.y / 2, size.y / 2),
                transform.position.z
            );
            // Spawn tại vị trí ngẫu nhiên
            GameObject objRainOn = Instantiate(rainOn, randomPosition, Quaternion.identity);
            // Hủy vật sau một khoảng thời gian
            Destroy(objRainOn, destroyDelay);
        }
    }
}
