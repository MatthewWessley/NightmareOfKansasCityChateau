using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillianLibrary;
using ChateauLibrary;

namespace NightmareOfKansasCityChateau
{
    class KansasCityChateau
    {
        static void Main()
        {

            Console.Title = "Nightmare of Kansas City Chateau";
            Console.WriteLine("The nightmare begins here...\n");

            // Villian Weapons

            Weapons dagger = new Weapons("Small Dagger", 1, 6, 0);
            //Console.WriteLine(dagger);
            Weapons razors = new Weapons("Gloves with razor nails", 5, 10, 5);
            //Console.WriteLine(razors);
            Weapons machete = new Weapons("Large blunt knife", 5, 10, 5);
            //Console.WriteLine(machete);
            Weapons chainsaw = new Weapons("Chainsaw with a rusted chain", 5, 10, 5);
            //Console.WriteLine(chainsaw);
            Weapons magic = new Weapons("Irish Magic of a Leprechaun", 5, 10, 5);
            //Console.WriteLine(magic);
            Weapons knife = new Weapons("Kitchen knife", 5, 10, 5);
            //Console.WriteLine(knife);
            Weapons morphing = new Weapons("Morph into your worst fear", 5, 10, 5);
            //Console.WriteLine(morphing);
            Weapons blades = new Weapons("Hooked and barbed blades", 5, 10, 5);
            //Console.WriteLine(dagger);
            Weapons psychological = new Weapons("Lure and murder", 5, 10, 5);
            //Console.WriteLine(psychological);
            Weapons appendages = new Weapons("Tenticle-like appendages", 5, 10, 5);
            //Console.WriteLine(appendages);

            // Player Weapons

            Weapons gun = new Weapons("Shotgun", 5, 10, 5);

            // Players

            Players at1 = new Players("Monte", 100, 100, 5, 0, gun, SelectPlayer.Attacker);

            Console.WriteLine(at1);

            Console.WriteLine();
            
            bool exit = false;

            do
            {
                Console.WriteLine(GetRoom());
                Console.WriteLine();

                // Villian
                Chucky ch1 = new Chucky("Chucky", 25, 25, 2, 1, 1, 5, "Murderous childrens doll", dagger);
                FreddyKrueger fk1 = new FreddyKrueger("Freddy Krueger", 90, 90, 7, 3, 1, 10, "Nightmare on your street", razors);
                JasonVorhees jv1 = new JasonVorhees("Jason", 45, 45, 0, 1, 1, 6, "Hockey revenge", machete);
                Leatherface lf1 = new Leatherface("Leatherface", 55, 55, 1, 1, 3, 7, "Psycho Redneck", chainsaw);
                Lubin lu1 = new Lubin("Lubin", 40, 40, 10, 3, 1, 6, "Leprechaun", magic);
                MichaelMyers mm1 = new MichaelMyers("Michael Myers", 30, 30, 0, 1, 1, 6, "Slow but deadly", knife);
                Pennywise pw1 = new Pennywise("Pennywise", 65, 65, 8, 4, 1, 8, "Your biggest fear", morphing);
                Pinhead ph1 = new Pinhead("Pinhead", 60, 60, 10, 4, 1, 8, "Hellraiser", blades);
                SamaraMorgan sm1 = new SamaraMorgan("Samara", 35, 35, 8, 2, 1, 5, "The dead return", psychological);
                Slenderman sl1 = new Slenderman("Slenderman", 50, 50, 9, 6, 1, 9, "Faceless Torment", appendages);


                Villian[] villians = { ch1, fk1, jv1, lf1, lu1, mm1, pw1, ph1, sm1, sl1 };

                Villian villian = villians[new Random().Next(villians.Length)];


                Console.WriteLine($"In this room you see " + villian.Name + "!");
                Console.WriteLine();

                // Loop for menu
                bool reload = false;

                do
                {
                    Console.WriteLine("\nChoose an action:\n" +
                        "F)ight \n" +
                        "R)un away\n" +
                        "P)layer Stats\n" +
                        "V)illian Stats\n" +
                        "E)xit");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.F:
                            Combat.DoBattle(at1, villian);
                            if (villian.Life <= 0)
                            {
                                Console.WriteLine($"You killed the {villian.Name}!\n");
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                reload = true;
                            }
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("RUN AWAY!\n");
                            int blockedIn = new Random().Next(2);
                            if (blockedIn == 1)
                            {
                                reload = true;
                            }
                            else
                            {
                                Console.WriteLine("You can't escape that easily!\n");
                            }
                            reload = true;
                            Combat.DoAttack(villian, at1);
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine(at1);
                            break;
                        case ConsoleKey.V:
                            Console.WriteLine(villian);
                            break;
                        case ConsoleKey.E:
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("You have chosen an option not available. Please try again.");
                            break;
                    }
                    
                    if (at1.Life <= 0)
                    {
                        Console.WriteLine($"You have been slain by {villian.Name}!");
                        exit = true;
                    }
                    

                } while (!exit && !reload);
            } while (!exit);

            Console.WriteLine("GAME OVER!");

        }

        private static string GetRoom()
        {
            string[] room =
            {
                        "Your nightmare starts in the same place you have your last memory... The master bedroom. Three low, oblong piles of rubble lie near the center of this small room. Each has a weapon jutting upright from one end -- a longsword, a spear, and a quarterstaff. The piles resemble cairns used to bury dead adventurers.",
                        "\nYou go down to the basement. You open the door, and the reek of garbage assaults your nose. Looking inside, you see a pile of refuse and offal that nearly reaches the ceiling. In the ceiling above it is a small hole that is roughly as wide as two human hands. No doubt some city dweller high above disposes of his rubbish without ever thinking about where it goes.",
                        "You enter the family room. A chill crawls up your spine and out over your skin as you look upon this room. The carvings on the wall are magnificent, a symphony in stonework -- but given the themes represented, it might be better described as a requiem. Scenes of death, both violent and peaceful, appear on every wall framed by grinning skeletons and ghoulish forms in ragged cloaks.",
                        "You head into the office. A wall that holds a seat with a hole in it is in this chamber. It's a privy! The noisome stench from the hole leads you to believe that the privy sees regular use",
                        "\nThe spare bedrrom is rarely used. When looking into this chamber, you're confronted by a thousand reflections of yourself looking back. Mirrored walls set at different angles fill the room. A path seems to wind through the mirrors, although you can't tell where it leads",
                        "You venture into the nursery. This room is a tomb. Stone sarcophagi stand in five rows of three, each carved with the visage of a warrior lying in state. In their center, one sarcophagus stands taller than the rest. Held up by six squat pillars, its stone bears the carving of a beautiful woman who seems more asleep than dead. The carving of the warriors is skillful but seems perfunctory compared to the love a sculptor must have lavished upon the lifelike carving of the woman.",
                        "\nThe kitchen is the next room in order to exit the house. This small chamber is a bloody mess. The corpse of a minotaur lies on the floor, its belly carved out. The creature's innards are largely missing, and yet you detect no other wounds. Bloody, froglike footprints track away from the corpse and out an open door.",
                        "The living room is not what you remember it to be. Corpses and pieces of corpses hang from hooks that dangle from chains attached to thick iron rings. Most appear humanoid but a few of the body parts appear more monstrous. You don't see any heads, hands, or feet -- all seem to have been chopped or torn off. Neither do you see any guts in the horrible array, but several thick leather sacks hang from hooks in the walls, and they are suspiciously wet and the leather looks extremely taut -- as if it' under great strain",
                        "\nYou just can't wait to wake up from this nightmare. You enter into the dining room. The door creaks open, which somewhat overshadows the sound of bubbling liquid. Before you is a room about which alchemists dream. Three tables bend beneath a clutter of bottles of liquid and connected glass piping. Several bookshelves stand nearby stuffed to overfilling with a jumble of books, jars, bottles, bags, and boxes. The alchemist who set this all up doesn't seem to be present, but a beaker of green fluid boils over a burner on one of the tables.",
                        "\nYou have made it to the garage. Many doors fill the room ahead. Doors of varied shape, size, and design are set in every wall and even the ceiling and floor. Barely a hand's width lies between one door and the next. All the doors but the one you entered by are shut, and many have obvious locks.",
                        "\nDid you really make it outside? The nightmare is over! Or is it... You see the last of all your worse nightmares. The villian that stands in front of you is the reason you have lived through this Chateau of horrors."
                };

            return room[new Random().Next(room.Length)];

        }
    }
}
