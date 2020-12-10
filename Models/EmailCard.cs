using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KerstKaartenGenerator.Models
{
    public class EmailCard
    {
        public int EmailCardID { get; set; }
        public string ImagePath { get; set; }
        public string TextMessage { get; set; }

        //ToDo
        //Add property for music.
    }
}
