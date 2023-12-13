

class Program
{
    static void Main(string[] args)
    {
        Address[] addresses =  new Address[3];
        addresses[0] = new Address("8269 ", "Rexburg", "Idaho", "00000-0000", "USA");
        addresses[1] = new Address("6564", "Lehi", "Utah", "00000", "USA");
        addresses[2] = new Address("7680", "Miami", "Florida", "61236", "USA");

        Event[] events =  new Event[3];
        events[0] = new LectureEvent("Pathway Connect","Frequent Questions","08/12/2023","06:00pm",addresses[0],"Jillian","150 People");
        events[1] = new ReceptionEvent("Graduation Party","Come to our graduation party","01/12/2023","08:00pm",addresses[1],"graduation@gmail.com");
        events[2] = new OutdoorGatheringEvent("Football","Enjoy the game bewteen Olimpia-Marathon!","10/09/2024","07:00pm",addresses[2],"Carlos");

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