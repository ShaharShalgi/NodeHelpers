using NodeClass;
using NodeInserts.Models;

namespace NodeInserts
{
    
    internal class Program
    {
        public static double Cheapest(CityBuses bus, Station end, Station start)
        {
            double cheapest = double.MaxValue;
            Node<Bus> busNode = bus.GetBuses();
            while (busNode != null)
            {
                if(busNode.GetValue().Ride(start, end) < cheapest && busNode.GetValue().Ride(start, end) != -1)
                {
                    cheapest = busNode.GetValue().Ride(start, end);

                }
                busNode = busNode.GetNext();
            }
            if (cheapest == double.MaxValue)
                return -1;
            else
                return cheapest;
        }
        public static int CanConnect(Node<Domino> node, Domino domino)
        {
         
            int counter = 0;
            while(node != null)
            {
                if(node.GetValue().isDomino(node.GetValue().getFirstnum())|| node.GetValue().isDomino(node.GetValue().getSecondnum()))
                    counter++;
                node = node.GetNext();
            }
            return counter;

        }
        public static string Winner(Node<Participant> node)
        {
            string winner = "";
            double currentwinner = double.MinValue;
            while(node != null)
            {
                if(node.GetValue().LossPercent() > currentwinner) 
                {
                    winner = node.GetValue().GetName();
                    currentwinner = node.GetValue().LossPercent();
                }
                node = node.GetNext();
            }
            return winner;
        }
        public static void Average(Node<Grade> node)
        {
            double average = 0;
            double counter = 0;
            while(node != null) 
            {
                average += node.GetValue().GetGrade();
                node = node.GetNext();
            }
            
            Console.WriteLine(average/counter);

        }
        public static void Average(Node<Student> node) 
        {
            
            while(node != null)
            {
                Console.WriteLine(node.GetValue().GetName());
                Average(node.GetValue().GetGrades());
                node = node.GetNext();
            }
        }
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