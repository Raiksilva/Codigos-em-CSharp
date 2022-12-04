using ExemploFundamento.Common.Models;














//Console.WriteLine("Hello");


/*// Instancia da classe pessoa
Pessoa pessoa2 = new Pessoa();

// Atribui o nome e a idade da pessoa  
pessoa2.Nome = "João";
pessoa2.Idade = 18;

// apresenta o nome e a idade da pessoa sitada
pessoa2.Apresentar();
*/




// itens da lista/ que irão percorrer na lista
/*List<string> liststring = new List<string>();

liststring.Add("BA");
liststring.Add("PE");
liststring.Add("RJ");
liststring.Add("MA");
liststring.Add("CE"); */

// código com a função de mostrar como de mostrar como o array funciona em uma lista 
/*Console.WriteLine($"Itens na minha lista: {liststring.Count} - capacidade {liststring.Capacity}");

liststring.Add("RN");

Console.WriteLine($"Itens na minha lista: {liststring.Count} - capacidade {liststring.Capacity}");

liststring.Remove("RJ");

Console.WriteLine($"Itens na minha lista: {liststring.Count} - capacidade {liststring.Capacity}");*/


//código para correr os itens de uma lista
/*Console.WriteLine("Percorrendo a lista com o For");
 for(int i = 0; i < liststring.Count; i++){
     Console.WriteLine($"Posição N°{i} - {liststring[i]}");
}

 Console.WriteLine("Percorrendo a lista com o Foreach");
 int ireach = 0;
 foreach(string item in liststring){
     Console.WriteLine($"Posição N°{ireach} - {item}");
     ireach ++;
}*/











// int[] arrayInteiros = new int[4];
 
// arrayInteiros[0] = 21;
// arrayInteiros[1] = 40;
// arrayInteiros[2] = 54;
// arrayInteiros[3] = 4;
 
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("percorrendo o array com FOR");

// for(int i = 0; i < arrayInteiros.Length; i++){
//       Console.WriteLine($"Posição N° {i} - {arrayInteiros[i]}");
//   };

//   Console.WriteLine("Percorrendo o Array com o Foreach");
//   int contadorforeach = 0;
//   foreach(int valor in arrayInteiros)
//   {
//       Console.WriteLine($"Posição N° {contadorforeach} - {valor}");
//      contadorforeach++;
//  };










//  using ExemploFundamento.Common.Models;

/*Pessoa pessoa1 = new Pessoa();


pessoa1.Nome = "Bano";
pessoa1.Idade = 24;
pessoa1.Apresentar();*/











// int numero = 5;

//  for (int contador = 0; contador <= 10; contador++){

//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }














 string opção;
 
 bool exibirMenu = true;

while(exibirMenu){

    
    Console.WriteLine("Escolha sua opção");
    Console.WriteLine("Opção 1 - Cadastra cliente");
    Console.WriteLine("Opção 2 - Procurar cliente");
    Console.WriteLine("Opção 3 - Apagar cliente");
    Console.WriteLine("Opção 4 - Sair do Menu");

      opção =  Console.ReadLine();

       switch(opção){

           case "1":
         Console.WriteLine("Cadastro de cliente:\n");
           break;
         case "2":
         Console.WriteLine("Procurar cliente:\n ");
            break;
         case "3":
         Console.WriteLine("Apagar cliente: \n");
           break;
         case "4":
         Console.WriteLine("encerrando");
          exibirMenu = false;
           //Environment.Exit(0);
           break;
       }
  }

  Console.WriteLine("Obrigado por acessar esté menu");













// int numero = 2;

// int contador = 0;

// int numero = 2;
// int contador = 0;
//  do{
//      Console.WriteLine($"{contador}° execurdar: {numero} x {contador} = {numero * contador}");
//      contador ++;
//  }
// while(contador <= 10);












// using ExemploFundamento.Common.Models;


// Calculadora calc = new Calculadora();
// calc.Somar(20,84);
// calc.Subtrair(10,50);
// calc.Multiplicar(2,6);
// calc.Dividir(5,25);
// calc.RestoDeDivisão(5,25);
// calc.Potencia(2,5);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(625);

// int numeroIncremento = 10 ;
//  Console.WriteLine(numeroIncremento);

//  Console.WriteLine("Incrementando o 10");
//  numeroIncremento ++;

//  Console.WriteLine(numeroIncremento);

// int numeroDecremento = 10 ;
//  Console.WriteLine(numeroDecremento);

//  Console.WriteLine("Incrementando o 10");
//  numeroDecremento --;

//  Console.WriteLine(numeroDecremento);













// bool choveu = false;
// bool estaTarde = false;


// if (!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar");
// }
// else{
//     Console.WriteLine("Vou pedalar um outro dia");
// }











// Console.WriteLine("Digiti uma letra: ");
// string letra = Console.ReadLine();

// switch (letra) {

//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }










// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade da Compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda: {possivelVenda}");

// if(quantidadeCompra == 0){
//     Console.WriteLine("Pedido invalido");
// }else if(possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }else{
//     Console.WriteLine("Desculpe. Protudo indisponivel.");
// }










// int a = 5;

// Console.WriteLine(a);

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);


// conversão de string para inteiro de forma segura ou conversão segura usando tryparse.

// string a = "5-";

// // int b = 1;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Realizado com sucesso");
