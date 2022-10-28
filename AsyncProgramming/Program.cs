using System;
using System.Threading.Tasks;

namespace asyncprogramming
{
    internal class Bacon { }
    internal class Coffee { }
    internal class Egg { }
    internal class Juice { }
    internal class Toast { }

    class Program
    {
        static async Task Main(string[] args)
        {
            Coffee coffee = PureCoffee();
            Console.WriteLine("coffee is ready");

            Egg egg = await FryEggsAsync(2);
            Console.WriteLine("Egg is ready");

            Bacon bacon = await FryBaconAsync(3);
            Console.WriteLine("Bacon is ready");

            Toast toast = await ToastBreadAsync(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("Toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("OJ is ready");
            Console.WriteLine("Breakfast is ready");
        }

        private static Task<Toast> ToastBreadAsync(int slices)
        {
            Console.WriteLine("Put bread on the toaster");
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine($"Start toasting {slice} slice of bread in the toaster");
                Task.Delay(1000).Wait();
            }
            Console.WriteLine("Take out bread from the toaster");

            return Task.FromResult(new Toast());
        }

        private static Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"Put {slices} slices of bacon in the pan");
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine($"cook {slice} slice");
                Task.Delay(1000).Wait();
            }
            Console.WriteLine("Put bacon on the plate");

            return Task.FromResult(new Bacon());
        }

        private static Task<Egg> FryEggsAsync(int eggs)
        {
            Console.WriteLine("Warming the egg pan");
            Task.Delay(1000).Wait();
            Console.WriteLine($"Cracking {eggs} eggs");
            Console.WriteLine("Cooking the eggs");
            Task.Delay(1000).Wait();
            Console.WriteLine("Put eggs on the plate");

            return Task.FromResult(new Egg());
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring Orange Juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) => Console.WriteLine("Apply jam on the toast");

        private static void ApplyButter(Toast toast) => Console.WriteLine("Apply butter on the toast");

        private static Toast ToastBread(int slices)
        {
            Console.WriteLine("Put bread on the toaster");
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine($"Start toasting {slice} slice of bread in the toaster");
                Task.Delay(1000).Wait();
            }
            Console.WriteLine("Take out bread from the toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"Put {slices} slices of bacon in the pan");
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine($"cook {slice} slice");
                Task.Delay(1000).Wait();
            }
            Console.WriteLine("Put bacon on the plate");

            return new Bacon();
        }

        private static Egg FryEggs(int number)
        {
            Console.WriteLine("Warming the egg pan");
            Task.Delay(1000).Wait();
            Console.WriteLine($"Cracking {number} eggs");
            Console.WriteLine("Cooking the eggs");
            Task.Delay(1000).Wait();
            Console.WriteLine("Put eggs on the plate");

            return new Egg();
        }

        private static Coffee PureCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}