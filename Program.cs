namespace taskOne;


class Program
{
    static void Main(string[] args)
    {

/*1.soru----Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
 Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin
 Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
 */
         /*
        int n;
        int[]  arrN;
        Console.Write("Bir  positive tam sayı giriniz:");
        n=Convert.ToInt32(Console.ReadLine());
        arrN=new int[n];
        Console.WriteLine("\n"+n+"adet   tam sayı giriniz:");
        for(int i=0; i<n;   i++){
            Console.Write("\n"+(i+1)+". sayiyi giriniz:");
            arrN[i]=Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("Girdiğiniz çift tam sayılar:");
        foreach(var nmbr in arrN){
            if(nmbr%2==0){
                Console.WriteLine(nmbr);
            }
        } */ 



 /* 2-Soru:Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        
        Console.WriteLine("İki adet tam sayi giriniz.");
        Console.Write("n:");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.Write("m:");
        int m=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(n+" Adet tam sayi giriniz:");
        int[] arrn=new int[n];
        for(int i=0;    i<n;    i++){
            Console.WriteLine((i+1)+".Sayi:");
            arrn[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(m+"e tam bölünen sayilar:");
        foreach(var item in arrn){
            if(item%m==0){
                Console.WriteLine(item);
            }
        }
        */


/*3-Soru:Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n)
 Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        Console.WriteLine("1 adet tam sayi giriniz.");
        Console.Write("n:");
        int n=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(n+"adet kelime giriniz:");
        string[]  words=new string[n];
        for(int i=0;    i<n;    i++){
            words[i]=Console.ReadLine();          
        }
        Array.Reverse(words);
        foreach(var item in words){
            Console.WriteLine(item);
        }

*/ 
/*  Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
 Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/
        Console.WriteLine("Bir cümle giriniz:");
        string word;
        char w;
        word=Console.ReadLine();
        int wordsCount=1,charCount=0;
        bool isSpace;
        
        for(int i=0;    i<word.Length;  i++){
           w=Convert.ToChar(word.Substring(i,1));
           isSpace=w.Equals(' ');
           if(isSpace){
            wordsCount++;
           }else{
            charCount++;
           }
        }
        Console.WriteLine("Kelime sayısı:"+wordsCount);
        Console.WriteLine("Harf sayısı:"+charCount);
        



       

        
    }
}
