/*First Excercise
Random random = new Random();
int coin = random.Next(0,2);
Console.WriteLine($" { (coin <= 1 ? "Tails" : "Head" )} ");
*/

string permission = "Admin|Manager";
int level = 55;
bool isAdmin = permission.Contains("Admin") ? true : false ;
if (isAdmin && level>55)Console.WriteLine("Welcome, Super Admin user.");
else if (isAdmin && level<=55)Console.WriteLine("Welcome, Admin user.");
else if(!isAdmin && level>20)Console.WriteLine("Contact an Admin for access.");
else if (!isAdmin&& level<=20)Console.WriteLine("You do not have sufficient privileges.");
else Console.WriteLine("You do not have sufficient privileges.");