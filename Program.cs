/*class Program{
    public static void Main(){
       Bil b = new Bil("RS", "Audi", 2016, 1750);

       b.Modell="RS";
       b.Tillverkare="Audi";
       b.Årsmodell=2016;
       b.Vikt=1750;

       Console.WriteLine("-------Bil nr.1------");
       Console.WriteLine(b.Modell);
       Console.WriteLine(b.Tillverkare);
       Console.WriteLine(b.Årsmodell);
       Console.WriteLine(b.Vikt);
       Console.WriteLine("-------------------");

       Bil f = new Bil("AMG", "Mercedes", 2014, 1400);

       f.Modell="AMG";
       f.Tillverkare="Mercedes";
       f.Årsmodell=2014;
       f.Vikt=1400;

       Console.WriteLine("--------Bil nr.2-------");
       Console.WriteLine(f.Modell);
       Console.WriteLine(f.Tillverkare);
       Console.WriteLine(f.Årsmodell);
       Console.WriteLine(f.Vikt);
       Console.WriteLine("-------------------");
    }
}*/
class Program{
    public static void Main()
    {
        BilLista bl = new BilLista();

        bl.AddToList();
        bl.Print();
       //bilLista.Add(f);
       //bilLista.Add("AMG", "Mercedes", 2014, 1400)
    }
}