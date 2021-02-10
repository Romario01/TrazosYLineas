using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trazos
{
    public partial class Form1 : Form
    {
        //declaracion de las variables que se usaran
        float t; //variable de tamaño del lapiz
        int c = 0; // contador de puntos para el triangulo
        Graphics graphics; //variable del opbjeto de graficos basicos
        Point p1,p2,p3; //puntos usados para la graficacion de el triangulo
        List<Point> miLista = new List<Point>(); //Una Lista donde guardaremos Puntos para la graficacion de 
                                                   // los poligonos

        public Form1()
        {
            InitializeComponent();
        }
        //Boton para limpiar el panel de dibujo
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Refresh();
        }

        private void rdbLineasPuntos_CheckedChanged(object sender, EventArgs e)
        {
                if (rdbLineasPuntos.Checked == true)
                {
                    if (!string.IsNullOrEmpty(txtTam.Text))
                    {
                    Console.WriteLine(t + "");
                    graphics = panel1.CreateGraphics();

                    Pen p = new Pen(Color.Red, t);
                    Pen p2 = new Pen(Color.Blue, t);
                    graphics.DrawLine(p2, 100, 340, 100, 10);
                    graphics.DrawLine(p, 20, 0, 20, 200);
                    graphics.DrawLine(p, 30, 150, 150, 150);
                    graphics.DrawLine(p, 200, 400, 10, 10);
                    graphics.DrawEllipse(p, 120, 300, 5, 5);
                    graphics.DrawEllipse(p, 344, 280, 4, 4);
                    graphics.DrawEllipse(p, 244, 255, 1, 1);
                    graphics.DrawEllipse(p, 255, 255, 1, 1);
                }
                else
                {
                    rdbLineasPuntos.Checked = false;
                    MessageBox.Show("Ingrese un tamaño");
                }
                }
        }

        private void rdaFigurasBasicas_CheckedChanged(object sender, EventArgs e)
        {
            //Activamos la lista de opciones de graficacion
            if(rdaFigurasBasicas.Checked == false)
            {
                listFiguras.Enabled = false;
            }
            else
            {
                listFiguras.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            listFiguras.Enabled = false;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //aqui convertimos el tipo de dato del textbox a float
            //desde aqui mandamos el valor del tamaño del Lapiz
            float.TryParse(txtTam.Text, out t);
            rdaFigurasBasicas.Checked = false;
            rdbLineasPuntos.Checked = false;
            rdbMouse.Checked = false;
        }

        private void listFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opc = listFiguras.SelectedIndex;

            switch (opc)
            {
                case 0:

                    break;
                case 1:
                    txtAxisX.Enabled = false;
                    txtAxisY.Enabled = false;
                    txtAltura.Enabled = false;
                    txtAncho.Enabled = false;
                    break;
                case 2:
                    txtAxisX.Enabled = true;
                    txtAxisY.Enabled = true;
                    txtAltura.Enabled = true;
                    
                    break;
                case 3:
                    txtAxisX.Enabled = true;
                    txtAxisY.Enabled = true;
                    txtAltura.Enabled = true;
                    txtAncho.Enabled = true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valueX; //valor de posicion en X
            int valueY; //Valor de posicion en Y
            int altura; //La altura de la figura
            int anchura; // el ancho de la figura
            string opc = listFiguras.Text.ToString();
            string color = cmbColor.Text.ToString();
            Pen p;

            switch (opc)
            {
                case "triángulos":
                    MessageBox.Show("Seleccione los puntos en el panel ");
                    p = new Pen(seleccionDeColor(color), t);
                    graphics = panel1.CreateGraphics();
                    Point[] points = { p1, p2, p3 };
                    graphics.DrawPolygon(p,points);

                    c = 0;
                    break;
                case "arcos":
                    MessageBox.Show("Selecciono el arco");
                    valueX =   Convert.ToInt32(txtAxisX.Text);
                    valueY = Convert.ToInt32(txtAxisY.Text);
                    anchura = Convert.ToInt32(txtAncho.Text);
                    altura   = Convert.ToInt32(txtAltura.Text);
                    p = new Pen(seleccionDeColor(color), t);
                    graphics = panel1.CreateGraphics();
                    Rectangle r = new Rectangle(valueX, valueY,anchura,altura);
                    graphics.DrawArc(p, r,0f,90f);
                    break;
                case "rectángulos":
                   
                    p = new Pen(seleccionDeColor(color), t);
                    graphics = panel1.CreateGraphics();
                    //solo se usara las cordenas y altura
                    valueX = Convert.ToInt32(txtAxisX.Text);
                    valueY = Convert.ToInt32(txtAxisY.Text);
                    anchura = Convert.ToInt32(txtAncho.Text);
                    altura = Convert.ToInt32(txtAltura.Text);
                    graphics.DrawRectangle(p, valueX , valueY,anchura,altura);
                    break;
                case "cuadrados":
                    p = new Pen(seleccionDeColor(color), t);
                    graphics = panel1.CreateGraphics();
                    p = new Pen(seleccionDeColor(color), t);
                    graphics = panel1.CreateGraphics();
                    //solo se usara las cordenas y altura
                    valueX = Convert.ToInt32(txtAxisX.Text);
                    valueY = Convert.ToInt32(txtAxisY.Text);
                    altura = Convert.ToInt32(txtAltura.Text);
                    graphics.DrawRectangle(p, valueX, valueY, altura, altura);

                    break;
            }
        }

        private Color seleccionDeColor(string color)
        {
            if (color.Equals("Rojo"))
            {
                return Color.Red;
            }
            if (color.Equals("Azul"))
            {
                return Color.Blue;
            }
            if (color.Equals("Cyan"))
            {
                return Color.Cyan;
            }
            if (color.Equals("Verde"))
            {
                return Color.Green;
            }
            return Color.Black;
        }
            private void Panel_MouseClick(object sender, MouseEventArgs e)
            {
            string color = cmbColor.Text.ToString();
            if (rdbMouse.Checked == true)
                {
                Pen p = new Pen(seleccionDeColor(color),t);
                Graphics g;
                //si se clickea el boton derecho del mouse, se generaran los puntos de un poligono
                if (e.Button == MouseButtons.Right)
                {
                    //se genera un punto nuevo con las cordenadas dadas por el click en el panel
                    Point punto = new Point(e.X, e.Y);
                    g = panel1.CreateGraphics();
                    g.DrawEllipse(p, e.X, e.Y, 1f, 1f);
                    //se guardan los puntos en una Lista
                    miLista.Add(punto);
                }
                //si se clikea el boton izquierdo nos podria dar 3 opciones
                if (e.Button == MouseButtons.Left)
                {
                    int t = miLista.Count;
                    //crea un arreglo con el tamaño de la lista antes creada
                    Point[] mi = new Point[t];
                    //si no hay puntos guardados en el arreglo no dibujara ningun poligono
                    if (t == 0)
                    {
                        MessageBox.Show("No hay puntos guardados");
                    }
                    //Si solo hay un punto guardado, no hara un poligono, solo sse quedara el punto en la pantalla 
                    //y se vaciara la lista
                    else if (t == 1)
                    {
                        miLista.Clear();
                    }
                    //Si encuntra mas de dos puntos, puede crear desde una linea hasta poligonos con los puntos guardados
                    else
                    {
                        miLista.CopyTo(mi);
                        g = panel1.CreateGraphics();
                        g.DrawPolygon(p, mi);
                        miLista.Clear();
                    }

                    
                    
                }
            }
                if (listFiguras.Text.ToString().Equals("triángulos"))
                {
                
                    Graphics g;
                    g = panel1.CreateGraphics();
                    Pen p = new Pen(Color.Black, 2f);

                    if (c < 3)
                    {
                    g.DrawEllipse(p, e.X, e.Y, 1f, 1f);
                    Console.WriteLine(c);
                        if(c == 0)
                    {
                        p1 = new Point(e.X, e.Y);
                    }
                        if(c == 1)
                    {
                        p2 = new Point(e.X, e.Y);
                    }
                        if(c == 2)
                    {
                        p3 = new Point(e.X, e.Y);
                    }
                    c++;
                    }
                }

            }

       
        }


    }
