using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatchStore.Models
{
    public class Watch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Article { get; set; }
        public string Price { get; set; }
        public byte[] Image { get; set; }
        public string ImageType { get; set; }
    }
}
