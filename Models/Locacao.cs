using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LocadoraDeFilmesPF.Models;

namespace LocadoraDeFilmesPF.Models
{
    public class Locacao // Classe para locacoes
    {
        public int id { get; set; } // atributos da classe locacao

        [Required(ErrorMessage = "Informe data inicial de locação")] // Exibe uma mnesagem de erro ao tentar fazer uma locação sem data inicial
        [Display(Name = "data inicial de locação")]
        [DataType(DataType.Date)]
        public DateTime? datalocação { get; set; }

        [Required(ErrorMessage = "Informe a data de devolução")]
        [Display(Name = "Data de devolução")]
        [DataType(DataType.Date)]

        public DateTime? dataDevolucao { get; set; }



        [Required(ErrorMessage = "Informe o nome do filme que deseja alugar")] //Exibe uma mnesagem de erro ao tentar fazer uma locação sem passar o nome do filme
        [Display(Name = "ID")]
        public int FilmeId { get; set; } // passei o FilmeID como atributo pois usaremos no momento da locação 


        [Display(Name ="Valor da locação")]
        public int valorLocacao { get; set; }


        public Filme Filme { get; set; }

        public string userId { get; set; }
        public IdentityUser user { get; set; }


    }

    
}
