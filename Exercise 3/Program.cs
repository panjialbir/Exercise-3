using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise_Linked List_A 
    {
    class Node
{
    //create nodes from the circular nexted list
    public int rollNumber;
    public string name;
    public Node text;
}
class circularlist()
    {
    Node LAST;
public circularlist()
{
    LAST = null;
        }
public bool Search(int rollNo, ref Node previous, ref Node current)/
* Searches for the specified node*/
    {
    for (previous = current = LAST.next; current != LAST; previous
current, current = current.next)
    {
    if (rollNo == current.rollNumber)
return (true);/*returns true if the node is found*/
}
if (rollNo == LAST.rollNumber)/*If the node is present at the end*/
    return true;
else
    return (false);/*return false if the node is not found*/

}
public bool listEmpty()
{
    if (LAST == null)
        return true;
    else
        return false;

}
public void traverse()/*traverses all the nodes of the list*/
{
    if (listEmpty())
        Console.WriteLine("\nList is empty");
    else
    {
        Console.WriteLine("\nrecord in the list are: \n");
        Node currentNode;
        currentNode = LAST.next;
        while (currentNode != LAST)
        {
            Console.Write(currentNode.rollNumber + "  " + currentNode.name + "\n");
            currentNode = currentNode.next;
        }
        Console.Write(LAST.rollNumber + "   " + LAST.name + "\n");

    }
}
public void firstNode()
{
    if (listEmpty())
        Console.WriteLine("\nlist is empty");
    else
        Console.WriteLine("\nthe first record in the list is:\n\n" + LAST.next.rollNumber + "  " + LAST.next.name);

}
static void Main(string[] args)
{
    CircularList obj = new CircularList();
    while (true)
    {
        try
        {
            Console.WriteLine("\nmenu");
            Console.WriteLine("1. view all the record in the list");
            Console.WriteLine("2. search for a record in the list");
            Console.WriteLine("3. display in the record in the list");
            Console.WriteLine("exit");
            Console.Write("\nenter your choice (1-4):");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '1':
                    {
                        obj.traverse();

                    }
            }
        }
    }
}

}
