﻿/**
* Text Shredder : A personal message encryption tool.
* 
* Copyright (C) 2014 Stephen Haunts
* http://www.stephenhaunts.com
* 
* This file is part of Text Shredder.
* 
* Text Shredder is free software: you can redistribute it and/or modify it under the terms of the
* GNU General Public License as published by the Free Software Foundation, either version 2 of the
* License, or (at your option) any later version.
* 
* Text Shredder is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* 
* See the GNU General Public License for more details <http://www.gnu.org/licenses/>.
* 
* Authors: Stephen Haunts
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HauntedHouseSoftware.TextShredder.Forms
{
    public partial class UpgradeNotice : Form
    {
        public UpgradeNotice()
        {
            InitializeComponent();
        }

        private void doNotDoThisAgain_CheckedChanged(object sender, EventArgs e)
        {

        }

        public bool DontShowThisAgain
        {
            get
            {
                return doNotDoThisAgain.Checked;
            }
            set
            {
                doNotDoThisAgain.Checked = value;
            }
        }
    }
}