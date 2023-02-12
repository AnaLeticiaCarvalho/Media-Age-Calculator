string firstPerson, secondPerson;
int ageOne, ageTwo;
double media;

Console.WriteLine("Digite o nome da primeira pessoa");
firstPerson = Console.ReadLine();

Console.WriteLine("Digite o nome da segunda pessoa");
secondPerson = Console.ReadLine();

Console.WriteLine("Digite a idade da primeira pessoa");
ageOne = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a idade da segunda pessoa");
ageTwo = int.Parse(Console.ReadLine());

media = (ageOne + ageTwo) / 2;

Console.WriteLine($"A idade média de {firstPerson} e {secondPerson} é de " + media + " anos");

