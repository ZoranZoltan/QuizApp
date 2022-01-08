using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralQuiz
{
    class Quiz
    {
        private string[,] questions = new string[20, 5];
        public Quiz()
        {
            questions[0, 0] = "Šta je String ";
            questions[0, 1] = "Piće";
            questions[0, 2] = "Struna";
            questions[0, 3] = "*Posebna vrsta niza";
            questions[0, 4] = "Empty metoda";
            //
            questions[1, 0] = "C# je";
            questions[1, 1] = "Akademski jezik";
            questions[1, 2] = "*OOP jezik";
            questions[1, 3] = "Web jezik";
            questions[1, 4] = "Funkcija";
            //
            questions[2, 0] = "Petlja je";
            questions[2, 1] = "*Naredba ponavljanja";
            questions[2, 2] = "duplirano kodiranje";
            questions[2, 3] = "prebacivanje izvršenja funkcija";
            questions[2, 4] = "algoritamsko kodiranje";
            //
            questions[3, 0] = "Kako kreirati prazan string";
            questions[3, 1] = "*Pomoću Empty metoda";
            questions[3, 2] = "Strukturom podataka";
            questions[3, 3] = "Boxing konverzijom";
            questions[3, 4] = "Pomoću argumenta metoda";
            //
            questions[4, 0] = " naredbe for, foreach, while, do while su";
            questions[4, 1] = "Stringovi";
            questions[4, 2] = "Pokazivači";
            questions[4, 3] = "*Petlje";
            questions[4, 4] = "Nizovi";
            //
            questions[5, 0] = "Pointer ili pokazivač predstavlja";
            questions[5, 1] = "traker";
            questions[5, 2] = "*Promenljivu specijalnog tipa";
            questions[5, 3] = "deklaraciju";
            questions[5, 4] = "komandu baze podataka";
            //
            questions[6, 0] = "U Windows Forms aplikaciji za definisanje prozora koristi se klasa";
            questions[6, 1] = "Window";
            questions[6, 2] = "*Form";
            questions[6, 3] = "WindowForm";
            questions[6, 4] = "WinForm";
            //
            questions[7, 0] = "Potrebno je da polje x neke klase može da ima celobrojnu vrednost ili null";
            questions[7, 1] = "private int x;";
            questions[7, 2] = "private nullable int x;";
            questions[7, 3] = "Ovako nešto nije moguće";
            questions[7, 4] = "*private int? x;";
            //
            questions[8, 0] = " C# umesto getter/setter metoda u klasama  definiše";
            questions[8, 1] = "Delegate";
            questions[8, 2] = "Polja";
            questions[8, 3] = "Indekseri";
            questions[8, 4] = "*Svojstva";
            //
            questions[9, 0] = "Naredbe goto, break i continue su";
            questions[9, 1] = "*nаredbe bezuslovnog skokа";
            questions[9, 2] = "itrativne naredbe";
            questions[9, 3] = "Naredbe selekcije";
            questions[9, 4] = "Povratne naredbe";
            //
            questions[10, 0] = "Najveća vrednost tipa int je";
            questions[10, 1] = "4,294,967,295";
            questions[10, 2] = "9,223,372,036,854,775,807";
            questions[10, 3] = "18,446,744,073,709,551,615";
            questions[10, 4] = "*2,147,483,647";
        }
        public string getQuestion(int i)
        {
            return questions[i, 0];
        }
        public string getAnswer(int i,int j)
        {
            return questions[i, j];
        }

    }
}
