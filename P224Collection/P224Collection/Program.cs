using System;
using System.Collections;
using System.Collections.Generic;
//using System.Collections.Generic;

namespace P224Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList arrayListDemo = new ArrayList();
            //arrayListDemo.Add(6);
            //arrayListDemo.Add("Hello");

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(5);
            //arrayList.Add("P224");
            //arrayList.Add(new Student { Name = "Test" });

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------------------------------");

            //arrayList.AddRange(arrayListDemo);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("--------------------------------------------");

            //arrayList.Clear();
            //arrayList.Remove(5);
            //arrayList.RemoveAt(3);
            //arrayList.RemoveRange(2, 2);
            //arrayList.Reverse();
            //arrayList.Sort();

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(arrayList.Count);

            //SortedList sortedList = new SortedList();
            //sortedList.Add("Hello", 5);
            //sortedList.Add("World", 6);
            //sortedList.Add("P224", 25);
            //foreach (var item in sortedList.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(sortedList["Hello"]);

            //Dictionary<int, string> dlist = new Dictionary<int, string>();
            //dlist.Add(5, "Test");
            //dlist.Add(6, "Test");
            //dlist.Add(3, "Test");
            //dlist.Add(9, "Test");

            //foreach (var item in dlist.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> iList = new List<int>();
            //iList.Add(5);
            //iList.Add(7);
            //iList.Add(8);
            //iList.Add(9);
            //iList.Add(15);

            //iList.Sort();

            //FIFO = First In First Out
            //Queue queueNonGeneric = new Queue();
            //queueNonGeneric.Enqueue(5);
            //queueNonGeneric.Enqueue(7);
            //queueNonGeneric.Enqueue("");

            //foreach (var item in queueNonGeneric)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine(queueNonGeneric.Peek());
            //Console.WriteLine("-------------------------------");
            //queueNonGeneric.Dequeue();

            //foreach (var item in queueNonGeneric)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine(queueNonGeneric.Peek());

            //Queue<string> qeu = new Queue<string>();
            //qeu.Enqueue("");


            //LIFO - Last In First Out
            Stack stackNonGeneric = new Stack();
            stackNonGeneric.Push(9);
            stackNonGeneric.Push(7);
            stackNonGeneric.Push(5);

            //Console.WriteLine(stackNonGeneric.Peek());
            stackNonGeneric.Pop();
            //Console.WriteLine(stackNonGeneric.Peek());

            foreach (var item in stackNonGeneric)
            {
                Console.WriteLine(item);
            }

            Stack<int> sta = new Stack<int>();
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}
