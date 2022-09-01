using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BilLista
{
    List<Bil> billista = new List<Bil>(); 

    Bil f = new Bil("Mercedes", "AMG", 2014, 1400);


public void AddToList() {
    billista.Add(f);
    billista.Add(new Bil("Audi", "RS", 2012, 1560));
    billista.Add(new Bil("BMW", "5-Serie", 2003, 1670));
}

    public void Print()
    {
        foreach (Bil element in billista)
        {
            Console.WriteLine(element.Tillverkare);
            Console.WriteLine(element.Modell);
            Console.WriteLine(element.Årsmodell);
            Console.WriteLine(element.Vikt);
        }
    }
}