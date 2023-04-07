namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 30;
            int[] Numbers = { 1, 2, 5, 6 };
            //Console.WriteLine(Numbers[0]);
            string[] Weapon = new string[3] { "Axe", "Bow", "Knife" };
            Weapon[0] = "Sword";
            Console.WriteLine(Weapon[0]);
            bool SwordisWeapon = Weapon[0].Equals("Sword");
            Console.WriteLine(SwordisWeapon);
        }
    }
}     