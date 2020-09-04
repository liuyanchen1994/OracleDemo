using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOracle
{
    [Table("TEST")]
    public class Test
    {

        public string ID { get; set; }
    }
}
