using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Creating_and_Adding_Items_to_ObservableCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> Names = new ObservableCollection<string>();

            Names.CollectionChanged += Items_CollectionChanged;

            Names.Add("a");
            Names.Add("b");
            Names.Add("c");
            Names.Add("d");
            Names.Add("e");
            Names.Add("f");

            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }

            var ss = Names.Where(x => !string.Equals(x, "a", StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine("\n\nSS Items = " + string.Join(",", ss));


            Names.Remove("b");


            Names.RemoveAt(3);

            Names.Where(x => x.StartsWith("e")).ToList().ForEach(x => Names.Remove(x));

            Names.Add("v");

            Names[4] = "k";

            Names.Move(3, 4);

            Names.Clear();



            //   stack  data structure

            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);


            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            var stack2 = new Stack<int>();

            int stackCount = stack.Count();
            for (int i = 0; i < stackCount; i++)
            {
                stack2.Push(stack.Pop());
            }

            Console.WriteLine("\n Reversed Stack in stack 2 : " + string.Join(",", stack2));

            stack = new Stack<int>(stack2);

            Console.WriteLine("\n First Element and delete it : " + stack.Pop());

            Console.WriteLine("\n First Element : " + stack.Peek());

            Console.WriteLine("\n Count : " + stack.Count());

            Console.WriteLine("\n is stack contian Number 2 :" + stack.Contains(2));

            Console.WriteLine("\n check if there is any elements in this stack which are greater than  Number 2 " + stack.Any(x => x > 2));






            stack.Clear();

            if (stack.Count == 0)
            {
                Console.WriteLine("\n Stack is empty");
            }


            Queue<int> queue = new Queue<int>();


            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n get The First Element with Removing it : " + queue.Dequeue());

            Console.WriteLine("\n get the first element : " + queue.Peek());

            Console.WriteLine("\n Count : " + queue.Count());

            queue.Clear();

            if (queue.Count == 0)
                Console.WriteLine("\n Queue is empty");

            LinkedList<int> linkedList1 = new LinkedList<int>();

            linkedList1.AddLast(1);
            linkedList1.AddLast(2);
            linkedList1.AddLast(3);
            linkedList1.AddLast(4);
            linkedList1.AddLast(5);

            Console.WriteLine("\n");
            foreach (var item in linkedList1)
            {
                Console.WriteLine($"\n Item : {item}");
            }

            linkedList1.AddFirst(0);

            Console.WriteLine("\n");
            foreach (var item in linkedList1)
            {
                Console.WriteLine($"\n Item : {item}");
            }

            linkedList1.RemoveFirst();

            linkedList1.RemoveLast();

            linkedList1.Remove(4);

            Console.WriteLine("\n");
            foreach (var item in linkedList1)
            {
                Console.WriteLine($"\n Item : {item}");
            }

            linkedList1.AddLast(4);
            linkedList1.AddLast(5);
            linkedList1.AddLast(6);
            linkedList1.AddLast(7);
            linkedList1.AddLast(8);

            linkedList1.AddLast(9);

            var linkedList2 = linkedList1.Where(x => x > 0 && x < 8).OrderByDescending(x => x);

            Console.WriteLine("\n LinkedList2 : ");
            foreach (var item in linkedList2)
            {
                Console.WriteLine($"\n Item : {item}");
            }

            Console.ReadKey();
        }

        static void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:

                    Console.WriteLine("\nAdded: ");
                    foreach (var item in e.NewItems)
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:

                    Console.WriteLine("\nRemoved: ");
                    foreach (var item in e.OldItems)
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:

                    Console.WriteLine("\nReplaced: ");
                    foreach (var item in e.OldItems)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("\nWith: ");
                    foreach (var item in e.NewItems) { Console.WriteLine(item); }

                    break;

                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:

                    Console.WriteLine("\nMoved: ");
                    foreach (var item in e.OldItems)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine($"\n From Index {e.OldStartingIndex}  to : {e.NewStartingIndex} ");


                    break;

                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:

                    Console.WriteLine("\n\n Clear - Reset Action :");
                    break;
            }
        }
    }
}
