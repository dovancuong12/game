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



<h2>Thêm sách</h2>
<form method="post">
  {% csrf_token %}
  {{ form.as_p }}
  <button type="submit">Lưu</button>
</form>
<a href="/">Về danh sách</a>


<h2>Danh sách sách</h2>
<form method="get">
  <input type="text" name="q" placeholder="Tìm theo tiêu đề hoặc tác giả" value="{{ query }}">
  <button type="submit">Tìm</button>
</form>

<table border="1">
  <tr>
    <th>Tiêu đề</th>
    <th>Tác giả</th>
    <th>Năm XB</th>
    <th>Thể loại</th>
  </tr>
  {% for book in page_obj %}
    <tr>
      <td>{{ book.title }}</td>
      <td>{{ book.author }}</td>
      <td>{{ book.published_year }}</td>
      <td>{{ book.genre }}</td>
    </tr>
  {% empty %}
    <tr><td colspan="4">Không có sách</td></tr>
  {% endfor %}
</table>

<div>
  {% if page_obj.has_previous %}
    <a href="?page={{ page_obj.previous_page_number }}{% if query %}&q={{ query }}{% endif %}">Trước</a>
  {% endif %}

  Trang {{ page_obj.number }} / {{ page_obj.paginator.num_pages }}

  {% if page_obj.has_next %}
    <a href="?page={{ page_obj.next_page_number }}{% if query %}&q={{ query }}{% endif %}">Sau</a>
  {% endif %}
</div>

<a href="/add/">➕ Thêm sách</a>


from django.contrib import admin
from django.urls import path
from msv2025123456 import views

urlpatterns = [
    path('admin/', admin.site.urls),
    path('', views.book_list, name='book_list'),
    path('add/', views.add_book, name='add_

from django.shortcuts import render, redirect
from .models import Student
from .forms import StudentForm
from django.core.paginator import Paginator

def student_list(request):
    query = request.GET.get('q', '')
    students = Student.objects.all()
    if query:
        students = students.filter(name__icontains=query) | students.filter(student_id__icontains=query)

    paginator = Paginator(students, 4)
    page_number = request.GET.get('page')
    page_obj = paginator.get_page(page_number)

    return render(request, 'student_list.html', {'page_obj': page_obj, 'query': query})

def add_student(request):
    if request.method == 'POST':
        form = StudentForm(request.POST)
        if form.is_valid():
            form.save()
            return redirect('student_list')
    else:
        form = StudentForm()
    return render(request, 'add_student.html', {'form': form})

