using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W7__Panda_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void txtBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string simpanKalimat = "";
            string hurufPertama = "";
            string hurufKedua = "";
            int indexArray = 0;
            int indexArray2 = 0;
            int count = 0;
            char[] alphabetArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            simpanKalimat = txtBoxInput.Text.ToUpper();
            hurufPertama = txtBoxInputChar.Text.ToUpper();
            hurufKedua = txtBoxOutputChar.Text.ToUpper();
            simpanKalimat.ToCharArray();
            hurufPertama.ToCharArray();
            hurufKedua.ToCharArray();
            for (int i = 0; i < alphabetArray.Length; i++)
            {
                if (hurufPertama == alphabetArray[i].ToString())
                    indexArray = i;
            }
            for (int j = 0; j < alphabetArray.Length; j++)
            {
                if (hurufKedua == alphabetArray[j].ToString())
                    indexArray2 = j;
            }
            if (indexArray < indexArray2)
                count = -indexArray - indexArray2;
            else
                count = indexArray + indexArray2;

            for (int k = 0; k < simpanKalimat.Length; k++)
            {
                string results = count + indexArray.ToString();
                labelOutput.Text = txtBoxInput.Text;
                //string output = count + 
                //letters[kamuketemu indexnya berapa + selisihnya]
                //+selish ke setiap index cetak label output.text to string
            }
        }

        private void txtBoxInputChar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelOutput_Click(object sender, EventArgs e)
        {
           

        }
    }
}
