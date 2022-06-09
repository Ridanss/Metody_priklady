using System;

namespace Weedeg
{
    /// <summary>
    /// Metody pro weedga
    /// </summary>
    public class weedeg
    {
        /// <summary>
        /// Zaokrouhlí číslo
        /// </summary>
        /// <param name="cislo">Vstupní číslo na zaokrouhlení</param>
        /// <param name="rad">Na jaké řády chceme zaokrouhlit (default: 10)</param>
        /// <returns>Vrátí zaokrouhlený výsledek</returns>
        static public int Zaokrouhleni(int cislo, int rad = 10)
        {
            if (cislo % rad >= rad / 2)
            {
                cislo += rad - cislo % rad;
            }
            else cislo -= cislo % rad;
            return cislo;
        }
        /// <summary>
        /// Zjistí zda se jedná a prvočíslo, pokud ne tak prvek vynásobí svým největším dělitelem
        /// </summary>
        /// <param name="vynasobene">Prvek vynasobeny svym nejvetsim delitelem</param>
        /// <param name="prvek">input, pokud prvek neni provicslo tak se v nem vrati hodnota prvku vynasobeneho jeho nejvetsim delitelem</param>
        /// <returns>vrátí hodnotu bool prvocislo</returns>
        static public bool Prvocislo(ref int prvek)
        {
            bool prvocis = false;
            prvocis = true;
            if (prvek == 1 || (prvek > 2 && prvek % 2 == 0)) prvocis = false;
            else for (int del = 3; del <= Math.Sqrt(prvek) && prvocis; del += 2)
                {
                    if (prvek % del == 0) prvocis = false;
                }
            if (!prvocis)
            {
                for (int del = prvek / 2; del >= 2; del--)
                {
                    if (prvek % del == 0) prvek *= del;
                }
            }
            return prvocis;
        }
        /// <summary>
        /// Spočítá přesnost průzkumu z velikosti průzkumu a z počtu kladných odpovědí s 95% přesností (kladných myšleno ANO na dotázanou otázku)
        /// </summary>
        /// <param name="sample_size">Počet lidí v průzkumu</param>
        /// <param name="sample_proportion">Počet lidí co odpověděli kladně v desetiném čísle (když 58% odpovědělo ano, tak zadáváme 0.58)</param>
        /// <returns>Vrátí +- odchylku průzkumu v procentech</returns>
        static public double MarginOfErrorProportion(int sample_size, double sample_proportion)
        {
            double precision= 1.95 * Math.Sqrt((sample_proportion * (1 - sample_proportion)) / sample_size);
            return precision *= 100;
        }
    }
}