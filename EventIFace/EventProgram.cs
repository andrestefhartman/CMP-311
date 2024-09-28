using System;
using System.Collections.Specialized;

namespace EventIFace
{
   public interface IBirthday 
    {
        void PrintCost();
        void PrintCostCode(string code);
        double Cost();
    }

   public interface IConference
    {
        void PrintCost();
        void PrintCostCode(string code);
        double Cost();
    }

    public interface ICharity
    {
        void PrintCost();
        void PrintCostCode(string code);
        double Cost();
    }

    public class EventInfo // class containing event info
    {
        int id;
        string description = "";       
        int attendees;
        double cost;
        

        public EventInfo(int newId, string newDescription, int newAttendees)
        {
            id = newId;
            description = newDescription;
            attendees = newAttendees;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Attendees
        {
            get { return attendees; }
            set { attendees = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        
        public override string ToString() //print all event info (formatted)
        {
            return description.ToString() + ":\n\n ID: " + id.ToString() + "\n Attendees: " + attendees.ToString() + "\n Cost: $" + cost.ToString() + "\n\n";
        }

    }

    public class Event : IBirthday, IConference, ICharity //class that inherits all interfaces
    {
        EventInfo thisEvent;

        public Event(int newId, string newDescription, int newAttendees)
        {
            thisEvent = new EventInfo(newId, newDescription, newAttendees);
        }

        void IBirthday.PrintCost()
        {
            double costPerHead = 12.50;
            thisEvent.Cost = costPerHead*thisEvent.Attendees;

            Console.WriteLine($"Cost: $ {thisEvent.Cost}");
        }
        
        void IBirthday.PrintCostCode(string code) // apply code to cost
        {
            code = code.ToLower();
            double costPerHead = 12.50;
            thisEvent.Cost = costPerHead * thisEvent.Attendees;

            thisEvent.Cost = CodeCost(code);

            Console.WriteLine($"Cost with code: $ {thisEvent.Cost}");


        }

        void IConference.PrintCost()
        {
            double costPerHead = 20.75;
            thisEvent.Cost = costPerHead * thisEvent.Attendees;

            Console.WriteLine($"Cost: $ {thisEvent.Cost}");
        }

        void IConference.PrintCostCode(string code) //apply code to cost
        {
            code = code.ToLower();
            double costPerHead = 20.75;
            thisEvent.Cost = costPerHead * thisEvent.Attendees;

            thisEvent.Cost = CodeCost(code);

            Console.WriteLine($"Cost with code: $ {thisEvent.Cost}");
        }
        
        void ICharity.PrintCost()
        {
            double costPerHead = 16.0;
            thisEvent.Cost = costPerHead * thisEvent.Attendees;

            Console.WriteLine($"Cost: $ {thisEvent.Cost}");
        }

        void ICharity.PrintCostCode(string code) //apply code to cost
        {
            code = code.ToLower();
            double costPerHead = 16.0;
            thisEvent.Cost = costPerHead * thisEvent.Attendees;

            thisEvent.Cost = CodeCost(code);

            Console.WriteLine($"Cost with code: $ {thisEvent.Cost}");
        }

        double IBirthday.Cost()
        {
            return thisEvent.Cost;
        }

        double ICharity.Cost()
        {
            return thisEvent.Cost;
        }

        double IConference.Cost()
        {
            return thisEvent.Cost;
        }

        public override string ToString()
        {
            return thisEvent.ToString();
        }

        private double CodeCost(string code)
        {
            switch (code)
            {
                case "d":
                    return thisEvent.Cost * 0.9;
                    
                case "l":
                    return thisEvent.Cost * 1.1;

                case "e":
                    return thisEvent.Cost * 0.75;
                case "f":
                    return 0;
                default:
                    return thisEvent.Cost;
            }
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            IBirthday birthdayEvent = new Event(0017, "Sally's birthday", 20);
            IConference conferenceEvent = new Event(0018, "Work Place Inc", 67);
            ICharity charityEvent = new Event(0019, "Good People charity", 36);

            Console.WriteLine("Birthday");
            birthdayEvent.PrintCost();
            birthdayEvent.PrintCostCode("D");
            

            Console.WriteLine("\nConference");
            conferenceEvent.PrintCost();
            conferenceEvent.PrintCostCode("l");

            Console.WriteLine("\nCharity");
            charityEvent.PrintCost();
            charityEvent.PrintCostCode("m");

            Console.WriteLine("\nEvents:\n\n" + birthdayEvent + conferenceEvent + charityEvent);

            Console.ReadLine();
        }
    }

}
