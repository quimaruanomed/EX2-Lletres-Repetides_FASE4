using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace M2._2_FaseIV
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lettersName = { 'J', 'o', 'a', 'q', 'u', 'i', 'n', 'a'};
            char[] surnameLet = { 'R', 'u', 'a', 'n', 'o' };
            
            List<char> lName = new List<char>();
            List<char> lSurname = new List<char>();
            List<char> spa = new List<char>();
            List<char> fullName = new List<char>();
            
            spa.Add(' ');
            spa.Add(' ');
            
            
            for (int i=0; i < lettersName.Length; i++) // Con este bucle rellenamos la lista lName
            {
                lName.Add(lettersName[i]);
             }
            for (int i=0; i < surnameLet.Length; i++) // Rellenamos la lista lSurname 
            {
                lSurname.Add(surnameLet[i]);
            }
            Console.WriteLine("El resultado de unir las dos listas es: ");
            
            fullName.AddRange(lName);  //unimos las listas fullName(inicialmente vacía) a lName 
            fullName.AddRange(spa);  // Añadimos el espacio a la lista fullName
            fullName.AddRange(lSurname); // Añadimo la lista lSurname a la lista fullName

            foreach (char x in fullName) // Imprimimos el resultado de la union de las 3 listas
            {
                Console.WriteLine(x);  

            }
         }
    }
}
