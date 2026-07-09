// =============== NOTE ===============
// SQL Injection occurs when embedding inputs (from User or any other services) directly in SQL Queries.
// To prevent this, use parameterized queries.

using June2026.SQLInjection;

LoginService loginService = new LoginService();

do
{
    Console.Write("[1] Vulnerable, [2] Secured, [0] Exist: ");
    int choicedWay = int.Parse(Console.ReadLine());

    if (choicedWay == 0) break;

    Console.Write("Enter username: ");
    string username = Console.ReadLine();

    Console.Write("Enter password: ");
    string password = Console.ReadLine();

    if (choicedWay == 1) loginService.VulnerableLogin(username, password);
    else loginService.SecuredLogin(username, password);
}
while (true);





