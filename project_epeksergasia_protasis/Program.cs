Console.WriteLine("Dwse moy mia protasi: ");
string protasi = Console.ReadLine();

string[] splitProtasi = protasi.Split(' ');

int count = 0;
foreach (string s in splitProtasi)
{
    count++;
}
Console.WriteLine($"H protasi exei : {count} lekseis");
int maxLength = 0;
string megaliteriLeksi = splitProtasi[0];
foreach (string s in splitProtasi)
{
     maxLength = 0;
     megaliteriLeksi = splitProtasi[0];
    if(s.Length > maxLength)
    {
        maxLength = s.Length;
        megaliteriLeksi = s;
    }

}
Console.WriteLine($"Megaliteri leksi einai: {megaliteriLeksi}");
  
Console.WriteLine("Oi lekseis me taksinomisi einai");
Array.Sort(splitProtasi);
foreach (string s in splitProtasi)
{
   
    Console.WriteLine(s);
}


