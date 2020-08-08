using LegoMinifigures.Figures;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var Han = new StarWars("Han Solo", "Smuggler", 49)
            {
                Arms = 2,
                Legs = 2,
                Catchphrase = "Never tell me the odds"
            };

            Han.GetCharacterInfo();
            Han.BecomeAJedi();
            Han.EquipWeapon("blaster");
            Han.CompleteMission("Destroy the Death Star");
            Han.BecomeAJedi();
            Han.GetCharacterInfo();

            var Anakin = new StarWars("Anakin Skywalker", "Padawan", 5)
            {
                Arms = 2,
                Legs = 2,
                Catchphrase = "I hate sand"
            };

            Anakin.GetCharacterInfo();
            Anakin.BecomeAJedi();
            Anakin.CompleteMission("Defeat Count Dooku");
            Anakin.CompleteMission("Defeat Obi Wan");
            Anakin.CompleteMission("Defeat Obi Wan");
            Anakin.CompleteMission("Defeat Obi Wan");
            Anakin.CompleteMission("Defeat Obi Wan");

        }
    }
}
