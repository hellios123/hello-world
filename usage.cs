using System;
using System.Collections.Generic;

namespace Apps
{
    /// <summary>
    /// Usage of  the  sorted  list class,
    every time  you add something  using  Adds method  it adds and  sorts  at  the  same time 
    /// </summary>
    public  class Prog
    {
        public static void Main()
        {
            Sortedl sl = new Sortedl();
                sl.Adds("Brute");
            sl.Adds("Angel");
            //chaining is also possible
             sl.Adds("Danger").Adds("Cat");
             //do  whatever  you like with the new  sl  sorted  list


        }
    }
}
