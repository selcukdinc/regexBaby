using System.Text.RegularExpressions;
namespace Regular_Expression
{
    internal class Program
    {

        

        
        static void Main(string[] args)
        {
            #region Giriş
            /*  
             *  Regular Expressions nedir? DÜZENLİ İFADELER
             *  regex101.com
             *      String değerleri bir algoritmaya kıyasla çok daha efektif bir şekilde kontrol etmemize yarar, yazım açısından tek bir satırda 10'larca 
             *      algoritma satırlarına denk verimlilik sağlar. yazım dili kaba ve gelecekte gelen özellikler ile ömür törpüsü olduğu duyumunu aldım, 
             *      şimdiden rez alalım...
             */
            #endregion
            #region Bölüm - 1 Operatörler
            /*  
             *  Bölüm - 1 Operatörler (～￣▽￣)～
             */
            #region ^ Operatörü, ornek1
            /*
            *  🧠   ^ operatörü: İfadenin ilk karakterini kontrol eder ve
            *     ^2 şeklinde kullanılırsa kontrol edilecek değerin ilk karakteri 2 ise geriye True değilse False değeri dödürür
            *  
            */

            /* 
             * text1 ve text2 değişkenleri için 02 olması çok şey ifade eder, ilk karakter kontrol operatörü olduğu için text2 için false
             * değeri döndürür
            */
            //// ❤️ ornek1 ile tekrar çağrılabilir
            //string Rgx1 = "^2", text1 = "201234"; string text2 = "024321";
            //Regex r1 = new Regex($"{Rgx1}");
            //Match m1 = r1.Match(text1), m2 = r1.Match(text2); // bir kontrol ifadesini iki farklı metine iki farkı Match nesnesi tanımlayarak kullandım OOP sağolsun (◔◡◔)
            //Console.WriteLine($"{Rgx1} ifadesi\n\ntext1 kontrol: {m1.Success}\ntext2 kontrol: {m2.Success}");

            #endregion
            #region \ Operatörü, ornek2
            /*
             * 🧠    
             * \ operatörü: belirli karakter gruplarını içermesini istiyorsak kullanırız
             * 
             * \D   : Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiği belirtilir
             * \d   : Metinsel değerin ilgili yerinde 0 - 9 arasında tek bir sayı olacağı ifade edilir.
             * 
             * \W   : Metinsel değerin ilgili yerinde alfanümerik olmayan karakterin olması gerektiği belirtilir. 
             *                          (Alfanümerik karakterler: a-z A-Z 0-9)
             * \w   : Metinsel değerin ilgili yerinde alfanümerik olan karakterin olacağı belirtlir.
             * 
             * \S   : Metinsel değerin ilgili yerinde boşluk karakterleri (tab veya space) dışında herhangi bir karakterin olamayacağını belirtlir
             * \s   : Metinsel değerin ilgili yerinde sadece boşuk karakterin olacağı ifade edilir.
             */

            //// ❤️ ornek2 ile tekrar çağrılabilir 
            // 9 ile başlayan, ikinci karakteri herhangi bir sayı olan ve 3 karakteride boşluk olmayan bir düzenli ifade yazın.
            //string Rgx1 = "^9\\d\\S", text1 = "90 1234", text2 = "901234";
            //Regex r1 = new Regex(@$"{Rgx1}");
            //Match m1 = r1.Match(text1), m2 = r1.Match(text2);
            //Console.WriteLine($"\\ Operatörü\n\n{Rgx1} ifadasi\n\n'{text1}' = {m1.Success}\n'{text2}' = {m2.Success}");

            #endregion
            #region + Operatörü, ornek3
            /*
             * 🧠
             * + operatörü: Aritmetik bir işlevi yoktur, regex'de kullanımı kendisinden önceki ifade veya grubun tekrarlanması görevini üstlenmektedir.
             * @"(4|dört)+" ifadesi bize tekrarlanan ifadeleri verir.
             * 
             */

            //// ❤️ ornek3 ile tekrar çağrılabilir 
            // 9 ile başlayan, arada herhangi bir sayısal değeri olan ve son karakteride boşluk olmayan bir düzenli ifade yazın.
            //string Rgx1 = "^9\\d+\\S$", text1 = "901234 ", text2 = "901234";
            //Regex r1 = new Regex(@$"{Rgx1}");
            //Match m1 = r1.Match(text1), m2 = r1.Match(text2);
            //Console.WriteLine($"+ Operatörü\n\n{Rgx1} ifadesi \n\n'{text1}' = {m1.Success}\n'{text2}' = {m2.Success}");

            #endregion
            #region | Operatörü, ornek4
            /*
             * 🧠
             * | operatörü: Birden fazla karakter grbundan bir ya da bir kaçının ilgili yerde olabileceğini 
             * belertmek istiyorsak mantıksal "veya" operatörü kullanılır.
             * ornek4 ile tekrar çağrılabilir
             */

            // harfi a yada b yada c olan metinsel ifadeyi girelim.
            //string Rgx1 = "^a|^b|^c", text1 = "Alfa", text2 = "Beta", text3 = "Cinamon", text4 = "Ro";
            //Regex r1 = new Regex(@$"{Rgx1}", RegexOptions.IgnoreCase);
            //Match m1 = r1.Match(text1), m2 = r1.Match(text2), m3 = r1.Match(text3), m4 = r1.Match(text4);
            //Console.WriteLine($"| Operatörü \n\nBaş harfi a veya b veya c ile başlayan kelimeleri seç (büyük - küçük harfe dikkat etme)\n\n{Rgx1} ifadesine göre\n\n'{text1}' = {m1.Success}\n'{text2}' = {m2.Success}\n'{text3}' = {m3.Success}\n'{text4}' = {m4.Success}\n");

            #endregion
            #region {n} Operatörü, ornek5
            /*
             * 🧠
             * {n} operatörü: Sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmeli
             * ornek5 ile tekrar çağrılabilir
             * 507-7514592
             * bu telefon numarasını düzenli ifade edelim
             */
            //string Rgx1 = "^\\d{3}-\\d{7}$", text1 = "507-7514592", text2 = "507-75145923";
            //Regex r1 = new Regex(@$"{Rgx1}");
            //Match m1 = r1.Match(text1), m2 = r1.Match(text2);
            //Console.WriteLine($"{{n}} operatörü\n\n{Rgx1} ifadesi için\n\n'{text1}' = {m1.Success}\n'{text2}' = {m2.Success}");

            #endregion
            #region ? Operatörü, ornek6
            /*
             * 🧠
             * ? Operatörü: bu karakterin önüne gelen karakter en fazla bir en az sıfır defa olabilmektedir. 
             * Aynı ifadeden 1'den fazla varsa o zaman .Match(text) dediğimizde false değer döndürür.
             * 
             * \d{3}B?A     --->  957BA,    174BBA,     6583BA
             * eğer 3. patterne bakarsak 4 adet sayı var fakat biz \d{3} yapmıştık, başlangıç belirtmediğimiz için
             * bu değerde true döndürür ifademizi ^\d{3}B?A şeklinde değiştirirsek 3. patternde de false değeri döndürülür.
             */

            //string Rgx1 = "\\d{3}B?A", Rgx2 = "^\\d{3}B?A", text1 = "957BA", text2 = "174BBA", text3 = "6583BA";
            //Regex r1 = new Regex(@$"{Rgx1}", RegexOptions.IgnoreCase), r2 = new Regex(@$"{Rgx2}", RegexOptions.IgnoreCase);
            //Match m11 = r1.Match(text1), m12 = r1.Match(text2), m13 = r1.Match(text3), m21 = r2.Match(text1), m22 = r2.Match(text2), m23 = r2.Match(text3);
            //Console.WriteLine($"? operatörü\n\n{Rgx1} ifadesine göre\n\n'{text1}' = {m11.Success}\n'{text2}' = {m12.Success}\n'{text3}' = {m13.Success}\n\n{Rgx2} ifadesine göre\n\n'{text1}' = {m21.Success}\n'{text2}' = {m22.Success}\n'{text3}' = {m23.Success}\n");

            #endregion
            #endregion
            Console.ReadKey();

        }
    }
}
