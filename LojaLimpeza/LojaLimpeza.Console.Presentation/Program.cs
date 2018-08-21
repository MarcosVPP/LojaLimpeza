namespace LojaLimpeza.Console.Presentation
{
    public class Program
    {
        static Service.CategoriaService categoriaService;

        static void Main(string[] args)
        {
            categoriaService = new Service.CategoriaService();

            Cadastro();

            ShowList();
        }

        private static void ShowList()
        {
            var categorias = categoriaService.Listar();

            foreach (var item in categorias)
            {
                System.Console.WriteLine(item.Nome);
            }

            System.Console.ReadKey();
        }


        private static void Cadastro()
        {
            System.Console.WriteLine("Informe os dados para cadastro");
            System.Console.Write("Código: ");
            var codigo = int.Parse(System.Console.ReadLine());

            System.Console.Write("Nome: ");
            var nome = System.Console.ReadLine();

            Domain.CategoriaDomain categoria = new Domain.CategoriaDomain(codigo, nome);
            
            categoriaService.Salvar(categoria);
        }
    }

}


