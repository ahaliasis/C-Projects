Console.WriteLine("Posous vathmous theleis na eisageis? ");
int n = int.Parse(Console.ReadLine());

int[] pinakasArithmwn = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Dwse arithmo: {i + 1}");
    pinakasArithmwn[i] = int.Parse(Console.ReadLine());

    

}
bool running = true;

while (running)
{
    Console.WriteLine("1 -- Emfanise tous arithmous me taksinomisi");
    Console.WriteLine("2 -- Emfanise ton meso oro twn arithmwn");
    Console.WriteLine("3 -- Emfanise ton megalitero arithmo");
    Console.WriteLine("4 -- Emfanise ton mikrotero arithmo");
    Console.WriteLine("5 -- Eksodos");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:

            for (int i = 0; i < pinakasArithmwn.Length; i++) { 
            Array.Sort(pinakasArithmwn);
            Console.WriteLine(pinakasArithmwn[i]);
    }
            break;

        case 2:
            int sum = 0;
            decimal avg = 0;

        for (int i = 0;i < pinakasArithmwn.Length; i++)
            {
                sum += pinakasArithmwn[i];
                avg = sum / pinakasArithmwn.Length;
            }
            Console.WriteLine($"O mesos oros einai: {avg}");
            break;

        case 3:
            int max = pinakasArithmwn[0];

            for (int i = 0; i < pinakasArithmwn.Length; i++)
            {
                if (pinakasArithmwn[i] > max)
                {
                    max = pinakasArithmwn[i];

                }
                
                
            }
            Console.WriteLine($"Megaliteros arithmos einai: {max}");
            break;

        case 4:
            int min = pinakasArithmwn[0];

            for(int i = 0;i< pinakasArithmwn.Length;i++)
            {
                if (pinakasArithmwn[i]<min)
                {
                    min = pinakasArithmwn[i];
                }
            }
            Console.WriteLine($"Mikroteros arithmos einai: {min}");

            break;

         case 5:
          running = false;
            break;

        default:
            Console.WriteLine("Lathos epilogi");
            break;
    
    
    }

}