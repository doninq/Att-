
 
  //     string[] StrMass = {"#5efS", "M", "Tu", "Red", "T", "Tertery"};



Console.WriteLine("Веедите количество элементов массива: ");
int MassLenght = Convert.ToInt32(Console.ReadLine()!);
string[] StrMass = new string[MassLenght];

Console.WriteLine("Веедите массив строк: ");
       for(int i = 0; i < StrMass.Length; i++)
       {   
        StrMass[i] = Console.ReadLine();
       };

       for(int i = 0; i < StrMass.Length; i++)
       {        
           //StrMass[i] = Console.WriteLine();
           Console.Write("[" + StrMass[i] + "]");
       }

       Console.WriteLine("");

       for(int i = 0; i < StrMass.Length; i++)
       {        
            if(StrMass[i].Length<4){
                //StrMass[i] = Console.WriteLine();
                Console.Write("[" + StrMass[i] + "]");
            }
       }
