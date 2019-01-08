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
        protected int Hp;
        public int Health {
            get {
                return Hp;
            }
            set {
                Hp = Health;
            }
        }
        public Human (string name) {
            Name = name;
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
        public virtual int Attack (Human target) {

            return target.Hp - Str * 5;
        }

    }
    class Wizard : Human {
        public Wizard (string name) : base (name) {
            Hp = 50;

        }
        public override int Attack (Human target) {
            var damage = Int * 5;
            target.Health -= damage;
            Hp += damage;
            return target.Health;
        }
        public int Heal(Human target){
            return target.Health += 10 * Int;
        }
    }
    class Ninja : Human {
        Random roll = new Random ();

        public Ninja (string name) : base (name) {
            Dex = 175;

        }
        public override int Attack (Human target) {
            var dmg = Dex * 5;
            var crit = roll.Next(0,5);
            if(crit == 4){
                dmg += 10;
            }
            return target.Health -= dmg;

        }
        public int Steal(Human target){
            Hp += 5;
            target.Health -= 5;
            return target.Health;
        }
    }
    class Samurai : Human {
        public Samurai (string name) : base (name) {
            Hp = 200;
        }
        public override int Attack(Human target){
            base.Attack(target);
            if(target.Health >= 50){
                target.Health = 0;
            }
            return target.Health;
        }
        public int Meditate(){
            Hp = 200;
            return Hp;
        }
    }
}