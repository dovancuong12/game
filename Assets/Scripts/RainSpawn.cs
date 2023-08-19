using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawn : MonoBehaviour
{
    public GameObject rain;
   // public GameObject rainSpawnBox;
    public float spawnDelay ;
    public float destroyDelay = 3f;
    private BoxCollider2D boxCollider;
    public void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        StartCoroutine(SpawnAndDestroyObjects());
    }
    public IEnumerator SpawnAndDestroyObjects()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            Vector2 size = boxCollider.size;
            Vector3 randomPosition = new Vector3(
                Random.Range(-size.x , size.x ),
                Random.Range(-size.y , size.y ),
                transform.position.z
            );

            GameObject objRainOn = Instantiate(rain,  randomPosition, Quaternion.identity);
            Destroy(objRainOn, destroyDelay);
        }
    }
}
