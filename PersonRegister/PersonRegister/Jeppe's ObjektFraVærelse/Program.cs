using System;

namespace Jeppe_s_ObjektFraVærelse
{
    class Program
    {
        static void Main(string[] args)
        {
            items genstande = new items(4, 52, 100, true);
            Reol jeppesReol = new Reol(3, "Black", genstande);

            Console.WriteLine(genstande.books);
            Console.WriteLine(jeppesReol.AddBook(genstande.books));

        }
    }
}
