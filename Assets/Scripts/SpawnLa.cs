using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLa : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject spawnArea;
    public float spawnDelay ;
    public float destroyDelay = 3f;
    private void Start()
    {
        StartCoroutine(SpawnAndDestroyObjects());
    }
    private IEnumerator SpawnAndDestroyObjects()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            // Lấy kích thước của Box Collider 2D
            Vector2 size = spawnArea.GetComponent<BoxCollider2D>().size;
            // Random vị trí trong Box Collider 2D
            Vector3 randomPosition = new Vector3(
                Random.Range(-size.x / 2, size.x / 2),
                Random.Range(-size.y / 2, size.y / 2),
                transform.position.z
            );
            // Spawn tại vị trí ngẫu nhiên
            GameObject spawnedObject = Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
            // Hủy vật sau một khoảng thời gian
            Destroy(spawnedObject, destroyDelay);
        }
    }
}