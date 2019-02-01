﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPTComShark.Windows
{
    public partial class OpenFiles : Form
    {
        private DateTime _from;
        private DateTime _to;

        public OpenFiles(List<DateTime> dates)
        {
            InitializeComponent();

            if (dates.Count == 0)
            {
                MessageBox.Show("No dates available from peek, will use all data");
            }
            else
            {
                dates.Sort();

                _from = dates.First();
                _to = dates.Last();

                labelDateFrom.Text = _from.ToString();
                labelDateTo.Text = _to.ToString();

                dateTimePickerFrom.MinDate = _from;
                dateTimePickerTo.MinDate = _from;
                dateTimePickerFromTime.MinDate = _from;
                dateTimePickerToTime.MinDate = _from;
                dateTimePickerFrom.MaxDate = _to;
                dateTimePickerTo.MaxDate = _to;
                dateTimePickerFromTime.MaxDate = _to;
                dateTimePickerToTime.MaxDate = _to;
                dateTimePickerFrom.Value = _from;
                dateTimePickerTo.Value = _to;
                dateTimePickerFromTime.Value = _from;
                dateTimePickerToTime.Value = _to;
            }

            

            this.DialogResult = DialogResult.OK;
        }

        public DateTime From;

        public DateTime To;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            From = dateTimePickerFrom.Value.Date.Add(dateTimePickerFromTime.Value.TimeOfDay);
            To = dateTimePickerTo.Value.Date.Add(dateTimePickerToTime.Value.TimeOfDay);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
