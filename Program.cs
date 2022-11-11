namespace ConsoleApp3
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }

        public int Attack { get; set; }
        public int Armor { get; set; }
        public int Agility { get; set; }

        public Pokemon(string name, int health, int attack, int armor, int agility) // конструктор
        {
            Name = name;
            HP = health;
            Attack = attack;
            Armor = armor;
            Agility = agility;
        }

        public void StartAttack(Pokemon other)
        {
            other.HP -= this.Attack;
        }
        public void StartHealth()
        {
            this.HP += this.Armor;
        }
        public void StartDodge(Pokemon other)
        {
            this.HP += this.Agility;
        }
    }
    class Program
    {
        static void Main()
        {
            Pokemon pokemon1 = new Pokemon("Пикачу", 100, 10, 5, 5);
            Console.WriteLine($"Имя покемона: {pokemon1.Name}, уровень здоровья: {pokemon1.HP},атака: {pokemon1.Attack}, уровень защиты: {pokemon1.Armor} и ловкости: {pokemon1.Agility}");

            Pokemon pokemon2 = new Pokemon("Бульбазавр", 120, 8, 11, 1);
            Console.WriteLine($"Имя покемона: {pokemon2.Name}, уровень здоровья: {pokemon2.HP},атака: {pokemon2.Attack}, уровень защиты: {pokemon2.Armor} и ловкости: {pokemon2.Agility}");
            
            string[] mas = new string[] { "Attack", "Health", "Dodge" };
            string[] mas2 = new string[] { "Attack", "Health", "Dodge" };
            string[] mas3 = new string[] { "Attack", "Health", "Dodge" };
            string[] mas4 = new string[] { "Attack", "Health", "Dodge" };
            Random rand = new Random();
            do
            {

                if (rand.Next(0, mas.Length-1) == 0)
                {
                    pokemon1.StartAttack(pokemon2);
                    Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");

                    if (rand.Next(0, mas2.Length - 1) == 0)
                    {
                        pokemon2.StartAttack(pokemon1);
                        Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 1)
                    {
                        pokemon2.StartHealth();
                        Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 2)
                    {
                        pokemon2.StartDodge(pokemon1);
                        Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");
                    }
                }

                else if (rand.Next(0, mas.Length - 1) == 1)
                {

                    pokemon1.StartHealth();
                    Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");

                    if (rand.Next(0, mas2.Length - 1) == 0)
                    {
                        pokemon2.StartAttack(pokemon1);
                        Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 1)
                    {
                        pokemon2.StartHealth();
                        Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 2)
                    {
                        pokemon2.StartDodge(pokemon1);
                        Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");
                    }
                }

                else if (rand.Next(0, mas.Length - 1) == 2)
                {
                    pokemon1.StartDodge(pokemon2);
                    Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");

                    if (rand.Next(0, mas2.Length - 1) == 0)
                    {
                        pokemon2.StartAttack(pokemon1);
                        Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 1)
                    {
                        pokemon2.StartHealth();
                        Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 2)
                    {
                        pokemon2.StartDodge(pokemon1);
                        Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");
                    }
                }

                // сходил первый покемон, а второй ответил, теперь ход за вторым, а отвечает - первый


                if (rand.Next(0, mas.Length - 1) == 0)
                {
                    pokemon2.StartAttack(pokemon1);
                    Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");

                    if (rand.Next(0, mas2.Length - 1) == 0)
                    {
                        pokemon1.StartAttack(pokemon2);
                        Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 1)
                    {
                        pokemon1.StartHealth();
                        Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 2)
                    {
                        pokemon1.StartDodge(pokemon2);
                        Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");
                    }
                }

                else if (rand.Next(0, mas.Length - 1) == 1)
                {
                    pokemon1.StartHealth();
                    Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");

                    if (rand.Next(0, mas2.Length - 1) == 0)
                    {
                        pokemon1.StartAttack(pokemon2);
                        Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 1)
                    {
                        pokemon1.StartHealth();
                        Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 2)
                    {
                        pokemon1.StartDodge(pokemon2);
                        Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");
                    }
                }

                else if (rand.Next(0, mas.Length - 1) == 2)
                {
                    pokemon2.StartDodge(pokemon1);
                    Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");

                    if (rand.Next(0, mas2.Length - 1) == 0)
                    {
                        pokemon1.StartAttack(pokemon2);
                        Console.WriteLine($"Здоровье второго покемона {pokemon2.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 1)
                    {
                        pokemon1.StartHealth();
                        Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");
                    }
                    else if (rand.Next(0, mas2.Length - 1) == 2)
                    {
                        pokemon1.StartDodge(pokemon2);
                        Console.WriteLine($"Здоровье первого покемона {pokemon1.HP}");
                    }
                }
                
            } while (pokemon1.HP >=0 & pokemon2.HP >=0);
            
        }
    }
}