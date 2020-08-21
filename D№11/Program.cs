using System;

namespace hw11
{
    class Student : Person
    {
        //����� ����������
        public string PlaceOfResidence;

        public Student(string FirstName, string LastName, string Surname, string Department, string PlaceOfResidence) : base(FirstName, LastName, Surname, Department)
        {
            this.PlaceOfResidence = PlaceOfResidence;
        }

        public override void Work()
        {
            Console.Write("�������: ");
            base.Work();
            Console.WriteLine($"����� ����������: {PlaceOfResidence}");

        }

    }

    class Teacher : Person
    {
        public string Subject;

        public Teacher(string FirstName, string LastName, string Surname, string Department, string Subject) : base(FirstName, LastName, Surname, Department)
        {
            this.Subject = Subject;
        }

        public override void Work()
        {
            Console.Write("�������������: ");
            base.Work();
            Console.WriteLine($"������� �������: {Subject}");

        }
    }

    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public string Surname;
        public string Department;

        public Person(string FirstName, string LastName, string Surname, string Department)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Surname = Surname;
            this.Department = Department;
        }

        virtual public void Work()
        {
            Console.WriteLine($"{FirstName} {LastName} {Surname}");
            Console.WriteLine($"���������: {Department}");
        }

        public override bool Equals(object obj)
        {
            if (obj is Person objectType)
            {
                return this.FirstName == objectType.FirstName && this.LastName == objectType.LastName && this.Surname == objectType.Surname;
            }
            return false;
        }
    }

    class HeadOfDepartment : Teacher
    {
        public HeadOfDepartment(string FirstName, string LastName, string Surname, string Department, string Subject) : base(FirstName, LastName, Surname, Department, Subject)
        {

        }

        public override void Work()
        {
            Console.Write($"���������� �������� {Department} ");
            Console.WriteLine($"{FirstName} {LastName} {Surname}");
            Console.WriteLine($"������� �������: {Subject}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ob1 = new Student("�������", "�������", "�������", "����", "���������, �.201");
            ob1.Work();
            Console.WriteLine();
            Student ob2 = new Student("������������", "�������", "�������", "����", "���������, �.201");
            ob2.Work();


            Console.WriteLine(ob1.Equals(ob2));
            Console.WriteLine(ob1.Equals(ob1));

            Teacher ob3 = new Teacher("�������", "�����", "����������", "����", "��");
            ob2.Work();
            Console.WriteLine();
            HeadOfDepartment ob4 = new HeadOfDepartment("������", "���", "������������ ", "����", "���");
            ob3.Work();
            Console.WriteLine();
        }
    }
}