using ExemploExplorando.Models;
using System.Globalization;
using Models;
using Newtonsoft.Json;

int numero = 28 ;
bool par = false;

// IF ternario, só fuciona se o caso for feito por um "if" e "else" pois so retornar dois valores 
par = numero.EhPar();
Console.WriteLine($"O número é {numero} " + (par ? "par" : "impar"));






/*
// uma classe genérica 
MeuArray<int> ArrayInterio = new MeuArray<int>();

ArrayInterio.AdicionarElementoArray(30);

Console.WriteLine(ArrayInterio[0]);

MeuArray<string> ArrayString = new MeuArray<string>();

ArrayString.AdicionarElementoArray("testando");

Console.WriteLine(ArrayString[0]);
*/






/*
dynamic VariavelDinamica = 4;

Console.WriteLine($"Tipo da variável: {VariavelDinamica.GetType()}, Valor: {VariavelDinamica}");

VariavelDinamica = "Texto";

Console.WriteLine($"Tipo da variável: {VariavelDinamica.GetType()}, Valor: {VariavelDinamica}");

VariavelDinamica = true;
Console.WriteLine($"Tipo da variável: {VariavelDinamica.GetType()}, Valor: {VariavelDinamica}");
*/










/*
string ConteudoArquivo = File.ReadAllText("arquivos/vendas.json");

List<Vendas> ListaVendas = JsonConvert.DeserializeObject<List<Vendas>>(ConteudoArquivo);

var ListaAnonima = ListaVendas.Select(x => new { x.Produto, x.Preço });

foreach(var Vendas in ListaAnonima)
{
    Console.WriteLine($"Produto: {Vendas.Produto}, Preço: {Vendas.Preço}");
}
*/






/*  lista anonima 
var TipoAnonimo = new { Nome = "Raik", Sobrenome = "Silva", Altura = 1.68 };

Console.WriteLine("Nome: " + TipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + TipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + TipoAnonimo.Altura);
*/










/* boleana com valor nulo
bool? DesejaReceberEmail = null;

if(DesejaReceberEmail.HasValue && DesejaReceberEmail.Value)
{
    Console.WriteLine("Usuário deseja receber e-mail");
}
else
{
    Console.WriteLine("Usuário não recebeu ou optou por não receber e-mail");
}*/




/* // quando se tem valores nulos em propriedades vindas pelo Json ou no meu programa mesmo
string ConteudoArquivo = File.ReadAllText("arquivos/vendas.json");

List<Vendas> listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(ConteudoArquivo);

foreach (Vendas vendas in listaVendas)
{
    Console.WriteLine($"ID: {vendas.ID}, Produto: {vendas.Produto}, " +
                      $"Preço: {vendas.Preço}, Data: {vendas.DataVenda.ToString("dd/MM/yyyy HH:mm")} " + 
                      $"{(vendas.Desconto.HasValue ? $"Desconto de: {vendas.Desconto}" : "")}");
}*/










/* Serialização com Json
DateTime dataAtual = DateTime.Now;

List<Vendas> listaVendas = new List<Vendas>();

Vendas v1 = new Vendas(1, "Material de escritório", 25.50M, dataAtual);
Vendas v2 = new Vendas(2, "Licença de software", 125.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializando = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializando);

Console.WriteLine(serializando);
*/













/*
int numero = 21;
bool ehpar = false;

// IF ternario, só fuciona se o caso for feito por um "if" e "else" pois so retornar dois valores 
Console.WriteLine($"O número {numero} " + (ehpar ? "par" : "impar"));
*/


/*
// IF não ternario
if(numero % 2 == 0)
{
    Console.WriteLine($"Esté número {numero} é par");
}
else
{
     Console.WriteLine($"Esté número {numero} é impar");
}
*/







/*
Pessoa p1 = new Pessoa("Leandro", "bruno");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");
*/









/*
// caso Queira descartar uma informação pode usar "_" para substituir a informação descartada: descarte
LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivos, _) = arquivo.LerArquivo("arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine("Quantidade de linhas" + LinhasQuantidade);
    foreach(string linhas in linhasArquivos)
    {
        Console.WriteLine(linhas);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}
*/








/*
// Mais recomendado
(int, string, string) tupla = (1, "Raik", "Silva");

// ValueTuple<int, string, string> outroExemploTupla = (1, "Raik", "Silva");
// var outroExemploTuplaCreate = Tuple.Create(1, "Raik", "Silva");

Console.WriteLine(tupla);
*/







/*
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("PE","Pernambuco");
estados.Add("BA", "Bahia");
estados.Add("RJ", "Rio de janeiro");
estados.Add("RN", "Rio grande do norte");


Console.WriteLine(estados["RN"]);
/*
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

Console.WriteLine("\n   ________------------_________\n");

estados.Remove("RJ");
estados["PE"] = "Pernambuco - valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}
*/

/*
string Chave = "RJ";
Console.WriteLine($"Verificando o elemento {Chave}");

if(estados.ContainsKey(Chave))
{
    Console.WriteLine($"Valor existente: {Chave}");
}
else
{
    Console.WriteLine($"Chave não existente pode cadastra-la: {Chave}");
}
*/













/*
Stack<int> Pilha = new Stack<int>();

Pilha.Push(2);
Pilha.Push(32);
Pilha.Push(7);
Pilha.Push(50);
Pilha.Push(21);


// Lifo = ultimo a entrar primeiro a sair.
foreach(int item in Pilha)
{
    Console.WriteLine($"Item na lista: {item}");
}

Console.WriteLine($"Removendo o item: {Pilha.Pop()}");

Pilha.Push(41);

foreach(int item in Pilha)
{
    Console.WriteLine($"Item na lista: {item}");
}
*/













// FIFO = primeiro a entrar primeiro a sair 
/*
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(5);
fila.Enqueue(8);
fila.Enqueue(9);
fila.Enqueue(10);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

    Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

fila.Enqueue(3);

foreach(int item in fila)
{
    Console.WriteLine(item);
}
*/











//new Exemploexcecao().Metodo1();











/*
try
{
        string[] linhas = File.ReadAllLines("arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas )    
    {
        Console.WriteLine(linha);
    }
}
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Aconteceu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message} ");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Aconteceu um erro na leitura do arquivo. Caminho da pasta não encontrado{ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção generica {ex.Message}");
}
finally
{
    
Console.WriteLine("Chegou até aqui");
}*/












/*
// formatos de datas e como alteralas 

// ajuda a converter uma string para o DateTime
string dataString = "2022-15-16 14:00";


bool sucesso = DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm", 
                             CultureInfo.InvariantCulture, 
                                DateTimeStyles.None, out DateTime data);

if(sucesso)
{
    Console.WriteLine($"A conversão teve sucesso!! Data: {data}");
}
else
{
    Console.WriteLine($"Ah data: {dataString} não é uma data válida");
}
*/




/*DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm", 
                             CultureInfo.InvariantCulture, 
                                DateTimeStyles.None, out DateTime data);

DateTime data = DateTime.Parse(dataString);
 
 
Console.WriteLine(data);
*/


//Somente a hora 
//Console.WriteLine(data.ToShortTimeString());

//Somente a data 
//Console.WriteLine(data.ToShortDateString());

// Data e hora requisitadas no momento atual
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));










/*
// configurando a cultura do programa na definição de data e valor do dinheiro, porém esse metodo trava essa cultura pro programa todo.
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("PT-BR");

// valores Monetarios estão ligado com a configuração do VS para definir o valor/tipo da moeda   
decimal ValorMonetario = 1582.40M;
//Console.WriteLine(ValorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine($"{ValorMonetario:C}");

// porcemtagem 
double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 224487;
Console.WriteLine(numero.ToString("##-##-##"));*/






/*
Pessoa pessoa2 = new Pessoa(nome: "Fabieli", sobreNome: "SIlva");
Pessoa pessoa3 = new Pessoa(nome: "Raik", sobreNome: "SIlva");
Pessoa pessoa4 = new Pessoa(nome: "Maria", sobreNome: "Luzemar");

Curso cursoDotNet = new Curso();
cursoDotNet.Nome = "DotNet";
cursoDotNet.Alunos = new List<Pessoa>();


cursoDotNet.AdicionarAluno(pessoa2);
cursoDotNet.AdicionarAluno(pessoa3);
cursoDotNet.AdicionarAluno(pessoa4);
cursoDotNet.ListarAlunos();*/







/*
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "raik";
pessoa1.SobreNome = "Silva";
pessoa1.Idade = 21;
pessoa1.Apresentar();
*/
