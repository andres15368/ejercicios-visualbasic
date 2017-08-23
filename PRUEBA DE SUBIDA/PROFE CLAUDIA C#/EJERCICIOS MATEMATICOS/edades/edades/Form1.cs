using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class calcular : Form
    {
        public calcular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(textBox1.Text); 
           
            if(n>=18){
          MessageBox.Show ("es mayor de edad");
                 }
      else{
           MessageBox.Show("es menor de edad");
        }
    }
}
}