using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySimplePaint.Figures;
using MySimplePaint.FiguresCreatores;

namespace MySimplePaint
{
    public partial class myPaintForm : Form
    {
        private Point startPoint;
        private Point endPoint;
        private List<PointF> points = new List<PointF>();

        private bool IsDrawing = false;
        private bool IsStartDrawing = false;
        private bool IsFeel;

        private Figure currentFigure;
        private ICreator currentCreator;

        private int topsNumber;
        private float penWidth;
        private Color penColor;
        private Color brushColor;

        private Serializer serializer;
        private AllFigures allFiguresStorage;

        public myPaintForm()
        {
            InitializeComponent();

            penColor = penColorButton.BackColor;
            brushColor = brushColorButton.BackColor;
            penWidth = penWidthTrackBar.Value;
            
            serializer = new Serializer();
            allFiguresStorage = new AllFigures();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (IsStartDrawing && !currentCreator.IsManyPoint)
            {
                allFiguresStorage.Add(currentFigure);
                if (currentCreator.IsPainting)
                {
                    currentCreator = new PaintingCreator();
                    currentFigure = currentCreator.Create(penColor,brushColor,penWidth);
                }
                else
                {
                    currentFigure = currentFigure.Clone();
                }
                //currentFigure = currentFigure.Clone();
                IsDrawing = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                endPoint = e.Location;
                points[points.Count - 1] = endPoint;
                currentFigure.points = points.ToArray();
                pictureBox.Refresh();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            allFiguresStorage.DrawFigures(e.Graphics);
            if (IsDrawing)
            {
                //currentFigure.points = points.ToArray();
                currentFigure.Draw(e.Graphics);
            }     
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsStartDrawing)
            {
                if (!currentCreator.IsManyPoint)
                {
                    startPoint.X = e.X;
                    startPoint.Y = e.Y;

                    points.Clear();
                    points.Add(startPoint);
                    points.Add(startPoint);

                    IsDrawing = true;
                    currentFigure.isFeel = IsFeel;
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsStartDrawing)
            {
                if (currentCreator.IsManyPoint)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        startPoint = e.Location;

                        if (!IsDrawing)
                        {
                            points.Clear();
                            points.Add(startPoint);
                            points.Add(startPoint);

                            IsDrawing = true;
                            currentFigure.isFeel = IsFeel;
                        }
                        else
                        {
                            points.Add(startPoint);
                        }
                    }
                    else if (e.Button == MouseButtons.Right && IsDrawing)
                    {
                        allFiguresStorage.Add(currentFigure);
                        currentFigure = currentFigure.Clone();
                        IsDrawing = false;
                    }
                }
            }
        }

        private void paintingButton_Click(object sender, EventArgs e)
        {
            currentCreator = new PaintingCreator();
            currentFigure = currentCreator.Create(penColor, brushColor, penWidth);
            StateChange(currentCreator);
            currentFigure.isFeel = true;
            IsStartDrawing = true;
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            currentCreator = new LineCreator();
            currentFigure = currentCreator.Create(penColor, brushColor, penWidth);
            StateChange(currentCreator);
            IsStartDrawing = true;
        }

        private void brokenLineButton_Click(object sender, EventArgs e)
        {
            currentCreator = new BrokenLineCreator();
            currentFigure = currentCreator.Create(penColor, brushColor, penWidth);
            StateChange(currentCreator);
            IsStartDrawing = true;
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            currentCreator = new EllipseCreator();
            currentFigure = currentCreator.Create(penColor, brushColor, penWidth);
            StateChange(currentCreator);
            currentFigure.isFeel = true;
            IsStartDrawing = true;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            currentCreator = new RectangleCreator();
            currentFigure = currentCreator.Create(penColor, brushColor, penWidth);
            StateChange(currentCreator);
            currentFigure.isFeel = true;
            IsStartDrawing = true;
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            currentCreator = new PolygonCreator();
            currentFigure = currentCreator.Create(penColor, brushColor, penWidth);
            StateChange(currentCreator);
            currentFigure.isFeel = true;
            IsStartDrawing = true;
        }

        private void regularPolygonButton_Click(object sender, EventArgs e)
        {
            currentCreator = new RegularPolygonCreator();
            currentFigure = currentCreator.Create(penColor, brushColor, penWidth);
            StateChange(currentCreator);
            currentFigure.isFeel = true;
            IsStartDrawing = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            allFiguresStorage.Clear();
            pictureBox.Refresh();
            IsDrawing = false;
        }

        private void penWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            penWidthLabel.Text = "Pen width : " + penWidthTrackBar.Value.ToString();
            penWidth = penWidthTrackBar.Value;
            if (currentFigure != null)
            {
                currentFigure.penWidth = penWidth;
            }
        }

        private void topsNumberTrackBar_Scroll(object sender, EventArgs e)
        {
            topsNumberLabel.Text = "Tops number : " + topsNumberTrackBar.Value.ToString();
            topsNumber = topsNumberTrackBar.Value;
            (currentFigure as RegularPolygon).numOfCorners = topsNumber; 
        }

        private void penColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                penColor = colorDialog.Color;
                penColorButton.BackColor = penColor;

                if (currentFigure != null)
                {
                    currentFigure.color = penColor;
                }
            }
        }

        private void brushColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                brushColor = colorDialog.Color;
                brushColorButton.BackColor = brushColor;

                if (currentFigure != null)
                {
                    currentFigure.fillColor = brushColor;
                }
            }
        }

        private void isFeelChechBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isFeelCheckBox.Checked)
            {
                IsFeel = true;
            }
            else
            {
                IsFeel = false;
            }
        }

        private void StateChange(ICreator creator)
        {
            if (creator.IsCanFeel)
            {
                isFeelCheckBox.Enabled = true;
            }
            else
            {
                isFeelCheckBox.Enabled = false;
            }

            if (creator.IsVariableAngles)
            {
                topsNumberTrackBar.Enabled = true;
            }
            else
            {
                topsNumberTrackBar.Enabled = false;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!allFiguresStorage.IsListEmpty())
            {
                allFiguresStorage.RemoveLast();
                IsDrawing = false;
                pictureBox.Refresh();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (!allFiguresStorage.IsStackEmpty())
            {
                allFiguresStorage.ReturnLast();
                IsDrawing = false;
                pictureBox.Refresh();
            }
        }

        private void serealizeButton_Click(object sender, EventArgs e)
        {
            serializer.Serialize(allFiguresStorage);
        }

        private void deserealizeButton_Click(object sender, EventArgs e)
        {
            allFiguresStorage = serializer.Deserialize(allFiguresStorage);
            pictureBox.Refresh();
        }
    }
}
