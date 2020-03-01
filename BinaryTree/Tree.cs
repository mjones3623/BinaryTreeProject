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


            Node root = null;

        }
        
        public Node Add( int v)
        {
            
            if(root == null)
            {
                root = new Node();
                root.value = v;

                return root;                
            }
            else if (v < root.value)
            {
                root.left = new Node();
                root.left.value = v;
                return root.left;
            }
            else
            {
                root.right = new Node();
                root.right.value = v;
                return root.right;
            }



            return root;



            //else if(root < root.value)
            //{ew
            //    Node left = new Node(node.value);

            //}
            //else 
            //{
            //    Node right = new Node(node.value);

            //}


        }

    }
}
