﻿using AccessModifiers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessModifiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sample sample = new Sample();
            
        }
        //----Erisim Belirtecler(Access Modifiers) ---

        /*
         * 
         #Public ==> Olusturuldugu projenin icerisinden ve disarisindan erisilebilir.
        #internal ==> sadece olusturuldugu proje icerisinden erisilebilir.
        #protected interal
        protected
        #private ==> sadece bulundugu sayfadan erisilebilirler.
         
         */
    }
}
