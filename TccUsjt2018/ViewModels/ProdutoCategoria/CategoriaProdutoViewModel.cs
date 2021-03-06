﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TccUsjt2018.ViewModels.ProdutoCategoria
{
    public class CategoriaProdutoViewModel
    {
        public int? CodigoCategoria { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string NomeCategoria { get; set; }
        [Required]
        [Display(Name = "Descrição")]
        public string DescricaoCategoria { get; set; }

    }
}