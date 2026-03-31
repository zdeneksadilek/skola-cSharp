using System.Net.Security;

namespace _30_3_26;

class Program
{


    static int PoziceZnaku(char[] poleZnaku)
    {
        string znakCoZadal = Console.ReadLine();
        int pozice = -1;

        for (int i = 0; i < poleZnaku.Length; i++)
        {
            if (znakCoZadal == poleZnaku[i].ToString())
            {
                pozice = i;

                break;
            }
        }
        return pozice;
    }
    static int Sub(int[] pole)
    {
        int i = 0;

        foreach (var item in pole)
        {
            i = i + item;
        }

        return i;
    }

    static (string, string) Prohozeni(string s, string t)
    {
        string docasne = s;
        s = t;
        t = docasne;

        return (s, t);

    }

    static int Median(int[] median)
    {
        median.Sort();
        int cislo = 0;

        if (median.Length % 2 == 1)
        {
            int delka = (median.Length - 1) / 2;
            cislo = median[delka];
        } else if (median.Length % 2 == 0)
        {
            int delka = median.Length / 2;
            cislo = (median[delka - 1] + median[delka]) / 2;
        }

        return cislo;
    }

    static void Main(string[] args)
    {
        int[] poleCisel = {2, 4, 6, 8};
        char[] poleZnaku = {'a', 'B', 'C', '4', 'i'};

        
        Console.WriteLine(Sub(poleCisel));

        Console.WriteLine(Prohozeni("ahoj", "cus"));

        Console.WriteLine(Median(poleCisel));

        Console.WriteLine(PoziceZnaku(poleZnaku));
    }
}
