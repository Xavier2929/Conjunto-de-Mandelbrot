using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conjunto_de_Mandelbrot
{
    class clsFuncion
    {


        public void conjuntoMandelbrot(PictureBox pcBx) {

            var largo = pcBx.Width;
            var alto = pcBx.Height;

            Bitmap bmp = new Bitmap(largo, alto);

            //cuando recorrimos las coordenadas de un picturebox es de arriba para abajo

            //filas, eje Y
            for (int i = 0; i < alto; i++)
            {
                //columnas, eje X
                for (int j = 0; j < largo; j++)
                {
                    //apartir del centro vamos representando la imagen
                    var c_re = (j - largo / 2) * 4.0 / largo;
                    var c_im = (i - alto / 2) * 4.0 / alto;

                    //establecemos un limite 
                    int cantIteraciones = 0;
                    double x = 0, y = 0;

                    while (cantIteraciones < 1000 && (x * x) + (y * y) <= 4)
                    {
                        double x_temp = (x * x) - (y * y) + c_re;
                        y = 2 * x * y + c_im;
                        x = x_temp;
                        cantIteraciones++;
                    }
                    if (cantIteraciones < 1000)
                    {
                        bmp.SetPixel(j, i, Color.FromArgb(cantIteraciones % 128, cantIteraciones % 50 * 5, cantIteraciones % 10));
                    }
                    else
                    {
                        bmp.SetPixel(j, i, Color.Black);
                    }
                }
                pcBx.Image = bmp;
            }
        }


    }
}
