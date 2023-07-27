Console.WriteLine("digite um número ");
int seq=Convert.ToInt32(Console.ReadLine());

Fibonacci(seq);
static void Fibonacci(int sequencia){
    int a=0;
    int b=1;
    int fibo;
    Console.WriteLine("Sequência Fibonacci:");
    Console.WriteLine($"{a}");

    
    for (int i=1; i<sequencia; i++){ /*instrução para: repete a seuqnência até que a variavél atinja o mesmo número que o usuário digitou*/
        fibo = a+b;
        Console.WriteLine($"{b}");
        a=b;
        b=fibo;
    }
}