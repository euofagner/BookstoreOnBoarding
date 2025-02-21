using src.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.ViewModels;

public class BookViewModel
{
    public ObservableCollection<BookModel> Books { get; set; } = [];

    public BookViewModel()
    {
        LoadScreen();
    }

    public void LoadScreen()
    {
        Books.Clear();
        Books.Add(new BookModel()
        {
            Title = "Bem-vindo à [Nome da Loja]",
            Description = "Descubra um mundo repleto de histórias fascinantes e conhecimento. Navegue pela nossa coleção e encontre o livro perfeito para você.",
            Image = "image2.png"
        });
        Books.Add(new BookModel()
        {
            Title = "Ofertas Exclusivas",
            Description = "Fique por dentro das nossas promoções e descontos exclusivos. Aproveite para adquirir seus livros favoritos com preços especiais.",
            Image = "image4.png"
        });
        Books.Add(new BookModel()
        {
            Title = "Crie sua Conta",
            Description = "Cadastre-se agora e tenha acesso a benefícios exclusivos, como recomendações personalizadas e histórico de compras. Vamos começar sua jornada literária!",
            Image = "image3.png",
        });
    }
}
