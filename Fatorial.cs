namespace ex24
{
   
    public class Fatorial                       
    {
                      
        public int fat(int vezes){
            int resultado;
            if(vezes<1){
                return 1;
            }else{

                
                resultado=vezes*fat(vezes-1);

            }
            return resultado;
        }
      

    }
}