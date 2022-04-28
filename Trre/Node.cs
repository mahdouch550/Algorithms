using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trre
{
    public class Node
    {
        public Node right;

        public Node left;

        public int value;

        public Node Find(int v)
        {
            if (value == v)
                return this;

            if (this == null)
                return null;

            var tmp = new Node();

            if (value > v)
                tmp = left;
            else
                tmp = right;
            if (tmp != null)
                return tmp.Find(v);
            else
                return null;
        }

        public void Add(int v)
        {
            if(v == value)
            {
                Console.WriteLine("Valeur déja existe!");
                return;
            }

            if (v > value)
            {
                if(right != null)
                {
                    right.Add(v);
                }
                else
                {
                    right = new Node
                    {
                        value = v
                    };
                }
            }

            else
            {
                if (v < value)
                {
                    if (left != null)
                    {
                        left.Add(v);
                    }
                    else
                    {
                        left = new Node
                        {
                            value = v
                        };
                    }
                }
            }
        }
    }
}