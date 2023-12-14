﻿using System;
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
        object[] cpu = {"cpu", "gyarto", "tipus","orajel", 0, 0}; // Gyártó, típus,órajel, magok száma, ár
        object[] motherb = {"motherboard", "gyarto","tipus", "foglalat", 0 }; //Gyáró, típus, foglalat, ár
        object[] gpu = {"graphics card", "gyarto", "int/ded", "tipus", 0 }; //Gyártó, integrált/dedikált, típus, ár
        object[] ram = {"ram", "gyarto", 0, "orajel", 0};  // Gyártó, méret, órajel, ár
        object[] storage = {"storage", "gyarto", "ssd/hdd", 0, 0}; //Gyártó, ssd/hhd, kapacitás, ár
        object[] monitor = {"monitor", "gyarto", "felbont", 0, 0, 0}; //Gyártó, méret, felbontás, kéfrissítés, ár
        object[] keyb = {"keyboard", "gyarto", "mechanic/membran", 0 };  //Gyártó, mehanikus?, ár
        object[] mouse = {"mouse", "gyarto", "lezer/optikai",0 }; //Gyártó, lézeres/optikai, ár

        public  string StringInput(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input)); // Check if the input is null or empty

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
                            cpu[1] = StringInput("Add meg a gyártóját: ");
                            cpu[2] = StringInput("Add meg a típusát: ");
                            cpu[3] = StringInput("Add meg az órajelét: ");
                            cpu[4] = IntInput("Add meg a  magok számát: ");
                            cpu[5] = IntInput("Add meg az árát: ");
                            break;
                        case "motherboard":                                                             //motherboard
                            motherb[1] = StringInput("Add meg a gyártóját: ");
                            motherb[2] = StringInput("Add meg a típusát: ");
                            motherb[3] = StringInput("Add meg a foglalatot: ");
                            motherb[4] = IntInput("Add meg az árát: ");
                            foreach (var y in motherb)
                                Console.WriteLine(y);
                            break;
                        case "graphics card":                                                           //gpu
                            gpu[1] = StringInput("Add meg a gyártóját: ");
                            gpu[2] = StringInput("Integrált vagy dedikált?");
                            gpu[3] = StringInput("Add meg a típusát: ");
                            gpu[4] = IntInput("Add meg az árát: ");
                            foreach (var item in gpu)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case "ram":                                                                     //ram
                            ram[1] = StringInput("Add meg a gyártóját: ");
                            ram[2] = IntInput("Add meg a méretét: ");
                            ram[3] = StringInput("Add meg az órajelét");
                            ram[4] = IntInput("Add meg az árát: ");
                            foreach(var item in ram) Console.WriteLine(item);
                            break;
                        case "storage":
                            storage[1] = StringInput("Add meg a gyártóját: ");
                            storage[2] = StringInput("SSD vagy HDD: ");
                            storage[3] = IntInput("Add meg a kapacitását(GB): ");
                            storage[4] = IntInput("Add meg az árát: ");
                            break;
                        case "monitor":
                            monitor[1] = StringInput("Add meg a gyártóját:");
                            monitor[2] = IntInput("Add meg a méretét(inch): ");
                            monitor[3] = StringInput("Add meg a felbontását: ");
                            monitor[4] = IntInput("Add meg a képfrissítési gyakoriságot(hz): ");
                            monitor[5] = IntInput("Add meg az árát: ");
                            foreach (var item in monitor)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case "keyboard":
                            keyb[1] = StringInput("Add meg a gyártóját: ");
                            keyb[2] = StringInput("Mechanikus vagy membrán: ");
                            keyb[3] = IntInput("Add meg az árát: ");
                            break;
                        case "mouse":
                            mouse[1] = StringInput("Add meg a gyártóját: ");
                            mouse[2] = StringInput("Lézeres vagy optikai: ");
                            mouse[3] = IntInput("Add meg az árát: ");
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