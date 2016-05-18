using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dress
{
    class Dress
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}.{0}.{0}", new string('_', n * 4));

            //int stars = n;
            //int underscore = n;
            int totalWidth = 12 * n + 2;
            int lenghtOfUnderscores = 4 * n - 2;
            
            for (int i = 1; i <= 2 * n; i++)
            {
                int numberOfStars = (totalWidth - 4 - 3 * (lenghtOfUnderscores)) / 2;
                Console.WriteLine("{0}.{1}.{0}.{1}.{0}",
                new string('_', lenghtOfUnderscores),
                new string('*', numberOfStars));
                lenghtOfUnderscores -= 2;


            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(".{0}."
                    , new string('*', n * 12));
            }
            Console.WriteLine("{0}{1}{0}"    //!!!//
                , new string('.', n * 3)
                , new string('*', totalWidth - n*6));
            for (int i = 0; i < n; i++)
            {
                
                
                Console.WriteLine("{0}{1}{0}"
                    , new string('_', n * 3)
                    , new string('o', totalWidth - n*6)); //!!!//

            }
            int bottomL = n * 3;
            int bottomS = n * 6;
            for (int i = 0; i < n * 3; i++)
            {
                Console.WriteLine("{0}.{1}.{0}"
                    , new string('_', bottomL)
                    , new string('*', bottomS));
                bottomL--;
                bottomS += 2;
            }
            Console.WriteLine("{0}", new string('.', 12 * n + 2));
        }
    }
}
