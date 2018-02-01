using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;
using System.Data;
using SEUTCV2.Properties;

namespace SEUTCV2.Models
{
    class ModelGrupo
    {
       
        public string clavegrupo { get; set; }
        public string periodo { get; set; }
        public string idcarrera { get; set; }
        public uint grado { get; set; }
        public string grupo { get; set; }
        public uint cupo { get; set; }
        public string claveplan { get; set; }
        public uint inscritos { get; set; }
        public uint bajas { get; set; }
        public string fechacreacion { get; set; }
        public string creador { get; set; }

    }
}
