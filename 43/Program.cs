using System;
using System.Linq;

namespace _43
{
    class Program
    {
        static void Main(string[] args)
        {
            var testResult1 = Program.Multiply("3141592653589793238462643383279502884197169399375105820974944592", 
                "2718281828459045235360287471352662497757247093699959574966967627");
            //var testResult2 = Program.Multiply("0", "999");
            //var testResult3 = Program.Multiply("123456789987654321", "1");
            //var testResult4 = Program.Multiply("123456789", "12345678");
            System.Console.WriteLine(testResult1);
            //System.Console.WriteLine(testResult2);
            //System.Console.WriteLine(testResult3);
            //System.Console.WriteLine(testResult4);

        }
        public static string Subtract(string num1, string num2) {
            num1 = num1.TrimStart('0');
            num2 = num2.TrimStart('0');
            if(string.Empty.Equals(num2)) return num1;
            if(string.Empty.Equals(num1)) return "0";
            if(num1.Equals(num2)) return "0";

            num2 = num2.PadLeft(num1.Length, '0');
            var num1Array = num1.Select(c => c - '0').ToArray();
            var num2Array = num2.Select(c => c - '0').ToArray();

            for (int i = num1Array.Length - 1; i > -1; i--)
            {
                if (num1Array[i] >= num2Array[i])
                {
                    num1Array[i] = num1Array[i] - num2Array[i];
                } else {
                    num1Array[i] = 10 + num1Array[i] - num2Array[i];
                    num1Array[i - 1]--; 
                }
            }

            return string.Join(string.Empty, num1Array).TrimStart('0');
        }

        public static string Add(string num1, string num2) {
            num1 = num1.TrimStart('0');
            num2 = num2.TrimStart('0');
            if (string.Empty.Equals(num1) && string.Empty.Equals(num2)) return "0";
            if (string.Empty.Equals(num1)) return num2;
            if (string.Empty.Equals(num2)) return num1;

            if (num1.Length > num2.Length){
                num2 = num2.PadLeft(num1.Length, '0');
            }else{
                num1 = num1.PadLeft(num2.Length, '0');
            }
            var num1Array = num1.Select(c => c - '0').ToArray();
            var num2Array = num2.Select(c => c - '0').ToArray();

            for (int i = num1Array.Length - 1; i > -1; i--)
            {
                if (num1Array[i] + num2Array[i] >= 10){
                    if (i == 0){
                        num1Array[0] += num2Array[0];
                    }else{
                        num1Array[i] = num1Array[i] + num2Array[i] - 10;
                        num1Array[i-1]++;
                    }
                }else{
                    num1Array[i] += num2Array[i];
                }
            }
            return string.Join(string.Empty, num1Array);
        }

        public static string Multiply(string num1, string num2){
            num1 = num1.TrimStart('0');
            num2 = num2.TrimStart('0');
            // 0 * X or X * 0
            if (string.Empty.Equals(num1) || string.Empty.Equals(num2)) return "0";
            // 1 * X or X * 1
            if (num1.Equals("1")) return num2;
            if (num2.Equals("1")) return num1;
            // xx * xx
            if (num1.Length <= 2 && num2.Length <=2){
                return (int.Parse(num1) * int.Parse(num2)).ToString();
            }
            if (num1.Length > num2.Length){
                num2 = num2.PadLeft(num1.Length, '0');
            }else{
                num1 = num1.PadLeft(num2.Length, '0');
            }
            var a = num1.Substring(0, num1.Length/2);
            var b = num1.Substring(num1.Length/2);
            var c = num2.Substring(0, num2.Length/2);
            var d = num2.Substring(num2.Length/2);

            var result1 = Multiply(a,c);
            var result2 = Multiply(b,d);
            var result3 = Subtract(Subtract(Multiply(Add(a,b),Add(c,d)),result1),result2);

            result1 = result1.PadRight(((num1.Length - num1.Length/2) * 2 + result1.Length),'0');
            result3 = result3.PadRight((num1.Length - num1.Length/2 + result3.Length),'0');

            return Add(Add(result1, result3),result2);
        }
    }
}
