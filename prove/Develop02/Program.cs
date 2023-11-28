using System;

Public class Journal
{
    //variable
    public List <Journal Entry>_ Journal=new List<Journal eEntry>();
    private string fileName="MyJournal.txt";
    private string_userFileName;
 {public Journal()
 }
 public void Display()
 {

 }
    Console.WriteLine("\n**********Journal Entries**********);
    foreach(JournalEntry journalEntry in_Journal)
    {
    journalEntry.Display();
    }

 Console.WriteLine("\n************End*************")

}
public void CreateJournalFile()
{
    Console.Write("Name of your file?");
    string userInput=Console.ReadLine();
    _userFileName=userInput+".txt";
    if (!CreateJournalFile.Exists(userFileName))
}
{
    foreach(JournalEntry journalEntry in_journal)
    {
        outputFile.WriteLine($"{journalEntry._entryNumber};{journalEntry._dateTime};{journlEntry._journalPrompt};{journal Entry._journalEntry}");
    }
}
