using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACME
{
    class ImageRdlGenerator
    {
        public Rdl.ImageType CreateImage(string name, string top, string left, string width, string height)
        {
            Rdl.ImageType imagem = new Rdl.ImageType();
            imagem.Name = name;
            imagem.Items = new object[]
                {   
                   Rdl.ImageTypeSizing.FitProportional,
                   Rdl.ImageTypeSource.Embedded,
                  name,
                   top,left,width,height, 
                };
            imagem.ItemsElementName = new Rdl.ItemsChoiceType15[]
                {
                    Rdl.ItemsChoiceType15.Sizing,
                    Rdl.ItemsChoiceType15.Source,
                    Rdl.ItemsChoiceType15.Value,
                    Rdl.ItemsChoiceType15.Top,
                    Rdl.ItemsChoiceType15.Left,
                    Rdl.ItemsChoiceType15.Height,
                    Rdl.ItemsChoiceType15.Width,
                };
            return imagem;
        }
    }
}
