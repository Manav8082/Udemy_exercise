namespace Coding.Exercise26
{
    internal class Program
    {
        public static void TestEvents()
        {
            // TODO: Add your code here
            Event event1 = new Event(
                new DateTime(2024, 07, 1),
                new DateTime(2024, 07, 10)
            );
            Event event2 = new Event(
                new DateTime(2024, 07, 5),
                new DateTime(2024, 07, 15)
            );
            Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
            Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");
            Console.WriteLine($"Events Overlap: {event1.IsOverlapping(event2)}");
        }
        
        static void Main(string[] args)
        {
            TestEvents();
        }
    }
    public struct Event
    {
        // TODO: Add your code here
        public DateTime StartDate;
        public DateTime EndDate;

        public Event(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public double GetDuration()
        {
            return (EndDate - StartDate).TotalDays;
        }

        public bool IsOverlapping(Event otherEvent)
        {
            return StartDate < otherEvent.EndDate && EndDate > otherEvent.StartDate;
        }
    }

}
