using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ParametroEntity: DBEntity
    {
        public int? Id_Parametro { get; set; }
        public String Codigo { get; set; }
        public String Descripcion { get; set; }
        public String Valor { get; set; }
        public String Estado { get; set; }
    }
}
