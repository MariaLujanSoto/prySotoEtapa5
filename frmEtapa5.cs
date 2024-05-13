using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySotoEtapa5
{
    public partial class frmEtapa5 : Form
    {
        public frmEtapa5()
        {
            InitializeComponent();
        }

       
        clsVehiculo objAuto = new clsVehiculo(); 
        clsVehiculo objAvion = new clsVehiculo();
        clsVehiculo objBarco = new clsVehiculo();

        Random rnd = new Random();
 

        private void frmEtapa5_Load(object sender, EventArgs e)
        {

        }

        private PictureBox imagenAleatoria;

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int indiceAleatorio = rnd.Next(1,4);
            // eliminar el pct si ya existe uno
            if (Controls.Contains(imagenAleatoria))
            {
                Controls.Remove(imagenAleatoria);
                imagenAleatoria.Dispose(); 
            }

            switch (indiceAleatorio)
            {
                case 1:
                    objAuto.crearAuto();
                    objAuto.Auto.Location = new Point(400, 500);
                    imagenAleatoria = objAuto.Auto;

                    break;

                case 2:
                    objAvion.crearAvion();
                    objAvion.Avion.Location = new Point(200, 100);
                    imagenAleatoria = objAvion.Avion;

                    break;

                case 3:
                    objBarco.crearBarco();
                    objBarco.Barco.Location = new Point(300, 350);
                    imagenAleatoria = objBarco.Barco;

                    break;
            }
            Controls.Add(imagenAleatoria);


        }
    }
}
