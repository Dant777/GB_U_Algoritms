using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_5
{
    public class MyBinaryTree : ITree
    {
        TreeNode _tree;
        
        public void AddItem(int value)
        {
            TreeNode tmp = null;
            if (_tree == null)
            {
                _tree = new TreeNode() { Value = value, Parent = _tree};
                return;
            }

            tmp = _tree;
            while (tmp != null)
            {
                if (tmp.Value > value)
                {
                    if (tmp.LeftChild == null)
                    {
                        tmp.LeftChild = new TreeNode() { Value = value, Parent = tmp };
                        return;
                    }
                    else
                    {
                        tmp = tmp.LeftChild;
                        continue;
                    }

                }
                else if (tmp.Value < value)
                {
                    if (tmp.RightChild == null)
                    {
                        tmp.RightChild = new TreeNode() { Value = value, Parent = tmp };
                        return;
                    }
                    else
                    {
                        tmp = tmp.RightChild;
                        continue;
                    }
                }
                else
                {
                    throw new Exception("Wrong tree state"); 
                }
            } 
        }

        public TreeNode GetNodeByValue(int value)
        {
            return HelpSearch(_tree, value);
        }
        public TreeNode GetRoot()
        {
            return _tree;
        }

        public void PrintTree()
        {
            
            HelpPrint(_tree);
            Console.WriteLine();
        }

        public void RemoveItem(int value)
        {
            //Проверяем, существует ли данный узел
            TreeNode tree = GetNodeByValue(value);
            if (tree == null)
            {
                
                return;
            }
            TreeNode curTree;
            //Если удаляем корень
            if (tree.Equals(_tree))
            {
                if (tree.RightChild != null)
                {
                    curTree = tree.RightChild;
                }
                else curTree = tree.LeftChild;

                while (curTree.LeftChild != null)
                {
                    curTree = curTree.LeftChild;
                }
                int temp = curTree.Value;
                this.RemoveItem(temp);
                tree.Value = temp;

                return;
            }
            //Удаление листьев
            if (tree.LeftChild == null && tree.RightChild == null && tree.Parent != null)
            {
                if (tree == tree.Parent.LeftChild)
                    tree.Parent.LeftChild = null;
                else
                {
                    tree.Parent.RightChild = null;
                }
                return;
            }

            //Удаление узла, имеющего левое поддерево, но не имеющее правого поддерева
            if (tree.LeftChild != null && tree.RightChild == null)
            {

                tree.LeftChild.Parent = tree.Parent;
                if (tree == tree.Parent.LeftChild)
                {
                    tree.Parent.LeftChild = tree.LeftChild;
                }
                else if (tree == tree.Parent.RightChild)
                {
                    tree.Parent.RightChild = tree.LeftChild;
                }

                return;
            }
            //Удаление узла, имеющего правое поддерево, но не имеющее левого поддерева
            if (tree.LeftChild == null && tree.RightChild != null)
            {

                tree.RightChild.Parent = tree.Parent;
                if (tree == tree.Parent.LeftChild)
                {
                    tree.Parent.LeftChild = tree.RightChild;
                }
                else if (tree == tree.Parent.RightChild)
                {
                    tree.Parent.RightChild = tree.RightChild;
                }

                return;
            }
            //Удаляем узел, имеющий поддеревья с обеих сторон
            if (tree.RightChild != null && tree.LeftChild != null)
            {
                curTree = tree.RightChild;

                while (curTree.LeftChild != null)
                {
                    curTree = curTree.LeftChild;
                }

                //Если самый левый элемент является первым потомком
                if (curTree.Parent == tree)
                {
                    curTree.LeftChild = tree.LeftChild;
                    tree.LeftChild.Parent = curTree;
                    curTree.Parent = tree.Parent;
                    if (tree == tree.Parent.LeftChild)
                    {
                        tree.Parent.LeftChild = curTree;
                    }
                    else if (tree == tree.Parent.RightChild)
                    {
                        tree.Parent.RightChild = curTree;
                    }
                    return ;
                }
                //Если самый левый элемент НЕ является первым потомком
                else
                {
                    if (curTree.RightChild != null)
                    {
                        curTree.RightChild.Parent = curTree.Parent;
                    }
                    curTree.Parent.LeftChild = curTree.RightChild;
                    curTree.RightChild = tree.RightChild;
                    curTree.LeftChild = tree.LeftChild;
                    tree.LeftChild.Parent = curTree;
                    tree.RightChild.Parent = curTree;
                    curTree.Parent = tree.Parent;
                    if (tree == tree.Parent.LeftChild)
                    {
                        tree.Parent.LeftChild = curTree;
                    }
                    else if (tree == tree.Parent.RightChild)
                    {
                        tree.Parent.RightChild = curTree;
                    }

                    return ;
                }
            }

        }

        private TreeNode HelpSearch(TreeNode tree, int val)
        {
            if (tree == null) return null;
            switch (val.CompareTo(tree.Value))
            {
                case 1: return HelpSearch(tree.RightChild, val);
                case -1: return HelpSearch(tree.LeftChild, val);
                case 0: return tree;
                default: return null;
            }
        }

        private void HelpPrint(TreeNode startNode, string indent = "", Side? side = null)
        {
            if (startNode != null)
            {
                var nodeSide = side == null ? "+" : side == Side.Left ? "L" : "R";
                Console.WriteLine($"{indent} [{nodeSide}]- {startNode.Value}");
                indent += new string(' ', 3);
                //рекурсивный вызов для левой и правой веток
                HelpPrint(startNode.LeftChild, indent, Side.Left);
                HelpPrint(startNode.RightChild, indent, Side.Right);
            }
        }

        public string BFS()
        {
            string bfsInfo = string.Empty;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(_tree);

            while (queue.Count != 0)
            {
                TreeNode temp = queue.Peek();
                queue.Dequeue();
                bfsInfo += temp.Value.ToString() + " ";

                if (temp.LeftChild != null)
                {
                    
                    queue.Enqueue(temp.LeftChild);
                }
                if (temp.RightChild != null)
                {
                    queue.Enqueue(temp.RightChild);
                }
            }

            return bfsInfo;
        }

        public void DFS(TreeNode tree)
        {
            
            if (tree == null) return ;
            Console.Write(tree.Value.ToString() + " " );
            DFS(tree.LeftChild);
            DFS(tree.RightChild);
            
        }
    }

    

    public enum Side
    {
        Left,
        Right
    }
}
