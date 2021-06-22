using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeFilmesPF.Models
{
    public class Filme // classe de filmes
    {
        
        [Display(Name = "ID")] // Com o Display conseguimos setar o nome que será exibido em tela
        public int id { get; set; } // atributos da classe Filme

        [Required(ErrorMessage = "Informe o nome do filme!")] // Exibe uma mensagem de erro ao tentar cadastrar um filme sem nome
        [Display(Name = "Nome do filme")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Informe a Sinopse!")] // Exibe uma mensagem de erro ao tentar cadastrar um filme sem Sinopse
        [Display(Name = "Sinopse")]
        public string sinopse { get; set; }

        [Required(ErrorMessage = "Informe o preço!")] // Exibe uma mensagem de erro ao tentar cadastrar um filme sem preço
        [Display(Name = "Preço de locação")]
        public double preco { get; set; }


        [Required(ErrorMessage = "Informe uma data de lançamento!")] //  Exibe uma mensagem de erro ao tentar cadastrar um filme sem data de lançamento
        [Display(Name = "Data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime? lancamento { get; set; }


        [Required(ErrorMessage = "Informe a duração do filme!")] // Exibe uma mensagem de erro ao tentar cadastrar um filme sem duração
        [Display(Name = "Duração")]
        public int duracao { get; set; }

        [Display(Name = "Link")] 
        [Required(ErrorMessage = "Insira o link")]
        public string link { get; set; } // atributo criado para atribuirmos o link dos filmes a serem assistidos

        
     


        public Filme(int id, string nome, string sinopse, double preco, DateTime lancamento, int duracao) // ctor
        {
            this.id = id;
            this.nome = nome;
            this.sinopse = sinopse;
            this.preco = preco;
            this.lancamento = lancamento;
            this.duracao = duracao;
        }

        public Filme() // ctor vazio
        {
        }
    }
}