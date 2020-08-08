using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Figures
{
    class StarWars
    {
        public bool Head { get; set; }
        public bool Torso { get; set; }
        public int Arms { get; set; }
        public int Legs { get; set; }
        public bool WeaponEquipped { get; set; }
        private bool _forceUser { get; set; } = false;


        public string Name { get; set; }
        public string Role { get; set; }
        public string Catchphrase { get; set; }
        public string Weapon { get; set; }
        private int _missionsCompleted { get; set; }

        public StarWars(string name, string role, int missionsCompleted)
        {
            Name = name;
            Role = role;
            _missionsCompleted = missionsCompleted;
            Head = true;
            Torso = true;
            WeaponEquipped = false;

            if (role == "jedi")
            {
                _forceUser = true;
            }

            Console.WriteLine($"{Name} unlocked.");
        }

        public void GetCharacterInfo()
        {
            Console.WriteLine($"{Name}'s Character Statistics:");
            Console.WriteLine($"Role: {Role}");

            Console.WriteLine($"Completed missions: {_missionsCompleted}");

            var CharacterWeapon = WeaponEquipped ? $"Weapon of choice: {Weapon}." : $"Weapon equipped: None";
            Console.WriteLine(CharacterWeapon);

            Console.WriteLine($"Catchphrase: `{Catchphrase}.`");
        }

        public void CompleteMission(string missionName)
        {
            if (!WeaponEquipped) 
            {
                if (Arms > 0)
                {
                    Console.WriteLine($"{Name} ran into battle without a weapon equipped and lost an arm!");
                    Arms--;
                    Console.WriteLine($"{Name} limb count: {Arms} arm(s) & {Legs} leg(s)");
                }
                else if (Legs > 0)
                {
                    Console.WriteLine($"{Name} ran into battle without a weapon equipped and lost a leg!");
                    Legs--;
                    Console.WriteLine($"{Name} limb count: {Arms} arm(s) & {Legs} leg(s)");
                }
                else Console.WriteLine($"{Name} doesn't have a weapon or any arms or legs. They should probably sit this one out.");
            }
            else
            {
                Console.WriteLine($"{Name} yells '{Catchphrase}!' {missionName} mission completed.");
                _missionsCompleted++;
            }
        }

        // equip weapon
        public void EquipWeapon(string weaponName)
        {
            Console.WriteLine($"{Name} equips the trusty {weaponName}.");
            Weapon = weaponName;
            WeaponEquipped = true;
        }

        // become jedi
        public void BecomeAJedi()
        {
           if (_missionsCompleted >= 50)
            {
                Console.WriteLine($"{Name} leveled up! {Name} is now a Jedi.");
                Role = "Jedi";
                Weapon = "Lightsaber";
                _forceUser = true;
            }
           else
            {
                Console.WriteLine($"{Name}'s training is not yet complete. Complete 50 missions to become a Jedi.");
            }
        }
    }
}
