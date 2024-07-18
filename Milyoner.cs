byte dogruCevap = 0;

Console.WriteLine("Kızınca tüküren hayvan hangisidir ?\na) Lama b) Deve");

if (Console.ReadLine() == "a")
{
    dogruCevap++;
    Console.WriteLine("Tebrikler! verdiğiniz cevap doğru, 2. sorunuz geliyor!"); 
} 
else Console.WriteLine("Maalesef verdiğiniz cevap yanlış, 2. sorunuz geliyor!");

Console.WriteLine("\nDünya'ya en yakın gezegen hangisidir ?\na) Venüs b) Mars");

if (Console.ReadLine() == "a")
{
    dogruCevap++;
    Console.WriteLine("Tebrikler! verdiğiniz cevap doğru, 3. sorunuz geliyor!");
}
//Burada 2 soruyu da yanlış cevapladığı durum için kontrol yapılıyor
else if (dogruCevap==0)
{
    Console.WriteLine("Maalesef verdiğiniz cevap yanlış, 2 soruya da yanlış cevap verdiğiniz için yarışmadan elendiniz.");
} 
else Console.WriteLine("Maalesef verdiğiniz cevap yanlış, 3. sorunuz geliyor!");

//Doğru cevap sayısı 1 veya 2 ise 3. soruyu getiriyor
if (dogruCevap >= 1)
{
    Console.WriteLine("\n5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?\na) 7 b) 12");
    if (Console.ReadLine() == "b")
    {
        dogruCevap++;
        Console.WriteLine($"Tebrikler! {dogruCevap} soruya doğru cevap vererek 1 Milyon TL'lik büyük ödülü kazandınız!");
    }
    else Console.WriteLine("Maalesef 3 sorudan 2 tanesine yanlış cevap verdiğiniz için yarışmadan elendiniz.");
}

