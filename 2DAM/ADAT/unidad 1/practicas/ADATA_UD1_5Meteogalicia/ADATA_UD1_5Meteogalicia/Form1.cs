using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADATA_UD1_5Meteogalicia
{
    public partial class Form1 : Form
    {

        DatosMeteo descargaDatos = new DatosMeteo();
        FicheroMeteoXML xml;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            descargaDatos.DownloadXmlAsync();
            xml = new FicheroMeteoXML(descargaDatos.reader);
        }


    }
}
