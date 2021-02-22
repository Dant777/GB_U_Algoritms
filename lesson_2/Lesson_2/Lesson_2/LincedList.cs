using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    public class LincedList : ILinkedList
    {
        Node _head;
        Node _tail;
        int _count;

        public void AddNode(int value)
        {
            Node newNode = new Node(value);
            if (_head == null)
                _head = newNode;
            else
            {
                _tail.NextNode = newNode;
                newNode.PrevNode = _tail;
            }
            _tail = newNode;
            _count++;
        }

        /// <summary>
        /// Добавить узел после определенного узла, если такой узел существует
        /// </summary>
        /// <param name="node">узел списка</param>
        /// <param name="value">новое значение для узла</param>
        public void AddNodeAfter(Node node, int value)
        {
            Node newNode = new Node();

            newNode.PrevNode = node;
            newNode.NextNode = node.NextNode;
            newNode.Value = value;
            node.NextNode.PrevNode = newNode;
            node.NextNode = newNode;
            _count++;
        }

        public Node FindNode(int searchValue)
        {
            Node currentNode = _head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(searchValue))
                {
                    return currentNode;
                }
                currentNode = currentNode.NextNode;
            }
            return null;
        }

        public void RemoveNode(int index)
        {
            Node currentNode = _head;

            for (int i = 0; i < index; i++)
            {
               
                currentNode = currentNode.NextNode;
            }

            if (currentNode != null)
            {
                if (currentNode.NextNode != null)
                    currentNode.NextNode.PrevNode = currentNode.PrevNode;
                else
                    _tail = currentNode.PrevNode;

                if (currentNode.PrevNode != null)
                    currentNode.PrevNode.NextNode = currentNode.NextNode;
                else
                    _head = currentNode.NextNode;

                _count--;
            }
        }

        public void RemoveNode(Node node)
        {
            Node currentNode = node;

            //while (currentNode != null)
            //{
            //    if (currentNode.Value.Equals(node.Value))
            //        break;
                
            //    currentNode = currentNode.NextNode;
            //}

            if (currentNode != null)
            {
                if(currentNode.NextNode != null)
                    currentNode.NextNode.PrevNode = currentNode.PrevNode;
                else
                    _tail = currentNode.PrevNode;

                if (currentNode.PrevNode != null)
                    currentNode.PrevNode.NextNode = currentNode.NextNode;
                else
                    _head = currentNode.NextNode;

                _count--;
            }

        }
        public int GetNodeValue(int index)
        {

            Node currentNode = _head;

            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.NextNode;
            }

            return currentNode.Value;
        }
        public Node GetNode(int index)
        {

            Node currentNode = _head;

            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.NextNode;
            }

            return currentNode;
        }
        public int GetCount()
        {
            return _count;
        }

    }
}
