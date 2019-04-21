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
        public Replies RepliesLOL { get; set; }
        public List<Replies> CountReply { get; set; }
        public IEnumerable<Questions> CountQuestions;
    }
}
