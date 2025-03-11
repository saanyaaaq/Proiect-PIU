public class ComandaRestaurant
{
    public int IDComanda { get; set; }
    public int NrMasa { get; set; } // Adăugat noul parametru
    public double PretTotal { get; set; }
    public string StareComanda { get; set; }
    public MenuRestaurant Menu { get; set; }

    public ComandaRestaurant() { }

    public ComandaRestaurant(int id, int nrMasa, double pretTotal, string stare, MenuRestaurant menu)
    {
        IDComanda = id;
        NrMasa = nrMasa;
        PretTotal = pretTotal;
        StareComanda = stare;
        Menu = menu;
    }

    public string Info()
    {
        return $"ID: {IDComanda}, Masa: {NrMasa}, Pret: {PretTotal}, Stare: {StareComanda}, Meniu: {Menu.Info()}";
    }
}
