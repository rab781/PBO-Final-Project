using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Project_PBO.App.Models
{
    internal class Kasir
    {
        [Key]
        public int id_kasir { get; set; }
        [Required]
        public string nama_kasir { get; set; }
        [Required]
        public string username_kasir { get; set; }
        [Required]
        public string password_kasir { get; set; }
    }
}
