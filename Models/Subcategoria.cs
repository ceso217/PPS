﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.Models
{
    public class Subcategoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public int CodigoSubcategoria {  get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<Articulo> Articulos { get; set; }
    }
}
