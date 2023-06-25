using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace FigureDrawer
{
    public partial class DrawerForm : Form
    {
        private enum DrawingTool
        {
            None,
            Rectangle,
            Circle,
            Triangle
        }

        private DrawingTool currentTool;
        private Pen drawingPen;
        private Point startPoint;
        private Bitmap drawingBitmap;
        private Stack<Bitmap> undoStack;
        private Stack<Bitmap> redoStack;

        public DrawerForm()
        {
            InitializeComponent();

            drawingPen = new Pen(Color.Black);
            currentTool = DrawingTool.None;
            startPoint = Point.Empty;
            drawingBitmap = new Bitmap(DrawBox.Width, DrawBox.Height);
            undoStack = new Stack<Bitmap>();
            redoStack = new Stack<Bitmap>();
        }

        private void DrawerForm_Load(object sender, EventArgs e)
        {
            ShapeComboBox.SelectedIndex = 0;
        }

        private void drawBox_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void drawBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (startPoint != Point.Empty)
            {
                Graphics g = Graphics.FromImage(drawingBitmap);

                switch (currentTool)
                {
                    case DrawingTool.Rectangle:
                        int width = Math.Abs(e.X - startPoint.X);
                        int height = Math.Abs(e.Y - startPoint.Y);
                        int x = Math.Min(startPoint.X, e.X);
                        int y = Math.Min(startPoint.Y, e.Y);
                        Rectangle rectangle = new Rectangle(x, y, width, height);
                        g.DrawRectangle(drawingPen, rectangle);
                        break;

                    case DrawingTool.Circle:
                        int radius = Math.Max(Math.Abs(e.X - startPoint.X), Math.Abs(e.Y - startPoint.Y));
                        x = startPoint.X - radius;
                        y = startPoint.Y - radius;
                        Rectangle circleBounds = new Rectangle(x, y, radius * 2, radius * 2);
                        g.DrawEllipse(drawingPen, circleBounds);
                        break;

                    case DrawingTool.Triangle:
                        Point[] trianglePoints = new Point[3];
                        trianglePoints[0] = startPoint;
                        trianglePoints[1] = new Point(startPoint.X, e.Y);
                        trianglePoints[2] = new Point(e.X, e.Y);
                        g.DrawPolygon(drawingPen, trianglePoints);
                        break;
                }

                undoStack.Push(new Bitmap(drawingBitmap));
                redoStack.Clear();

                DrawBox.Image = drawingBitmap;
                startPoint = Point.Empty;
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(new Bitmap(drawingBitmap));
                drawingBitmap.Dispose();
                drawingBitmap = (Bitmap)undoStack.Pop().Clone();
                DrawBox.Image = drawingBitmap;
            }
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(new Bitmap(drawingBitmap));
                drawingBitmap.Dispose();
                drawingBitmap = (Bitmap)redoStack.Pop().Clone();
                DrawBox.Image = drawingBitmap;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            undoStack.Push(new Bitmap(drawingBitmap));
            drawingBitmap = new Bitmap(DrawBox.Width, DrawBox.Height);
            redoStack.Clear();
            DrawBox.Image = drawingBitmap;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(saveDialog.FileName).ToLower();
                    ImageFormat imageFormat = ImageFormat.Jpeg;

                    if (extension == ".png")
                        imageFormat = ImageFormat.Png;
                    else if (extension == ".bmp")
                        imageFormat = ImageFormat.Bmp;

                    drawingBitmap.Save(saveDialog.FileName, imageFormat);
                }
            }
        }

        private void shapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ShapeComboBox.SelectedIndex)
            {
                case 0:
                    currentTool = DrawingTool.None;
                    break;

                case 1:
                    currentTool = DrawingTool.Rectangle;
                    break;

                case 2:
                    currentTool = DrawingTool.Circle;
                    break;

                case 3:
                    currentTool = DrawingTool.Triangle;
                    break;
            }
        }
    }
}
