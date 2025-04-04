﻿using System.ComponentModel.DataAnnotations;

namespace ExemploEF.Models
{
    public class Produto
    {
        [Key]
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
