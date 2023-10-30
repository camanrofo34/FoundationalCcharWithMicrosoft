int heroLife=10;
int monsterLife=10;
Random random = new Random ();
do{
    int danoM = random.Next(1, 11);
    monsterLife-=danoM;
    Console.WriteLine("Monster was damaged and lost "+danoM+" health and now has "+monsterLife+" health.");
    if (monsterLife<=0) break;
    int danoH = random.Next(10);
    heroLife-=danoH;
    Console.WriteLine("Hero was damaged and lost "+danoH+" health and now has "+heroLife+" health.");
} while (heroLife>0);
if (heroLife<=0)Console.WriteLine("Monster wins!");
else Console.WriteLine("Hero wins!");