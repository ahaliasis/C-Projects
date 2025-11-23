Console.WriteLine("Posa proionta theleis na kataxwriseis? ");
int n = int.Parse(Console.ReadLine());

string[] products = new string[n];

int[] prices = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Dwse to onoma toy proiontos: {i + 1}");
    products[i] = Console.ReadLine();

    Console.WriteLine($"Dwse tin timi toy proiontos {products[i]}");
    prices[i] = int.Parse(Console.ReadLine());
}

bool running = true;

while (running)
{
    Console.WriteLine("1 -- Emfanisi olwn twn proiontwn kai tis times toys");
    Console.WriteLine("2 -- Ypologismos toy sinolikoy kostous");
    Console.WriteLine("3 -- Emfanisi toy akrivoterou proiontos");
    Console.WriteLine("4 -- Emfanisi toy fthinoteroy proiontos");
    Console.WriteLine("5 -- Eksodos");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Lista proiontwn");
                Console.WriteLine($"{products[i]} ---> {prices[i]} ");
            }
            break;

        case 2:
            int sum = 0;
            foreach (int price in prices)
            {
                sum += price;
            }
            Console.WriteLine($"To sinoliko kostos einai: {sum} $");

            break;
        case 3:
            int max = prices[0];
            string expensiveProduct = products[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > max)

                {
                    max = prices[i];
                    expensiveProduct = products[i];
                }

            }
            Console.WriteLine($"Akrivotero proion einai {expensiveProduct} me timi {max} ");
            break;
        case 4:
            int min = prices[0];
            string cheapestProduct = products[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                    cheapestProduct = products[i];
                }
            }
            Console.WriteLine($"Fthinotero proion einai {cheapestProduct} me timi {min}");
            break;
        case 5:
            Console.WriteLine("Exiting the programm...");
            running = false;
            break;

        default:
            Console.WriteLine("Lathos epilogi");
            break;


    }
    }