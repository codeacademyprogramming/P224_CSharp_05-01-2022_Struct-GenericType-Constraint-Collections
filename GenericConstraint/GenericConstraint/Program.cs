using System;
using System.Collections;

namespace GenericConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int num1 = 5;
            //IntList intList1 = new IntList();
            //intList1.Add(num1);
            //intList1.Add(15);
            //intList1.Add(25);
            //intList1.Add(35);
            //intList1.Add(45);
            //intList1.Add(55);
            //intList1.Add(65);
            //intList1.Add(75);

            //Console.WriteLine(intList1.Count);
            //intList1.ShowList();

            //string str1 = "Test";

            //StringList stringList = new StringList();
            //stringList.Add(str1);
            //stringList.Add("Test");
            //stringList.Add("Test");
            //stringList.Add("Test");
            //stringList.Add("Test");
            //stringList.Add("Test");
            //stringList.Add("Test");
            //stringList.Add("Test");
            //stringList.Add("Test");
            //stringList.Add("Test");

            //StudentList studentList = new StudentList();
            //studentList.Add(new Student 
            //    { 
            //        Name = "", 
            //        SurName = "" 
            //    }
            //);
            //studentList.Add(new Student
            //{
            //    Name = "",
            //    SurName = ""
            //}
            //); studentList.Add(new Student
            //{
            //    Name = "",
            //    SurName = ""
            //}
            // ); studentList.Add(new Student
            // {
            //     Name = "",
            //     SurName = ""
            // }
            // ); studentList.Add(new Student
            // {
            //     Name = "",
            //     SurName = ""
            // }
            // ); studentList.Add(new Student
            // {
            //     Name = "",
            //     SurName = ""
            // }
            // );

            //Console.WriteLine(studentList.Count);

            //MyList<int> myIntList = new MyList<int>();
            //myIntList.Add(5);
            //myIntList.Add(5);
            //myIntList.Add(5);
            //myIntList.Add(5);
            //myIntList.Add(5);
            //myIntList.Add(5);

            //foreach (var item in myIntList)
            //{
            //    Console.WriteLine(item);
            //}

            //MyList<string> myStringList = new MyList<string>();
            //myStringList.Add("");

            //MyList<Student> myStudentLst = new MyList<Student>();

            //myStudentLst.Add(new Student { });


            //MyList<Teacher> myTeacherList = new MyList<Teacher>();
            //myTeacherList.Add(new Teacher { });

            //MyList<Person,object> myList = new MyList<Person,object>();

            MyList<object> myList = new MyList<object>();
            myList.Add(5);
            myList.Add("Test");
        }

        //static T Write<T>(T item) where T:class, new()
        //{
        //    Console.WriteLine(item);
        //    return item;
        //}

        //static void WriteStr(string str)
        //{
        //    Console.WriteLine(str);
        //}

        //static void WriteInt(int str)
        //{
        //    Console.WriteLine(str);
        //}
    }

    //class Person
    //{

    //}

    //class Student:Person
    //{
    //    public string Name { get; set; }
    //    public string SurName { get; set; }
    //}

    //class Teacher : Person
    //{

    //}

    class MyList<T>
    {
        private T[] _arr;
        public int Count { get; set; }

        public MyList()
        {
            _arr = new T[0];
        }

        public void Add(T num)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = num;
            Count++;
        }

        public void ShowList()
        {
            foreach (T item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }

    //class MyList<T, U> where T : U
    //{
    //    private T[] _arr;
    //    public int Count { get; set; }

    //    public MyList()
    //    {
    //        _arr = new T[0];
    //    }

    //    public void Add(T num, T NUm)
    //    {
    //        Array.Resize(ref _arr, _arr.Length + 1);
    //        _arr[_arr.Length - 1] = num;
    //        _arr[_arr.Length - 1] = NUm;
    //        Count++;
    //    }

    //    public void ShowList()
    //    {
    //        foreach (T item in _arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}


    //class IntList
    //{
    //    private int[] _arr;
    //    public int Count { get; set; }

    //    public IntList()
    //    {
    //        _arr = new int[0];
    //    }

    //    public void Add(int num)
    //    {
    //        Array.Resize(ref _arr, _arr.Length + 1);
    //        _arr[_arr.Length - 1] = num;
    //        Count++;
    //    }

    //    public void ShowList()
    //    {
    //        foreach (int item in _arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class StringList
    //{
    //    private string[] _arr;
    //    public int Count { get; set; }

    //    public StringList()
    //    {
    //        _arr = new string[0];
    //    }

    //    public void Add(string num)
    //    {
    //        Array.Resize(ref _arr, _arr.Length + 1);
    //        _arr[_arr.Length - 1] = num;
    //        Count++;
    //    }

    //    public void ShowList()
    //    {
    //        foreach (string item in _arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class StudentList
    //{
    //    private Student[] _arr;
    //    public int Count { get; set; }

    //    public StudentList()
    //    {
    //        _arr = new Student[0];
    //    }

    //    public void Add(Student num)
    //    {
    //        Array.Resize(ref _arr, _arr.Length + 1);
    //        _arr[_arr.Length - 1] = num;
    //        Count++;
    //    }

    //    public void ShowList()
    //    {
    //        foreach (Student item in _arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
}
