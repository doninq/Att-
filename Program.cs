
       for(int j = 0; j < matrix.GetLength(1); j++)
       {        
           string? name = Console.ReadLine();
           
       }
       */
       string[] StrMass = {"#5efS", "M", "Tu", "Red", "T", "Tertery"};


       for(int i = 0; i < StrMass.Length; i++)
       {        
           //StrMass[i] = Console.WriteLine();
           Console.Write("[" + StrMass[i] + "]");
       }
       Console.WriteLine("");

       for(int i = 0; i < StrMass.Length; i++)
       {        
            if(StrMass[i].Length>3){
                //StrMass[i] = Console.WriteLine();
                Console.Write("[" + StrMass[i] + "]");
            }
       }
