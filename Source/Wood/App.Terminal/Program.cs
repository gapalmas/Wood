using System;


namespace App.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            int cortesH = Triplay.Cut.Horizontal(12, 15);
            int cortesV = Triplay.Cut.Vertical(12, 15);

            int countHorizontal = 0, countVertical = 0;
            double PiezaHorizontal = 12, PiezaVertical = 15;

            double MedidaVertical = 48, MedidaHorizontal = 96, octa = .125;

            while (PiezaHorizontal <= MedidaHorizontal)
            {
                MedidaHorizontal = (MedidaHorizontal - PiezaHorizontal)  - octa;
                countHorizontal++;
            }

            while (PiezaVertical <= MedidaVertical)
            {
                MedidaVertical = (MedidaVertical - PiezaVertical) - octa;
                countVertical++;
            }

            //while (PiezaVertical < MedidaHorizontal & PiezaHorizontal < MedidaVertical)
            //{
            //    MedidaHorizontal = (MedidaHorizontal - PiezaVertical) - (1/8);
            //    MedidaVertical = (MedidaVertical - PiezaHorizontal) - (1/8);
            //    countVertical++;
            //}
            Console.WriteLine("Hello World!");
        }
    }
}
