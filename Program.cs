using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clash_Royal_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] karten =   {"Bomber","Bogenschützen","Ritter","Speerkobolde","Kobolde",
                                "Skelette","Lakaien","Barbaren","Lakaienhorde","Feuergeister",
                                "Skelettfass","Elitebarbaren","Königsriese","Fledermäuse","Eisgeist",
                                "Koboldgang","Rabauken","Königsrekruten",
                                "Mini-P.E.K.K.A.","Musketierin","Riese","Walküre","Schweinereiter",
                                "Magier","Rammbock","Megalakai","Drei Musketierinnen","Eisgolem",
                                "Musketierinnen","Eisgolem","Elixiergolem",
                                "Flugmaschine","Blasrohrkobold","Zappys","Königsschweinchen","Koboldkäfig",
                                "Prinz","Drachenbaby","Skelettarmee","Hexe","Riesenskelett",
                                "Ballon","P.E.K.K.A.","Golem","Dunkler Prinz","Wächter",
                                "Bowler","Scharfrichter","Jäger","Kanonenkarre","Elektrodrache",
                                "Koboldriese",
                                "Infernodrache","Lavahund","Eismagier","Funki","Tunnelgräber",
                                "Elektromagier","Prinzessin","Nachthexe","Holzfäller","Banditin",
                                "Megaritter","Königsgeist","Magieschütze","Fischer","Widderreiterin",
                                "Pfeile","Knall","Schneeball",
                                "Feuerball","Rakete","Heilzauber","Erdbeben",
                                "Blitz","Koboldfass"," Wut","Gift",
                                "Spiegel","Tornado","Klonzauber","Barbarenfass",
                                "Friedhof","Kampfholz","Elixiergolem" +
                                "Kanone","Tesla","Minenwerfer",
                                  "Koboldhütte","Grabstein","Bombenturm","Barbarenhütte","Infernoturm",
                                  "Ofen","Elixiersammler",
                                 "X-Bogen"



                         };

            Console.WriteLine("Wilkommen zum Clash Royal Deck generator");
            Console.WriteLine("Derzeit gibt es "+karten.Length+" Karten in Clash Royal");
            String benutzerEingabe = "RevolutionMelon";
          
            /*
            Console.Write("Bitte gib deinen Namen ein: ");
           
           String benutzerEingabe = Console.ReadLine();
            benutzerEingabe = benutzerEingabe.Trim();
            if (benutzerEingabe == "") 
            {
                while (benutzerEingabe == "") 
                {
                    Console.WriteLine("Name muss eingegeben werden! ");
                    benutzerEingabe = Console.ReadLine();
                    benutzerEingabe = benutzerEingabe.Trim();
                }

              }
          
           */
    
    
    
    int startwert = 0;
             
                for(int i=0;i<benutzerEingabe.Length; i++)
            {  
                char zeichen = benutzerEingabe[i];
                int zeichenInt = zeichen;
                startwert += zeichenInt* (i + 1); 
               // Console.Write(zeichen + " = " + zeichenInt);
              
            }
            
            Console.WriteLine(" Hallo " + benutzerEingabe + " ich erstelle jetzt dein Deck. Dein Startwert ist: "+ startwert);
            int anzahlKarten = 8;
            int maxKartenNummer = karten.Length;
            bool[] gezogene = new bool[maxKartenNummer];
            Random zufallGenerator = new Random(startwert);
            for (int i=1;i <= anzahlKarten; i++)
            {
                
                int zufall = zufallGenerator.Next(1, maxKartenNummer);
                while (gezogene[zufall] ==true)
                {
                    zufall = zufallGenerator.Next(1, maxKartenNummer);
                }
                if (gezogene[zufall] == true) 
                    Console.Write(" Zahl Doppelt ");
                // Console.WriteLine("Deine " + i + ".Karte ist: " + zufall+" "+karten[zufall-1]);
                Console.Write(karten[zufall - 1] + "   ");
                if (i%4 == 0 )
                {
                    Console.WriteLine("");
                }
                gezogene[zufall] = true; 
                
             }
            
            Console.ReadKey();





        }  




    }
}
 