using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models
{
    public class Motorista
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Nome Completo")]
        public string NomeCompletoMot { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Cpf")]

        public int CpfMot { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Telefone")]
        [Phone]
        public int TelefoneMot { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string EmailMot { get; set; }





        [Display(Name = "Data Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]

        public string? DataNascimentoMot { get; set; }



        // (Propriedade de navegação de coleção) Estou indicando que o Motorista pode possuir varias V

    public ICollection<Veiculo> Veiculo { get; set; }


    }

}



