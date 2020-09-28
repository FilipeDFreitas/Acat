using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACAT
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            int i;

            DataTable Tabela;

            Tabela = new DataTable();

            Tabela.Columns.Add("Numero", typeof(decimal));

            Tabela.Columns.Add("Seno", typeof(string));

            Tabela.Columns.Add("Cosseno", typeof(string));

            Tabela.Columns.Add("Tangente", typeof(string));

            DataRow Linha;

            for (i = 1; i < 360; i++)
            {

                Linha = Tabela.NewRow();

                Linha[0] = i;

                Linha[1] = Math.Sin(i * PI / 180).ToString("###,###,##0.00000");

                Linha[2] = Math.Cos(i * PI / 180).ToString("###,###,##0.00000");

                if (i == 90 || i == 270)
                {
                    Linha[3] = Math.Tan(i * PI / 180).ToString(" ---------- ");
                }

                else
                {
                    Linha[3] = Math.Tan(i * PI / 180).ToString("###,###,##0.00000");
                }
                Tabela.Rows.Add(Linha);
            }

            Grid.DataSource = Tabela;
        }
        bool menu_area = false;
        bool menu_volume = false;
        bool menu_bhaskara = false;
        bool menu_triangulo = false;
        bool menu_tabela = false;

        bool flag_a_retangulo = false;
        bool flag_b_retangulo = false;
        bool flag_a_triangulo = false;
        bool flag_b_triangulo = false;
        bool flag_r_circulo = false;
        bool flag_a_cubo = false;
        bool flag_b_cubo = false;
        bool flag_c_cubo = false;
        bool flag_esfera = false;
        bool flag_a_cone = false;
        bool flag_r_cone = false;
        bool flag_a_cilindro = false;
        bool flag_r_cilindro = false;
        bool flag_a_bhaskara = false;
        bool flag_b_bhaskara = false;
        bool flag_c_bhaskara = false;
        bool flag_a_lado = false;
        bool flag_b_lado = false;
        bool flag_c_lado = false;
        bool flag_a_angulo = false;
        bool flag_b_angulo = false;
        bool flag_c_angulo = false;

        bool flag_v_a_retangulo = false;
        bool flag_v_b_retangulo = false;
        bool flag_v_a_triangulo = false;
        bool flag_v_b_triangulo = false;
        bool flag_v_r_circulo = false;
        bool flag_v_a_cubo = false;
        bool flag_v_b_cubo = false;
        bool flag_v_c_cubo = false;
        bool flag_v_esfera = false;
        bool flag_v_a_cone = false;
        bool flag_v_r_cone = false;
        bool flag_v_a_cilindro = false;
        bool flag_v_r_cilindro = false;
        bool flag_v_a_bhaskara = false;
        bool flag_v_b_bhaskara = false;
        bool flag_v_c_bhaskara = false;
        bool flag_m_a_bhaskara = false;
        bool flag_m_b_bhaskara = false;
        bool flag_m_c_bhaskara = false;
        bool flag_v_a_lado = false;
        bool flag_v_b_lado = false;
        bool flag_v_c_lado = false;
        bool flag_v_a_angulo = false;
        bool flag_v_b_angulo = false;
        bool flag_v_c_angulo = false;
        bool flag_m_a_lado = false;
        bool flag_m_b_lado = false;
        bool flag_m_c_lado = false;
        bool flag_m_a_angulo = false;
        bool flag_m_b_angulo = false;
        bool flag_m_c_angulo = false;

        double PI = 3.14159265358979323846264;

        //ÁREA

        private void area_a_MouseHover(object sender, EventArgs e)
        {

        }

        private void area_b_MouseLeave(object sender, EventArgs e)
        {
            if (menu_area == false)
            {
                area_a.Visible = true;
                area_b.Visible = false;
            }
        }

        private void area_b_Click(object sender, EventArgs e)
        {
            grupo_area.Visible = true;
            grupo_bhaskara.Visible = false;
            grupo_volume.Visible = false;
            grupo_tabela.Visible = false;
            grupo_triangulo.Visible = false;
            grupo_desenvolvimento.Visible = false;
            if (menu_area == false)
            {
                area_b.Visible = false;
                area_c.Visible = true;
                volume_a.Visible = true;
                volume_c.Visible = false;
                bhaskara_a.Visible = true;
                bhaskara_c.Visible = false;
                triangulo_a.Visible = true;
                triangulo_c.Visible = false;
                tabela_a.Visible = true;
                tabela_c.Visible = false;
                menu_area = true;
                menu_volume = false;
                menu_bhaskara = false;
                menu_triangulo = false;
                menu_tabela = false;
            }
        }

        //VOLUME

        private void volume_a_MouseHover(object sender, EventArgs e)
        {
            if (menu_volume == false)
            {
                volume_a.Visible = false;
                volume_b.Visible = true;
            }
        }

        private void volume_b_MouseLeave(object sender, EventArgs e)
        {
            if (menu_volume == false)
            {
                volume_a.Visible = true;
                volume_b.Visible = false;
            }
        }

        private void volume_b_Click(object sender, EventArgs e)
        {
            grupo_area.Visible = false;
            grupo_bhaskara.Visible = false;
            grupo_volume.Visible = true;
            grupo_tabela.Visible = false;
            grupo_triangulo.Visible = false;
            grupo_desenvolvimento.Visible = false;

            if (menu_volume == false)
            {
                area_a.Visible = true;
                area_c.Visible = false;
                volume_b.Visible = false;
                volume_c.Visible = true;
                bhaskara_a.Visible = true;
                bhaskara_c.Visible = false;
                triangulo_a.Visible = true;
                triangulo_c.Visible = false;
                tabela_a.Visible = true;
                tabela_c.Visible = false;
                desenvolvimento0.Visible = true;
                Desenvolvimento1.Visible = false;
                desenvolvimento2.Visible = false;
                menu_area = false;
                menu_volume = true;
                menu_bhaskara = false;
                menu_triangulo = false;
                menu_tabela = false;
            }
        }

        //BHASKARA

        private void bhaskara_a_MouseHover(object sender, EventArgs e)
        {
            if (menu_bhaskara == false)
            {
                bhaskara_a.Visible = false;
                bhaskara_b.Visible = true;
            }
        }

        private void bhaskara_b_MouseLeave(object sender, EventArgs e)
        {
            if (menu_bhaskara == false)
            {
                bhaskara_a.Visible = true;
                bhaskara_b.Visible = false;
            }
        }

        private void bhaskara_b_MouseClick(object sender, MouseEventArgs e)
        {
            grupo_area.Visible = false;
            grupo_bhaskara.Visible = true;
            grupo_volume.Visible = false;
            grupo_tabela.Visible = false;
            grupo_triangulo.Visible = false;
            grupo_desenvolvimento.Visible = false;

            if (menu_bhaskara == false)
            {
                area_a.Visible = true;
                area_c.Visible = false;
                volume_a.Visible = true;
                volume_c.Visible = false;
                bhaskara_b.Visible = false;
                bhaskara_c.Visible = true;
                triangulo_a.Visible = true;
                triangulo_c.Visible = false;
                tabela_a.Visible = true;
                tabela_c.Visible = false;
                desenvolvimento0.Visible = true;
                Desenvolvimento1.Visible = false;
                desenvolvimento2.Visible = false;
                menu_area = false;
                menu_volume = false;
                menu_bhaskara = true;
                menu_triangulo = false;
                menu_tabela = false;
            }
        }

        //TRIANGULO

        private void triangulo_a_MouseHover(object sender, EventArgs e)
        {
            if (menu_triangulo == false)
            {
                triangulo_a.Visible = false;
                triangulo_b.Visible = true;
            }
        }

        private void triangulo_b_MouseLeave(object sender, EventArgs e)
        {
            if (menu_triangulo == false)
            {
                triangulo_a.Visible = true;
                triangulo_b.Visible = false;
            }
        }

        private void triangulo_b_MouseClick(object sender, MouseEventArgs e)
        {
            grupo_area.Visible = false;
            grupo_bhaskara.Visible = false;
            grupo_volume.Visible = false;
            grupo_tabela.Visible = false;
            grupo_triangulo.Visible = true;
            grupo_desenvolvimento.Visible = false;

            if (menu_triangulo == false)
            {
                area_a.Visible = true;
                area_c.Visible = false;
                volume_a.Visible = true;
                volume_c.Visible = false;
                bhaskara_a.Visible = true;
                bhaskara_c.Visible = false;
                triangulo_b.Visible = false;
                triangulo_c.Visible = true;
                tabela_a.Visible = true;
                tabela_c.Visible = false;
                desenvolvimento0.Visible = true;
                Desenvolvimento1.Visible = false;
                desenvolvimento2.Visible = false;
                menu_area = false;
                menu_volume = false;
                menu_bhaskara = false;
                menu_triangulo = true;
                menu_tabela = false;
            }
        }

        private void tabela_a_MouseHover(object sender, EventArgs e)
        {
            tabela_a.Visible = false;
            tabela_b.Visible = true;
        }

        private void tabela_b_MouseLeave(object sender, EventArgs e)
        {
            tabela_a.Visible = true;
            tabela_b.Visible = false;
        }

        private void tabela_b_MouseClick(object sender, MouseEventArgs e)
        {
            grupo_area.Visible = false;
            grupo_bhaskara.Visible = false;
            grupo_volume.Visible = false;
            grupo_tabela.Visible = true;
            grupo_triangulo.Visible = false;
            grupo_desenvolvimento.Visible = false;

            if (menu_tabela == false)
            {
                area_a.Visible = true;
                area_c.Visible = false;
                volume_a.Visible = true;
                volume_c.Visible = false;
                bhaskara_a.Visible = true;
                bhaskara_c.Visible = false;
                triangulo_a.Visible = true;
                triangulo_c.Visible = false;
                tabela_b.Visible = false;
                tabela_c.Visible = true;
                desenvolvimento0.Visible = true;
                Desenvolvimento1.Visible = false;
                desenvolvimento2.Visible = false;
                menu_area = false;
                menu_volume = false;
                menu_bhaskara = false;
                menu_triangulo = false;
                menu_tabela = true;
            }
        }

        private void a_retangulo_Click(object sender, EventArgs e)
        {
            a_retangulo.Text = "";
            flag_a_retangulo = true;
            flag_v_a_retangulo = false;
        }

        private void a_retangulo_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_a_retangulo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_a_retangulo = true;
            }

        }

        private void b_retangulo_Click(object sender, EventArgs e)
        {
            b_retangulo.Text = "";
            flag_b_retangulo = true;
            flag_v_b_retangulo = false;
        }

        private void b_retangulo_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_b_retangulo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_b_retangulo = true;
            }

        }

        private void a_triangulo_Click(object sender, EventArgs e)
        {
            a_triangulo.Text = "";
            flag_a_triangulo = true;
            flag_v_a_triangulo = false;
        }

        private void a_triangulo_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_a_triangulo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_a_triangulo = true;
            }

        }

        private void b_triangulo_Click(object sender, EventArgs e)
        {
            b_triangulo.Text = "";
            flag_b_triangulo = true;
            flag_v_b_triangulo = false;
        }

        private void b_triangulo_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_b_triangulo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_b_triangulo = true;
            }

        }

        private void r_circulo_Click(object sender, EventArgs e)
        {
            r_circulo.Text = "";
            flag_r_circulo = true;
            flag_v_r_circulo = false;
        
        }

        private void r_circulo_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_r_circulo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_r_circulo = true;
            }

        }

        //CALCULAR ÁREA

        private void calcular_triangulo1_Click(object sender, EventArgs e)
        {
            if (flag_a_triangulo == true && flag_b_triangulo == true && a_triangulo.Text != "" && b_triangulo.Text != "")
            {
                double a = double.Parse(a_triangulo.Text);
                double b = double.Parse(b_triangulo.Text);

                result_triangulo.Text = ((a * b) / 2).ToString("###,##0.00");
            }
        }

        private void calcular_circulo1_Click(object sender, EventArgs e)
        {
            if (flag_r_circulo == true && r_circulo.Text != "")
            {
                double raio = double.Parse(r_circulo.Text);

                result_circulo.Text = (raio * raio * PI).ToString("###,##0.00");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            if (flag_a_bhaskara == true && flag_b_bhaskara == true && flag_c_bhaskara == true)
            {

                if (a_bhaskara.Text == "")
                {
                    a_bhaskara.Text = "0";
                }
                double a = double.Parse(a_bhaskara.Text);
                if (b_bhaskara.Text == "")
                {
                    b_bhaskara.Text = "0";
                }
                double b = double.Parse(b_bhaskara.Text);

                if (c_bhaskara.Text == "")
                {
                    c_bhaskara.Text = "0";
                }
                double c = double.Parse(c_bhaskara.Text);

                if (a == 0)
                {
                    result_bhaskara.Text = "\r\n\r\n\r\n\r\n\r\nPara ser uma equação do segundo grau\r\n'A' não pode valer 0!!!";
                }
                else
                {
                    double delta = ((b * b) + (-4 * (a * c))); ;

                    result_bhaskara.Text = " A = " + a;
                    result_bhaskara.Text = result_bhaskara.Text + "\r\n B = " + b;
                    result_bhaskara.Text = result_bhaskara.Text + "\r\n C = " + c;

                    result_bhaskara.Text = result_bhaskara.Text + "\r\n\r\n ▲ = b² - ( 4 * a * c )";
                    result_bhaskara.Text = result_bhaskara.Text + "\r\n ▲ = " + b + "²" + " - ( 4 * " + a + " *  " + c;
                    result_bhaskara.Text = result_bhaskara.Text + " )\r\n ▲ = " + (b * b) + " - ( 4 * " + a + " *  " + c;
                    result_bhaskara.Text = result_bhaskara.Text + " )\r\n ▲ = " + (b * b) + " - ( 4 * " + (a * c);
                    result_bhaskara.Text = result_bhaskara.Text + " )\r\n ▲ = " + (b * b) + " " + (-4 * (a * c));
                    result_bhaskara.Text = result_bhaskara.Text + "\r\n\r\n ▲ = " + ((b * b) + (-4 * (a * c)));

                    if (delta < 0)
                    {
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n\r\n Delta menor que zero!";

                        result_bhaskara.Text = result_bhaskara.Text + "\r\n\r\n Não há raizes reais!";
                    }
                    else if (delta == 0)
                    {
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n\r\n X = ( - b (+/-) RAIZ(▲) )  / 2 * a";
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n X = ( " + (b * -1) + " (+/-) RAIZ ( 0 ) )  / (2 * " + a;
                        result_bhaskara.Text = result_bhaskara.Text + ")\r\n X = " + (b * -1) + " / " + (2 * a);
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n X = " + ((b * -1) / (2 * a));
                    }
                    else
                    {
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n\r\n X¹ = ( - b + RAIZ(▲) )  / 2,00 * a";
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n X¹ = ( " + (b * -1).ToString("###,##0.00") + " + RAIZ( " + delta.ToString("###,##0.00") + " ) )  / 2,00 * " + a.ToString("###,##0.00");
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n X¹ = ( " + (b * -1).ToString("###,##0.00") + " + " + Math.Sqrt(delta).ToString("###,##0.00") + " ) / " + (2 * a).ToString("###,##0.00");
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n X¹ = " + ((b * -1) + (Math.Sqrt(delta))).ToString("###,##0.00") + " / " + (2 * a).ToString("###,##0.00");
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n X¹ = " + (((b * -1) + (Math.Sqrt(delta))) / (2 * a)).ToString("###,##0.00");

                        result_bhaskara.Text = result_bhaskara.Text + "\r\n\r\n X² = ( - b - RAIZ(▲) )  / 2,00 * a";
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n X² = ( " + (b * -1).ToString("###,##0.00") + " - RAIZ( " + delta.ToString("###,##0.00") + " ) )  / 2,00 * " + a.ToString("###,##0.00");
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n X² = ( " + (b * -1).ToString("###,##0.00") + " - " + Math.Sqrt(delta).ToString("###,##0.00") + " ) / " + (2 * a).ToString("###,##0.00");
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n X² = " + ((b * -1) - (Math.Sqrt(delta))).ToString("###,##0.00") + " / " + (2 * a).ToString("###,##0.00");
                        result_bhaskara.Text = result_bhaskara.Text + "\r\n X² = " + (((b * -1) - (Math.Sqrt(delta))) / (2 * a)).ToString("###,##0.00");
                    }
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

            if (Lado_A.Text == "")
            {
                Lado_A.Text = "0";
            }
            if (Lado_B.Text == "")
            {
                Lado_B.Text = "0";
            }
            if (Lado_C.Text == "")
            {
                Lado_C.Text = "0";
            }
            if (Angulo_A.Text == "")
            {
                Angulo_A.Text = "0";
            }
            if (Angulo_B.Text == "")
            {
                Angulo_B.Text = "0";
            }
            if (Angulo_C.Text == "")
            {
                Angulo_C.Text = "0";
            }
            double lado_a = double.Parse(Lado_A.Text);
            double lado_b = double.Parse(Lado_B.Text);
            double lado_c = double.Parse(Lado_C.Text);
            double angulo_a = double.Parse(Angulo_A.Text);
            double angulo_b = double.Parse(Angulo_B.Text);
            double angulo_c = double.Parse(Angulo_C.Text);

            int i;
            
                for (i = 0; i < 5; i++)
                {
                    if (angulo_a > 0 && angulo_b > 0 && angulo_c == 0)
                    {
                        angulo_c = 180 - (angulo_a + angulo_b);
                    }
                    else if (angulo_a > 0 && angulo_c > 0 && angulo_b == 0)
                    {
                        angulo_b = 180 - (angulo_a + angulo_c);
                    }
                    else if (angulo_b > 0 && angulo_c > 0 && angulo_a == 0)
                    {
                        angulo_a = 180 - (angulo_b + angulo_c);
                    }


                    if (lado_a == lado_b && lado_b == lado_c && lado_c == lado_a && lado_b != 0)
                    {
                        angulo_a = 60;
                        angulo_b = 60;
                        angulo_c = 60;
                    }
                    if (lado_a != 0 && lado_a == lado_b && (angulo_a == 60 || angulo_b == 60 || angulo_c == 60))
                    {
                        angulo_a = 60;
                        angulo_b = 60;
                        angulo_c = 60;
                        lado_c = lado_b;
                    }
                    if (lado_c != 0 && lado_c == lado_b && (angulo_a == 60 || angulo_b == 60 || angulo_c == 60))
                    {
                        angulo_a = 60;
                        angulo_b = 60;
                        angulo_c = 60;
                        lado_a = lado_b;
                    }
                    if (lado_c != 0 && lado_a == lado_c && (angulo_a == 60 || angulo_b == 60 || angulo_c == 60))
                    {
                        angulo_a = 60;
                        angulo_b = 60;
                        angulo_c = 60;
                        lado_b = lado_c;
                    }
                    if (angulo_a == 60 && (angulo_a == angulo_b || angulo_a == angulo_c))
                    {
                        if (lado_a > 0 && lado_b == 0 && lado_c == 0)
                        {
                            lado_b = lado_a;
                            lado_c = lado_a;
                        }
                        if (lado_b > 0 && lado_a == 0 && lado_c == 0)
                        {
                            lado_a = lado_b;
                            lado_c = lado_b;
                        }
                        if (lado_c > 0 && lado_b == 0 && lado_a == 0)
                        {
                            lado_b = lado_c;
                            lado_a = lado_c;
                        }

                    }
                    if (angulo_b == 60 && (angulo_a == angulo_b || angulo_b == angulo_c))
                    {
                        if (lado_a > 0 && lado_b == 0 && lado_c == 0)
                        {
                            lado_b = lado_a;
                            lado_c = lado_a;
                        }
                        if (lado_b > 0 && lado_a == 0 && lado_c == 0)
                        {
                            lado_a = lado_b;
                            lado_c = lado_b;
                        }
                        if (lado_c > 0 && lado_b == 0 && lado_a == 0)
                        {
                            lado_b = lado_c;
                            lado_a = lado_c;
                        }

                    }
                    if (angulo_a == 90)
                    {
                        for (i = 0; i < 5; i++)
                        {
                            if (lado_b == lado_c && angulo_b == 0 && angulo_c == 0)
                            {
                                angulo_b = 45;
                                angulo_c = 45;
                            }
                            if (angulo_b == 45 && angulo_c == 0)
                            {
                                angulo_c = 45;
                            }
                            if (angulo_c == 45 && angulo_b == 0)
                            {
                                angulo_b = 45;
                            }
                            if (angulo_b == 45 && lado_b > 0 && lado_c == 0)
                            {
                                angulo_c = 45;
                                lado_c = lado_b;
                            }
                            if (angulo_c == 45 && lado_c > 0 && lado_b == 0)
                            {
                                angulo_b = 45;
                                lado_b = lado_c;

                            }
                            if (lado_a == 0 && lado_b > 0 && lado_c > 0)
                            {
                                lado_a = Math.Sqrt((lado_b * lado_b) + (lado_c * lado_c));
                            }
                            if (lado_b == 0 && lado_a > 0 && lado_c > 0)
                            {
                                lado_b = Math.Sqrt((lado_a * lado_a) - (lado_c * lado_c));
                            }
                            if (lado_c == 0 && lado_a > 0 && lado_b > 0)
                            {
                                lado_c = Math.Sqrt((lado_a * lado_a) - (lado_b * lado_b));
                            }
                            if (lado_b == 0 && lado_c > 0 && angulo_b > 0)
                            {
                                lado_b = Math.Tan(angulo_b * PI / 180) * lado_c;
                            }
                            if (lado_c == 0 && lado_b > 0 && angulo_c > 0)
                            {
                                lado_c = Math.Tan(angulo_c * PI / 180) * lado_b;
                            }
                            if (lado_b == 0 && lado_a > 0 && angulo_b > 0)
                            {
                                lado_b = Math.Sin(angulo_b * PI / 180) * lado_a;
                            }
                            if (lado_c == 0 && lado_a > 0 && angulo_c > 0)
                            {
                                lado_c = Math.Sin(angulo_c * PI / 180) * lado_a;
                            }
                            if (lado_b == 0 && lado_a > 0 && angulo_c > 0)
                            {
                                lado_b = Math.Cos(angulo_c * PI / 180) * lado_a;
                            }
                            if (lado_c == 0 && lado_a > 0 && angulo_b > 0)
                            {
                                lado_c = Math.Cos(angulo_b * PI / 180) * lado_a;
                            }
                            
                        }
                    }
                    else if (angulo_b == 90)
                    {
                        for (i = 0; i < 5; i++)
                        {
                            if (lado_a == lado_c && angulo_a == 0 && angulo_c == 0)
                            {
                                angulo_a = 45;
                                angulo_c = 45;
                            }
                            if (angulo_a == 45 && angulo_c == 0)
                            {
                                angulo_c = 45;
                            }
                            if (angulo_c == 45 && angulo_a == 0)
                            {
                                angulo_a = 45;
                            }
                            if (angulo_a == 45 && lado_a > 0 && lado_c == 0)
                            {
                                angulo_c = 45;
                                lado_c = lado_a;
                            }
                            if (angulo_c == 45 && lado_c > 0 && lado_a == 0)
                            {
                                angulo_a = 45;
                                lado_a = lado_c;
                            }
                            if (lado_b == 0 && lado_a > 0 && lado_c > 0)
                            {
                                lado_b = Math.Sqrt((lado_a * lado_a) + (lado_c * lado_c));
                            }
                            if (lado_a == 0 && lado_b > 0 && lado_c > 0)
                            {
                                lado_a = Math.Sqrt((lado_b * lado_b) - (lado_c * lado_c));
                            }
                            if (lado_c == 0 && lado_b > 0 && lado_a > 0)
                            {
                                lado_c = Math.Sqrt((lado_b * lado_b) - (lado_a * lado_a));
                            }

                            if (lado_a == 0 && lado_c > 0 && angulo_a > 0)
                            {
                                lado_a = Math.Tan(angulo_a * PI / 180) * lado_c;
                            }
                            if (lado_c == 0 && lado_a > 0 && angulo_c > 0)
                            {
                                lado_c = Math.Tan(angulo_c * PI / 180) * lado_a;
                            }

                            if (lado_a == 0 && lado_b > 0 && angulo_a > 0)
                            {
                                lado_a = Math.Sin(angulo_a * PI / 180) * lado_b;
                            }
                            if (lado_c == 0 && lado_b > 0 && angulo_c > 0)
                            {
                                lado_c = Math.Sin(angulo_c * PI / 180) * lado_b;
                            }
                            if (lado_a == 0 && lado_b > 0 && angulo_c > 0)
                            {
                                lado_a = Math.Cos(angulo_c * PI / 180) * lado_b;
                            }
                            if (lado_c == 0 && lado_b > 0 && angulo_a > 0)
                            {
                                lado_c = Math.Cos(angulo_a * PI / 180) * lado_b;
                            }
                            
                        }
                    }
                    else if (angulo_c == 90)
                    {
                        for (i = 0; i < 5; i++)
                        {

                            if (lado_b == lado_a && angulo_b == 0 && angulo_a == 0)
                            {
                                angulo_b = 45;
                                angulo_a = 45;
                            }
                            if (angulo_b == 45 && angulo_a == 0)
                            {
                                angulo_a = 45;
                            }
                            if (angulo_a == 45 && angulo_b == 0)
                            {
                                angulo_b = 45;
                            }
                            if (angulo_b == 45 && lado_b > 0 && lado_a == 0)
                            {
                                angulo_a = 45;
                                lado_a = lado_b;
                            }
                            if (angulo_a == 45 && lado_a > 0 && lado_b == 0)
                            {
                                angulo_b = 45;
                                lado_b = lado_a;
                            }
                            if (lado_c == 0 && lado_b > 0 && lado_a > 0)
                            {
                                lado_c = Math.Sqrt((lado_b * lado_b) + (lado_a * lado_a));
                            }
                            if (lado_b == 0 && lado_c > 0 && lado_a > 0)
                            {
                                lado_b = Math.Sqrt((lado_c * lado_c) - (lado_a * lado_a));
                            }
                            if (lado_a == 0 && lado_c > 0 && lado_b > 0)
                            {
                                lado_a = Math.Sqrt((lado_c * lado_c) - (lado_b * lado_b));
                            }

                            if (lado_b == 0 && lado_a > 0 && angulo_b > 0)
                            {
                                lado_b = Math.Tan(angulo_b * PI / 180) * lado_a;
                            }
                            if (lado_a == 0 && lado_b > 0 && angulo_a > 0)
                            {
                                lado_a = Math.Tan(angulo_a * PI / 180) * lado_b;
                            }

                             if (lado_b == 0 && lado_c > 0 && angulo_b > 0)
                            {
                                lado_b = Math.Sin(angulo_b * PI / 180) * lado_c;
                            }
                            if (lado_a == 0 && lado_c > 0 && angulo_a > 0)
                            {
                                lado_a = Math.Sin(angulo_a * PI / 180) * lado_c;
                            }
                            if (lado_b == 0 && lado_c > 0 && angulo_a > 0)
                            {
                                lado_b = Math.Cos(angulo_a * PI / 180) * lado_c;
                            }
                            if (lado_a == 0 && lado_c > 0 && angulo_b > 0)
                            {
                                lado_a = Math.Cos(angulo_b * PI / 180) * lado_c;
                            }
                            
                        }
                    }
                    else
                    {
                        for (i = 0; i < 15; i++)
                        {
                            if (angulo_a > 0 && angulo_b > 0 && angulo_c == 0)
                            {
                                angulo_c = 180 - (angulo_a + angulo_b);
                            }
                            else if (angulo_a > 0 && angulo_c > 0 && angulo_b == 0)
                            {
                                angulo_b = 180 - (angulo_a + angulo_c);
                            }
                            else if (angulo_b > 0 && angulo_c > 0 && angulo_a == 0)
                            {
                                angulo_a = 180 - (angulo_b + angulo_c);
                            }



                            //LADO A
                            if (lado_a == 0 && lado_b > 0 && lado_c > 0 && angulo_b > 0 && angulo_c > 0)
                            {
                                lado_a = (lado_b * (Math.Cos(angulo_c * PI / 180)) + (lado_c * (Math.Cos(angulo_b * PI / 180))));
                            }
                            else if (lado_a == 0 && lado_b > 0 && lado_c > 0 && angulo_a > 0)
                            {
                                lado_a = Math.Sqrt((Math.Pow(lado_b, 2) + Math.Pow(lado_c, 2)) - 2 * lado_b * lado_c * Math.Cos(angulo_a * PI / 180));
                            }
                            else if (angulo_c > 0 && lado_c > 0 && lado_a == 0 && angulo_a > 0)
                            {
                                lado_a = (lado_c * Math.Sin(angulo_a * PI / 180)) / Math.Sin(angulo_c * PI / 180);
                            }
                            else if (angulo_b > 0 && lado_b > 0 && lado_a == 0 && angulo_a > 0)
                            {
                                lado_a = (lado_b * Math.Sin(angulo_a * PI / 180)) / Math.Sin(angulo_b * PI / 180);
                            }

                            //LADO B
                            if (lado_b == 0 && lado_a > 0 && lado_c > 0 && angulo_c > 0 && angulo_a > 0)
                            {
                                lado_b = (lado_c * (Math.Cos(angulo_a * PI / 180)) + (lado_a * (Math.Cos(angulo_c * PI / 180))));
                            }
                            else if (lado_b == 0 && lado_a > 0 && lado_c > 0 && angulo_b > 0)
                            {
                                lado_b = Math.Sqrt((Math.Pow(lado_a, 2) + Math.Pow(lado_c, 2)) - 2 * lado_a * lado_c * Math.Cos(angulo_b * PI / 180));
                            }
                            else if (angulo_b > 0 && lado_b > 0 && lado_c == 0 && angulo_c > 0)
                            {
                                lado_b = (lado_c * Math.Sin(angulo_b * PI / 180)) / Math.Sin(angulo_c * PI / 180);
                            }
                            else if (angulo_b > 0 && lado_c > 0 && lado_b == 0 && angulo_b > 0)
                            {
                                lado_b = (lado_a * Math.Sin(angulo_b * PI / 180)) / Math.Sin(angulo_a * PI / 180);
                            }

                            //LADO C
                            if (lado_c == 0 && lado_a > 0 && lado_b > 0 && angulo_a > 0 && angulo_b > 0)
                            {
                                lado_c = (lado_a * (Math.Cos(angulo_b * PI / 180)) + (lado_b * (Math.Cos(angulo_a * PI / 180))));
                            }
                            else if (lado_c == 0 && lado_a > 0 && lado_b > 0 && angulo_c > 0)
                            {
                                lado_c = Math.Sqrt((Math.Pow(lado_a, 2) + Math.Pow(lado_b, 2)) - 2 * lado_a * lado_b * Math.Cos(angulo_c * PI / 180));
                            }
                            else if (angulo_a > 0 && lado_a > 0 && lado_c == 0 && angulo_c > 0)
                            {
                                lado_c = (lado_a * Math.Sin(angulo_c * PI / 180)) / Math.Sin(angulo_a * PI / 180);
                            }
                            else if (angulo_b > 0 && lado_b > 0 && lado_c == 0 && angulo_c > 0)
                            {
                                lado_c = (lado_b * Math.Sin(angulo_c * PI / 180)) / Math.Sin(angulo_b * PI / 180);
                            }
                        }
                    }
                }


                //VERIFICAÇÃO !!!

                Erro.Text = "";

                if (angulo_a >= 180 || angulo_b >= 180 || angulo_c >= 180)
                {
                    Erro.Text = "Um angulo não pode ser igual ou maior que 180 !";
                    Angulo_A.Enabled = false;
                    Angulo_B.Enabled = false;
                    Angulo_C.Enabled = false;
                    Lado_A.Enabled = false;
                    Lado_B.Enabled = false;
                    Lado_C.Enabled = false;
                }
                else if ((lado_a + lado_b < lado_c && lado_a != 0 && lado_b != 0 && lado_c != 0) || (lado_a + lado_c < lado_b && lado_a != 0 && lado_b != 0 && lado_c != 0) || (lado_b + lado_c < lado_a && lado_a != 0 && lado_b != 0 && lado_c != 0))
                {
                    Erro.Text = "A soma de dois lados não podem ser menor que o terceiro !";
                    Angulo_A.Enabled = false;
                    Angulo_B.Enabled = false;
                    Angulo_C.Enabled = false;
                    Lado_A.Enabled = false;
                    Lado_B.Enabled = false;
                    Lado_C.Enabled = false;
                    Lado_A.Text = lado_a.ToString("###,###,##0.00");
                    Lado_B.Text = lado_b.ToString("###,###,##0.00");
                    Lado_C.Text = lado_c.ToString("###,###,##0.00");
                }
                else if (lado_a <= 0 || lado_b <= 0 || lado_c <= 0)
                {
                    Erro.Text = "Dados insuficientes !";
                }
                else if (angulo_a + angulo_b + angulo_c != 180)
                {
                    Lado_A.Text = lado_a.ToString("###,###,##0.00");
                    Lado_B.Text = lado_b.ToString("###,###,##0.00");
                    Lado_C.Text = lado_c.ToString("###,###,##0.00");
                    Erro.Text = "Dados insuficientes para calcular os ângulos !";
                    Angulo_A.Enabled = false;
                    Angulo_B.Enabled = false;
                    Angulo_C.Enabled = false;
                    Lado_A.Enabled = false;
                    Lado_B.Enabled = false;
                    Lado_C.Enabled = false;
                }
                else
                {
                    Erro.Text = "";
                    Angulo_A.Text = angulo_a.ToString("###,###,##0.00");
                    Angulo_B.Text = angulo_b.ToString("###,###,##0.00");
                    Angulo_C.Text = angulo_c.ToString("###,###,##0.00");
                    Lado_A.Text = lado_a.ToString("###,###,##0.00");
                    Lado_B.Text = lado_b.ToString("###,###,##0.00");
                    Lado_C.Text = lado_c.ToString("###,###,##0.00");
                    Angulo_A.Enabled = false;
                    Angulo_B.Enabled = false;
                    Angulo_C.Enabled = false;
                    Lado_A.Enabled = false;
                    Lado_B.Enabled = false;
                    Lado_C.Enabled = false;
                }
                
            
        }
        private void calcular_retangulo0_MouseHover(object sender, EventArgs e)
        {
            calcular_retangulo1.Visible = true;
        }

        private void calcular_triangulo0_MouseHover(object sender, EventArgs e)
        {
            calcular_triangulo1.Visible = true;
        }

        private void calcular_circulo0_MouseHover(object sender, EventArgs e)
        {
            calcular_circulo1.Visible = true;
        }

        private void calcular_retangulo1_MouseLeave(object sender, EventArgs e)
        {
            calcular_retangulo1.Visible = false;
        }

        private void calcular_triangulo1_MouseLeave(object sender, EventArgs e)
        {
            calcular_triangulo1.Visible = false;
        }

        private void calcular_circulo1_MouseLeave(object sender, EventArgs e)
        {
            calcular_circulo1.Visible = false;
        }

        private void altura_cubo_Click(object sender, EventArgs e)
        {
            a_cubo.Text = "";
            flag_a_cubo = true;
            flag_v_a_cubo = false;

        }


        private void altura_cubo_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_a_cubo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_a_cubo = true;
            }

        }

        private void c_cubo_Click(object sender, EventArgs e)
        {
            c_cubo.Text = "";
            flag_c_cubo = true;
            flag_v_c_cubo = false;
        
        }

        private void c_cubo_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_c_cubo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_c_cubo = true;
            }

        }

        private void b_cubo_Click(object sender, EventArgs e)
        {
            b_cubo.Text = "";
            flag_b_cubo = true;
            flag_v_b_cubo = false;
        
        }

        private void b_cubo_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_b_cubo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_b_cubo = true;
            }

        }

        private void raio_esfera_Click(object sender, EventArgs e)
        {
            raio_esfera.Text = "";
            flag_esfera = true;

            flag_v_esfera = false;
        }

        private void raio_esfera_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_esfera == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_esfera = true;
            }

        }

        private void a_cone_Click(object sender, EventArgs e)
        {
            a_cone.Text = "";
            flag_a_cone = true;

            flag_v_a_cone = false;
        }

        private void a_cone_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_a_cone == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_a_cone = true;
            }

        }

        private void r_cone_Click(object sender, EventArgs e)
        {
            r_cone.Text = "";
            flag_r_cone = true;
            flag_v_r_cone = false;
        }

        private void r_cone_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_r_cone == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_r_cone = true;
            }

        }

        private void a_cilindro_Click(object sender, EventArgs e)
        {
            a_cilindro.Text = "";
            flag_a_cilindro = true; 
            flag_v_a_cilindro = false;
        
        }

        private void a_cilindro_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_a_cilindro == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_a_cilindro = true;
            }

        }

        private void r_cilindro_Click(object sender, EventArgs e)
        {
            r_cilindro.Text = "";
            flag_r_cilindro = true;

            flag_v_r_cilindro = false;
        }

        private void r_cilindro_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_r_cilindro == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_r_cilindro = true;
            }

        }

        private void calcular_cubo0_MouseHover(object sender, EventArgs e)
        {
            calcular_cubo1.Visible = true;
        }

        private void calcular_cubo1_Click(object sender, EventArgs e)
        {
            if (flag_a_cubo == true && flag_b_cubo == true && flag_c_cubo == true && a_cubo.Text != "" && b_cubo.Text != "" && c_cubo.Text != "")
            {
                double a = double.Parse(a_cubo.Text);
                double b = double.Parse(b_cubo.Text);
                double c = double.Parse(c_cubo.Text);

                result_cubo.Text = (a * b * c).ToString("###,##0.00");
            }
        }

        private void calcular_cubo1_MouseLeave(object sender, EventArgs e)
        {
            calcular_cubo1.Visible = false;
        }

        private void calcular_esfera0_MouseHover(object sender, EventArgs e)
        {
            calcular_esfera1.Visible = true;
        }

        private void calcular_esfera1_Click(object sender, EventArgs e)
        {
            if (flag_esfera == true && raio_esfera.Text != "")
            {
                double r = double.Parse(raio_esfera.Text);

                result_esfera.Text = ((4 / 3) * PI * r * r * r).ToString("###,##0.00");
            }
        }

        private void calcular_esfera1_MouseLeave(object sender, EventArgs e)
        {
            calcular_esfera1.Visible = false;
        }

        private void calcular_cone0_MouseHover(object sender, EventArgs e)
        {
            calcular_cone1.Visible = true;
        }

        private void calcular_cone1_Click(object sender, EventArgs e)
        {
            if (flag_a_cone == true && flag_r_cone == true && a_cone.Text != "" && r_cone.Text != "")
            {
                double a = double.Parse(a_cone.Text);
                double r = double.Parse(r_cone.Text);
                double area = r * r * PI;

                result_cone.Text = ((area * a) / 3).ToString("###,##0.00");
            }
        }

        private void calcular_cone1_MouseLeave(object sender, EventArgs e)
        {
            calcular_cone1.Visible = false;
        }

        private void calcular_cilindro0_MouseHover(object sender, EventArgs e)
        {
            calcular_cilindro1.Visible = true;
        }

        private void calcular_cilindro1_Click(object sender, EventArgs e)
        {
            if (flag_a_cilindro == true && flag_r_cilindro == true && a_cilindro.Text != "" && r_cilindro.Text != "")
            {
                double a = double.Parse(a_cilindro.Text);
                double r = double.Parse(r_cilindro.Text);

                double area = r * r * PI;

                result_cilindro.Text = (area * a).ToString("###,##0.00");
            }
        }

        private void calcular_cilindro1_MouseLeave(object sender, EventArgs e)
        {
            calcular_cilindro1.Visible = false;
        }

        private void calcular_bhaskara0_MouseHover(object sender, EventArgs e)
        {
            calcular_bhaskara1.Visible = true;
        }

        private void calcular_bhaskara1_MouseLeave(object sender, EventArgs e)
        {
            calcular_bhaskara1.Visible = false;
        }

        private void a_bhaskara_Click(object sender, EventArgs e)
        {
            a_bhaskara.Text = "";
            flag_a_bhaskara = true;
            flag_v_a_bhaskara = false;
            flag_m_a_bhaskara = false;
        }

        private void a_bhaskara_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_a_bhaskara == false && flag_m_a_bhaskara == true)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else if (flag_v_a_bhaskara == true && flag_m_a_bhaskara == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != '-')
                {
                    e.Handled = true;
                }
            }
            else if (flag_v_a_bhaskara == true && flag_m_a_bhaskara == true)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != '-' && a != ',')
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_a_bhaskara = true;
            }
            if (a == '-')
            {
                flag_m_a_bhaskara = true;
            }

        }

        private void b_bhaskara_Click(object sender, EventArgs e)
        {
            b_bhaskara.Text = "";
            flag_b_bhaskara = true;
            flag_v_b_bhaskara = false;
            flag_m_b_bhaskara = false;
        }

        private void b_bhaskara_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_b_bhaskara == false && flag_m_b_bhaskara == true)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else if (flag_v_b_bhaskara == true && flag_m_b_bhaskara == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != '-')
                {
                    e.Handled = true;
                }
            }
            else if (flag_v_b_bhaskara == true && flag_m_b_bhaskara == true)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != '-' && a != ',')
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_b_bhaskara = true;
            }
            if (a == '-')
            {
                flag_m_b_bhaskara = true;
            }

        }

        private void c_bhaskara_Click(object sender, EventArgs e)
        {
            c_bhaskara.Text = "";
            flag_c_bhaskara = true;
            flag_v_c_bhaskara = false;
            flag_m_c_bhaskara = false;
        }

        private void c_bhaskara_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_c_bhaskara == false && flag_m_c_bhaskara == true)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else if (flag_v_c_bhaskara == true && flag_m_c_bhaskara == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != '-')
                {
                    e.Handled = true;
                }
            }
            else if (flag_v_c_bhaskara == true && flag_m_c_bhaskara == true)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != '-' && a != ',')
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_c_bhaskara = true;
            }
            if (a == '-')
            {
                flag_m_c_bhaskara = true;
            }

        }

        private void fechar0_MouseHover(object sender, EventArgs e)
        {
            fechar1.Visible = true;
            fechar0.Visible = false;
        }

        private void fechar1_MouseLeave(object sender, EventArgs e)
        {
            fechar0.Visible = true;
            fechar1.Visible = false;
        }

        private void fechar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void min0_MouseHover(object sender, EventArgs e)
        {
            min0.Visible = false;
            min1.Visible = true;
        }

        private void min1_MouseLeave(object sender, EventArgs e)
        {
            min0.Visible = true;
            min1.Visible = false;
        }

        private void min1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void calcular_triangulo_MouseHover(object sender, EventArgs e)
        {
            calcular_triangulo.Visible = false;
            calcular_triangulo2.Visible = true;
        }

        private void calcular_triangulo2_MouseLeave(object sender, EventArgs e)
        {
            calcular_triangulo2.Visible = false;
            calcular_triangulo.Visible = true;
        }

        private void Erro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void limpar_triangulo_MouseHover(object sender, EventArgs e)
        {
            limpar_triangulo1.Visible = true;
            limpar_triangulo.Visible = false;
        }

        private void limpar_triangulo1_MouseLeave(object sender, EventArgs e)
        {
            limpar_triangulo1.Visible = false;
            limpar_triangulo.Visible = true;
        }

        private void limpar_triangulo1_Click(object sender, EventArgs e)
        {
            Angulo_A.Text = "0";
            Angulo_B.Text = "0";
            Angulo_C.Text = "0";
            Lado_A.Text = "0";
            Lado_B.Text = "0";
            Lado_C.Text = "0";
            Erro.Text = "";
            Angulo_A.Enabled = true;
            Angulo_B.Enabled = true;
            Angulo_C.Enabled = true;
            Lado_A.Enabled = true;
            Lado_B.Enabled = true;
            Lado_C.Enabled = true;
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            calcular_retangulo1.Visible = true;
        }

        private void calcular_retangulo1_Click_1(object sender, EventArgs e)
        {
            if (flag_a_retangulo == true && flag_b_retangulo == true && a_retangulo.Text != "" && b_retangulo.Text != "")
            {
                double a = double.Parse(a_retangulo.Text);
                double b = double.Parse(b_retangulo.Text);

                result_retangulo.Text = (a * b).ToString("###,##0.00");
            }
        }

        private void calcular_retangulo1_MouseLeave_1(object sender, EventArgs e)
        {
            calcular_retangulo1.Visible = false;
        }

        private void limpar_tri_MouseHover(object sender, EventArgs e)
        {
            limpar_tri1.Visible = true;
        }

        private void limpar_tri1_MouseLeave(object sender, EventArgs e)
        {
            limpar_tri1.Visible = false;
        }

        private void limpar_circulo_MouseHover(object sender, EventArgs e)
        {
            limpar_circulo1.Visible = true;
        }

        private void limpar_circulo1_MouseLeave(object sender, EventArgs e)
        {
            limpar_circulo1.Visible = false;
        }

        private void limpar_retangulo1_Click(object sender, EventArgs e)
        {
            a_retangulo.Text = "Altura";
            b_retangulo.Text = "Base";
            result_retangulo.Text = "";

            flag_a_retangulo = false;
            flag_b_retangulo = false;
            flag_v_a_retangulo = false;
            flag_v_b_retangulo = false;
        }

        private void limpar_retangulo_MouseHover(object sender, EventArgs e)
        {
            limpar_retangulo1.Visible = true;
        }

        private void limpar_tri1_Click(object sender, EventArgs e)
        {
            a_triangulo.Text = "Altura";
            b_triangulo.Text = "Base";
            result_triangulo.Text = "";

            flag_a_triangulo = false;
            flag_b_triangulo = false;
            flag_v_a_triangulo = false;
            flag_v_b_triangulo = false;
        }

        private void limpar_circulo1_Click(object sender, EventArgs e)
        {
            r_circulo.Text = "Raio";
            result_circulo.Text = "";

            flag_r_circulo = false;
            flag_v_r_circulo = false;
        }

        private void limpar_bhaskara_MouseHover(object sender, EventArgs e)
        {
            limpar_bhaskara1.Visible = true;
        }

        private void limpar_bhaskara1_MouseLeave(object sender, EventArgs e)
        {
            limpar_bhaskara1.Visible = false;
        }

        private void limpar_bhaskara1_Click(object sender, EventArgs e)
        {
            a_bhaskara.Text = "A";
            b_bhaskara.Text = "B";
            c_bhaskara.Text = "C";
            result_bhaskara.Text = "";

            flag_a_bhaskara = false;
            flag_b_bhaskara = false;
            flag_c_bhaskara = false;
            flag_v_a_bhaskara = false;
            flag_v_b_bhaskara = false;
            flag_v_c_bhaskara = false;
        }

        private void limpar_cubo_MouseHover(object sender, EventArgs e)
        {
            limpar_cubo1.Visible = true;
        }

        private void limpar_cubo1_MouseLeave(object sender, EventArgs e)
        {
            limpar_cubo1.Visible = false;
        }

        private void limpar_esfera_MouseHover(object sender, EventArgs e)
        {
            limpar_esfera1.Visible = true;
        }

        private void limpar_esfera1_MouseLeave(object sender, EventArgs e)
        {
            limpar_esfera1.Visible = false;
        }

        private void limpar_cone_MouseHover(object sender, EventArgs e)
        {
            limpar_cone1.Visible = true;
        }

        private void limpar_cone1_MouseLeave(object sender, EventArgs e)
        {
            limpar_cone1.Visible = false;
        }

        private void limpar_cilindro_MouseHover(object sender, EventArgs e)
        {
            limpar_cilindro1.Visible = true;
        }

        private void limpar_cilindro1_MouseLeave(object sender, EventArgs e)
        {
            limpar_cilindro1.Visible = false;
        }

        private void limpar_cubo1_Click(object sender, EventArgs e)
        {
            a_cubo.Text = "Altura";
            b_cubo.Text = "Base";
            c_cubo.Text = "Comprimento";
            result_cubo.Text = "";

            flag_a_cubo = false;
            flag_b_cubo = false; 
            flag_c_cubo = false;

            flag_v_a_cubo = false;
            flag_v_b_cubo = false;
            flag_v_c_cubo = false; 

        }

        private void limpar_esfera1_Click(object sender, EventArgs e)
        {
            raio_esfera.Text = "Raio";
            result_esfera.Text = "";

            flag_esfera = false;
            flag_v_esfera = false;
        }

        private void limpar_cone1_Click(object sender, EventArgs e)
        {
            a_cone.Text = "Altura";
            r_cone.Text = "Raio";
            result_cone.Text = "";

            flag_a_cone = false;
            flag_r_cone = false;
            
            flag_v_a_cone = false;
            flag_v_r_cone = false;

        }

        private void limpar_cilindro1_Click(object sender, EventArgs e)
        {
            a_cilindro.Text = "Altura";
            r_cilindro.Text = "Raio";
            result_cilindro.Text = "";

            flag_a_cilindro = false;
            flag_r_cilindro = false;

            flag_v_a_cilindro = false;
            flag_v_r_cilindro = false;
        }

        private void Angulo_A_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_a_angulo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_a_angulo = true;
            }

        }

        private void Lado_B_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_b_lado == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_b_lado = true;
            }

        }

        private void Angulo_C_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_c_angulo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_c_angulo = true;
            }


        }

        private void Lado_A_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_a_lado == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_a_lado = true;
            }

        }

        private void Angulo_B_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_b_angulo == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_b_angulo = true;
            }

        }

        private void Lado_C_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            int a = (int)c;

            // somente numeros

            if (flag_v_c_lado == false)
            {
                if (!char.IsNumber(e.KeyChar) && a != 8 && a != ',')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && a != 8)
                {
                    e.Handled = true;
                }
            }

            if (a == ',')
            {
                flag_v_c_lado = true;
            }

        }

        private void limpar_retangulo1_MouseLeave(object sender, EventArgs e)
        {
            limpar_retangulo1.Visible = false;
        }

        private void desenvolvimento0_MouseHover(object sender, EventArgs e)
        {
            Desenvolvimento1.Visible = true;
        }

        private void Desenvolvimento1_MouseLeave(object sender, EventArgs e)
        {
            Desenvolvimento1.Visible = false;
        }

        private void Desenvolvimento1_Click(object sender, EventArgs e)
        {
            area_a.Visible = true;
            area_c.Visible = false;
            volume_a.Visible = true;
            volume_c.Visible = false;
            bhaskara_a.Visible = true;
            bhaskara_c.Visible = false;
            triangulo_a.Visible = true;
            triangulo_c.Visible = false;
            tabela_a.Visible = true;
            tabela_c.Visible = false;
            desenvolvimento0.Visible = false;
            Desenvolvimento1.Visible = false;
            desenvolvimento2.Visible = true;
            menu_area = false;
            menu_volume = false;
            menu_bhaskara = false;
            menu_triangulo = false;
            menu_tabela = false;

            grupo_area.Visible = false;
            grupo_bhaskara.Visible = false;
            grupo_triangulo.Visible = false;
            grupo_volume.Visible = false;
            grupo_tabela.Visible = false;
            grupo_desenvolvimento.Visible = true;
        }

        private void Angulo_C_Click(object sender, EventArgs e)
        {
            Angulo_C.Text = "";
            flag_c_angulo = true;
            flag_v_c_angulo = false;
        }

        private void Lado_A_Click(object sender, EventArgs e)
        {
            Lado_A.Text = "";
            flag_a_lado = true;
            flag_v_a_lado = false;
        }

        private void Angulo_B_Click(object sender, EventArgs e)
        {
            Angulo_B.Text = "";
            flag_b_angulo = true;
            flag_v_b_angulo = false;
        }

        private void Lado_C_Click(object sender, EventArgs e)
        {
            Lado_C.Text = "";
            flag_c_lado = true;
            flag_v_c_lado = false;
        }

        private void Angulo_A_Click(object sender, EventArgs e)
        {
            Angulo_A.Text = "";
            flag_a_angulo = true;
            flag_v_a_angulo = false;
        }

        private void Lado_B_Click(object sender, EventArgs e)
        {
            Lado_B.Text = "";
            flag_b_lado = true;
            flag_v_b_lado = false;
        }

        private void area_a_MouseMove(object sender, MouseEventArgs e)
        {
            if (menu_area == false)
            {
                area_b.Visible = true;
                area_a.Visible = false;
            }
        }
    }
    
}