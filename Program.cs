using System.Security.Cryptography.X509Certificates;
using C__proj_2026;

Console.WriteLine("============================================================================================================================================================");
Console.WriteLine("============================================================================================================================================================");
Console.WriteLine("============================================================================================================================================================");
Console.WriteLine("                         000000000             0000              0000                         1000000                   00000");
Console.WriteLine("                        0000000000             0000              0000                     100         001               000  0000");
Console.WriteLine("                      0000                     0000              0000                   100             001             000        00");
Console.WriteLine("                     0000                      0000              0000                  100               001            000         00");
Console.WriteLine("                    0000                       0000              0000                 100                 001           000        00");  
Console.WriteLine("                   0000                        0000              0000                100                   001          000       00");
Console.WriteLine("                    0000                       0000              0000               100                     001         000  0000");
Console.WriteLine("                      0000                     0000000000000000000000               100                     001         00000");
Console.WriteLine("                        00000                  0000000000000000000000               100                     001         000"); 
Console.WriteLine("                            0000               0000              0000               100                     001         000");  
Console.WriteLine("                               000             0000              0000               100                     001         000");  
Console.WriteLine("                               000             0000              0000                100                   001          000"); 
Console.WriteLine("                               0000            0000              0000                 100                 001           000");  
Console.WriteLine("                             0000              0000              0000                   100              001            000"); 
Console.WriteLine("                          00000                0000              0000                    100            001             000");  
Console.WriteLine("                      0000000                  0000              0000                      100        001               000");   
Console.WriteLine("                 0000000                       0000              0000                          100000                   00");  
Console.WriteLine("============================================================================================================================================================");
Console.WriteLine("============================================================================================================================================================");
Console.WriteLine("============================================================================================================================================================");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("WELCOME TO OUR CONSOLE SHOP!!");
Console.WriteLine("");


string Determinant = "";

for (int i = 0; i < 10; i++){

    Console.WriteLine("Enter 1 to register or 2 to browse as guest \n (Note: You can't order anything while browsing as a guest. You can only view our products list):");

    Console.WriteLine("");

    Determinant = Console.ReadLine();

    if(Determinant != "1" && Determinant != "2"){

        if(i == 9)
        {
        
            Console.WriteLine("Too many invalid tries.");

        }

        Console.WriteLine("");

        Console.WriteLine("");

        continue;

    } else {

        Console.WriteLine("");

        Console.WriteLine("");
        
        break;

    }



}

if(Determinant == "1"){
    
    Console.WriteLine("Proceeding to register tab >>>>");

    Console.WriteLine(".");
    Console.WriteLine(".");
    Console.WriteLine(".");
    Console.WriteLine(">>>");
    Console.WriteLine("");
    Console.WriteLine("");


    Console.WriteLine("*** WELCOME TO OUR REGISTER TAB! ***");
    Console.WriteLine("");

    string email = "";

    for(int i = 0; i < 10; i++)
    {
        
        Console.WriteLine("Enter your email for registration: ");

        email = Console.ReadLine();

        if(
            (email.Contains("@gmail.com") && email.Length > 10 && email != " @gmail.com" )|| 
            (email.Contains("@yahoo.com") && email.Length > 10 && email != " @yahoo.com")||
            (email.Contains("@icloud.com") && email.Length > 11 && email != " @icloud.com")||
            (email.Contains("@outlook.com") && email.Length > 12 && email != " @outlook.com")
        )
        {
            
            Console.WriteLine("Email registered successfuly ✔️");

            Console.WriteLine("");

            Console.WriteLine("");

            break;

        } else {

            Console.WriteLine("Invalid email");

            if(i == 9)
            {
                
                Console.WriteLine("");

                Console.WriteLine("Too many invalid tries");

                Console.WriteLine("Registration cancelled");

                Environment.Exit(0);

            }

            Console.WriteLine("");

            Console.WriteLine("");

        }

    }

    string password = "";

    for(int i = 0; i < 10; i++)
    {
        
        Console.WriteLine("Enter your password: ");

        password = Console.ReadLine();

        if(password.Length < 8)
        {

            if(i == 9)
            {
            
                Console.WriteLine("Too many invalid tries.");

                Console.WriteLine("Registration cancelled");

                Environment.Exit(0);

            } else{

                Console.WriteLine("Password must be up to 8 characters");

                Console.WriteLine("");

                Console.WriteLine("");

            }

        } else
        {
            
            Console.WriteLine("Confirm your password to continue:");

            string c_password = Console.ReadLine();

            if(c_password != password)
            {

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("Passswords don't match!!");

                Console.WriteLine("");

                Console.WriteLine("Ooops, you're going to have to restart the password registration process, due to password verification issues. \n (Please use a password you can easily remember.)");

                Console.WriteLine("");

                Console.WriteLine("");
                
            } else
            {
                
                Console.WriteLine("Password verification successful");

                Console.WriteLine("");

                Console.WriteLine("");

                break;

            }

        }

    }

    Console.WriteLine("*✔️* REGISTRATIONN SUCCESSFULL!!! *✔️*");

    Console.WriteLine("");

    Console.WriteLine("Congratulations ⭐️. \n You're done with the hard part. Now all you need to do is create your username");

    Console.WriteLine("");

    Console.WriteLine("Enter your username:");

    string username = Console.ReadLine();

    Console.WriteLine("");

    Console.WriteLine("");

    Console.WriteLine("");

    while(username.Length < 1 || username.Trim() == "")
    {

        Console.WriteLine("Invalid username 👎❌");

        Console.WriteLine("");

        Console.WriteLine("");
        
        if(username.Length < 1)
        {
            
            Console.WriteLine("Username must be up to a character (letter)!!!");

            Console.WriteLine("");

        }
        else
        {
            
            Console.WriteLine("Username must consist of characters (letters). Username can not contain ony white spaces");

            Console.WriteLine("");

        }

        Console.WriteLine("Enter a valid username to continue:");

        username = Console.ReadLine();

    }

    int n_fr_u_id = username.Length;

    string user_id = $"{username[0] + username[1] + n_fr_u_id.ToString()}";

    bool isLoggedIn = true;


    User user = new User(username, user_id, email, password);

    Console.WriteLine($"You are welcome to our console-based-shop {user.GetUsername()}");

    Console.WriteLine("");

    // Console.WriteLine(user.GetUser_id());      WORK ON THE USER ID!!!!!!!!

    Console.WriteLine("");

    Console.WriteLine($"Enjoy our products {user.GetUsername()} \n There's a lot to see 😁👍\n \n We hope you find what you are looking for");

    Console.WriteLine("");

    Products_list products_List = new Products_list();

    while(isLoggedIn){

        Console.WriteLine("Enter 1 to search for an item \n Enter 2 to 'Product surf' 😁 \n Enter 3 to view your profile");

        Console.WriteLine("");

        Console.WriteLine("");

        Console.WriteLine("");

        string i_a_d = Console.ReadLine();

        while (i_a_d != "1" && i_a_d != "2" && i_a_d != "3")
        {

            Console.WriteLine("Invalid input");

            Console.WriteLine("");

            Console.WriteLine("Enter 1 to search for an item \n \nEnter 2 to 'Product surf' \n \nEnter 3 to view your profile");

            i_a_d = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("");

            Console.WriteLine("");

        }

        if(i_a_d == "1")
        {
            
            Console.WriteLine($"Enter the name of the product you seek {user.GetUsername()}");

            string P_S_C = Console.ReadLine();

            while(P_S_C.Trim() == "")
            {
                
                Console.WriteLine("Ooops!!! You didn't enter a search category. \nPlease enter the name of the product you are looking for:");

                Console.WriteLine("");

                P_S_C = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("");

            }

            Console.WriteLine($"Here are the results for {P_S_C} {user.GetUsername()}");

            Console.WriteLine("");

            Console.WriteLine("");

            Console.WriteLine("============================================================================================================================================================");
            Console.WriteLine("============================================================================================================================================================");
            Console.WriteLine("============================================================================================================================================================");
            Console.WriteLine("                         000000000             0000              0000                         1000000                   00000");
            Console.WriteLine("                        0000000000             0000              0000                     100         001               000  0000");
            Console.WriteLine("                      0000                     0000              0000                   100             001             000        00");
            Console.WriteLine("                     0000                      0000              0000                  100               001            000         00");
            Console.WriteLine("                    0000                       0000              0000                 100                 001           000        00");  
            Console.WriteLine("                   0000                        0000              0000                100                   001          000       00");
            Console.WriteLine("                    0000                       0000              0000               100                     001         000  0000");
            Console.WriteLine("                      0000                     0000000000000000000000               100                     001         00000");
            Console.WriteLine("                        00000                  0000000000000000000000               100                     001         000"); 
            Console.WriteLine("                            0000               0000              0000               100                     001         000");  
            Console.WriteLine("                               000             0000              0000               100                     001         000");  
            Console.WriteLine("                               000             0000              0000                100                   001          000"); 
            Console.WriteLine("                               0000            0000              0000                 100                 001           000");  
            Console.WriteLine("                             0000              0000              0000                   100              001            000"); 
            Console.WriteLine("                          00000                0000              0000                    100            001             000");  
            Console.WriteLine("                      0000000                  0000              0000                      100        001               000");   
            Console.WriteLine("                 0000000                       0000              0000                          100000                   00");  
            Console.WriteLine("============================================================================================================================================================");
            Console.WriteLine("============================================================================================================================================================");
            Console.WriteLine("============================================================================================================================================================");
            
            for (int i = 0; i < products_List.products.Length; i++)
            {

                if (products_List.products[i].GetProduct_category().Contains(P_S_C.ToLower()))
                {

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine("***********************************************************************************************************************************************************");
                    
                    Console.WriteLine("***********************************************************************************************************************************************************");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine($"          ================  {products_List.products[i].GetProduct_name()}  ================");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine(products_List.products[i].GetProduct_description());

                    Console.WriteLine("");

                    Console.WriteLine($"Price: ${products_List.products[i].GetProduct_price()}");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    string rating_stars = "";

                    for(int r_c = 0; r_c < products_List.products[i].GetProduct_rating(); r_c++)
                    {

                        rating_stars += "⭐️";

                    }

                    Console.WriteLine($"          ================  Rating: {rating_stars}  ================");

                    Console.WriteLine("");

                    string cont = "";

                    while(cont != "1" && cont != "2" && cont != "3")
                    {

                        Console.WriteLine("");

                        Console.WriteLine("");                        

                        Console.WriteLine("Enter 1 to move on to the next product \n \nEnter 2 to add to cart \n \nEnter 3 to exit product search");

                        Console.WriteLine("");

                        Console.WriteLine("");   

                        cont = Console.ReadLine();


                    }

                    if(cont == "1")
                    {
                        
                        continue;

                    } else if(cont == "2")
                    {
                        
                        Cart cart = new Cart();

                        cart.SetCart(products_List.products[i]);

                        Console.WriteLine("");

                        Console.WriteLine("");

                        Console.WriteLine("Product added to cart successfully ✔️✨");

                    } else{
                        
                        Console.WriteLine("");

                        Console.WriteLine("");

                        Console.WriteLine("");

                        Console.WriteLine("");

                        Console.WriteLine("");

                        Console.WriteLine("");
                        
                        break;

                    }

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine("***********************************************************************************************************************************************************");

                    Console.WriteLine("***********************************************************************************************************************************************************");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine("");

                    Console.WriteLine("");

                }

            }

        }

    }


} else if(Determinant == "2")
{
    
    Console.WriteLine("Enjoy our product lists");

} else {Console.WriteLine("Registration/Browsing Cancelled");}