using FundamentosOO;
using System.Runtime.CompilerServices;

internal class Program
{

    private static void Main(string[] args)
    {
        //usando a class do Livro criado na pasta Livro.cs
        //Livro Livro1 = new Livro();
        //Livro1.Titulo = "Menino do pijama listrado";
        //Livro1.Editora = "London";
        //Livro1.Autor = "J.K";
        //Livro1.AnoLancamento = 1945;

        //Livro Livro2 = new Livro();
        //Livro2.Titulo = "jack";
        //Livro2.Autor = "orkdom";
        //Livro2.Editora = "crayon";
        //Livro2.AnoLancamento = 1995;

        //Livro Livro3 = new Livro();
        //Livro3.Titulo = "legolas";
        //Livro3.Autor = "lovis";
        //Livro3.Editora = "bostom";
        //Livro3.AnoLancamento = 2021;

        //Aluno Aluno1 = new Aluno();
        //Aluno1.Nome = "Matheus F Rodrigues";
        //Aluno1.Email = "math2306.r@gmail.com";
        //Aluno1.RM = "4640";
        //Aluno1.Nascimento = new DateOnly(2007, 06, 23);
        ////DateOnly so irá funcionar se for colocado datas em metodo americano

        ////Imprimir na tela o aluno 1
        //Console.WriteLine("Aluno1");
        //Console.WriteLine("Nome: " + Aluno1.Nome);
        //Console.WriteLine("RM: " + Aluno1.RM);
        //Console.WriteLine("Nascimento: " + Aluno1.Nascimento);
        //Console.WriteLine("Email: " + Aluno1.Email);
        //Console.WriteLine("===========================");

        //Aluno Aluno2 = new Aluno();
        //Aluno2.Nome = "Claudio";
        //Aluno2.Email = "claudio.dr@gmail.com";
        //Aluno2.RM = "6860";
        //Aluno2.Nascimento = new DateOnly(2005, 07, 20);

        ////imprimindo na tela o aluno 2
        //Console.WriteLine("Aluno2");
        //Console.WriteLine("Nome: " + Aluno2.Nome);
        //Console.WriteLine("RM: " + Aluno2.RM);
        //Console.WriteLine("Nascimento: " + Aluno2.Nascimento);
        //Console.WriteLine("Email: " + Aluno2.Email);
        //Console.WriteLine("===========================");

        //Aluno aluno3 = new Aluno();
        //aluno3.Nome = "Roger";
        //aluno3.Email = "Roger.46@gmail.com";
        //aluno3.RM = "9693";
        //aluno3.Nascimento = new DateOnly(2000, 01, 06);

        ////imprimindo na tela o aluno 3
        //Console.WriteLine("Aluno3");
        //Console.WriteLine("Nome: " + aluno3.Nome);
        //Console.WriteLine("RM: " + aluno3.RM);
        //Console.WriteLine("Nascimento: " + aluno3.Nascimento);
        //Console.WriteLine("Email: " + aluno3.Email);
        //Console.WriteLine("===========================");

        ////instanciar um objeto de tipo produto
        //Produto p1 = new Produto();
        //p1.Nome = "Coca-Cola 2 Litros";
        //p1.Preco = 12.99;
        //p1.Codigo = 123456;
        //p1.Estoque = 106;
        //Console.WriteLine("O produto é: " + p1.Nome);
        //Console.WriteLine("O preço é: " + p1.Preco);
        //Console.WriteLine("O código é: " + p1.Codigo);

        //p1.QuantidadeEstoque();
        //p1.Estoque = 100;
        //p1.QuantidadeEstoque();
        //Console.WriteLine("===========================");

        //Carro carro1 = new Carro();
        //carro1.Marca = "Konigseg";
        //carro1.Velocidade = 358;
        //carro1.Modelo = "Jesko";
        //Console.WriteLine("A marca é:" + carro1.Marca);
        //Console.WriteLine("O Modelo é:" + carro1.Modelo);
        //Console.WriteLine("A velocidade atual é:" + carro1.Velocidade);
        //carro1.acelerar();
        //carro1.Desacelerar();
        //Console.WriteLine("===========================");

        //Pessoa pessoa1 = new Pessoa();
        //pessoa1.nome = "Matheus";
        //pessoa1.idade = 18;
        //Console.WriteLine("Seu nome é:" + pessoa1.nome);
        //Console.WriteLine("Sua idade é:" + pessoa1.idade);
        //pessoa1.envelhecer(1);
        //Console.WriteLine("===========================");
        //Funcionario funcionario1 = new Funcionario();
        //funcionario1.nome = "Matheus Felipe Rodrigues";
        //funcionario1.idade = 19;
        //funcionario1.Cargo = "Dev";
        //funcionario1.Salario = 1995.45;

        //funcionario1.apresentarSe();
        //Console.WriteLine("===========================");

        ////Console.WriteLine("O nome do funcionario é:" + funcionario1.nome);
        ////Console.WriteLine("Tem " + funcionario1.idade + "anos");
        ////Console.WriteLine("Tem o cargo de " + funcionario1.Cargo);
        ////Console.WriteLine("Ganha R$" + funcionario1.Salario);

        ////Animal animal1 = new Animal();
        ////animal1.Especie = "cachorro";
        ////animal1.emitirSom();
        ////Console.WriteLine("O animal " + animal1.Especie + " emitiu som");
        ////Console.WriteLine("===========================");

        //Gato gato = new Gato();
        //gato.Nome = "Frajola";
        //Console.WriteLine(gato.Nome + " emitiu som");
        //gato.emitirSom();
        //Console.WriteLine("===========================");

        //Porco porco = new Porco();
        //porco.Nome = "Joanco";
        //Console.WriteLine(porco.Nome + " emitiu som");
        //porco.emitirSom();
        //Console.WriteLine("===========================");

        //Galinha galinha = new Galinha();
        //galinha.Nome = "Gertrudes";
        //Console.WriteLine(galinha.Nome + " emitiu som");
        //galinha.emitirSom();
        //Console.WriteLine("===========================");

        Mago merlin = new Mago();
        merlin.Nome = "Mago Merlin";
        merlin.Vida = 100;
        merlin.Inteligencia = 92;
        merlin.Agilidade = 50;
        merlin.Forca = 62;
        merlin.Nivel = 1;

        Elfo elfo = new Elfo();
        elfo.Nome = "Julius";
        elfo.Vida = 100;
        elfo.Inteligencia = 83;
        elfo.Forca = 99;
        elfo.Agilidade = 99;
        elfo.Nivel = 1;

        merlin.apresentarSe();
        elfo.apresentarSe();
        merlin.batalhar(elfo);







    }

}

// barras duplas usada para comitar uma linha
/*
 * E barra asterisco para 1 ou mais linhas
 */