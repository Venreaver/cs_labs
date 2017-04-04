using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class ChildForm : Form
    {
        private static ChildForm instance;
        protected ChildForm()
        {
            InitializeComponent();
            pointSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lineSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 8; i < 20; i++)
            {
                pointSizeComboBox.Items.Add(i*2);
                lineSizeComboBox.Items.Add(i);
            }
            pointSizeComboBox.SelectedIndex = 0;
            lineSizeComboBox.SelectedIndex = 0;
        }

        public static ChildForm Instance
        {
            get
            {
                return instance ?? (instance = new ChildForm());
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (sender == okButton)
            {
                MainForm owner = (MainForm)Owner;
                if (owner != null)
                {
                    owner.PointBrushColor = new SolidBrush(pointColorComboBox.Color);
                    owner.LineBrushColor = new SolidBrush(lineColorComboBox.Color);
                    owner.PointSize = (int)pointSizeComboBox.SelectedItem;
                    owner.LineSize = (int)lineSizeComboBox.SelectedItem;
                    if (saveRadioButton.Checked)
                    {
                        owner.RandomMoving = false;
                    }
                    else if (randomRadioButton.Checked)
                    {
                        owner.RandomMoving = true;
                    }
                    Close();
                }
            }
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }
    }
}
