using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeFilmesPF.Models
{
    public class Funcionario
    {
        public int id { get; set; }

        [Display(Name = "Nome do funcionário")]
        [Required(ErrorMessage = "Informe um Nome!")]
        public string nome { get; set; }

        [Display(Name = "Salário")]
        [Required(ErrorMessage = "Informe um salário!")]
        public double salario { get; set; }

        [Display(Name = "Data de admissão")]
        [Required(ErrorMessage = "Informe uma data de admissão!")]
        [DataType(DataType.Date)]
        public DateTime? admissao { get; set; }
        

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "Informe uma data de nascimento!")]
        [DataType(DataType.Date)]
        public DateTime? nascimento { get; set; }
        

    }
}
