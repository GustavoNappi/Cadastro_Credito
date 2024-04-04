// See https://aka.ms/new-console-template for more information

//Abertura
Console.WriteLine("||CADASTRO DE CARTÃO DE CREDITO BEAR EXPRESS||");
Console.WriteLine("||Gustavo Souza Nappi||");
Console.WriteLine("||PROGRAMA FEITO EM C#(2024)||");



//Vars/input
Console.Write("\n Insira sua idade: ");
int age = Convert.ToInt32(Console.ReadLine());


Console.Write("\n Escreva seu nome: ");
string nome = Console.ReadLine();

//Condição dos nomes
if (nome == "")
{
    Console.Beep();
    Console.WriteLine(" Seu nome está vazio ");
}
else
{
    Console.WriteLine("\n Seja bem vindo " + nome);
}


//idade
if (age >= 18)
{
    Console.WriteLine("\n Você está assinado " + nome );
}
else if (age < 0)
{
    Console.Beep();
    Console.WriteLine("\n Você nem nasceu ainda! " + nome);
}
else 
{
    Console.Beep();
    Console.WriteLine(" ATENÇÃO!!! TEM QUE SER MAIOR DE 18 ANOS DE IDADE ");
}


Console.ReadKey();