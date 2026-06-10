using TShirtShop.AbstractFactory;
using TShirtShop.Decorator;
using TShirtShop.Models;
using TShirtShop.Observer;
using TShirtShop.Singleton;

namespace TShirtShop;

class Program
{
    static void Main(String[] args)
    {
        Console.Clear();
        System.Console.WriteLine("═══════════════════════════════════════");
        System.Console.WriteLine("          T-Shirt Shop System          ");
        System.Console.WriteLine("═══════════════════════════════════════");
        System.Console.WriteLine();
    
        StartShopping();
    }

    static void StartShopping()
    {
        SalesTracker tracker = SalesTracker.Instance;
        ShopOwner owner = new ShopOwner("Moataz");
        tracker.RegisterObserver(owner);

        Order order = Order.Instance;

        while(true)
        {
            Loading();

            TShirtFactory? factory = SelectRegion();
            if(factory is null)
                break;
            Loading();

            TShirt? tshirt = SelectSize(factory);
            if(tshirt is null)
                break;
            Loading();

            tshirt = AddExtension(tshirt);
            Loading();
            
            FinishOrder(order, tshirt);
            System.Console.WriteLine();
            
            System.Console.WriteLine("[1] Continue...\n[0] Exit\n");
            retry:
            System.Console.Write("> ");
            char choice = Console.ReadKey().KeyChar;
            System.Console.WriteLine();

            if(choice == '0')
                break;
            else if (choice =='1')
            {
                continue;
            }
            else
                goto retry;
        }

        Loading();

        System.Console.WriteLine("📊 Final Sales Report");
        owner.PrintReport();
    }

    static TShirtFactory? SelectRegion(){
        System.Console.WriteLine("Select your region:");
        System.Console.WriteLine("[1] Middle East\n[2] China\n[3] Asia\n[0] Exit");
        
        retry:
        System.Console.Write("\n> ");
        char choice = Console.ReadKey().KeyChar;
        System.Console.WriteLine();

        TShirtFactory factory;

        switch(choice)
        {
            case '1': factory = new MiddleEastFactory();break;
            case '2': factory = new ChinaFactory();break;
            case '3': factory = new AsiaFactory();break;
            case '0': return null;
            default: goto retry;
        }

        return factory;
    }

    static TShirt? SelectSize(TShirtFactory factory)
    {
        System.Console.WriteLine("Select your size:");
        System.Console.WriteLine("[1] Small\n[2] Medium\n[3] Large\n[0] Exit");
        
        retry:
        System.Console.Write("\n> ");
        char choice = Console.ReadKey().KeyChar;
        System.Console.WriteLine();

        TShirt tshirt;

        switch(choice)
        {
            case '1': tshirt = factory.CreateSmall();break;
            case '2': tshirt = factory.CreateMedium();break;
            case '3': tshirt = factory.CreateLarge();break;
            case '0': return null;
            default: goto retry;
        }

        return tshirt;
    }

    static TShirt AddExtension(TShirt tshirt)
    {
        System.Console.WriteLine("Add features (enter 0 when done):");
        System.Console.WriteLine("[1] Bird Logo\n[2] Text \"Nice Day!\"\n[3] Red Color\n[4] Blue Color\n[0] Done");
              
        bool shouldExit = false;
        bool[] selectedChooices = {false, false, false, false};

        while(!shouldExit)
        {
            // retry:
            System.Console.Write("\n> ");
            char choice = Console.ReadKey().KeyChar;
            System.Console.WriteLine();

            switch(choice)
            {
                case '1':
                    if(!selectedChooices[0])
                    {
                        tshirt = new LogoDecorator(tshirt);
                        System.Console.WriteLine("\n✅ Bird Logo added!");
                        selectedChooices[0] = true;   
                    }
                    else
                        System.Console.WriteLine("\n❌ This extension has been selected before");
                    break;
                case '2': 
                    if(!selectedChooices[1])
                    {
                        tshirt = new TextDecorator(tshirt);
                        System.Console.WriteLine("\n✅ Text \"Nice Day!\" added!");
                        selectedChooices[1] = true;
                    }
                    else
                        System.Console.WriteLine("\n❌ This extension has been selected before");
                    break;
                case '3': 
                    if(!selectedChooices[2])
                    {
                        tshirt = new RedColorDecorator(tshirt);
                        System.Console.WriteLine("\n✅ Red Color added!");
                        selectedChooices[2] = true;
                    }
                    else
                        System.Console.WriteLine("\n❌ This extension has been selected before");
                    break;
                case '4': 
                    if(!selectedChooices[3])
                    {
                        tshirt = new BlueColorDecorator(tshirt);
                        System.Console.WriteLine("\n✅ Blue Color added!");
                        selectedChooices[3] = true;
                    }
                    else
                        System.Console.WriteLine("\n❌ This extension has been selected before");
                    break;
                case '0': 
                    shouldExit = true;
                    break;
            }
        }

        return tshirt;
    }

    static void FinishOrder(Order order, TShirt tshirt)
    {
        System.Console.WriteLine("Your Order:");

        order.PlaceOrder(tshirt);

        System.Console.WriteLine("[1] Confirm Order\n[2] Cancel");
        
        retry:
        System.Console.Write("\n> ");
        char choice = Console.ReadKey().KeyChar;
        System.Console.WriteLine();
        System.Console.WriteLine();
        Loading();

        switch(choice)
        {
            case '1': 
                order.CompleteOrder();
                System.Console.WriteLine("\n✅ Order placed successfully!");
                break;
            case '2':
                return;
            
            default: goto retry;
        }

        System.Console.WriteLine("\n\n═══════════════════════════════════════");
    }

    static void Loading()
    {
        System.Console.WriteLine();
        Thread.Sleep(400);
        System.Console.Write(". ");
        Thread.Sleep(400);
        System.Console.Write(". ");
        Thread.Sleep(400);
        System.Console.WriteLine(".    ");
        Thread.Sleep(400);
        Console.Clear();
    }

}

