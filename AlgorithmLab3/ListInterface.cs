using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AlgorithmLab3
{
    internal interface ListInterface<T> 

    {
        // Operations on the lsit
        void Add(T data); // add to the end of list
        void InsertAt (T data, int index); // add element to specific place in list
        void RemoveAt (int index); // remove element in list
        void Clear(); // clear the list
        T GetValueAt(int index); // Get what element is in the place
        bool isEmpty(); // Is it empty
        int Lenght(); // get the lenght of list
        void Display(); //Show the list
    }
}
