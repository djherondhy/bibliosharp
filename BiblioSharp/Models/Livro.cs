
namespace BiblioSharp.Models; 
internal class Livro {
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public DateTime DataPublicacao { get; set; }
    public bool EstaEmprestado { get; set; }

    public Livro(string titulo) {
        Titulo = titulo;
    }

    public void Emprestar() {
        EstaEmprestado = true;
    }

    public void Devolver() {
        EstaEmprestado = false;
    }

    public void ExibirInformações() {
        Console.WriteLine($"");
        Console.WriteLine($"Titulo do Livro: {Titulo}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Data de Publicação: {DataPublicacao}");
        if (EstaEmprestado) Console.WriteLine("Status: Emprestado!");
        else Console.WriteLine("Status: Disponível para Empréstimo!");
    }

}
