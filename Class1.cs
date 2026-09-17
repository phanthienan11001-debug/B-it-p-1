public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor để khởi tạo nhanh đối tượng
    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    // Override ToString để in thông tin dễ dàng hơn
    public override string ToString()
    {
        return $"ID: {Id}, Tên: {Name}, Tuổi: {Age}";
    }
}