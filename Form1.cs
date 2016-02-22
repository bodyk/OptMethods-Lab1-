using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_MethodOpt_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Function
        {
            public double x1, x2, result;
            public string sign;
            private string sign_between_x1_x2;

            private void SetSign(string x2)
            {
                if (x2.Contains("-"))
                    sign_between_x1_x2 = "";
                else
                    sign_between_x1_x2 = "+";
            }

            public override string ToString()
            {
                SetSign(Convert.ToString(x2));
                return x1 + " " + sign_between_x1_x2 + x2 + " " + sign + 
                    " " + result + "\n";
            }
        }

        Function Main_Function = new Function();

        List<Function> All_Function = new List<Function>();
        List<Points> PoligonPoints = new List<Points>();

        struct Points
        {
            public Points(double _x,double _y)
            {
                x = _x;
                y = _y;
            }

            double x, y;
        }

        private void AddFunction_Click(object sender, EventArgs e)
        {
            Function cur_f = new Function();
            cur_f.x1 = Convert.ToDouble(txtX1.Text);
            cur_f.x2 = Convert.ToDouble(txtX2.Text);

            switch(cmb_sign.SelectedIndex)
            {
                case 0:
                    cur_f.sign = ">";
                    break;
                case 1:
                    cur_f.sign = ">=";
                    break;
                case 2:
                    cur_f.sign = "<";
                    break;
                case 3:
                    cur_f.sign = "<=";
                    break;
                case 4:
                    cur_f.sign = "=";
                    break;
                default:
                    break;
            }
            cur_f.result = Convert.ToDouble(TxtResult.Text);
            txt_AllFunction.Text += cur_f.ToString();
            All_Function.Add(cur_f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Function.x1 = Convert.ToDouble(txtX1F.Text);
            Main_Function.x2 = Convert.ToDouble(txtX2F.Text);
            Calculate(All_Function, Main_Function);
        }

        private void Calculate(List<Function> all_func, Function cur_f)
        {
            FindCrossPoints(all_func,cur_f);

        }

        private void FindCrossPoints(List<Function> all_func, Function cur_f)
        {
            double x, y;
            double tmp1, tmp2, tmp3;
            for(int i = 0; i < all_func.Count; i++)
            {
                for(int j = i + 1; j < all_func.Count; j++)
                {
                    tmp1 = all_func[i].x1 * 
                        all_func[j].x2 - all_func[j].x2 * all_func[j].x1;
                    tmp2 = all_func[i].result * all_func[j].x2 - 
                        all_func[i].x2 * all_func[j].result;
                    tmp3 = all_func[i].x1 * all_func[j].result - 
                        all_func[i].result * all_func[j].x1;

                    if(tmp1 != 0)
                    {
                        x = tmp2 / tmp1;
                        y = tmp3 / tmp1;

                        if(x >= 0 && y >= 0)
                        {
                            PoligonPoints.Add(new Points(x, y));
                        }
                    }
                }
            }
        }
    }
}
