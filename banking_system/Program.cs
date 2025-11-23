/*💡 Ιδέα προγράμματος: “Απλός Τραπεζικός Λογαριασμός”

Ο χρήστης έχει έναν λογαριασμό και μπορεί να κάνει:

1️⃣ Κατάθεση χρημάτων
2️⃣ Ανάληψη χρημάτων
3️⃣ Έλεγχο υπολοίπου
4️⃣ Έξοδο
kai elegxo pin */
decimal ipoloipo = 1000;
decimal katathesi(int poso)
{
    ipoloipo += poso;
    return ipoloipo;
}
decimal analipsi(int poso)
{
   if(poso > ipoloipo)
    {
        Console.WriteLine("Den iparxei ipoloipo");
    }
    else
    {
        ipoloipo -=poso;
    }
   return ipoloipo;
}

void emfanisiIpoloipou()
{
    Console.WriteLine($"To ipoloipo einai {ipoloipo}");
}

bool running = true;
Console.WriteLine("Dwse to pin sou: ");
int pin = int.Parse(Console.ReadLine());

if (pin == 1234)
{
    running = true;
}
else
{
    running = false;
}
    while (running)
    {
       Console.WriteLine("----MENU----");
    Console.WriteLine("1 --- Katathesi---");
    Console.WriteLine("2 --- Analipsi---");
    Console.WriteLine("3 --- Emfanisi Ipoloipou");
    Console.WriteLine("4 --- Eksodos");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("ti poso theleis na kaneis katathesi ? ");
            int poso = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"To ipoloipo einai: {katathesi(poso)}");
            break;

        case 2:
            Console.WriteLine("ti poso theleis na kaneis analipsi ? ");
            int poso2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"To ipoloipo einai: {analipsi(poso2)}");
            break;

        case 3:
            emfanisiIpoloipou();
            break;

        case 4:
            running = false;
            break;

        default:
            Console.WriteLine("Lathos epilogi");
            break;

    }








    }




