using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2._5
{
    public class samling <T>
    {
        protected int buffert;
        protected T[] lista;                                //viken sorts lista det är

        protected int längd;                                // hur många plattser du har
        protected int antal;                                // upptagna plattser
        public samling() 
        {
            buffert = 30;
            antal = 0;
            längd = 30;
            lista = new T[längd];
        }

        protected void Expandera(int storlek)
        {
            if (storlek < 1) return;

            // gör ett nytt större fält
            T[] temp = new T[längd + storlek];

            //kopierar över gamla värden till den nya listan
            for (int i = 0; i < antal; i++) temp[i] = lista[i];

            lista = temp;
            längd += storlek;
        }

        protected void Reducera()
        {
            // gör en ny mindre lista
            T[] temp = new T[antal];


            // kopierar över värderna från den gamla listan
            for (int i = 0; i < antal; i++) temp[i] = lista[i];
            lista = temp;
            längd = antal;
        }

        public void Läggtill (T e)
        {
            // skaffa fler plattser om det behövs
            if (antal + 1 > längd ) Expandera ( 1 + buffert );
            
            lista[antal++] = e;
         }

        public T TaBort ( int index )
        {
            T temp = lista[index];


            // flytta alla element efter idex ett steg åt vänster
            for (int i = index; i<antal-1; i++)
            {
                lista[i] = lista[i+1];
            }

            antal--;

            //krymp fältet om det finns för många tomma plattser
            if ( antal - antal > buffert )  Reducera();

            return temp;
        }




    }
}
