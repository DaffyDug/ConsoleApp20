using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Viapone
    {
        private Color _color;
        private string _name;
        public Viapone(Color color, string name)
        {
            _color = color;
            _name = name;
        }
    }

    class shotgun : Viapone
    {
        public shotgun(Color color, string name) : base(color, name)
        {

        }
    }
    class Pistol : Viapone
    {
        public Pistol(Color color, string name) : base(color, name)
        {

        }
    }
    class Player
    {
        Viapone _viapone;
        public Player(shotgun viapone)
        {
            _viapone = viapone;
        }
        public void Take_VIAPONE(Viapone Viapone)
        {
            _viapone = Viapone;
            Console.WriteLine($"Ты подобрал {_viapone}");
        }
    }
}