using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Project_PBO.App.Models
{
    internal class Admin
    {
        [Key]
        public int id_admin { get; set; }
        [Required]
        public string nama_admin { get; set; }
        [Required]
        public string username_admin { get; set; }
        [Required]
        public string password_admin { get; set; }
    }
}
