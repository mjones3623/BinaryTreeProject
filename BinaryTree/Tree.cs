using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree
    {
        public Node root;

        public Tree()
        {
           

        }
        
        public Node Add( int v)
        {

            Node root = new Node();

            if(root == null)
            {
                root.value = v;


                return root;                
            }
            else if (v < root.value)
            {
                root.left.value = v;

                return root.left;
            }
            else
            {
                root.right.value = v;

                return root.right;
            }





        }

    }
}
