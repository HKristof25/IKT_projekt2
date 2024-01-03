using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Alkatreszek
{
    internal class Beolvas
    {
        string[] components = { "cpu", "motherboard", "graphics card", "ram", "storage", "monitor", "keyboard", "mouse" };
        object[] cpu = {"cpu", "gyarto", "tipus", 0, 0}; // Gyártó, típus, magok száma, ár
        object[] motherb = {"motherboard", "gyarto","tipus", "foglalat", 0 }; //Gyáró, típus, foglalat, ár
        object[] gpu = {"graphics card", "gyarto", "int/ded", "tipus", 0 }; //Gyártó, integrált/dedikált, típus, ár
        object[] ram = {"ram", "gyarto", 0, "orajel", 0};  // Gyártó, méret, órajel, ár
        object[] storage = {"storage", "gyarto", "ssd/hdd", 0, 0}; //Gyártó, ssd/hhd, kapacitás, ár
        object[] monitor = {"monitor", "gyarto",  0,"felbont", 0}; //Gyártó, méret, felbontás,  ár
        object[] keyb = {"keyboard", "gyarto", "mechanic/membran", "numpad", 0 };  //Gyártó, mehanikus?, ár
        object[] mouse = {"mouse", "gyarto", "lezer/optikai",0 ,0}; //Gyártó, lézeres/optikai, dpi,ár

        public  string StringInput(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input));

            return input;
        }
        public int IntInput(string message)
        {
            int input;
            bool number = false;

            do
            {
                Console.Write(message);
                number = int.TryParse(Console.ReadLine(), out input);

                if (!number)
                {
                    Console.WriteLine("Számot adj meg! ");
                }

            } while (!number);

            return input;
        }

        public void Read()
        {
            Console.Write("Add meg milyen alkatrészt akarsz feltöteni: ");
            string fajta = Console.ReadLine();
            foreach (var x in components)
            {   
                if (components.Contains( fajta.ToLower()))
                {
                    switch (fajta.ToLower())
                    {
                        case "cpu":                                                                     //cpu
                            cpu[1] = StringInput("Add meg a gyártóját: ").ToLower();
                            cpu[2] = StringInput("Add meg a típusát: ").ToLower();
                            cpu[3] = IntInput("Add meg a  magok számát: ");
                            cpu[4] = IntInput("Add meg az árát: ");
                            using (StreamWriter OutputFile = new StreamWriter("adatok.txt", true))
                            {
                                OutputFile.Write($"{cpu[0]},{cpu[1]},{cpu[2]},{cpu[3]},{cpu[4]}\n");
                            }
                            break;
                        case "motherboard":                                                             //motherboard
                            motherb[1] = StringInput("Add meg a gyártóját: ").ToLower();
                            motherb[2] = StringInput("Add meg a típusát: ").ToLower();
                            motherb[3] = StringInput("Add meg a foglalatot: ").ToLower();
                            motherb[4] = IntInput("Add meg az árát: ");
                            using (StreamWriter OutputFile = new StreamWriter("adatok.txt", true))
                            {
                                OutputFile.Write($"{motherb[0]},{motherb[1]},{motherb[2]},{motherb[3]},{motherb[4]},\n");
                            }
                            break;
                        case "graphics card":                                                           //gpu
                            gpu[1] = StringInput("Add meg a gyártóját: ").ToLower();
                            gpu[2] = StringInput("Integrált vagy dedikált?: ").ToLower();
                            gpu[3] = StringInput("Add meg a típusát: ").ToLower();
                            gpu[4] = IntInput("Add meg az árát: ");
                            using (StreamWriter OutputFile = new StreamWriter("adatok.txt", true))
                            {
                                OutputFile.Write($"{gpu[0]},{gpu[1]},{gpu[2]},{gpu[3]},{gpu[4]}\n");
                            }
                            break;
                        case "ram":                                                                     //ram
                            ram[1] = StringInput("Add meg a gyártóját: ").ToLower();
                            ram[2] = IntInput("Add meg a méretét: ");
                            ram[3] = StringInput("Add meg az órajelét: ").ToLower();
                            ram[4] = IntInput("Add meg az árát: ");
                            using (StreamWriter OutputFile = new StreamWriter("adatok.txt", true))
                            {
                                OutputFile.Write($"{ram[0]},{ram[1]},{ram[2]},{ram[3]},{ram[4]}\n");
                            }
                            break;
                        case "storage":                                                                 //storage
                            storage[1] = StringInput("Add meg a gyártóját: ").ToLower();
                            storage[2] = StringInput("SSD vagy HDD: ").ToLower();
                            storage[3] = IntInput("Add meg a kapacitását(GB): ");
                            storage[4] = IntInput("Add meg az árát: ");
                            using (StreamWriter OutputFile = new StreamWriter("adatok.txt", true))
                            {
                                OutputFile.Write($"{storage[0]},{storage[1]},{storage[2]},{storage[3]},{storage[4]}\n");
                            }
                            break;
                        case "monitor":                                                                 //monitor
                            monitor[1] = StringInput("Add meg a gyártóját:").ToLower();
                            monitor[2] = IntInput("Add meg a méretét(inch): ");
                            monitor[3] = StringInput("Add meg a felbontását: ").ToLower();
                            monitor[4] = IntInput("Add meg az árát: ");
                            using (StreamWriter OutputFile = new StreamWriter("adatok.txt", true))
                            {
                                OutputFile.Write($"{monitor[0]},{monitor[1]},{monitor[2]},{monitor[3]},{monitor[4]}\n");
                            }
                            break;
                        case "keyboard":                                                               //keyboard
                            keyb[1] = StringInput("Add meg a gyártóját: ").ToLower();
                            keyb[2] = StringInput("Mechanikus vagy membrán: ").ToLower();
                            keyb[3] = StringInput("Van e num pad: ").ToLower();
                            keyb[4] = IntInput("Add meg az árát: ");
                            using (StreamWriter OutputFile = new StreamWriter("adatok.txt", true))
                            {
                                OutputFile.Write($"{keyb[0]},{keyb[1]},{keyb[2]},{keyb[3]}, {keyb[4]}\n");
                            }
                            break;
                        case "mouse":                                                                   //mouse
                            mouse[1] = StringInput("Add meg a gyártóját: ").ToLower();
                            mouse[2] = StringInput("Lézeres vagy optikai: ").ToLower();
                            mouse[3] = IntInput("Mekkora az érzékenysége(DPI): ");
                            mouse[4] = IntInput("Add meg az árát: ");
                            using (StreamWriter OutputFile = new StreamWriter("adatok.txt", true))
                            {
                                OutputFile.Write($"{mouse[0]},{mouse[1]},{mouse[2]},{mouse[3]},{mouse[4]}\n");
                            }
                            break;
                    }
                }
                else Console.WriteLine("Nincs ilyen lehetőség."); break;
            }
        }
        public void Readin() 
        {
            string upload;
            do
            {

                Console.Write("Fel szeretnéd tölteni az adatokat?: ");
                upload = Console.ReadLine();
                upload = upload.ToLower();
                if (upload != "igen")
                {
                    break;
                }
                Read();
            } while (upload == "igen");

        }
    }
}
