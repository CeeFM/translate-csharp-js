using System;
using System.Linq;
using System.Collections.Generic;

// Define a guest
public class Guest
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public string Bio { get; set; }
}

public class Program
{
    public static void Main() {

        // Create some guests and store them in a List
        List<Guest> guests = new List<Guest>() {
            new Guest(){ Name="Marilyn Monroe", Occupation="entertainer", Bio="(1926 - 1962) American actress, singer, model"},
            new Guest(){ Name="Abraham Lincoln", Occupation="politician", Bio="(1809 - 1865) US President during American civil war"},
            new Guest(){ Name="Martin Luther King", Occupation="activist", Bio="(1929 - 1968)  American civil rights campaigner"},
            new Guest(){ Name="Rosa Parks", Occupation="activist", Bio="(1913 - 2005)  American civil rights activist"},
            new Guest(){ Name="Peter Sellers", Occupation="entertainer", Bio="(1925 - 1980) British actor and comedian"},
            new Guest(){ Name="Alan Turing", Occupation="computer scientist", Bio="(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"},
            new Guest(){ Name="Admiral Grace Hopper", Occupation="computer scientist", Bio="(1906 - 1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"},
            new Guest(){ Name="Indira Gandhi", Occupation="politician", Bio="(1917 - 1984) Prime Minister of India 1966 - 1977"}
        };
        //Create empty arrays for seating assignments and logic
        List<Guest> table1 = [];
        List<Guest> table2 = [];
        List<string> table1Occupations = [];

        foreach (Guest guest in guests)
        {
            //add first guest to table 1
            if(table1.Count == 0)
            {
                table1.Add(guest);
                table1Occupations.Add(guest.Occupation);
            }
            //if any subsequent guests' occupation matches a guest at table 1, seat them at table 2 instead
            else if (table1Occupations.Contains(guest.Occupation))
            {
                table2.Add(guest);
            }
            //otherwise, sit them at table 1 and add their occupation to the table 1 occupations array
            else 
            {
                table1.Add(guest);
                table1Occupations.Add(guest.Occupation);
            }
        }

    Console.WriteLine("Table 1");
    //go through each list of table 1 guests and list their name, occupation, and bio
    foreach (Guest t1 in table1)
    {
        Console.WriteLine($"{t1.Name} ({t1.Occupation}) {t1.Bio}");
    }
    Console.WriteLine("Table 2");
    //same as above, but for table 2
    foreach (Guest t2 in table2)
    {
        Console.WriteLine($"{t2.Name} ({t2.Occupation}) {t2.Bio}");
    }

    }
}