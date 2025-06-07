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
        transform.position = Vector3.MoveTowards(pos , target , moveSpeed * Time.


    return render(request, 'book_list.html', {'page_obj': page_obj, 'query': query})
}
body {
    font-family: Arial, sans-serif;
    margin: 40px;
    background: #f9f9f9;
}

h2 {
    color: #333;
    border-bottom: 2px solid #ccc;
    padding-bottom: 10px;
}

form input[type="text"],
form input[type="number"] {
    padding: 5px;
    margin: 5px;
    width: 300px;
    border: 1px solid #ccc;
    border-radius: 4px;
}

form button {
    padding: 5px 15px;
    background-color: #007bff;
    color: white;
    border: none;
    border-radius: 4px;
}

form button:hover {
    background-color: #0056b3;
}

table {
    border-collapse: collapse;
    width: 100%;
    margin-top: 20px;
    background-color: white;
}

th, td {
    padding: 10px;
    border: 1px solid #ccc;
    text-align: left;
}

th {
    background-color: #f1f1f1;
}

a {
    text-decoration: none;
    color: #007bff;
}

a:hover {
    text-decoration: underline;
}



