using System;

namespace DesignPatterns
{
    public static class ExecutionObservable
    {
        public static void Execute()
        {
            Observer joao = new Observer("João");
            Observer eduardo = new Observer("Eduardo");
            Observer bill = new Observer("Bill");

            BovespaPaper amazon = new BovespaPaper("Amazon", NextDecimal());
            BovespaPaper microsoft = new BovespaPaper("Microsoft", NextDecimal());

            amazon.Subscribe(joao);
            amazon.Subscribe(eduardo);

            microsoft.Subscribe(eduardo);
            microsoft.Subscribe(bill);

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Value = NextDecimal();
                microsoft.Value = NextDecimal();

                if (i == 1)
                {
                    amazon.UnSubscribe(eduardo);
                }
            }
        }

        public static decimal NextDecimal()
        {
            Random random = new Random();
            int r = random.Next(141421, 314160);
            return r / (decimal)100000.00;
        }
    }
}