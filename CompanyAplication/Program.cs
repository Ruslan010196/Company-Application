// See https://aka.ms/new-console-template for more information
using CompanyAplication.Helper;

Helper.ChangeTextColor(ConsoleColor.DarkRed, "CompanyAplication");
Helper.ChangeTextColor(ConsoleColor.Blue, "Enter number:"+
    "1.CreateEmployee 2.GetAllEmployee 0.ExitMenu");

EnterMenu: string menu =Console.ReadLine();
bool result=int.TryParse(menu, out int intMenu);
while(true)
if (result&&intMenu>0&&intMenu<3)
{


}
else if (intMenu == 0)
{
        Helper.ChangeTextColor(ConsoleColor.Yellow, "Bye Bye");
        break;
}
else
{
    Helper.ChangeTextColor(ConsoleColor.Yellow, "Duzgun eded daxil et");
        goto EnterMenu;

}