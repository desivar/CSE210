using System;
class Program
{
    static void Main(string[] args)
    {
        Address[] addresses =  new Address[3];
        addresses[0] = new Address("4567 The Loops", "Salt Lake City", "Utah", "96999-5727", "United States");
        addresses[1] = new Address("66454 The Pines Apt. 451", "Rexburg", "Idaho", "03360", "United States");
        addresses[2] = new Address("85 Rue de la Pompe", " Douai", "Nord-Pas-de-Calais", " 59500", "France");

        Event[] events =  new Event[3];
        events[0] = new LectureEvent("Introduction to Python course","Let's learn the basics of Python","04/04/2024","11:00am",addresses[0],"William","56 People");
        events[1] = new ReceptionEvent("Jacob and Jillian Wedding","Join us celebrating our Wedding","01/04/2024","08:00pm",addresses[1],"jj@gmail.com");
        events[2] = new OutdoorGatheringEvent("Tennis With Friends","Let's play a with friends!","04/04/2024","07:00pm",addresses[2],"Karl");

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Event N°: {i + 1}");
            Console.WriteLine("\n-STANDARD DETAILS-");
            Console.WriteLine(events[i].StandardDetails());
            Console.WriteLine("-SHORT DETAILS- ");
            Console.WriteLine(events[i].ShortDetails());
            Console.WriteLine("-FULL DETAILS-");
            Console.WriteLine(events[i].FullDetails());
            
        }
    }
}