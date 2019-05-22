using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EngSoftwareForum.Models
{
    public class Questions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Question { get; set; }

        public string UserID { get; set; }

        public string UserKey { get; set; }

        public int VoteGQ { get; set; }

        public string UsersUpVoteQ { get; set; }

        public string UsersDownVoteQ { get; set; }

        //public int VoteQ { get; set; } //gammification
    }

}
