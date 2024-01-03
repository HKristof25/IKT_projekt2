using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Alkatreszek
{
    internal class Kereses
    {
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


        List<ListaIras> list;
        public Kereses()
        {
            list = new List<ListaIras>();
        }
        public void Beolvas(string faljnev)
        {
            object elso;
            object masodik;
            object harmadik;
            object negyedik;
            object otodik;

            var sorok = File.ReadAllLines(faljnev);

            foreach (var sor in sorok)
            {
                var resz = sor.Split(",");
                elso = resz[0];
                masodik = resz[1];
                harmadik = resz[2];
                negyedik = resz[3];
                otodik = resz[4];

                ListaIras lista = new ListaIras(elso, masodik, harmadik, negyedik, otodik);
                list.Add(lista);

            }
        }

        public void Test()
        {
            Console.WriteLine(list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item.Elso);
            }
        }

        public void TipKeres()
        {
            List<object> lista = new List<object>();
            bool van = false;

            Console.Write("Add meg milyen alkatrészre szeretnél keresni: ");
            string tipus = Console.ReadLine();
            foreach (var i in list)
            {
                if (i.Elso.ToString() == tipus.ToLower())
                {
                    van = true;
                    lista.Add($"Gyárója: {i.Masodik},Típusa: {i.Harmadik},Ára: {i.Otodik}");
                }
            }
            if (van)
            {
                Console.WriteLine("Ilyen alkatrészekből ezek vannak feltöltve: ");
                foreach (var i in lista)
                {
                    Console.WriteLine(i);
                }
            }
            else { Console.WriteLine("Nincs ilyen alkatrész feltöltve."); }
        }

        public void Arkereses()
        {
            List<object> lista = new List<object>();
            bool van = false;
            int min;
            int max;
            do
            {
               min = IntInput("Add meg a minimum árat: ");     
               max = IntInput("Add meg a maximum árat: ");
            } while (min > max);
            foreach (var i in list)
            {
                if (Convert.ToInt32(i.Otodik) >= min && Convert.ToInt32(i.Otodik) <= max)
                {
                    van = true;
                    lista.Add($"Alkatrész fajtája: {i.Elso}, Gyárója: {i.Masodik},Típusa: {i.Harmadik},Ára: {i.Otodik}");
                }
            }
            if (van)
            {
                Console.WriteLine("Ezek a határok közötti alkatrészek: ");
                foreach (var i in lista)
                {
                    Console.WriteLine(i);
                }
            }
            else { Console.WriteLine("Nincs alkatrész feltöltve ezeken az árakon belül."); }
        }

        public void Statisztika()
        {
            int cpudb = 0, amdcpu = 0, intelcpu = 0;
            int keyboard = 0, mechanikbill = 0, membranbill = 0;
            int storage = 0, ssd = 0, hdd = 0;
            int gpu = 0, ded = 0, integ = 0;
            int ram = 0;
            int monitor = 0;
            int mouse = 0, lezer = 0, optikai = 0;
            int mb = 0;
            foreach (var i in list)
            {
                if (i.Elso.ToString() == "cpu")
                {
                    cpudb++;
                    if (i.Masodik.ToString() == "intel")
                    {
                        intelcpu++;
                    }
                    else if (i.Masodik.ToString() == "amd")
                    {
                        amdcpu++;
                    }
                }

                else if (i.Elso.ToString() == "keyboard")
                {
                    keyboard++;
                    if (i.Masodik.ToString() == "mechanikus")
                    {
                        mechanikbill++;
                    }
                    else if (i.Masodik.ToString() == "membran")
                    {
                        membranbill++;
                    }
                }

                else if (i.Elso.ToString() == "storage")
                {
                    storage++;
                    if (i.Harmadik.ToString() == "ssd")
                    {
                        ssd++;
                    }
                    else if (i.Harmadik.ToString() == "hdd")
                    {
                        hdd++;
                    }
                }

                else if (i.Elso.ToString() == "graphics card")
                {
                    gpu++;
                    if (i.Masodik.ToString() == "integrált")
                    {
                        integ++;
                    }
                    else if (i.Masodik.ToString() == "dedikált")
                    {
                        ded++;
                    }
                }

                else if (i.Elso.ToString() == "ram")
                {
                    ram++;
                }

                else if (i.Elso.ToString() == "monitor")
                {
                    monitor++;
                }

                else if (i.Elso.ToString() == "mouse")
                {
                    mouse++;
                    if (i.Masodik.ToString() == "lézeres")
                    {
                        lezer++;
                    }
                    else if (i.Masodik.ToString() == "optikai")
                    {
                        optikai++;
                    }
                }
                else if (i.Elso.ToString() == "motherboard")
                {
                    mb++;
                }
            }
                Console.WriteLine($"Összesen {cpudb} db CPU van feltöltve, ebből {intelcpu} db Intel és {amdcpu} db AMD.");
                Console.WriteLine($"Összesen {keyboard} db billentyűzet van feltöltve, ebből {mechanikbill} db mechanikus és {membranbill} db membrános. ");
                Console.WriteLine($"Összesen {mouse} db egér van feltöltve, ebből {lezer} db lézeres és {optikai} db optikai. ");
                Console.WriteLine($"Összesen {monitor} db monitor van feltöltve.");
                Console.WriteLine($"Összesen {gpu} db videokárty van feltöltve, ebből {integ} db integrált és {ded} db dedikált.");
                Console.WriteLine($"Összesen {ram} darab ram van feltöltve.");
                Console.WriteLine($"Összesen {mb} darab alaplap van feltöltve.");
                Console.WriteLine($"Összesen {storage} db tároló van feltöltve, ebből {ssd} db ssd és {hdd} db hdd. ");
        }

        public void Akcio()
        {
            bool VanTermek = false;
            string termek;
            int akcio;
                Console.Write("Melyik alkatrész fajtának szeretnéd csökkenteni az árát(összes/egyik se is lehet): ");
                termek = Console.ReadLine();
            foreach (var item in list)
            {
                if (item.Elso.ToString() == termek.ToLower()) { VanTermek = true; }
            }

            if (termek !="egyik se" )
            {
                Console.Write("Hány százalékkal: ");
                akcio = int.Parse(Console.ReadLine());
                foreach (var i in list)
                {

                    if (termek == "összes")
                    {
                        i.Otodik = Convert.ToInt32(i.Otodik) * (1 - akcio / 100);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Az új akciós ára a {termek} terméknek : {i.Otodik} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if (i.Elso.ToString() == termek)
                    {
                        i.Otodik = Convert.ToInt32(i.Otodik) * (1 - akcio / 100);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Az új akciós ára a {termek} terméknek : {i.Otodik} ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                
                }
            }
            if (VanTermek == false && termek != "egyik se") { Console.WriteLine("Nincs ilyen lehetőség."); }
        }


        public void html()
        {
            var groupedItems = list.GroupBy(item => item.Elso.ToString());

            using (StreamWriter OutputFile = new StreamWriter("proba2.txt", true))
            {
                foreach (var group in groupedItems)
                {
                    string category = group.Key;

                    string html = $"<h2>{GetCategoryTitle(category)}</h2>\n" +
                                  $"<div class=\"flex-container\">\r\n";

                    foreach (var item in group)
                    {
                        html += $"<div class=\"flex-item\">" +
                                $"<div>{item.Masodik}</div>\r\n" +
                                $"<div>{item.Harmadik}</div>\r\n" +
                                $"<div>{item.Negyedik}</div>\r\n" +
                                $"<div>{item.Otodik}</div>" +
                                $"</div>";
                    }

                    html += "</div>";

                    OutputFile.Write(html);
                }
            }
        }

        private string GetCategoryTitle(string category)
        {
            switch (category)
            {
                case "cpu":
                    return "CPU";
                case "graphics card":
                    return "Graphics card";
                case "ram":
                    return "RAM";
                case "monitor":
                    return "Monitor";
                case "keyboard":
                    return "Keyboard";
                case "mouse":
                    return "Mouse";
                case "motherboard":
                    return "Motherboard";
                case "storage":
                    return "Storage";
                default:
                    return "Unknown Category";
            }
        }

    }
}