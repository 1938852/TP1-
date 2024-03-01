using Atelier2C6_101_2024;
using Atelier2C6_101_2024.Connect4;

namespace TP1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Util.Titrer("Partie de Connect4");
            Util.Pause();

            PartieConnect4 pConn4 = new PartieConnect4();
            pConn4.Jouer();
        }
    }
}
