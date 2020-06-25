
        
using System;

namespace ex24
{
    public class Tribonnaci
    {                               
        public Tribonnaci(int vezes){
            
            
            
               
            int t1=0;
            int t2=0;
            int t3=1;
            int tn;
            
           
            
            for (int i =0;i<vezes;i++){ 
                tn = t1+t2+t3;
                
                Console.WriteLine(tn);
                t1=t2;
                t2=t3;
                t3=tn;
                
                
            }
            
            
        }
        // Copia e cola la
        // msm fita no program
        // copia a classe toda , da control A
   }
}