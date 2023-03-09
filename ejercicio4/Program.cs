using persona;
Student student = new Student();
student.SetAge(21);
student.SetName("Carlos");
student.SayHello();
student.GoToClasses();
student.ShowAge();

Console.WriteLine("");
Teacher teacher = new Teacher();
teacher.SetAge(30);
teacher.SetName("Jeserrano");
teacher.SayHello();
teacher.Explain();