using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        var target = player.transform.position;
        var pos = transform.position;
        target.z =pos.z;
        transform.position = Vector3.MoveTowards(pos , target , moveSpeed * Time.deltaTime);
    }
}
