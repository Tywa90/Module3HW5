using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class Starter
    {
        public void Run()
        {
            Console.WriteLine(StringConcat().Result);
        }

        public async Task<string> ReadFile1()
        {
            string str1 = await File.ReadAllTextAsync("D:\\project\\a-level\\Module3HW5\\Threads\\Hello.txt");
            return str1;
        }

        public async Task<string> ReadFile2()
        {
            string str2 = await File.ReadAllTextAsync("D:\\project\\a-level\\Module3HW5\\Threads\\World.txt");
            return str2;
        }

        public async Task<string> StringConcat()
        {
            var list = new Task<string>[]
            {
                ReadFile1(),
                ReadFile2()
            };

            await Task.WhenAll(list);

            var result = string.Concat(list[0].Result, list[1].Result);
            return result;
        }
    }
}
