using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Matchmaking
{
    public partial class Pnlbase : Form
    {
        // Importa a função ReleaseCapture e SendMessage da User32.dll para permitir arrastar a janela
        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public Pnlbase()
        {
            InitializeComponent();
        
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnFecharLogin_Click(object sender, EventArgs e)
        {
            this.Close(); // Esse Comando fecha o formulário
        }

        private void btnFecharRegister_Click(object sender, EventArgs e)
        {
            this.Close(); // Esse Comando Fecha o formulário
        }

        private void btnMinimizarRegister_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Esse Comando minimiza o formulário
        }

        private void btnMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Esse Comando minimiza o formulário
        }

        private void Pnlbase_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
