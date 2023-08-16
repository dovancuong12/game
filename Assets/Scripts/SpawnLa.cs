using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLa : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnDelay = 1f;
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

            // Tạo ra vật
            float spawnX = Random.Range(-11,28);
            Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, transform.position.z);

            GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, Quaternion.identity);

            // Hủy vật sau một khoảng thời gian
            Destroy(spawnedObject, destroyDelay);
        }
    }
}
