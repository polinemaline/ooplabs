using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1._3
{


    
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            TreeNode child1 = new TreeNode(2);
            TreeNode child2 = new TreeNode(3);
            TreeNode grandchild1 = new TreeNode(4);
            TreeNode grandchild2 = new TreeNode(5);

            root.AddChild(child1);
            root.AddChild(child2);
            child1.AddChild(grandchild1);
            child1.AddChild(grandchild2);

            root.PrintChildrenValues();
            Console.ReadKey();
        }
    }
}
