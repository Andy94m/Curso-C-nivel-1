using System;

namespace ejemplo_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch
            char letra = 'A';

            switch(letra){
                case 'M':
                    Console.WriteLine("Tu nombre comienza con M...");
                    //lalalala
                    if(true){
                        switch (letra)
                        {
                            case 'J':
                            break;
                        }

                    }
                    if(true){
                        if (true)
                        {

                        }
                    }
                    break;
                case 'H':
                    //asdas
                    //asdasd
                    break;
                case 'R':
                    break;
                default:
                    //no coincide con ninguna...
                    break;
                
            }
        }
    }
}
