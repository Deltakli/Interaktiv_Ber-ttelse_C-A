using System;

string input;

Console.WriteLine("Du gick på en promenad ut men sen stötte du på en väg som delar sig");

bool done = false;
bool fast = false;
while (false == done)
{
    if(fast == false) {
        Console.WriteLine("vad väljer du gå till Höger eller vänster ?");
        input = Console.ReadLine().ToLower();
    


        if (input == "höger")
        {
            Console.WriteLine("Du gick åt höger och du hittade en dator med frågan höger eller vänster?");
        }

        else if (input == "vänster")
        {
            Console.WriteLine("Du gick åt vänster och bröt ut dig ur loopen");
            done = true;
        }
        else
        {
            Console.WriteLine("Du gjorde ingetting och är fast i loopen");
            fast = true;
        }
    }
    if(fast == true) {
    Console.WriteLine("du är fast");
    
}
}



    Console.ReadLine();
