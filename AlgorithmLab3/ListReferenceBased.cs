using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLab3
{
    public class ListReferenceBased<T> : ListInterface<T>
    {
        private Node<T> head; // Reference to the head of list

        public ListReferenceBased() // Empty list with head reference null
        {
            head = null;
        }

        //Method to add element to end of list
        public void Add(T data)
        {
            if (head == null) // Check if empty, if empty, add new element as head
            {
                head = new Node<T>(data);
            }
            else 
            {
                Node<T> current = head; // start traverse at head
                while (current.Next != null) // iterate until last node is reached
                {
                    current = current.Next; 
                }
                current.Next = new Node<T>(data); // Add the new node
            }

        }

        // method to add an element to a chosen position in list
        public void InsertAt(T data, int index)
        {
            if (index == 0) // If index is zero then new node at the head position
            {
                Node<T> newNode = new Node<T>(data); 
                newNode.Next = head; 
                head = newNode; 
            }
            else
            {
                Node<T> current = head; // start traverse at head
                int currentIndex = 0; // keep track of current position
                while (current.Next != null && currentIndex < index - 1) // traverse through until last node or index is reached
                {
                    current = current.Next;
                    currentIndex++;
                }
                if (current == null) // if index is outside the list index
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");
                }
                // if desired index is reached, create new node between current and next one and link it
                Node<T> newNode = new Node<T>(data); 
                newNode.Next = current.Next; 
                current.Next = newNode; 
            }
        }

        // remove element at specified index
        public void RemoveAt(int index)
        {
            if (index == 0) // check if index is zero
            {
                if (head == null) // if head is null
                {
                    throw new InvalidOperationException("List is empty");
                }
                head = head.Next; //Remove first node in list
            }
            else
            {
                Node<T> current = head; // start traverse at head
                int currentIndex = 0; // Keep track of where in list it is
                while (current != null && currentIndex < index - 1) // loop until end is reached or node before the node to be removed is reached
                {
                    current = current.Next;
                    currentIndex++;
                }
                if (current == null || current.Next == null) // if index is out of range
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");
                }
                current.Next = current.Next.Next; //remove the node
            }
        }

        // Method to clear the list
        public void Clear()
        {
            head = null; //Simply clears the list by setting the head to null
        }

        //Method to get the value at a specific index in list
        public T GetValueAt(int index)
        {
            Node<T> current = head; //traverse at start
            int currentIndex = 0; // keep track of which positon it's at
            while (current != null && currentIndex < index) // loop through until end is reached or desired index is reached
            {
                current = current.Next;
                currentIndex++;
            }
            if (current == null) // if index is out of range
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");
            }
            return current.Data; // if desired index is reached, return the data of the node
        }

        //Check if list is empty
        public bool isEmpty()
        {
            return head == null; // checks if head is null
        }

        //get the lenght of the list
        public int Lenght()
        {
            int count = 0; // a counter that counts nodes
            Node<T> current = head; //start at head to traverse the list
            while (current != null) // travers until end is reached
            {
                count++; 
                current = current.Next; 
            }
            return count; //return total count
        }

        //Show the whole list
        public void Display()
        {
            Node<T> current = head; //Starting traverse
            int index = 1; // Index starting point
            while (current != null) //loop until end is reached
            {
                Console.WriteLine($"index {index}-> {current.Data}"); // print it out
                current = current.Next;
                index++;
            }
        }
    }
}
