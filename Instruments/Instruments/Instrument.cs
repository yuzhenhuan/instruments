using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Instrument
{
    public Instrument ()
    {
    }

    public Instrument (string brass, string strings, string woodwind)
    {
        Brass = brass;
        Strings = strings;
        Woodwind = woodwind;
    }

    public string Brass { get; set; }
    public string Strings { get; set; }
    public string Woodwind { get; set; }
}
