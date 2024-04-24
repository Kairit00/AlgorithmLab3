namespace AlgorithmLab3
{
    internal class Node<T> 
    {
        internal T Data { get; } //Read-only property, value can be read and set
        internal Node<T>? Next { get; set; } // Next property, can be any type an nullable.  
      
        internal Node(T data)
        {
            // Set the first node to whatever is in the node, and the next node in turn to null.
            Data = data; 
            Next = null;
        }
       
    }
}