using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Range(minimum:1, maximum:10, ErrorMessage = "Valor fora da faixa")]
        public int Quantidade { get; set; }
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categorias { get; set; }

    }
}
