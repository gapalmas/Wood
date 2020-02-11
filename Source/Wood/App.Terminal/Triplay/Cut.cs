using System;
using System.Collections.Generic;
using System.Text;

namespace App.Terminal.Triplay
{
    public class Cut
    {
        public static int Horizontal(double PiezaHorizontal, double PiezaVertical)
        {
            int countHorizontal = 0, countVertical = 0;
            //double PiezaHorizontal = 12, PiezaVertical = 15;

            double MedidaVertical = 48, MedidaHorizontal = 96, octa = .125;

            while (PiezaHorizontal <= MedidaHorizontal)
            {
                MedidaHorizontal = (MedidaHorizontal - PiezaHorizontal) - octa;
                countHorizontal++;
            }
            while (PiezaVertical <= MedidaVertical)
            {
                MedidaVertical = (MedidaVertical - PiezaVertical) - octa;
                countVertical++;
            }
            return countHorizontal * countVertical;
        }

        public static int Vertical(double PiezaHorizontal, double PiezaVertical)
        {
            int countHorizontal = 0, countVertical = 0;
            //double PiezaHorizontal = 12, PiezaVertical = 15;

            double MedidaVertical = 48, MedidaHorizontal = 96, octa = .125;

            while (PiezaHorizontal <= MedidaHorizontal)
            {
                MedidaHorizontal = (MedidaHorizontal - PiezaVertical) - octa;
                countHorizontal++;
            }
            while (PiezaVertical <= MedidaVertical)
            {
                MedidaVertical = (MedidaVertical - PiezaHorizontal) - octa;
                countVertical++;
            }
            return countHorizontal * countVertical;
        }
    }
}
