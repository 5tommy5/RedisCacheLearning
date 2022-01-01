using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisCacheLearning.Cache
{
    public class RedisCacheSetting
    {
        public bool Enabled { get; set; }
        public string ConnectionString { get; set; }
    }
}
