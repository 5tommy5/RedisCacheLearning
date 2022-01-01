using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RedisCacheLearning.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int InfoId { get; set; }
        [ForeignKey(nameof(InfoId))]
        public Info Info { get; set; }
    }
}
