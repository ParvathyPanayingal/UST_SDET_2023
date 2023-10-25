using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GC
    {
        public void ListHandling()
        {
            List<string> numbers = new List<string>();
            numbers.Add("AA");
            numbers.Add("BB");
            numbers.Add("CC");

            /*for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[ist

            }*/


            numbers.Add("DD");
            numbers.Add("EE");
            numbers.Add("FF");

            foreach (string item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Reverse();
            foreach (string item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Sort();
            foreach (string item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.RemoveAt(3);
            foreach (string item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Sort();
            foreach (string item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(numbers.Contains("AA"));
            Console.WriteLine(numbers.IndexOf("FF"));

            numbers.Clear();
            foreach (string item in numbers)
            {
                Console.WriteLine(item);
            }
        }


            public void Stackhandling()
            {
                Stack st = new Stack();
                st.Push(10);
                st.Push(20);
                st.Push(30);
                st.Push("GG");
                st.Push(12.34);
                st.Push(60);
                st.Push(99);

                foreach (var item in st)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Pop" + st.Pop());
                foreach (var item in st)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Peek" + st.Peek());
                foreach (var item in st)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Count" + st.Count);
            }

        public void Queuehandling()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(88.2323);
            q.Enqueue("BB");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pop" + q.Dequeue());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek" + q.Peek());
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + q.Count);
        }

        public void Dicthandling()
        {
            Dictionary <int,string> dict = new Dictionary<int, string>();

            dict.Add(1, "10");
            dict.Add(2, "20");
            dict.Add(3, "30");
            dict.Add(5, "AA");
            dict.Add(4, "BB");


            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            dict.Remove(3);
            foreach (int item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            //ht.ContainsKey("6");
            Console.WriteLine(dict.ContainsKey(6));
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in dict.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + dict.Count);


        }
        
        }



    }
    


