using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 代码转换器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("@\"");
            foreach (var charCode in code)
            {
                if (charCode == '"')
                {
                    sb.Append("{0}");
                    continue;
                }
                if (charCode == '{')
                {
                    sb.Append("{{");
                    continue;
                }
                if (charCode == '}')
                {
                    sb.Append("}}");
                    continue;
                }
                sb.Append(charCode);
            }
            sb.Append("\",\"\\\"\"");
            txtString.Text = sb.ToString();
        }
    }
}