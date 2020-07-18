using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This class is a subclass of the LottoGame abstract superclass
     * </summary>
     * 
     * @class Lottario
     */
    public class Pick4 : LottoGame, IGenerateLottoNumbers
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
        public Pick4()
            : base(0, 9)
        {

        }
        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {

            for (int i = 0; i < 4; i++)
            {
                this.PickElements();
                Console.Write($"Ticket   {i}=  0 3  4 5");
                Console.WriteLine(ToString());
            }

        }
    }
}
