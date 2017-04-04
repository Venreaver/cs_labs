using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    enum eLineType { None, Curved, Polygone, Beizers, Filled };

    public partial class MainForm : Form
    {
        List<Point> arPoints = new List<Point>();

        bool addPoints = false;
        bool isMoving = false;
        bool randomMoving = false;
        bool pointDrag = false;

        eLineType linetype;

        SolidBrush pointBrush = (SolidBrush)Brushes.DarkBlue;
        SolidBrush lineBrush = (SolidBrush)Brushes.DarkBlue;
        Pen pen;
        int pointSize = 8;
        int lineSize = 4;
        int idxPointToDrag;
        
        private Timer moveTimer = new Timer();
        int speed = 5;
        List<int[]> arSpeed = new List<int[]>();
        Random rnd = new Random();


        public MainForm()
        {
            InitializeComponent();
            pen = new Pen(Color.DarkBlue, lineSize);
            moveTimer.Interval = 30;
            moveTimer.Tick += TimerTickHandler;
            DoubleBuffered = true;
            KeyPreview = true;
            KeyDown += MainForm_KeyDown;
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            MouseUp += MainForm_MouseUp;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender == pointButton)
            {
                addPoints = !addPoints;
                if (addPoints && isMoving)
                {
                    isMoving = false;
                    clearButton.PerformClick();
                }
                Refresh();
            }
            else if (sender == paramButton)
            {
                if (!ChildForm.Instance.Visible)
                {
                    ChildForm.Instance.Show(this);
                }
            }
            else if (sender == closedCurveButton)
            {
                addPoints = false;
                linetype = eLineType.Curved;
                Refresh();
            }
            else if (sender == polygoneButton)
            {
                addPoints = false;
                linetype = eLineType.Polygone;
                Refresh();
            }
            else if (sender == beizersButton)
            {
                addPoints = false;
                linetype = eLineType.Beizers;
                Refresh();
            }
            else if (sender == fillCurveButton)
            {
                addPoints = false;
                linetype = eLineType.Filled;
                Refresh();
            }
            else if (sender == pointDrButton)
            {
                addPoints = false;
                linetype = eLineType.None;
                Refresh();
            }
            else if (sender == moveButton)
            {
                addPoints = false;
                if (arPoints.Count > 0)
                {
                    isMoving = !isMoving;
                    if (isMoving)
                    {
                        ChangeSpeedAr();
                        moveTimer.Start();
                    }
                }
            }
            else if (sender == clearButton)
            {
                arPoints.Clear();
                Refresh();
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (addPoints)
            {
                pointButton.BackColor = Color.LightSteelBlue;
            }
            else
            {
                pointButton.UseVisualStyleBackColor = true;
            }
            if (arPoints.Count > 0)
            {
                switch (linetype)
                {
                    case eLineType.Curved:
                        if (arPoints.Count > 2)
                        {
                            e.Graphics.DrawClosedCurve(pen, arPoints.ToArray());
                        }
                        break;
                    case eLineType.Polygone:
                        if (arPoints.Count > 1)
                        {
                            e.Graphics.DrawPolygon(pen, arPoints.ToArray());
                        }
                        break;
                    case eLineType.Beizers:
                        if (arPoints.Count % 3 == 1)
                        {
                            e.Graphics.DrawBeziers(pen, arPoints.ToArray());
                        }
                        break;
                    case eLineType.Filled:
                        if (arPoints.Count > 2)
                        {
                            e.Graphics.FillClosedCurve(lineBrush, arPoints.ToArray());
                        }
                        break;
                    default:
                        break;
                }
                arPoints.ForEach(el => e.Graphics.FillEllipse(pointBrush, el.X - pointSize / 2, el.Y - pointSize / 2, pointSize, pointSize));
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (addPoints)
                {
                    if (e.Location.X > ClientRectangle.X + buttonPanel.Width)
                    {
                        arPoints.Add(new Point(e.Location.X, e.Location.Y));
                        arSpeed.Add(new int[2]);
                        Refresh();
                    }
                }
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < arPoints.Count; i++)
                {
                    if (IsOnPoint(e.Location, arPoints[i]))
                    {
                        idxPointToDrag = i;
                        pointDrag = true;
                    }
                }
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (pointDrag)
            {
                if (e.Location.X > ClientRectangle.X + buttonPanel.Width + pointSize
                    && e.Location.X < ClientRectangle.Right
                    && e.Location.Y > ClientRectangle.Y
                    && e.Location.Y < ClientRectangle.Bottom)
                {
                    arPoints[idxPointToDrag] = new Point(e.Location.X, e.Location.Y);
                    Refresh();
                }
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            pointDrag = false;
        }


        private bool IsOnPoint(Point location, Point point)
        {
            if (location.X <= (point.X + PointSize / 2)
                && location.X >= (point.X - PointSize / 2)
                && location.Y <= (point.Y + PointSize / 2)
                && location.X >= (point.Y - PointSize / 2))
            {
                return true;
            }
            return false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                case Keys.Oemplus:
                    foreach (var item in arSpeed)
                    {
                        for (int i = 0; i < item.Length; i++)
                        {
                            if (item[i] < 0)
                            {
                                --item[i];
                            }
                            else
                            {
                                ++item[i];
                            }
                        }
                    }
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    foreach (var item in arSpeed)
                    {
                        for (int i = 0; i < item.Length; i++)
                        {
                            if (item[i] < 0)
                            {
                                ++item[i];
                            }
                            else
                            {
                                --item[i];
                            }
                        }
                    }
                    break;
                case Keys.Space:
                    moveButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Escape:
                    clearButton.PerformClick();
                    e.Handled = true;
                    break;
                default:
                    break;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool flag;
            switch (keyData)
            {
                case Keys.Left:
                    if (isMoving)
                    {
                        foreach (var item in arSpeed)
                        {
                            if (item[0] < 0)
                            {
                                --item[0];
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < arPoints.Count; i++)
                        {
                            flag = !arPoints.Any(p => (ClientRectangle.X + pointSize > p.X - pointSize) || (ClientRectangle.Right - pointSize < p.X - pointSize));
                            if (flag)
                            {
                                arPoints[i] = new Point(arPoints[i].X - pointSize, arPoints[i].Y);
                            }
                            else
                            {
                                break;
                            }
                        }
                        Refresh();
                    }
                    return true;
                case Keys.Up:
                    if (isMoving)
                    {
                        foreach (var item in arSpeed)
                        {
                            if (item[1] >= 0)
                            {
                                ++item[1];
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < arPoints.Count; i++)
                        {
                            flag = !arPoints.Any(p => (ClientRectangle.Y + pointSize > p.Y - pointSize) || (ClientRectangle.Bottom - pointSize < p.Y - pointSize));
                            if (flag)
                            {
                                arPoints[i] = new Point(arPoints[i].X, arPoints[i].Y - pointSize);
                            }
                            else
                            {
                                break;
                            }
                        }
                        Refresh();
                    }
                    return true;
                case Keys.Right:
                    if (isMoving)
                    {
                        foreach (var item in arSpeed)
                        {
                            if (item[0] >= 0)
                            {
                                ++item[0];
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < arPoints.Count; i++)
                        {
                            flag = !arPoints.Any(p => (ClientRectangle.X + pointSize > p.X + pointSize) || (ClientRectangle.Right - pointSize < p.X + pointSize));    
                            if (flag)
                            {
                                arPoints[i] = new Point(arPoints[i].X + pointSize, arPoints[i].Y);
                            }
                            else
                            {
                                break;
                            }
                        }
                        Refresh();
                    }
                    return true;
                case Keys.Down:
                    if (isMoving)
                    {
                        foreach (var item in arSpeed)
                        {
                            if (item[1] < 0)
                            {
                                --item[1];
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < arPoints.Count; i++)
                        {
                            flag = !arPoints.Any(p => (ClientRectangle.Y + pointSize > p.Y + pointSize) || (ClientRectangle.Bottom - pointSize < p.Y + pointSize));
                            if (flag)
                            {
                                arPoints[i] = new Point(arPoints[i].X, arPoints[i].Y + pointSize);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    Refresh();
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void TimerTickHandler(object sender, EventArgs e)
        {
            MovePoints();
            Refresh();
        }

        private void MovePoints()
        {
            if (isMoving)
            {
                for (int i = 0; i < arPoints.Count; i++)
                {
                    int x = arPoints[i].X;
                    int y = arPoints[i].Y;
                    if (ClientRectangle.X + pointSize > x)
                    {
                        x = ClientRectangle.X + pointSize + (ClientRectangle.X + pointSize - x);
                    }
                    else if (ClientRectangle.Right - pointSize < x)
                    {
                        x = ClientRectangle.Right - pointSize - (x - (ClientRectangle.Right - pointSize));
                    }
                    if (ClientRectangle.Y + pointSize > y)
                    {
                        y = ClientRectangle.Y + pointSize + (ClientRectangle.Y + pointSize - y);
                    }
                    else if (ClientRectangle.Bottom - pointSize < y)
                    {
                        y = ClientRectangle.Bottom - pointSize - 1;
                    }
                    int help = arSpeed[i][0] > pointSize ? arSpeed[i][0] : pointSize;
                    if ((ClientRectangle.X + help + buttonPanel.Width > x + arSpeed[i][0]) || (ClientRectangle.Right - help < x + arSpeed[i][0]))
                    {
                        arSpeed[i][0] = -arSpeed[i][0];
                    }
                    help = arSpeed[i][1] > pointSize ? arSpeed[i][1] : pointSize;
                    if ((ClientRectangle.Y + help > y + arSpeed[i][1]) || (ClientRectangle.Bottom - help < y + arSpeed[i][1]))
                    {
                        arSpeed[i][1] = -arSpeed[i][1];
                    }
                    arPoints[i] = new Point(x + arSpeed[i][0], y + arSpeed[i][1]);
                }
            }
        }

        public SolidBrush PointBrushColor
        {
            get
            {
                return pointBrush;
            }
            set
            {
                pointBrush = value;
                Refresh();
            }
        }

        public SolidBrush LineBrushColor
        {
            get
            {
                return lineBrush;
            }
            set
            {
                lineBrush = value;
                pen = new Pen(lineBrush, lineSize);
                Refresh();
            }
        }

        public int PointSize
        {
            get
            {
                return pointSize;
            }
            set
            {
                pointSize = value;
                Refresh();
            }
        }

        public int LineSize
        {
            get
            {
                return lineSize;
            }
            set
            {
                lineSize = value;
                pen = new Pen(lineBrush, lineSize);
                Refresh();
            }
        }

        public bool RandomMoving
        {
            get
            {
                return randomMoving;
            }
            set
            {
                randomMoving = value;
                if (isMoving)
                {
                    ChangeSpeedAr();
                }
            }
        }


        private void ChangeSpeedAr()
        {
            if (randomMoving)
            {
                foreach (var item in arSpeed)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        item[i] = rnd.Next(-20, 21);
                    }
                }
            }
            else
            {
                foreach (var item in arSpeed)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        item[i] = speed;
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
