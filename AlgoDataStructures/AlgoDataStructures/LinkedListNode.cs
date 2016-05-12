using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace AlgoDataStructures
{
    /// <summary>
    /// Create a new node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }
    }
}
