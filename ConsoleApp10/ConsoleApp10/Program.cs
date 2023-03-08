using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz postać:");
            Console.WriteLine("a - Wojownik Jonn (20 pkt życia, 25 pkt siły, 5 punktów)");
            Console.WriteLine("b - Wojownik Janusz (30 pkt życia, 20 pkt siły, 5 punktów)");
            Console.WriteLine("c - Wojownik Jacek (25 pkt życia, 30 pkt siły, 3 punktów)");
            string postac = Console.ReadLine().ToString();
            int[] character;
            if (postac == "a")
            {
                character = CharacterChoose2.characterClassSelection2();
                Console.WriteLine("Wybrałeś Wojownika Jonna");
            }
            else if (postac == "b")
            {
                character = CharacterChoose3.characterClassSelection3();
                Console.WriteLine("Wybrałeś Wojownika Janusza");
            }
            else if (postac == "c")
            {
                character = CharacterChoose.characterClassSelection();
                Console.WriteLine("Wybrałeś Wojownika Jacka");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór postaci. Wybierz jeszcze raz.");
                return;
            }
            int zycie = character[0];
            int sila = character[1];
            int maxzycie = character[2];
            int pkt = character[3];

            bool Game = false;

            while (!Game)
            {
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine($"Twoje życie {zycie}\tTwoja siła {sila}\t Twoje punkty{pkt}\t max{maxzycie}");
                Console.WriteLine("a - walka \t b - ulepsz coś \t c - wybierz inną postać \td - walka z bossem\t cokolwiek innego - wróci do menu");
                string inpu = Console.ReadLine().ToString();

                if (inpu == "c")
                {
                    Console.WriteLine("Wybierz postać:");
                    Console.WriteLine("a - Wojownik Jonn (20 pkt życia, 25 pkt siły, 5 punktów)");
                    Console.WriteLine("b - Wojownik Janusz (30 pkt życia, 20 pkt siły, 5 punktów)");
                    Console.WriteLine("c - Wojownik Jacek (25 pkt życia, 30 pkt siły, 3 punktów)");
                    postac = Console.ReadLine().ToString();
                    if (postac == "a")
                    {
                        Console.WriteLine("Wybrałeś Wojownika Jonn");
                        character = CharacterChoose2.characterClassSelection2();
                    }
                    else if (postac == "b")
                    {
                        Console.WriteLine("Wybrałeś Wojownika Janusz");
                        character = CharacterChoose3.characterClassSelection3();
                    }
                    else if (postac == "c")
                    {
                        character = CharacterChoose.characterClassSelection();
                        Console.WriteLine("Wybrałeś Wojownika Jacka");
                    }
                 
                            else
                            {
                                Console.WriteLine("Nieprawidłowy wybór postaci. Wybierz jeszcze raz.");
                                continue;
                            }
                            zycie = character[0];
                            sila = character[1];
                            maxzycie = character[2];
                            pkt = character[3];
                        }

                        if (inpu == "a")
                        {
                            Random rnd = new Random();
                            int przh = rnd.Next(1, 35);
                            Random rond = new Random();
                            int prza = rond.Next(1, 25);
                            Console.WriteLine($"Przeciwnik ma {przh} życia i {prza} sily");
                            Console.WriteLine("a - atakuj \t b - uciekaj");
                            string iny = Console.ReadLine().ToString();
                            if (iny == "a")
                            {
                                zycie -= prza;
                                przh -= sila;


                                Console.WriteLine($"Masz teraz {zycie} zdrowia a przeciwnik {przh}");

                                if (przh <= 0)
                                {
                                    Console.WriteLine("Zabiłeś przeciwnika");
                                    zycie = Postac.Reg(maxzycie, zycie);

                                    pkt++;
                                }

                            }
                            else if (iny == "b")
                            {
                                Console.WriteLine("Uciekłeś tchórzu");
                            }
                            else
                            {
                                Console.WriteLine("nieprawidłowa komenda");
                            }
                        }
                        if (inpu == "b")
                        {
                            Console.WriteLine("a - ulepsz atak \t b - ulepsz życie \t (za punkty)");
                            string inju = Console.ReadLine().ToString();
                            if (inju == "a")
                            {
                                sila = Postac.Ula(sila);
                                pkt -= 1;
                            }
                            if (inju == "b")
                            {
                                maxzycie = Postac.Ulz(maxzycie);
                                pkt -= 1;


                            } zycie = Postac.Reg(maxzycie, zycie);
                        }
                else if (inpu == "d")
                {

                    Console.WriteLine("Rozpoczynasz walkę z bossem!");

                    int[] Boszz = Boss.Boss2();
                    int bosshp = Boszz[0];
                    int bossatk = Boszz[1];

                    while (bosshp > 0 && zycie > 0)
                    {
                        Console.WriteLine($"Twoje życie: {zycie}\tSiła twojego ataku: {sila}\nPunkty życia bossa: {bosshp}\tSiła ataku bossa: {bossatk}");
                        Console.WriteLine("a - atakuj \t b - uciekaj");
                        string iny = Console.ReadLine().ToString();
                        if (iny == "a")
                        {
                            bosshp -= sila;
                            zycie -= bossatk;
                            Console.WriteLine($"Zadałeś bossowi {sila} obrażeń! Boss zadał ci {bossatk} obrażeń!");
                            if (bosshp <= 0)
                            {
                                Console.WriteLine("Pokonałeś bossa!");
                                zycie = Postac.Reg(maxzycie, zycie);
                                pkt += 5;
                            }
                            if (zycie <= 0)
                            {
                                Console.WriteLine("Zostałeś pokonany przez bossa!");
                                Game = true;
                                break; 
                            }
                        }
                        else if (iny == "b") 
                        {
                            Console.WriteLine("Uciekłeś tchórzu");
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Nieprawidłowa komenda");
                        }
                    }
                }






            }
            Console.WriteLine("Koniec gry");
                    Console.ReadKey();
                
            
        }
    }
}
