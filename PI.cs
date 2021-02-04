/***********************************************************************************************
 * Übungsnr:        07                                     
 * Programmname:    PI                                  
 * Autor:           karlof002                               
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Bestimme den Wert von PI näherungsweise!
 * ************************************************
*/

using System;

namespace PI
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal res = 0;
            decimal sign = 1; //Start mit positiven Vorzeichen: pi/4 = 1/1 - 1/3 + 1/5 - 1/7.....
            for (int i = 0; i < 2000000000; i++)
            {
                res = res + sign / (2 * i + 1);
                sign = sign * -1; //Vorzeichen von + auf - ändern, bzw. von - auf + ändern
            }
            res = res * 4;
            Console.WriteLine("PI="+res);
        }
    }
}
