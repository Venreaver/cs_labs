using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab_5
{
    public partial class MainForm : Form
    {
        BindingSource bs = new BindingSource();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Country>));
        Font myFont = new Font("Microsoft Sans Serif", 13);
        string dwnlText = "Double click to download a pic!";
        Point dwnlTextPoint = new Point(5, 75);

        public MainForm()
        {
            InitializeComponent();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            bs.DataSource = new List<Country>();
            grid.DataSource = bs;
            grid.Columns[0].Visible = false;
            nav.BindingSource = bs;
            chart.DataSource = bs;
            chart.Series[0].XValueMember = "Name";
            chart.Series[0].YValueMembers = "Population";
            chart.Legends.Clear();
            chart.Titles.Add("Распределение по численности населения");
            bs.CurrentChanged += (o, e) => chart.DataBind();
            propertyGrid.DataBindings.Add("SelectedObject", bs, "");
            pictureBox.DataBindings.Add("ImageLocation", bs, "Image", true);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void grid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода!");
        }

        private void toolStripNewButton_Click(object sender, EventArgs e)
        {
            for (int i = 0, n = bs.Count; i < n; i++)
            {
                bindingNavigatorDeleteItem.PerformClick();
            }
        }

        private void toolStripLoadButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            bindingNavigatorAddNewItem.PerformClick();
            toolStripNewButton.PerformClick();
            try
            {
                Stream reader = new FileStream(openFileDialog.FileName, FileMode.Open);
                List<Country> list = (List<Country>)xmlSerializer.Deserialize(reader);
                bs.DataSource = list;
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Stream writer = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
            xmlSerializer.Serialize(writer, bs.DataSource);
            writer.Close();
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Файлы-изображения (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            (bs.Current as Country).Image = openFileDialog.FileName;
            bs.ResetBindings(false);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int n = grid.CurrentCell.ColumnIndex;
            if (n == 2)
            {
                try
                {
                    double.Parse(toolStripTextBox1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка ввода!");
                    return;
                }
                for (int i = 0; i < bs.Count; i++)
                {
                    if (double.Parse(grid[n, i].Value.ToString()) == double.Parse(toolStripTextBox1.Text))
                    {
                        grid.CurrentCell = grid[n, i];
                        return;
                    }
                }
            }
            else if (n == 4)
            {
                try
                {
                    int.Parse(toolStripTextBox1.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка ввода!");
                    return;
                }
                for (int i = 0; i < bs.Count; i++)
                {
                    if (int.Parse(grid[n, i].Value.ToString()) == int.Parse(toolStripTextBox1.Text))
                    {
                        grid.CurrentCell = grid[n, i];
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < bs.Count; i++)
                {
                    if (grid[n, i].Value.ToString().ToLower().Equals(toolStripTextBox1.Text.ToLower()))
                    {
                        grid.CurrentCell = grid[n, i];
                        return;
                    }
                }
            }
            MessageBox.Show("Значение не найдено!");
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                toolStripButton1.PerformClick();
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (bs.Current != null)
            {
                if (((bs.Current as Country).Image == null) || ((bs.Current as Country).Image.Equals("")))
                {
                    e.Graphics.DrawString(dwnlText, myFont, Brushes.Black, dwnlTextPoint);
                }
            }
        }
    }
}