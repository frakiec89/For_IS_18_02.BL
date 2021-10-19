using System;

namespace For_IS_18_02.BL
{
    public class klassNachalo
    {
       private string name ="ggg";

       protected ClassMayBe classMayBe; 


       public  klassNachalo (string n)
       {
            name = n;
            classMayBe = new ClassMayBe();
       }

        public string Metod1 (bool flag)
        {
            if (flag == true)
            {
                return "Вы не  на том пути";
            }
            else
            {
                return "Вы не  на том пути";
            }
        }

        public  string MetodH ()
        {
            return "Надо  ходить на  пары";
        }

    }
}
