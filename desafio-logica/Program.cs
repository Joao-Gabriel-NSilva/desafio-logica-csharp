using System.Collections;

bool continua = true;

while(continua) {
    var lista = new List<int>();
    double media;

    Console.WriteLine("Deseja calcular a média de quantas notas? ");
    var num = Convert.ToInt32(Console.ReadLine());

    if(num <= 0 ){
        break;
    }

    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"Digite a {i}º nota (de 0 a 10): ");
        lista.Add(Convert.ToInt32(Console.ReadLine()));

    }

    var soma = 0;
    foreach (var item in lista)
    {

        soma += item;
    }

    media = soma / num;
    Console.WriteLine($"A média desse aluno foi de: {media}");

    if(media >= 6) {
        Console.WriteLine("Aluno aprovado!");
    } else
    {
        Console.WriteLine("Aluno em recuperação!");
    }

    Console.WriteLine("Deseja executar novamente? (s/n)");
    var cont = Console.ReadLine();

    if (cont == "n")
    {
    continua = false;
    }
}
Console.WriteLine("Execução finalizada!");