using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyHocSinh
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Tạo danh sách và thêm ít nhất 5 học sinh
            List<Student> students = new List<Student>()
            {
                new Student(1, "An", 16),
                new Student(2, "Binh", 14),
                new Student(3, "Anh", 18),
                new Student(4, "Dung", 15),
                new Student(5, "An", 20),
                new Student(6, "Hung", 17)
            };

            Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ hiển thị tiếng Việt

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("--- a. Danh sách toàn bộ học sinh ---");
            foreach (var sv in students)
            {
                Console.WriteLine(sv.ToString());
            }

            // b. Tìm và in ra danh sách học sinh có tuổi từ 15 đến 18
            Console.WriteLine("\n--- b. Học sinh có tuổi từ 15 đến 18 ---");
            var listAge15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            foreach (var sv in listAge15To18)
            {
                Console.WriteLine(sv.ToString());
            }

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("\n--- c. Học sinh tên bắt đầu bằng chữ 'A' ---");
            var listNameStartA = students.Where(s => s.Name.StartsWith("A")).ToList();
            foreach (var sv in listNameStartA)
            {
                Console.WriteLine(sv.ToString());
            }

            // d. Tính tổng tuổi của tất cả học sinh
            Console.WriteLine("\n--- d. Tổng tuổi của tất cả học sinh ---");
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"Tổng tuổi: {totalAge}");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            Console.WriteLine("\n--- e. Học sinh có tuổi lớn nhất ---");
            // Cách 1: Dùng MaxBy (C# 6.0 trở lên/ .NET 6+)
            // var oldestStudent = students.MaxBy(s => s.Age); 

            // Cách 2: Dùng OrderByDescending (An toàn cho mọi phiên bản)
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();

            if (oldestStudent != null)
            {
                Console.WriteLine(oldestStudent.ToString());
            }

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra
            Console.WriteLine("\n--- f. Danh sách sắp xếp theo tuổi tăng dần ---");
            var sortedList = students.OrderBy(s => s.Age).ToList();
            foreach (var sv in sortedList)
            {
                Console.WriteLine(sv.ToString());
            }

            Console.ReadLine();
        }
    }
}