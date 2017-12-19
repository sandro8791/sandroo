using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;
namespace WHAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMessage_Click(object sender, EventArgs e)
        {
            try
            {
                string from = "94991315204";
            string Fone = txFone.Text;
            string msg = txMessagem.Text;

            WhatsApp wa = new WhatsApp(from, "snowden+snowden=", "sekhar", false, false);

            wa.OnLoginSuccess += (phoneNumber, data) =>
                {
                    wa.SendMessage(Fone, msg);
                    MessageBox.Show("Messagem Enviada");
                };
            wa.OnLoginFailed += (data) =>
                {
                    MessageBox.Show("login errado:{0}", data);
                };
            wa.Login();
            {
                wa.OnConnectFailed += (ex) =>
            {
                MessageBox.Show("conecçao errada");
            };

                {
                    wa.Connect();
                }}}
            
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);          
            
            }
    }
}}
    



           
             
            
              
            
    

    
            

