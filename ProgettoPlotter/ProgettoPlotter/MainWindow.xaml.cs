using Microsoft.Win32;
using ProgettoPlotter.Classes;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ProgettoPlotter
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CManager manager;

        Point p1; /* Temporary starting point */
        Point p2; /* Temporary ending point */

        /* Default constructor */
        public MainWindow()
        {
            InitializeComponent();

            manager = new CManager(PictureCanvas, ListBoxLines); /* Initialize canvas */

            CheckBoxRules.IsChecked = true; /* Default checked item */

            /* Initialize combo color */
            ComboColor.ItemsSource = typeof(Colors).GetProperties();
            ComboColor.SelectedIndex = 7;
            RadioButtonDefaultColor.IsChecked = true;

            /* Initialize radio button */
            RadioButtonPen.IsChecked = true;
            RadioButtonUpDown.IsEnabled = false;
            RadioButtonLeftRight.IsEnabled = false;
            RadioButtonUpLeft.IsEnabled = false;
            RadioButtonUpRight.IsEnabled = false;
            RadioButtonRightTriangle.IsEnabled = false;
            RadioButtonIsoscelesTriangle.IsEnabled = false;

            /* Initialize ComboBox */
            for (int i = 1; i < 9; i++)
                ComboBoxCOM.Items.Add("COM" + i);

            
        }

        /* Picture Canvas actions */
        private void PictureCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            /* Check if any radiobutton is checked */
            if (RadioButtonPen.IsChecked == true || RadioButtonRectangle.IsChecked == true || RadioButtonRuler.IsChecked == true || RadioButtonTriangle.IsChecked == true)
            {
                p1 = e.GetPosition(PictureCanvas); /* Get intital position */
                manager.StartDrawingLine(p1, GetSelectedColor());          /* Start drawing line */
            }
        }
        private void PictureCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            p2 = e.GetPosition(PictureCanvas); /* Get current position */

            /* Refresh position */
            TextBlockX.Text = p2.X.ToString();
            TextBlockY.Text = p2.Y.ToString();

            if (RadioButtonPen.IsChecked == true)        /* Continue drawing normal line */
                manager.ContinueDrawingLine(p2);

            else if (RadioButtonRuler.IsChecked == true) /* Continue drawing ruler line */
            {
                if (RadioButtonUpDown.IsChecked == true) manager.ContinueDrawingStraightLine(p2, 1);
                else if (RadioButtonLeftRight.IsChecked == true) manager.ContinueDrawingStraightLine(p2, 2);
                else if (RadioButtonUpLeft.IsChecked == true) manager.ContinueDrawingStraightLine(p2, 3);
                else if (RadioButtonUpRight.IsChecked == true) manager.ContinueDrawingStraightLine(p2, 4);
            }

        }
        private void PictureCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            p2 = e.GetPosition(PictureCanvas); /* Get final position */

            if (RadioButtonPen.IsChecked == true) /* End drawing normal line */
                manager.EndDrawingLine(p2);

            else if (RadioButtonRuler.IsChecked == true) /* End drawing ruler line */
            {
                if (RadioButtonUpDown.IsChecked == true) manager.EndDrawingStraightLine(p2, 1);
                else if (RadioButtonLeftRight.IsChecked == true) manager.EndDrawingStraightLine(p2, 2);
                else if (RadioButtonUpLeft.IsChecked == true) manager.EndDrawingStraightLine(p2, 3);
                else if (RadioButtonUpRight.IsChecked == true) manager.EndDrawingStraightLine(p2, 4);
            }

            else if (RadioButtonRectangle.IsChecked == true) /* End drawing rectangle */
                manager.EndDrawingRectangle(p2);

            else if (RadioButtonTriangle.IsChecked == true) /* End drawing triangle */
            {
                if (RadioButtonRightTriangle.IsChecked == true) manager.EndDrawingTriangle(p2, 1);
                else if (RadioButtonIsoscelesTriangle.IsChecked == true) manager.EndDrawingTriangle(p2, 2);
            }


        }


        /* Ruler and grid */
        private void CheckBoxRules_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBoxRules.IsChecked == true)
            {
                /* Set rule visibility to true */
                ImageRule1.Visibility = Visibility.Visible;
                ImageRule2.Visibility = Visibility.Visible;
            }

            else
            {
                /* Set rule visibility to true */
                ImageRule1.Visibility = Visibility.Hidden;
                ImageRule2.Visibility = Visibility.Hidden;
            }
        }
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }


        /* Image buttons */
        private void ImageUndo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            manager.Undo();
        }
        private void ImageDeleteAll_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            manager.DeleteAll();
        }
        private void ImageDeleteAt_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            manager.DeleteAt(ListBoxLines.SelectedIndex);
        }
        private void ImageNewFile_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            System.Windows.Forms.DialogResult res = System.Windows.Forms.MessageBox.Show("Do you want to save this file?", "", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Information);

            if (res == System.Windows.Forms.DialogResult.No)
            {
                MainWindow newWindow = new MainWindow();
                newWindow.Show();
                this.Close();
            }
        }

        /* Radio button colors */
        private void RadioButtonDefaultColor_Checked(object sender, RoutedEventArgs e)
        {
            LabelColor1.IsEnabled = true;
            ComboColor.IsEnabled = true;
            SliderR.IsEnabled = false;
            SliderG.IsEnabled = false;
            SliderB.IsEnabled = false;
        }
        private void RadioButtonCustom_Checked(object sender, RoutedEventArgs e)
        {
            LabelColor1.IsEnabled = false;
            ComboColor.IsEnabled = false;
            SliderR.IsEnabled = true;
            SliderG.IsEnabled = true;
            SliderB.IsEnabled = true;
        }
        /* Slider colors */
        private void SliderR_MouseMove(object sender, MouseEventArgs e)
        {
            TextR.Text = ((int)SliderR.Value).ToString();
        }
        private void SliderG_MouseMove(object sender, MouseEventArgs e)
        {
            TextG.Text = ((int)SliderG.Value).ToString();
        }
        private void SliderB_MouseMove(object sender, MouseEventArgs e)
        {
            TextB.Text = ((int)SliderB.Value).ToString();
        }

        /* Get automatically selected color */
        private SolidColorBrush GetSelectedColor()
        {
            if (RadioButtonDefaultColor.IsChecked == true) /* If default color */
            {
                switch (ComboColor.SelectedIndex)
                {
                    case 0: return Brushes.AliceBlue;
                    case 1: return Brushes.AntiqueWhite;
                    case 2: return Brushes.Aqua;
                    case 3: return Brushes.Aquamarine;
                    case 4: return Brushes.Azure;
                    case 5: return Brushes.Beige;
                    case 6: return Brushes.Bisque;
                    case 7: return Brushes.Black;
                    case 8: return Brushes.BlanchedAlmond;
                    case 9: return Brushes.Blue;
                    case 10: return Brushes.BlueViolet;
                    case 11: return Brushes.Brown;
                    case 12: return Brushes.BurlyWood;
                    case 13: return Brushes.CadetBlue;
                    case 14: return Brushes.Chartreuse;
                    case 15: return Brushes.Chocolate;
                    case 16: return Brushes.Coral;
                    case 17: return Brushes.CornflowerBlue;
                    case 18: return Brushes.Cornsilk;
                    case 19: return Brushes.Crimson;
                    case 20: return Brushes.Cyan;
                    case 21: return Brushes.DarkBlue;
                    case 22: return Brushes.DarkCyan;
                    case 23: return Brushes.DarkGoldenrod;
                    case 24: return Brushes.DarkGray;
                    case 25: return Brushes.DarkGreen;
                    case 26: return Brushes.DarkKhaki;
                    case 27: return Brushes.DarkMagenta;
                    case 28: return Brushes.DarkOliveGreen;
                    case 29: return Brushes.DarkOrange;
                    case 30: return Brushes.DarkOrchid;
                    case 31: return Brushes.DarkRed;
                    case 32: return Brushes.DarkSalmon;
                    case 33: return Brushes.DarkSeaGreen;
                    case 34: return Brushes.DarkSlateBlue;
                    case 35: return Brushes.DarkSlateGray;
                    case 36: return Brushes.DarkTurquoise;
                    case 37: return Brushes.DarkViolet;
                    case 38: return Brushes.DeepPink;
                    case 39: return Brushes.DeepSkyBlue;
                    case 40: return Brushes.DimGray;
                    case 41: return Brushes.DodgerBlue;
                    case 42: return Brushes.Firebrick;
                    case 43: return Brushes.FloralWhite;
                    case 44: return Brushes.ForestGreen;
                    case 45: return Brushes.Fuchsia;
                    case 46: return Brushes.Gainsboro;
                    case 47: return Brushes.GhostWhite;
                    case 48: return Brushes.Gold;
                    case 49: return Brushes.Goldenrod;
                    case 50: return Brushes.Gray;
                    case 51: return Brushes.Green;
                    case 52: return Brushes.GreenYellow;
                    case 53: return Brushes.Honeydew;
                    case 54: return Brushes.HotPink;
                    case 55: return Brushes.IndianRed;
                    case 56: return Brushes.Indigo;
                    case 57: return Brushes.Ivory;
                    case 58: return Brushes.Khaki;
                    case 59: return Brushes.Lavender;
                    case 60: return Brushes.LavenderBlush;
                    case 61: return Brushes.LawnGreen;
                    case 62: return Brushes.LemonChiffon;
                    case 63: return Brushes.LightBlue;
                    case 64: return Brushes.LightCoral;
                    case 65: return Brushes.LightCyan;
                    case 66: return Brushes.LightGoldenrodYellow;
                    case 67: return Brushes.LightGray;
                    case 68: return Brushes.LightGreen;
                    case 69: return Brushes.LightPink;
                    case 70: return Brushes.LightSalmon;
                    case 71: return Brushes.LightSeaGreen;
                    case 72: return Brushes.LightSkyBlue;
                    case 73: return Brushes.LightSlateGray;
                    case 74: return Brushes.LightSteelBlue;
                    case 75: return Brushes.LightYellow;
                    case 76: return Brushes.Lime;
                    case 77: return Brushes.LimeGreen;
                    case 78: return Brushes.Linen;
                    case 79: return Brushes.Magenta;
                    case 80: return Brushes.Maroon;
                    case 81: return Brushes.MediumAquamarine;
                    case 82: return Brushes.MediumBlue;
                    case 83: return Brushes.MediumOrchid;
                    case 84: return Brushes.MediumPurple;
                    case 85: return Brushes.MediumSeaGreen;
                    case 86: return Brushes.MediumSlateBlue;
                    case 87: return Brushes.MediumSpringGreen;
                    case 88: return Brushes.MediumTurquoise;
                    case 89: return Brushes.MediumVioletRed;
                    case 90: return Brushes.MidnightBlue;
                    case 91: return Brushes.MintCream;
                    case 92: return Brushes.MistyRose;
                    case 93: return Brushes.Moccasin;
                    case 94: return Brushes.NavajoWhite;
                    case 95: return Brushes.Navy;
                    case 96: return Brushes.OldLace;
                    case 97: return Brushes.Olive;
                    case 98: return Brushes.OliveDrab;
                    case 99: return Brushes.Orange;
                    case 100: return Brushes.OrangeRed;
                    case 101: return Brushes.Orchid;
                    case 102: return Brushes.PaleGoldenrod;
                    case 103: return Brushes.PaleGreen;
                    case 104: return Brushes.PaleTurquoise;
                    case 105: return Brushes.PaleVioletRed;
                    case 106: return Brushes.PapayaWhip;
                    case 107: return Brushes.PeachPuff;
                    case 108: return Brushes.Peru;
                    case 109: return Brushes.Pink;
                    case 110: return Brushes.Plum;
                    case 111: return Brushes.PowderBlue;
                    case 112: return Brushes.Purple;
                    case 113: return Brushes.Red;
                    case 114: return Brushes.RosyBrown;
                    case 115: return Brushes.RoyalBlue;
                    case 116: return Brushes.SaddleBrown;
                    case 117: return Brushes.Salmon;
                    case 118: return Brushes.SandyBrown;
                    case 119: return Brushes.SeaGreen;
                    case 120: return Brushes.SeaShell;
                    case 121: return Brushes.Sienna;
                    case 122: return Brushes.Silver;
                    case 123: return Brushes.SkyBlue; //OK
                    case 124: return Brushes.SlateBlue;
                    case 125: return Brushes.SlateGray;
                    case 126: return Brushes.Snow;
                    case 127: return Brushes.SpringGreen;
                    case 128: return Brushes.SteelBlue;
                    case 129: return Brushes.Tan;
                    case 130: return Brushes.Teal;
                    case 131: return Brushes.Thistle;
                    case 132: return Brushes.Tomato;
                    case 133: return Brushes.Transparent;
                    case 134: return Brushes.Turquoise;
                    case 135: return Brushes.Violet;
                    case 136: return Brushes.Wheat;
                    case 137: return Brushes.White;
                    case 138: return Brushes.WhiteSmoke;
                    case 139: return Brushes.Yellow;
                    case 140: return Brushes.YellowGreen;
                    default: return Brushes.Black;
                }
            }

            else
            {
                Color c = new Color();
                c.R = (byte)SliderR.Value;
                c.G = (byte)SliderG.Value;
                c.B = (byte)SliderB.Value;
                c.A = 255;
                System.Console.WriteLine(c.ToString());
                SolidColorBrush color = new SolidColorBrush(c);
                return color;
            }
        }

        /* Parallel drawing radioButton */
        private void RadioButtonPen_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonPen_copy.IsChecked = true;
        }
        private void RadioButtonRuler_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonRuler_copy.IsChecked = true;
        }
        private void RadioButtonRectangle_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonRectangle_copy.IsChecked = true;
        }
        private void RadioButtonTriangle_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonTriangle_copy.IsChecked = true;
        }
        private void RadioButtonPen_copy_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonPen.IsChecked = true;
        }
        private void RadioButtonRuler_copy_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonRuler.IsChecked = true;
            RadioButtonUpDown.IsEnabled = true;
            RadioButtonLeftRight.IsEnabled = true;
            RadioButtonUpLeft.IsEnabled = true;
            RadioButtonUpRight.IsEnabled = true;
        }
        private void RadioButtonRectangle_copy_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonRectangle.IsChecked = true;
        }
        private void RadioButtonTriangle_copy_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonTriangle.IsChecked = true;
            /* Enable radio buttons */
            RadioButtonRightTriangle.IsEnabled = true;
            RadioButtonIsoscelesTriangle.IsEnabled = true;
        }
        private void RadioButtonRuler_copy_Unchecked(object sender, RoutedEventArgs e)
        {
            /* Radio buttons disabled */
            RadioButtonUpDown.IsEnabled = false;
            RadioButtonLeftRight.IsEnabled = false;
            RadioButtonUpLeft.IsEnabled = false;
            RadioButtonUpRight.IsEnabled = false;
        }
        private void RadioButtonRuler_Unchecked(object sender, RoutedEventArgs e)
        {
            /* Radio buttons disabled */
            RadioButtonUpDown.IsEnabled = false;
            RadioButtonLeftRight.IsEnabled = false;
            RadioButtonUpLeft.IsEnabled = false;
            RadioButtonUpRight.IsEnabled = false;
        }
        private void RadioButtonTriangle_copy_Unchecked(object sender, RoutedEventArgs e)
        {
            RadioButtonRightTriangle.IsEnabled = false;
            RadioButtonIsoscelesTriangle.IsEnabled = false;
        }

        /* Menù */
        private void MenuItemShowLines_Click(object sender, RoutedEventArgs e)
        {
            manager.ShowLines();
        }
        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            manager.Open();
        }
        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            manager.Save();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            manager.SaveAs();
        }
        private void ImageSaveFile_MouseDown(object sender, MouseButtonEventArgs e)
        {
            manager.Save();
        }
        private void ImageOpenFile_MouseDown(object sender, MouseButtonEventArgs e)
        {
            manager.Open();
        }


        /* Serial port */
        private void ButtonConnect_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxCOM.SelectedIndex != -1) /* If serial port selected */
                manager.ConnectTo((string)ComboBoxCOM.SelectedItem);

            else
                MessageBox.Show("No serial port selected!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

        }

        



        //ToDo : 
        /*
         
         1 - Terminare tutte le funzioni delle immagini
         2 - Aggiungere classe per la gestione del log
         3 - Terminare tutte le funzioni del menù
         4 - Finire il protocollo di stampa

            EXTRA:
         1 - Aggiungere i metodi per le preview
         2 - Aggiungere poligoni da disegnare
         3 - Trasformare il vettore in un vettore di poligoni
             

         */
    }
}