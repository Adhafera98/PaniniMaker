﻿using System.Text;
var paninoStandard = @"                                      ░░                                                
                                                ██████████████                          
                                        ████████▓▓▓▓██░░░░██▓▓████                      
                                ████████░░░░░░░░██▓▓██░░░░██▓▓▓▓▓▓██                    
                            ████░░██▓▓▓▓██░░░░░░██▓▓▓▓██░░██▓▓▓▓▓▓▓▓██                  
                        ████░░░░░░░░██▓▓▓▓██░░░░██▓▓▓▓██░░██▓▓▓▓▓▓▓▓██                  
                      ██▓▓▓▓██░░░░░░░░██▓▓▓▓██░░██▓▓▓▓██░░██▓▓▓▓▓▓██                    
                    ██▓▓▓▓▓▓▓▓██░░░░░░██▓▓▓▓██░░██▓▓▓▓██░░██▓▓▓▓▓▓██                    
                    ██▓▓▓▓▓▓▓▓▓▓██░░░░██▓▓▓▓██░░██▓▓▓▓▓▓██▓▓▓▓▓▓▓▓██                    
                    ██▓▓▓▓▓▓▓▓▓▓▓▓██░░██▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██                      
                    ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████                        
                    ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████                            
                      ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████                                
                          ████████▓▓▓▓▓▓▓▓▓▓▓▓██████                                    
                                  ████████████                                          
                                                                                        ";

var paninoGatto = @"
            ██████████████                            
        ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████            ██        
    ████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████      ██▓▓██      
  ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▓▓▓▓▓▓▓▓██████▓▓░░██      
  ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓██▓▓▓▓▓▓▓▓██▓▓░░░░░░██    
██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓░░░░██▓▓▓▓████▓▓░░░░░░████  
██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██  
██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓░░░░░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░██  
████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓░░▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░██
██▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░██
████▓▓██▓▓██▓▓██▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░████░░██
  ████▓▓██▓▓██▓▓██▓▓██░░░░░░░░░░░░░░░░░░░░░░░░████░░██
  ██▓▓██▓▓██▓▓██▓▓██▓▓░░░░░░████░░░░░░░░░░░░░░████░░██
  ████▓▓██▓▓██▓▓██▓▓██░░░░░░████░░░░░░░░░░░░░░░░░░░░██
  ██▓▓██▓▓██▓▓██▓▓██▓▓░░░░░░████░░░░░░██░░░░██░░░░██  
  ████▓▓██▓▓██▓▓██▓▓██░░░░░░░░░░░░░░██░░████░░░░░░██  
  ██▓▓██▓▓██▓▓██▓▓██▓▓██░░░░░░░░████░░░░░░░░░░░░░░██  
  ████▓▓██▓▓██▓▓██▓▓██▓▓██░░░░░░░░░░░░░░░░░░░░░░░░██  
  ██▓▓██▓▓██▓▓██▓▓██▓▓██▓▓░░░░░░░░░░░░░░░░░░░░░░░░██  
  ████▓▓██▓▓██▓▓██▓▓██▓▓██░░░░░░░░░░░░░░░░░░░░░░░░██  
  ██▓▓██▓▓██▓▓██▓▓██▓▓██▓▓░░░░░░░░░░░░░░░░░░░░░░░░██  
  ██▓▓▓▓██▓▓██▓▓██▓▓██▓▓██░░░░░░░░░░░░░░░░░░░░░░░░██  
    ████▓▓██▓▓██▓▓██▓▓██▓▓░░░░░░░░░░░░░░░░░░░░░░░░██  
        ████▓▓▓▓██▓▓██▓▓██░░░░░░░░░░░░░░░░░░░░░░░░██  
            ██████▓▓▓▓██▓▓░░░░░░░░░░░░░░░░░░░░████    
                  ████▓▓██░░░░░░░░░░░░░░██████        
                      ████░░░░░░░░██████              
                          ████████                    
";


Console.WriteLine("How many PANINI do you request to Marina?");

var paniniCount = Console.ReadLine();

if (long.TryParse(paniniCount, out long realPaniniCount))
{
    Console.WriteLine("Insert your name:");

    var colleagueName = Console.ReadLine();

    if (colleagueName != null)
    {
        if (colleagueName.Equals("gatto", StringComparison.InvariantCultureIgnoreCase))
        {
            DrawPanini(realPaniniCount, paninoGatto);
            return;
        }
    }
    DrawPanini(realPaniniCount, paninoStandard);
}

static void DrawPanini(long realPaniniCount, string panino)
{
    Console.WriteLine("Here are your PANINI");
    for (int i = 0; i < realPaniniCount; i++)
    {
        Console.WriteLine(panino);
    }
}