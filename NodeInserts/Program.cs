using NodeClass;
using NodeInserts.Models;

namespace NodeInserts
{
    
    internal class Program
    {
        public static bool IsReciever(Node<ShabatRecievers> node, int day, int month, int year)
        {
            while (node != null)
            {
                if (node.GetValue().GetDay() == day && node.GetValue().GetMonth() == month && node.GetValue().GetYear() == year)
                    return true;
                node = node.GetNext();
            }
            return false;
        }
        public static Node<ShabatRecievers> DeleteReciever(Node<ShabatRecievers> node, string name)
        {
            Node<ShabatRecievers> head = node;
            while(node!=null)
            {
                if (node.GetValue().GetParent1() == name)
                {
                    head = NodeHelper.DeleteWithDummy(node, node.GetValue());
                    return head;
                }
                node = node.GetNext();
            }
            return head;
        }
        static void Main(string[] args)
        {
            Node<ShabatRecievers> shabatShalom = new Node<ShabatRecievers>(new ShabatRecievers("Shiri","Shira",18,1,2024));
            Node<ShabatRecievers> nextShabat = new Node<ShabatRecievers>(new ShabatRecievers("Ofek", "Aviv", 25, 1, 2024));
            shabatShalom.SetNext(nextShabat);

            ShabatRecievers sh = shabatShalom.GetValue();
            string p1 = sh.GetParent1();


        }
    }
}