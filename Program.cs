using System;

namespace Human {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
        }
    }
    class Human {
        public string Name;
        public int Str;
        public int Int;
        public int Dex;
        private int Hp {
            get {
                return Hp;
            }
            set {

            }
        }
        public Human (string who) {
            Name = who;
            Str = 3;
            Int = 3;
            Dex = 3;
            Hp = 100;

        }
        public Human (string who, int strength, int intellect, int dexterity, int health) {
            Name = who;
            Str = strength;
            Int = intellect;
            Dex = dexterity;
            Hp = health;
        }
        public int Attack (Human target) {

            return target.Hp - this.Str * 5;
        }
    }
}