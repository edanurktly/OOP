﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConApp.Entities
{
    //data annotation ile yapilandrıma

    [Table("Urunler")]
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public DateTime? CreateDate { get; set; }= DateTime.Now;

        //burasi database'e eklenecek alan
        [ForeignKey("FK_KategoryId")]

        
        public int KategoriId { get; set; }

        //burasi database eklnemyecek alan
        //burasi sadece navigation property olarak yer alacak
        public Kategori Kategori { get; set; }
    }
}
