﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class Frm_Base : Form
    {
        public Frm_Main frm_Main;
        public delegate void _deDongtab();
        public _deDongtab deDongtab;

        public Frm_Base()
        {
            InitializeComponent();
        }
    }
}
