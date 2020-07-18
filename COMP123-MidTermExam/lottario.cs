using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /** Amish tangri
 * 301108446
 * 17-07-2019
 * this is a program for lottery number picker in this program there are classes,methods,properties and fields.
 * i have revised the syllabus again and also watch the previous lecture to get some help.
 **/
    /**
     * <summary>
     * This class is a subclass of the LottoGame abstract superclass
     * </summary>
     * 
     * @class Lottario
     */
    public class Lottario : LottoGame, IGenerateLottoNumbers
    {
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public Lottario()
            : base(6, 45)
        {

        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {

            for (int i = 0; i < 6; i++)
            {
                this.PickElements();
                Console.Write($"Ticket   {i}= ");
                Console.WriteLine(ToString());
            }

        }
    }
}
