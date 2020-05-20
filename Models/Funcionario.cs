using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCompass.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DtNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        [Display(Name = "Salário")]
        public int Salario { get; set; }
    }
}
