.pagination {
    text-align: center;
    margin-top: 30px;
    font-size: 16px;
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 20px;
}

.page-btn {
    padding: 6px 14px;
    background-color: #007bff;
    color: white;
    font-weight: bold;
    border-radius: 6px;
    text-decoration: none;
    box-shadow: 0 2px 6px rgba(0, 123, 255, 0.2);
    transition: background-color 0.3s ease;
}

.page-btn:hover {
    background-color: #0056b3;
}

.page-disabled {
    color: #ccc;
    font-weight: bold;
}

.page-info {
    font-weight: 500;
    color: #2c3e50;
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
body {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    background: #eef1f5;
    margin: 0;
    padding: 0;
}

.container {
    max-width: 800px;
    margin: 40px auto;
    background: #ffffff;
    padding: 40px;
    border-radius: 12px;
    box-shadow: 0 8px 25px rgba(0, 0, 0, 0.1);
}

h2 {
    text-align: center;
    color: #2c3e50;
    margin-bottom: 30px;
    font-weight: 600;
}

form {
    text-align: center;
    margin-bottom: 30px;
}

input[type="text"],
input[type="number"] {
    width: 85%;
    padding: 10px;
    margin: 8px 0;
    border: 1px solid #ccc;
    border-radius: 6px;
    font-size: 14px;
}

button {
    padding: 10px 20px;
    background: #3498db;
    color: white;
    border: none;
    border-radius: 6px;
    font-weight: bold;
    cursor: pointer;
    transition: 0.3s;
}

button:hover {
    background: #2980b9;
}

table {
    width: 100%;
    border-collapse: collapse;
    margin-top: 20px;
    background-color: white;
    border-radius: 6px;
    overflow: hidden;
}

th, td {
    padding: 12px 15px;
    border-bottom: 1px solid #eee;
    text-align: center;
    font-size: 15px;
}

th {
    background-color: #f5f7fa;
    font-weight: 600;
}

tr:hover {
    background-color: #f1f1f1;
}

.pagination {
    text-align: center;
    margin-top: 25px;
}

.pagination a {
    margin: 0 12px;
    text-decoration: none;
    color: #3498db;
    font-weight: bold;
}

.pagination a:hover {
    text-decoration: underline;
}

.link {
    text-align: center;
    margin-top: 20px;
}

.link a {
    color: #2d3436;
    font-weight: bold;
    text-decoration: none;
}

.link a:hover {
    text-decoration: underline;
}

{% load static %}
<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <title>Danh sách sinh viên</title>
    <link rel="stylesheet" href="{% static 'css/styles.css' %}">
</head>
<body>
<div class="container">
    <h2>📘 Danh sách sinh viên</h2>

    <form method="get">
        <input type="text" name="q" placeholder="Tìm theo tên hoặc MSSV" value="{{ query }}">
        <br>
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
            <a href="?page={{ page_obj.previous_page_number }}&q={{ query }}">← Trang trước</a>
        {% endif %}

        Trang {{ page_obj.number }} / {{ page_obj.paginator.num_pages }}

        {% if page_obj.has_next %}
            <a href="?page={{ page_obj.next_page_number }}&q={{ query }}">Trang sau →</a>
        {% endif %}
    </div>

    <div class="link">
        <a href="/add/">➕ Thêm sinh viên</a>
    </div>
</div>
</body>
</html>

{% load static %}
<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <title>Thêm sinh viên</title>
    <link rel="stylesheet" href="{% static 'css/styles.css' %}">
</head>
<body>
<div class="container">
    <h2>📝 Thêm sinh viên</h2>

    <form method="post">
        {% csrf_token %}
        {{ form.as_p }}
        <button type="submit">Lưu</button>
    </form>

    <div class="link">
        <a href="/">← Quay lại danh sách</a>
    </div>
</div>
</body>
</html>






.link a.button-link {
    display: inline-block;
    padding: 10px 18px;
    background-color: #007bff;
    color: #fff;
    border-radius: 6px;
    font-weight: bold;
    box-shadow: 0 4px 8px rgba(0, 123, 255, 0.2);
    transition: background-color 0.3s ease, transform 0.2s ease;
}

.link a.button-link:hover {
    background-color: #0056b3;
    transform: translateY(-2px);
    text-decoration: none;
}
