﻿namespace ExemploEF.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }  
        public string Nome { get; set; }
        public IEnumerable<Produto>? Produtos { get; set; }
    }
}
