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

    Console.WriteLine("Enter 1 to register or 2 to browse as guest \n (Note: You can't order anything while browsing as a guest. You can onlu view our products list):");

    Determinant = Console.ReadLine();

    if(Determinant != "1" && Determinant != "2"){

        if(i == 9)
        {
        
            Console.WriteLine("Too many invalid tries.");

        }

        continue;
    } else {break;}



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

    // for(int i = 0; i < 10; i++)
    // {
        
    //     Console.WriteLine("Enter your username:");

    //     username = Console.ReadLine();

    // }

    int n_fr_u_id = username.Length;

    string user_id = username[0] + username[1] + n_fr_u_id.ToString();


    User user = new User(username, user_id, email, password);

    Console.WriteLine(user.GetUsername());
    Console.WriteLine(user.GetUser_id());
    Console.WriteLine(user.GetEmail());
    Console.WriteLine(user.GetPassword());

    // Console.WriteLine(username, user_id, email, password);

} else if(Determinant == "2")
{
    
    Console.WriteLine("Enjoy our product lists");

} else {Console.WriteLine("Registration/Browsing Cancelled");}