Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() =="маша") //позволяет перевести все буквы в нижний регистр
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}