namespace Converter
{

    class App
    {

        private static void Main(string[] args)
        {
            if(args.Length == 0)
            {

                Console.WriteLine("Enter Hex: ");
                int colorR = Convert.ToInt16(Console.ReadLine());

                string colorCode = createConvert(colorR);

                Console.Write(colorCode);
                Console.Write(colorCode);
                Console.Write(colorCode);
            }

            Console.ReadKey();



        }

        private static string createConvert(int a)
        {
            return Convert.ToString(a, 16);
        }

        

    }
    
}