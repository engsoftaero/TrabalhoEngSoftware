using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace EngSoftwareForum.Models
{
    public class CommonViewModel
    {
        public Questions Questions { get; set; }
        public IEnumerable<Questions> CountQuestions;
        public Replies RepliesLOL { get; set; }
        public IEnumerable<Replies> RepliesCount;
        public List<Replies> CountReply { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Tags Tags { get; set; }
    }
}
