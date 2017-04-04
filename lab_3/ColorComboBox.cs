using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab_3
{
    public class ColorComboBox : ComboBox
    {
        public ColorComboBox()
        {
            FillColors();
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FillColors()
        {
            Items.Clear();
            foreach (Color col in typeof(Color).GetProperties().Where(pr => pr.PropertyType == typeof(Color)).Select(c => c.GetValue(c)))
            {
                Items.Add(col);
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {

                Color color = (Color)Items[e.Index];
                int nextX = e.Bounds.Height * 2 - 8;
                e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
                Rectangle rect = new Rectangle(e.Bounds.X + 3, e.Bounds.Y + 3, nextX, e.Bounds.Height - 6);
                e.Graphics.FillRectangle(new SolidBrush(color), rect);
                nextX += 8;
                e.Graphics.DrawString(color.Name, e.Font, new SolidBrush(e.ForeColor), nextX, e.Bounds.Y);
            }
            else
            {
                base.OnDrawItem(e);
            }
        }

        public Color Color
        {
            get
            {
                if (SelectedItem != null)
                {
                    return (Color)SelectedItem;
                }
                return Color.Black;
            }
            set
            {
                int ix = Items.IndexOf(value);
                if (ix >= 0)
                {
                    SelectedIndex = ix;
                }
            }
        }
    }
}
