using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hjh
{
    public partial class Menu : Form
    {
        FormRegistro registro;
        FormHistorial historial;
        FormDerechoshumanos derechoshumanos;
        FormAcercade acercade;
        public Menu()
        {
            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 143)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 40)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void multa_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 86)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnSettings.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width <= 375)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnSettings.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            if (registro == null)
            {
                registro = new FormRegistro();
                registro.FormClosed += Registro_FormClosed;
                registro.MdiParent = this;
                registro.Dock = DockStyle.Fill;
                registro.Show();
            }
            else
            {
                registro.Activate();
            }
        }
        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            registro = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();//abriendo el formulario principal
            Hide();//esto sirve para ocultar el formulario de login
        }

        private void His_Click(object sender, EventArgs e)
        {
            if (historial == null)
            {
                historial = new FormHistorial();
                historial.FormClosed += historial_FormClosed;
                historial.MdiParent = this;
                historial.Dock = DockStyle.Fill;
                historial.Show();
            }
            else
            {
                historial.Activate();
            }
        }
        private void historial_FormClosed(object sender, FormClosedEventArgs e)
        {
            historial = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (acercade == null)
            {
                acercade = new FormAcercade();
                acercade.FormClosed += acercade_FormClosed;
                acercade.MdiParent = this;
                acercade.Dock = DockStyle.Fill;
                acercade.Show();
            }
            else
            {
                acercade.Activate();
            }

        }
        private void acercade_FormClosed(object sender, FormClosedEventArgs e)
        {
            acercade = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (derechoshumanos == null)
            {
                derechoshumanos = new FormDerechoshumanos();
                derechoshumanos.FormClosed += derechoshumanos_FormClosed;
                derechoshumanos.MdiParent = this;
                derechoshumanos.Dock = DockStyle.Fill;
                derechoshumanos.Show();
            }
            else
            {
                derechoshumanos.Activate();
            }
        }
        private void derechoshumanos_FormClosed(object sender, FormClosedEventArgs e)
        {
            derechoshumanos = null;
        }
    }
}

