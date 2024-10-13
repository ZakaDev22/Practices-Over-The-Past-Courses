using System;
using System.Collections.Generic;

namespace General_Tree
{
    public class TreeNode<T>
    {
        public T Value { get; set; }

        public List<TreeNode<T>> children { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            this.children = new List<TreeNode<T>>();
        }

        public void AddChilde(TreeNode<T> childe)
        {
            this.children.Add(childe);
        }

        public TreeNode<T> Find(T value)
        {
            if (EqualityComparer<T>.Default.Equals(this.Value, value))
                return this;

            foreach (var child in children)
            {
                var found = child.Find(value);
                if (found != null) return found;
            }


            return null;
        }


        public void PrintTree()
        {
            PrintTreeElemnts<T>(this);
        }

        private static void PrintTreeElemnts<T>(TreeNode<T> Node, string indent = "     ")
        {
            Console.WriteLine(indent + Node.Value);
            foreach (var Child in Node.children)
            {
                PrintTreeElemnts(Child, indent + "  ");
            }
        }
    }

    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public Tree(T RootValue)
        {
            Root = new TreeNode<T>(RootValue);
        }

        public void PrintTreeElements()
        {
            this.Root.PrintTree();
        }

        public TreeNode<T> Find(T value)
        {
            return this.Root.Find(value);
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            var CompanyTree = new Tree<string>("CEO");
            var Finance = new TreeNode<string>("CFO");
            var Tech = new TreeNode<string>("CTO");
            var Marketing = new TreeNode<string>("CMO");

            CompanyTree.Root.AddChilde(Finance);
            CompanyTree.Root.AddChilde(Tech);
            CompanyTree.Root.AddChilde(Marketing);

            // Add employees to departments
            Finance.AddChilde(new TreeNode<string>("Accountant"));
            Tech.AddChilde(new TreeNode<string>("Developer"));
            Tech.AddChilde(new TreeNode<string>("UX Designer"));
            Marketing.AddChilde(new TreeNode<string>("Social Media Manager"));

            CompanyTree.PrintTreeElements();

            Console.WriteLine("\n\n\tThis Is Elfakhar Family Tree : \n\n");

            var ElfakharFamilyRoot = new Tree<string>("Ibrahim Elfakhar");
            var Mohammed = new TreeNode<string>("Mohammed");
            var Rachide = new TreeNode<string>("Rachide");
            var Hamza = new TreeNode<string>("Hamza");
            var Zakaria = new TreeNode<string>("Zakaria");
            var Omar = new TreeNode<string>("Omar");

            ElfakharFamilyRoot.Root.AddChilde(Mohammed);
            ElfakharFamilyRoot.Root.AddChilde(Rachide);
            ElfakharFamilyRoot.Root.AddChilde(Hamza);
            ElfakharFamilyRoot.Root.AddChilde(Zakaria);
            ElfakharFamilyRoot.Root.AddChilde(Omar);

            var Abd_arahman = new TreeNode<string>("Abd_arahman");
            var alaa = new TreeNode<string>("Alaa");
            var Omama = new TreeNode<string>("Omama");
            var Ibrahime = new TreeNode<string>("Ibrahime");
            var Yahya = new TreeNode<string>("Yahya");
            var Assia = new TreeNode<string>("Assia");

            Mohammed.AddChilde(alaa);
            Rachide.AddChilde(Abd_arahman);
            Rachide.AddChilde(Omama);
            Rachide.AddChilde(Ibrahime);
            Zakaria.AddChilde(Yahya);
            Zakaria.AddChilde(Assia);

            ElfakharFamilyRoot.PrintTreeElements();

            Console.WriteLine("\n\n Zakaria Tree");
            Zakaria.PrintTree();


            Console.ReadKey();
        }


    }
}
