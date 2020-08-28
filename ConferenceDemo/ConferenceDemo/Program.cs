using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConferenceDemo
{ //so we couldnt figure out how to do the compare thingie with meh program. oh well. its not like ill ever use it again. *shoots myself when chapter 16 rolls by*
    public class Conference
    {
        string Name, Date;
        int Attendees1;
        public Conference(string name, string date,int attendees1 )
        {
            this.Name = name;
            this.Date = date;
            Write("How many people attended the first conference?  ");
            this.Attendees1 = attendees1 = Convert.ToInt32(ReadLine());   
        }
        public void Display()
        {
            WriteLine("The name of the name for the first conference is {0}, the date is {1}, and the headcount is {2}", this.Name, this.Date, this.Attendees1);
        }
    }
    public class Conference2
    {
        string Name, Date;
        int Attendees2;
        public Conference2(string name, string date, int attendees2)
        {
            this.Name = name;
            this.Date = date;
            Write("How many people attended the second conference?  ");
            this.Attendees2 = attendees2 = Convert.ToInt32(ReadLine());
        }
        public void Display()
        {
            WriteLine("The name of the name for the second conference is {0}, the date is {1}, and the headcount is {2}", this.Name, this.Date, this.Attendees2);
        }
    }
    public class Conference3
    {
        string Name, Date;
        int Attendees3;
        public Conference3(string name, string date, int attendees3)
        {
            this.Name = name;
            this.Date = date;
            Write("How many people attended the third conference?  ");
            this.Attendees3 = attendees3 = Convert.ToInt32(ReadLine());
        }
        public void Display()
        {
            WriteLine("The name of the name for the third conference is {0}, the date is {1}, and the headcount is {2}", this.Name, this.Date, this.Attendees3);
        }
    }
    public class Conference4
    {
        string Name, Date;
        int Attendees4;
        public Conference4(string name, string date, int attendees4)
        {
            this.Name = name;
            this.Date = date;
            Write("How many people attended the fourth conference?  ");
            this.Attendees4 = attendees4 = Convert.ToInt32(ReadLine());
        }
        public void Display()
        {
            WriteLine("The name of the name for the fourth conference is {0}, the date is {1}, and the headcount is {2}", this.Name, this.Date, this.Attendees4);
        }
    }
    public class Conference5
    {
        string Name, Date;
        public int Attendees5 { get; set; }
        public Conference5(string name, string date, int attendees5)
        {
            this.Name = name;
            this.Date = date;
            Write("How many people attended the fith conference?  ");
            this.Attendees5 = attendees5 = Convert.ToInt32(ReadLine());
        }
        public void Display()
        {
            WriteLine("The name of the name for the fith conference is {0}, the date is {1}, and the headcount is {2}", this.Name, this.Date, this.Attendees5);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Conference con1 = new Conference("American Society for the Prevention of Cruelty to Pugs", "1/30/2012", 0);
            con1.Display();
            WriteLine("");
            Conference2 con2 = new Conference2("Bringing Back the Rack Cancer Org.", "5/15/2013", 0);
            con2.Display();
            WriteLine("");
            Conference3 con3 = new Conference3("PETA", "8/20/2009", 0);
            con3.Display();
            WriteLine("");
            Conference4 con4 = new Conference4("Shaving The Cat foundation", "1/23/2010", 0);
            con4.Display();
            WriteLine("");
            Conference5 con5 = new Conference5("Trump Financial Support Org.", "6/13/2011", 0);
            con5.Display();
            WriteLine("");
            ReadLine();
        }
    }
}
