



using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Shapes;
using ListBox = System.Windows.Controls.ListBox;
using MessageBox = System.Windows.Forms.MessageBox;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using DialogResult = System.Windows.Forms.DialogResult;

namespace ProgettoPlotter.Classes
{
    class CManager
    {
        /* Properties */
        public Canvas DrawingSheet { get; set; }
        public List<Line> Lines { get; set; }
        public Line NewLine { get; set; }
        public ListBox List { get; set; }
        public CSerialPort port { get; set; }
        public string LastPath { get; set; }
        public string SavedName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEdit { get; set; }

        /* Constructors */
        public CManager()
        {
            DrawingSheet = new Canvas();
            Lines = new List<Line>();
            NewLine = null;
        }
        public CManager(Canvas DrawingSheet)
        {
            this.DrawingSheet = DrawingSheet;
            Lines = new List<Line>();
            NewLine = null;
        }
        public CManager(Canvas DrawingSheet, ListBox List)
        {
            this.DrawingSheet = DrawingSheet;
            this.List = List;
            this.Lines = new List<Line>();
            NewLine = null;
            port = new CSerialPort();
            LastPath = "-Not Saved-";
            SavedName = "-Not Saved-";
            CreationDate = DateTime.Now;
            LastEdit = DateTime.Now;
        }

        /* Canvas Methods */
        public void StartDrawingLine(Point p1, Brush color)
        {
            /* Create new line start point */
            NewLine = new Line();
            NewLine.Stroke = color;
            /* Set the value of newLine's start point */
            NewLine.X1 = p1.X;
            NewLine.X2 = p1.X;
            NewLine.Y1 = p1.Y;
            NewLine.Y2 = p1.Y;
        }
        public void ContinueDrawingLine(Point p2)
        {
            /* Check if there isn't a new line */
            if (NewLine == null) return;

            /* Set value of NewLine last point */
            NewLine.X2 = p2.X;
            NewLine.Y2 = p2.Y;

            /* Check if there is a preview and remove */
            while (DrawingSheet.Children.Count > Lines.Count)
                DrawingSheet.Children.RemoveAt(DrawingSheet.Children.Count - 1);

            /* Add new line and refresh */
            try { DrawingSheet.Children.Add(NewLine); } catch (System.Exception) { }
        }
        public void EndDrawingLine(Point p2)
        {
            /* Check if there is a new line */
            if (NewLine == null) return;
            /* Set the value of NewLine's last point */
            NewLine.X2 = p2.X;
            NewLine.Y2 = p2.Y;
            /* Add new line to canvas and listbox */
            Lines.Add(NewLine);
            List.Items.Add(ToListItem(NewLine, List.Items.Count + 1));
            NewLine = null;
        }
        public void ContinueDrawingStraightLine(Point p2, int direction)
        {
            /* Check if there isn't a new line */
            if (NewLine == null) return;

            switch (direction)
            {
                case 1:
                    /* Same X axis value */
                    NewLine.X2 = NewLine.X1;
                    NewLine.Y2 = p2.Y;
                    break;

                case 2:
                    /* Same Y axis value */
                    NewLine.X2 = p2.X;
                    NewLine.Y2 = NewLine.Y1;
                    break;
                case 3:
                    /* Up - left */
                    NewLine.X2 = NewLine.X1 - (NewLine.Y1 - p2.Y);
                    NewLine.Y2 = p2.Y;
                    break;
                case 4:
                    /* Up - right */
                    NewLine.X2 = NewLine.X1 - (p2.Y - NewLine.Y1);
                    NewLine.Y2 = p2.Y;
                    break;
            }


            /* Check if there is a preview and remove */
            while (DrawingSheet.Children.Count > Lines.Count)
                DrawingSheet.Children.RemoveAt(DrawingSheet.Children.Count - 1);

            /* Add new line and refresh */
            try { DrawingSheet.Children.Add(NewLine); } catch (System.Exception) { }
        }
        public void EndDrawingStraightLine(Point p2, int direction)
        {
            /* Check if there is a new line */
            if (NewLine == null) return;
            /* Set the value of NewLine's last point */

            switch (direction)
            {
                case 1:
                    /* Same X axis value */
                    NewLine.X2 = NewLine.X1;
                    NewLine.Y2 = p2.Y;
                    break;

                case 2:
                    /* Same Y axis value */
                    NewLine.X2 = p2.X;
                    NewLine.Y2 = NewLine.Y1;
                    break;
                case 3:
                    /* Up - left */
                    NewLine.X2 = NewLine.X1 - (NewLine.Y1 - p2.Y);
                    NewLine.Y2 = p2.Y;
                    break;
                case 4:
                    /* Up - right */
                    NewLine.X2 = NewLine.X1 - (p2.Y - NewLine.Y1);
                    NewLine.Y2 = p2.Y;
                    break;
            }

            /* Add new line to canvas and listbox */
            Lines.Add(NewLine);
            List.Items.Add(ToListItem(NewLine, List.Items.Count + 1));
            NewLine = null;
        }
        public void EndDrawingRectangle(Point p2)
        {
            /* Check if there is a new line */
            if (NewLine == null) return;
            /* Set the value of NewLine's last point */
            NewLine.X2 = p2.X;
            NewLine.Y2 = p2.Y;
            Point p1 = new Point(NewLine.X1, NewLine.Y1);

            /* Create rectangle lines */
            Line base1 = new Line();
            Line base2 = new Line();
            Line height1 = new Line();
            Line height2 = new Line();
            base1.Stroke = NewLine.Stroke;
            base2.Stroke = NewLine.Stroke;
            height1.Stroke = NewLine.Stroke;
            height2.Stroke = NewLine.Stroke;


            base1.X1 = p1.X;
            base1.Y1 = p1.Y;
            base1.X2 = p2.X;
            base1.Y2 = p1.Y;

            base2.X1 = p1.X;
            base2.Y1 = p2.Y;
            base2.X2 = p2.X;
            base2.Y2 = p2.Y;

            height1.X1 = p2.X;
            height1.Y1 = p1.Y;
            height1.X2 = p2.X;
            height1.Y2 = p2.Y;

            height2.X1 = p1.X;
            height2.Y1 = p1.Y;
            height2.X2 = p1.X;
            height2.Y2 = p2.Y;

            /* Add new rectangle and refresh */
            try
            {
                DrawingSheet.Children.Add(base1);
                DrawingSheet.Children.Add(base2);
                DrawingSheet.Children.Add(height1);
                DrawingSheet.Children.Add(height2);
                Lines.Add(base1);
                Lines.Add(base2);
                Lines.Add(height1);
                Lines.Add(height2);
            }
            catch (System.Exception) { }



            List.Items.Add(ToListItem(base1, List.Items.Count + 1));
            List.Items.Add(ToListItem(base2, List.Items.Count + 1));
            List.Items.Add(ToListItem(height1, List.Items.Count + 1));
            List.Items.Add(ToListItem(height2, List.Items.Count + 1));



            NewLine = null;
        }
        public void EndDrawingTriangle(Point p2, int type)
        {
            /* Check if there is a new line */
            if (NewLine == null) return;
            /* Set the value of NewLine's last point */
            NewLine.X2 = p2.X;
            NewLine.Y2 = p2.Y;
            Point p1 = new Point(NewLine.X1, NewLine.Y1);

            /* Create rectangle lines */
            Line line1 = new Line();
            Line line2 = new Line();
            Line line3 = new Line();
            line1.Stroke = NewLine.Stroke;
            line2.Stroke = NewLine.Stroke;
            line3.Stroke = NewLine.Stroke;

            switch (type) /* Triangle type */
            {
                case 1:
                    line1.X1 = p1.X;
                    line1.Y1 = p1.Y;
                    line1.X2 = p2.X;
                    line1.Y2 = p1.Y;

                    line2.X1 = p1.X;
                    line2.Y1 = p1.Y;
                    line2.X2 = p1.X;
                    line2.Y2 = p2.Y;

                    line3.X1 = p2.X;
                    line3.Y1 = p1.Y;
                    line3.X2 = p1.X;
                    line3.Y2 = p2.Y;
                    break;

                case 2:

                    line1.X1 = p1.X;
                    line1.Y1 = p1.Y;
                    line1.X2 = p2.X;
                    line1.Y2 = p1.Y;

                    line2.X1 = p1.X;
                    line2.Y1 = p1.Y;
                    line2.X2 = p1.X + ((p2.X - p1.X) / 2);
                    line2.Y2 = p2.Y;

                    line3.X1 = line2.X2;
                    line3.Y1 = line2.Y2;
                    line3.X2 = p2.X;
                    line3.Y2 = p1.Y;

                    break;
            }


            /* Add new line and refresh */
            try
            {


                Lines.Add(line1);
                Lines.Add(line2);
                Lines.Add(line3);

                DrawingSheet.Children.Clear();
                foreach (Line l in Lines)
                    DrawingSheet.Children.Add(l);
            }
            catch (System.Exception) { }

            List.Items.Add(ToListItem(line1, List.Items.Count + 1));
            List.Items.Add(ToListItem(line2, List.Items.Count + 1));
            List.Items.Add(ToListItem(line3, List.Items.Count + 1));

            NewLine = null;
        }

        /* Edit canvas methods */
        public void DeleteAll()
        {
            /* Check if there are lines */
            if (Lines.Count > 0)
            {
                /* Clear ListBox, list of lines and update canvas */
                List.Items.Clear();
                List.Items.Refresh();
                Lines.Clear();
                DrawingSheet.Children.Clear();
                MessageBox.Show("All lines deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No line drawn!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        public void DeleteAt(int index)
        {
            if (index != -1)
            {
                /* Refresh lines */
                Lines.RemoveAt(index);
                /* Refresh drawing sheet */
                DrawingSheet.Children.RemoveAt(index);
                /* Refresh ListBox */
                List.Items.Clear();
                foreach (Line l in Lines)
                    List.Items.Add(ToListItem(l, List.Items.Count + 1));
            }
            else
                MessageBox.Show("No line selected!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
        public void Undo()
        {
            if (List.Items.Count > 0)
            {
                DrawingSheet.Children.RemoveAt(DrawingSheet.Children.Count - 1); /* Delete last line in canvas */
                List.Items.RemoveAt(List.Items.Count - 1);                         /* Delete last line in list */
                Lines.RemoveAt(Lines.Count - 1);                     /* Delete last item in listbox */
            }
            else
                MessageBox.Show("No line drawn!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /* File edit methods */
        public void Save()
        {
            if (LastPath != "")
            {
                CFileCSV file = new CFileCSV(LastPath + ".txt");
                file.ClearFile();
                foreach (Line l in Lines)
                {
                    string line = ToCSV(l);
                    file.Write(line);
                }
            }
            else
                SaveAs();
        }
        public void SaveAs()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save file";
            if (saveFile.ShowDialog() == true) /* If dialog is open */
            {
                LastPath = saveFile.FileName;
                LastEdit = DateTime.Now;
                SavedName = saveFile.SafeFileName;

                CFileCSV file = new CFileCSV(LastPath + ".txt");

                foreach (Line l in Lines)
                {
                    string line = ToCSV(l);
                    file.Write(line);
                }
            }
        }
        public void Open()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true) /* If dialog is open */
            {
                CFileCSV file = new CFileCSV(ofd.FileName);
                List<Line> temp = file.ReadAll();

                SavedName = ofd.SafeFileName;
                LastPath = ofd.FileName;

                foreach (Line l in temp)
                {
                    //Add to canvas
                    DrawingSheet.Children.Add(l);
                    Lines.Add(l);
                    List.Items.Add(ToListItem(l, List.Items.Count + 1));
                }
            }
        }
        public void OpenNew()
        {
            MainWindow newWindow = new MainWindow();
            newWindow.Show();
        }
        public int DeleteFile()
        {
            /* Ask if user want to save file before leave */
            DialogResult res = MessageBox.Show("Changes won't be saved", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (res == DialogResult.OK)
                return 1;
            else
                return 2;

            /*
             1 - Close file
             2 - Cancel
             */
        }

        /* Serial Port methods */
        public void ConnectTo(string PortName)
        {
            port.ConnectTo(PortName);
        }

        /* Private methods */
        private string ToListItem(Line line, int index)
        {
            string ris = "";
            ris += ("Line " + index + " >> ");
            ris += ("X1:" + line.X1);
            ris += (", Y1:" + line.Y1);
            ris += (", X2:" + line.X2);
            ris += (", Y2:" + line.Y2);
            ris += (", Color: " + line.Stroke.ToString());
            return ris;
        }
        private string ToCSV(Line temp)
        {
            string s = "";
            s += temp.X1 + ";" + temp.Y1 + ";" + temp.X2 + ";" + temp.Y2 + ";" + temp.Stroke.ToString() + ";";
            return s;
        }

        /* Open information windows methods */
        public void ShowLines()
        {
            int i = 1; /* Line index */

            LinesDialog ls = new LinesDialog(); /* New window */
            foreach (Line l in Lines)
            {
                ls.DialogList.Items.Add(ToListItem(l, i));
                i++;
            }
            ls.ShowDialog(); /* Show window as dialog */
        }
        public void ShowInfo()
        {
            string s = "";
            s += "Name:               " + SavedName + "\n";
            s += "File path:          " + LastPath + "\n";
            s += "Creation date:  " + CreationDate.ToString() + "\n";
            s += "Last save:          " + LastEdit.ToString() + "\n";
            MessageBox.Show(s, "About this project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
