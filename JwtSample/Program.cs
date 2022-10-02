using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter user password: ");
            string userPassword = Console.ReadLine();
            UserService userService = new UserService();
            string token = userService.Authentication(userName, userPassword);
            Console.WriteLine(token);
            Console.ReadKey(true);
        }
    }
   
}
