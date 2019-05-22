using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EngSoftwareForum.Models
{
    public class Replies
    {
        [Key]
        public int ReplyId { get; set; }

        [Required]
        public string ReplyString { get; set; }

        public int QuestionID { get; set; }

        public string UserID { get; set; }

        public string UserKey { get; set; }

        public int VoteGR { get; set; }

        public string UsersUpVoteR { get; set; }

        public string UsersDownVoteR { get; set; }

        //public int VoteR { get; set; } //gammification
    }
}