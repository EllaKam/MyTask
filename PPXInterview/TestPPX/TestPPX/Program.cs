using CustomerPPX;
using PPX_Pos;


namespace TestPPX
{
    class Program
    {
        static void Main(string[] args)
        {
            var Pos = new CustomerFactory().Create("Italy");
            POS_Process.Load(Pos);

        }
    }


}
