using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACME
{
    class TextboxRdlGenerator
    {
        private String m_titulo;

        public String Titulo
        {
            get { return m_titulo; }
            set { m_titulo = value; }
        }

        public Rdl.TextboxType CreateTextbox()
        {
            Rdl.TextboxType Textbox = new Rdl.TextboxType();
            Textbox.Name = "Textbox1";
            Textbox.Items = new object[]
            {
                m_titulo,
                CreateHeaderCellTextboxStyle(),
                "0.80cm",
                "11cm",
                "0.92cm",
                "13.43cm",
            };
            Textbox.ItemsElementName = new Rdl.ItemsChoiceType14[]
            {
                Rdl.ItemsChoiceType14.Value,
                Rdl.ItemsChoiceType14.Style,
                Rdl.ItemsChoiceType14.Top,
                Rdl.ItemsChoiceType14.Left,
                Rdl.ItemsChoiceType14.Height,
                Rdl.ItemsChoiceType14.Width,
            };
            return Textbox;
        }
        private Rdl.StyleType CreateHeaderCellTextboxStyle()
        {
            Rdl.StyleType headerCellTextboxStyle = new Rdl.StyleType();
            headerCellTextboxStyle.Items = new object[]
            {
                "20pt",
                "Left",
            };
            headerCellTextboxStyle.ItemsElementName = new Rdl.ItemsChoiceType5[]
            {
                Rdl.ItemsChoiceType5.FontSize,
                Rdl.ItemsChoiceType5.TextAlign,
            };
            return headerCellTextboxStyle;
        }

    }
}
