using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1_Apuestas
{
    public partial class Form1 : Form
    {
        Fichero fichero = new Fichero("quiniela.txt");
        FicheroXml xml = new FicheroXml("Apuestas_Q.xml");
        List<Categoria> categorias = new List<Categoria>();
        List<Partido> partidos = new List<Partido>();
        List<Pronostico> pronosticos = new List<Pronostico>();
        List<Premios> premios = new List<Premios>();
        int recaudacion;
        public Form1()
        {
            InitializeComponent();
            List<string> nombreCategoria = new List<string>();
            nombreCategoria.Add("Pleno al 15");
            nombreCategoria.Add("1º");
            nombreCategoria.Add("2º");
            nombreCategoria.Add("3º");
            nombreCategoria.Add("4º");
            nombreCategoria.Add("5º");
            partidos = xml.leerPartidos();
            pronosticos = xml.leerPronosticos(partidos);
            categorias = leerCategorias();
            recaudacion = xml.leerRecaudacion();
            foreach (Pronostico itPronosticos in pronosticos)
            {
                if (itPronosticos.aciertos >= 10)
                    categorias.Where(i => i.aciertosNecesarios == itPronosticos.aciertos).First().acertantes++;
            }
            foreach (Categoria itCategoria in categorias)
            {
                if (itCategoria.acertantes > 0)
                    premios.Add(new Premios
                    {
                        Categoria = nombreCategoria[ itCategoria.id-1],
                        Aciertos = itCategoria.aciertosNecesarios,
                        Porcentaje = itCategoria.porcentajePremio,
                        Cuantia = recaudacion / itCategoria.porcentajePremio,
                        Acertantes = itCategoria.acertantes,
                        PremioUnitario = (recaudacion / itCategoria.porcentajePremio) / itCategoria.acertantes
                    });
                else
                {
                    premios.Add(new Premios
                    {
                        Categoria = nombreCategoria[itCategoria.id - 1],
                        Aciertos = itCategoria.aciertosNecesarios,
                        Porcentaje = itCategoria.porcentajePremio,
                        Cuantia = recaudacion / itCategoria.porcentajePremio,
                        Acertantes = itCategoria.acertantes,
                        PremioUnitario = 0
                    });
                }
            }

        }
        private List<Categoria> leerCategorias()
        {
            List<Categoria> tmp = new List<Categoria>();
            foreach (string item in fichero.LeerLineas())
            {
                string[] split = item.Split('\t');
                tmp.Add(new Categoria
                {
                    id = Convert.ToInt32(split[0]),
                    aciertosNecesarios = Convert.ToInt32(split[1]),
                    porcentajePremio = Convert.ToInt32(split[2])
                });
            }
            return tmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridViewPartidos.DataSource = partidos;
            dataGridViewPremios.DataSource = premios;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xml.añadir(premios);
        }
    }
}
