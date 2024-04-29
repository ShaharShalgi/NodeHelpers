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
        public static int[] GetSides(int x)
        {
            int[] sides = new int[2];
            sides[1] = x % 10;
            while (x / 10 != 0)
            {
                x /= 10;
            }
            sides[0] = x;
            return sides;
        }
        public static bool IsSameSides(int[] x1, int[] x2)
        {
            if (x1[0] != x2[0] || x1[1] != x2[1]) return false;
            return true;
        }
        
        public static Node<int> ModifyByX(Node<int> node, int x)
        {
            Node<int> head = new Node<int>(default, node); 
            Node<int> tail = new Node<int>(default, node);
            bool SameSides = false;
            int[] val = GetSides(x);
            while (tail.GetNext()!=null)
            {
                if(IsSameSides(val, GetSides(tail.GetNext().GetValue())))
                {
                    tail.SetNext(tail.GetNext().GetNext());
                    SameSides= true;
                }
                else
                {
                    tail = tail.GetNext();
                }
                
               }
            if (!SameSides)
            {
                int count = NodeHelper.CountList(node);
                for (int i = 0; i < (count / 2)-1; i++)
                {
                    node = node.GetNext();
                }
                
                node.SetNext(new Node<int>(x, node.GetNext()));
            }
            return head.GetNext();
            
        }
        static void Main(string[] args)
        {
            //Node<ShabatRecievers> shabatShalom = new Node<ShabatRecievers>(new ShabatRecievers("Shiri","Shira",18,1,2024));
            //Node<ShabatRecievers> nextShabat = new Node<ShabatRecievers>(new ShabatRecievers("Ofek", "Aviv", 25, 1, 2024));
            //shabatShalom.SetNext(nextShabat);

            //ShabatRecievers sh = shabatShalom.GetValue();
            //string p1 = sh.GetParent1();
            //int[] arr = GetSides(5072);
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[1]);
            Node<int> node4 = new Node<int>(5493);
            Node<int> node3 = new Node<int>(51, node4);
            Node<int> node2 = new Node<int>(425, node3);
            Node<int> node1 = new Node<int>(2705, node2);
            Console.WriteLine(ModifyByX(node1, 5072).ToString());


        }


    }
}