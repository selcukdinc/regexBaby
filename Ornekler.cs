using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression
{
    internal class Ornekler
    {
        public static void ornek1()
        {
            string Rgx1 = "^2", text1 = "201234"; string text2 = "024321";
            Regex r1 = new Regex($"{Rgx1}");
            Match m1 = r1.Match(text1), m2 = r1.Match(text2); 
            Console.WriteLine($"{Rgx1} ifadesi\n\ntext1 kontrol: {m1.Success}\ntext2 kontrol: {m2.Success}");

        }

        public static void ornek2()
        {
            string Rgx1 = "^9\\d\\S", text1 = "90 1234", text2 = "901234";
            Regex r1 = new Regex(@$"{Rgx1}");
            Match m1 = r1.Match(text1), m2 = r1.Match(text2);
            Console.WriteLine($"\\ Operatörü\n\n{Rgx1} ifadasi\n\n'{text1}' = {m1.Success}\n'{text2}' = {m2.Success}");

        }

        public static void ornek3()
        {
            string Rgx1 = "^9\\d+\\S$", text1 = "901234 ", text2 = "901234";
            Regex r1 = new Regex(@$"{Rgx1}");
            Match m1 = r1.Match(text1), m2 = r1.Match(text2);
            Console.WriteLine($"+ Operatörü\n\n{Rgx1} ifadesi \n\n'{text1}' = {m1.Success}\n'{text2}' = {m2.Success}");

        }

        public static void ornek4()
        {
            string Rgx1 = "^a|^b|^c", text1 = "Alfa", text2 = "Beta", text3 = "Cinamon", text4 = "Ro";
            Regex r1 = new Regex(@$"{Rgx1}", RegexOptions.IgnoreCase);
            Match m1 = r1.Match(text1), m2 = r1.Match(text2), m3 = r1.Match(text3), m4 = r1.Match(text4);
            Console.WriteLine($"| Operatörü \n\nBaş harfi a veya b veya c ile başlayan kelimeleri seç (büyük - küçük harfe dikkat etme)\n\n{Rgx1} ifadesine göre\n\n'{text1}' = {m1.Success}\n'{text2}' = {m2.Success}\n'{text3}' = {m3.Success}\n'{text4}' = {m4.Success}\n");

        }

        public static void ornek5()
        {
            string Rgx1 = "^\\d{3}-\\d{7}$", text1 = "507-7514592", text2 = "507-75145923";
            Regex r1 = new Regex(@$"{Rgx1}");
            Match m1 = r1.Match(text1), m2 = r1.Match(text2);
            Console.WriteLine($"{{n}} operatörü\n\n{Rgx1} ifadesi için\n\n'{text1}' = {m1.Success}\n'{text2}' = {m2.Success}");
        }

        public static void ornek6()
        {
            string Rgx1 = "\\d{3}B?A", Rgx2 = "^\\d{3}B?A", text1 = "957BA", text2 = "174BBA", text3 = "6583BA";
            Regex r1 = new Regex(@$"{Rgx1}", RegexOptions.IgnoreCase), r2 = new Regex(@$"{Rgx2}", RegexOptions.IgnoreCase);
            Match m11 = r1.Match(text1), m12 = r1.Match(text2), m13 = r1.Match(text3), m21 = r2.Match(text1), m22 = r2.Match(text2), m23 = r2.Match(text3);
            Console.WriteLine($"? operatörü\n\n{Rgx1} ifadesine göre\n\n'{text1}' = {m11.Success}\n'{text2}' = {m12.Success}\n'{text3}' = {m13.Success}\n\n{Rgx2} ifadesine göre\n\n'{text1}' = {m21.Success}\n'{text2}' = {m22.Success}\n'{text3}' = {m23.Success}\n");

        }
    }
}
