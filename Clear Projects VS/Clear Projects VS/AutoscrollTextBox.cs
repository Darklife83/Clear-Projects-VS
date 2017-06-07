using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clear_Projects_VS
{
    public class AutoscrollTextBox : TextBox
    {


        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.SelectionStart = this.TextLength;
            this.ScrollToCaret();
        }


        public void SetText(string text)
        {
            this.Text = text;
        }

        public void AddText(string text)
        {
            this.AppendText(text);
        }


    }
}
