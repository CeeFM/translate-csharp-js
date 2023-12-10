using System;
using System.Linq;
using System.Collections.Generic;

// We must specify the Type of the "names" variable.
//  It is a "List" that can only contain "strings".
List<string> insults = new List<string> {
    "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
};

Random rand = new Random();
int number = rand.Next(0, insults.Count);
Console.WriteLine(insults.Count);
Console.WriteLine(number);
Console.WriteLine(insults[number]);