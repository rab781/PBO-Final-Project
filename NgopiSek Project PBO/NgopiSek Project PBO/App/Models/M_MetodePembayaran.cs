﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Project_PBO.App.Models
{
    internal class M_MetodePembayaran
    {
        [Key]
        public int id_metode_pembayaran { get; set; }
        [Required]
        public string nama_metode_pembayaran { get; set; }
    }
}
