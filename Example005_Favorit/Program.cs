Console.Write("Давай знакомиться! Введи свое имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "марго")
{
    Console.Write("Ура, это же Марго!!!"); 
}
else
{
    Console.Write("Привет,  "); 
    Console.Write(username);
}



