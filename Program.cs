
static double PlochaKruh (double polomer)
{
    double plocha = Math.PI * Math.PI * polomer;

    return plocha;
}


static double ObvodKruh (double polomer)
{
    double obvod = Math.PI * 2 * polomer;

    return obvod;
}

static double NejvetsiSpolecnyDelitel (int[] pole)
{
    int nsd = Math.Abs(pole[0]);
    for (int i = 0; i < pole.Length; i++)
    {
        int a = nsd;
        int b = Math.Abs(pole[i]);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        nsd = a;
        if (nsd == 1)
        {
            break;
        }
    }

    return nsd;
}

static int Samohlasky (string[] poleStringu, string[] samohlaskyPole)
{

    List<int> pocetSamohlasek= new List<int>();

    foreach (var item in poleStringu)
    {
        string slovoMalym = item.ToLower();

        for (int i = 0; i < slovoMalym.Length; i++)
        {
            foreach (var samohlaska in samohlaskyPole)
            {
                if (samohlaska.ToString() == slovoMalym[i].ToString())
                {
                    pocetSamohlasek.Add(slovoMalym[i]);
                }
            }
        }
    }

    return pocetSamohlasek.Count;

}

int[] cisla = {9, 18, 27};
string[] samohlskyPole = {"a", "e", "i", "o", "u", "y"};

Console.WriteLine("Zadejte poloměr kruhu: ");
string vstup = Console.ReadLine();

double cisloVstup;
bool daSeParsnout = double.TryParse(vstup, out cisloVstup);

if (daSeParsnout)
{
    Console.WriteLine(PlochaKruh(cisloVstup));
    Console.WriteLine(ObvodKruh(cisloVstup));
}

string[] poleStringu = {"Ovoce", "Pes", "Evangelia", "Kanon", "Auto", "Gruzie"};

Console.WriteLine("Pocet samohlasek je roven {0}", Samohlasky(poleStringu, samohlskyPole));
Console.WriteLine("Nejvetsi spolecny delitel cisel je {0}", NejvetsiSpolecnyDelitel(cisla));