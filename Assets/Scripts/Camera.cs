iusing System.Collections;
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

{% load static %}
<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <title>Thêm sinh viên</title>
    <link rel="stylesheet" href="{% static 'css/styles.css' %}">
</head>
<body>
    <h2>Thêm sinh viên</h2>

    <form method="post">
        {% csrf_token %}
        {{ form.as_p }}
        <button type="submit">Lưu</button>
    </form>

    <p><a href="/">← Quay lại danh sách</a></p>
</body>
</html>

{% load static %}
<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <title>Danh sách sinh viên</title>
    <link rel="stylesheet" href="{% static 'css/styles.css' %}">
</head>
<body>
    <h2>Danh sách sinh viên</h2>

    <form method="get">
        <input type="text" name="q" placeholder="Tìm theo tên hoặc MSSV" value="{{ query }}">
        <button type="submit">Tìm</button>
    </form>

    <table>
        <thead>
            <tr>
                <th>Tên</th>
                <th>MSSV</th>
                <th>Năm sinh</th>
                <th>Ngành</th>
            </tr>
        </thead>
        <tbody>
            {% for student in page_obj %}
            <tr>
                <td>{{ student.name }}</td>
                <td>{{ student.student_id }}</td>
                <td>{{ student.birth_year }}</td>
                <td>{{ student.major }}</td>
            </tr>
            {% empty %}
            <tr>
                <td colspan="4">Không có sinh viên nào.</td>
            </tr>
            {% endfor %}
        </tbody>
    </table>

    <div class="pagination">
        {% if page_obj.has_previous %}
            <a href="?page={{ page_obj.previous_page_number }}{% if query %}&q={{ query }}{% endif %}">← Trang trước</a>
        {% endif %}

        Trang {{ page_obj.number }} / {{ page_obj.paginator.num_pages }}

        {% if page_obj.has_next %}
            <a href="?page={{ page_obj.next_page_number }}{% if query %}&q={{ query }}{% endif %}">Trang sau →</a>
        {% endif %}
    </div>

    <p><a href="/add/">➕ Thêm sinh viên</a></p>
</body>
</html>

