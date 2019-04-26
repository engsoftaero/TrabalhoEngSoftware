using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EngSoftwareForum.Models
{
    public class Avatar
    {
        [Key]
        public int Id { get; set; } //id da foto

        [Required]
        public string Path { get; set; } //caminho da foto

        public string UserID { get; set; } //id do usuário da foto
    }

}
