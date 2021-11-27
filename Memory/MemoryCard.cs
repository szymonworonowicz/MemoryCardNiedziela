﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public class MemoryCard : Label
    {
        public Guid Id;
        public Image Tyl;
        public Image Przod;

        public MemoryCard(Guid id, string tylPath, string przodPath)
        {
            Id = id;
            Tyl = Image.FromFile(tylPath);
            Przod = Image.FromFile(przodPath);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void Zakryj()
        {
            BackgroundImage = Tyl;
            Enabled = true;
        }
        
        public void Odkryj()
        {
            BackgroundImage = Przod;
            Enabled = false;
        }
    }
}
