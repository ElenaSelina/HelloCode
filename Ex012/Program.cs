/*Скопировано из лекции, выдает ошибки */

string Metod4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i<count)
{
result = result + text;
i++;
}
return result;
}
string res = Metod4(10, “asdf”);
Console.WriteLine(res);
