
Console.WriteLine("posous mathites exei i taksi? ");
int n = int.Parse(Console.ReadLine());

string[] onomataMathitwn = new string[n];

int[] vathmos = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Dwse onoma {i + 1}");
    onomataMathitwn[i] = Console.ReadLine();
}
for (int i = 0;i < n; i++)
{
    Console.WriteLine($"Dwse vathmo gia {onomataMathitwn[i]}");
    vathmos[i] = int.Parse(Console.ReadLine());
}
void average()
{
    int sum = 0;
    decimal average = 0;
    foreach(int grade in vathmos)
    {
        sum += grade;
        average = sum / vathmos.Length;
    }
    Console.WriteLine($"O mesos oros tis taksis einai: {average}");
}
void kaliterosMathitis()
{
    int max = vathmos[0];
    string bestStudent = onomataMathitwn[0];
    for(int i = 0; i < vathmos.Length; i++)
    {
        if (vathmos[i] > max){
            max = vathmos[i];
            bestStudent = onomataMathitwn[i];

    }
       
    }
    Console.WriteLine($"Kaliteros mathitis einai: {bestStudent} me vathmo {max}");
}
void xeiroterosMathitis()
{
    int min = vathmos[0];
    string worstStudent = onomataMathitwn[0];
    for (int i = 0; i < vathmos.Length; i++)
    {
        if (vathmos[i] < min)
        {
            min = vathmos[i];
            worstStudent = onomataMathitwn[i];
        }
       

    }
    Console.WriteLine($"Xeritoeros mathitis einai: {worstStudent}");
}

void epitixia()
{

    string epitixontes = "";
    for (int i = 0; i < vathmos.Length; i++)
    {
        if (vathmos[i] >= 10)
        {
            epitixontes += onomataMathitwn[i] + " ";
        }

    }
    Console.WriteLine($"Ta paidia poy perasan einai {epitixontes}");
}

bool running = true;
while (running)
{
    Console.WriteLine("1 -- Deikse olous tous mathites");
    Console.WriteLine("2 -- Deikse ton meso oro tis taksis");
    Console.WriteLine("3 -- Deikse ton kalitero mathiti");
    Console.WriteLine("4 -- Deikse ton xeirotero mathiti");
    Console.WriteLine("5 -- Deiske poioi perasan");
    Console.WriteLine("6 -- Eksodos");
    int epilogi = int.Parse(Console.ReadLine());

    switch (epilogi)
    {
        case 1: 

            foreach(string name in onomataMathitwn)
            {
            Console.WriteLine(name); 
            }
            break;
        case 2 :
            average();
            break;
        case 3:
            kaliterosMathitis();
            break;
        case 4 :
            xeiroterosMathitis();
            break;
        case 5 :
            epitixia();
            break;

        case 6 :
            running = false;
            break;
        default:
            Console.WriteLine("Lathos epilogi");
            break;
    }


 
}