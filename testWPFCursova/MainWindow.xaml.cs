using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ChristmasPostcard;
//using Xceed.Wpf.Toolkit;
//using System.Windows.Forms;
//using ColorFont;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;
//using WpfAnimatedGif;
//using ColorFont;
//using System.Windows.Controls.Primitives;
//using System.IO;
//using System.Windows.Media.Animation;


namespace testWPFCursova
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        Manager manager;

        //private Point mouseClick;
        //private double canvasLeft;
        //private double canvasTop;
        //private TransformGroup trGrp;
        //private TransformGroup trGrp2;
        //private SkewTransform trSkw;
        //private RotateTransform trRot;
        //private TranslateTransform trTns;
        //private ScaleTransform trScl;
        //private SkewTransform trSkw2;
        //private RotateTransform trRot2;
        //private TranslateTransform trTns2;
        //private ScaleTransform trScl2;
        //System.Windows.Forms.FontDialog fd;
//textBlock
//        void mytext_LostMouseCapture(object sender, MouseEventArgs e)
//        {
//            ((TextBlock)sender).ReleaseMouseCapture();
//        }

//        void mytext_TextInput(object sender, TextCompositionEventArgs e)
//        {
//            ((TextBlock)sender).ReleaseMouseCapture();
//        }

//        void mytext_MouseUp(object sender, MouseButtonEventArgs e)
//        {
//            ((TextBlock)sender).ReleaseMouseCapture();
//        }

//        void mytext_MouseMove(object sender, MouseEventArgs e)
//        {
//            if (((TextBlock)sender).IsMouseCaptured)
//            {
//                Point mouseCurrent = e.GetPosition(null);
//                double Left = mouseCurrent.X - mouseClick.X;
//                double Top = mouseCurrent.Y - mouseClick.Y;
//                mouseClick = e.GetPosition(null);
//                ((TextBlock)sender).SetValue(Canvas.LeftProperty, canvasLeft + Left);
//                ((TextBlock)sender).SetValue(Canvas.TopProperty, canvasTop + Top);
//                canvasLeft = Canvas.GetLeft(((TextBlock)sender));
//                canvasTop = Canvas.GetTop(((TextBlock)sender));
//            }
//        }

//        void text_TextChanged(object sender, TextChangedEventArgs e)
//        {
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (TextBlock a in canva.Children.OfType<TextBlock>())
//            {
//                if (a.Name == (sender as TextBox).Name)
//                {
//                    a.Text = (sender as TextBox).Text;
//                }
//            }
//            //throw new NotImplementedException();
//        }
//// create editor
//        void mytext_MouseDown(object sender, MouseButtonEventArgs e)
//        {
//            Edit.Children.Clear();
//            TextBox text = new TextBox();
//            Label l = new Label();
//            l.Content = "Text Editor";
//            text.TextChanged += text_TextChanged;
//            text.Text = (sender as TextBlock).Text;
//            text.Name = (sender as TextBlock).Name;
//            Edit.Children.Add(l);
//            Edit.Children.Add(text);

//            Xceed.Wpf.Toolkit.ColorPicker cp = new Xceed.Wpf.Toolkit.ColorPicker();
//            cp.Height = 30;
//            cp.DisplayColorAndName = true;
//            cp.Name = (sender as TextBlock).Name;
//            cp.ShowAdvancedButton = true;
//            cp.SelectedColor = ((sender as TextBlock).Foreground as SolidColorBrush).Color;
//            cp.SelectedColorChanged += cp_SelectedColorChanged;
//            Edit.Children.Add(cp);

//                //fd = new System.Windows.Forms.FontDialog();
//            System.Windows.Controls.Button newBtn = new Button();

//            newBtn.Content = "Changed Font";
//            newBtn.Name = (sender as TextBlock).Name; ;
//            newBtn.Click += newBtn_Click;
//            Edit.Children.Add(newBtn);

//            Button b = new Button();
//            b.Content = "Delete";
//            b.Name = (sender as TextBlock).Name;
//            b.Click += b_text_Click;
//            Edit.Children.Add(b);

//            mouseClick = e.GetPosition(null);
//            canvasLeft = Canvas.GetLeft(((TextBlock)sender));
//            canvasTop = Canvas.GetTop(((TextBlock)sender));
//            ((TextBlock)sender).CaptureMouse();
//        }

//        void b_text_Click(object sender, RoutedEventArgs e)
//        {
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (TextBlock a in canva.Children.OfType<TextBlock>())
//            {
//                if (a.Name == (sender as Button).Name)
//                {
//                    Edit.Children.Clear();
//                    canva.Children.Remove(a);
//                    break;
//                }
//            }
   
//            //throw new NotImplementedException();
//        }

//        void newBtn_Click(object sender, RoutedEventArgs e)
//        {
//            ColorFont.ColorFontDialog fntDialog = new ColorFont.ColorFontDialog();
//            fntDialog.Owner = this;
//            Canvas canva2 = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (TextBlock a in canva2.Children.OfType<TextBlock>())
//            {
//                if (a.Name == (sender as Button).Name)
//                {                                    
//                        Control s = new Control();
//                        s.FontFamily = a.FontFamily;
//                        s.FontSize = a.FontSize;
//                        s.FontWeight = a.FontWeight;
//                        s.FontStyle = a.FontStyle;
//                        s.Foreground = a.Foreground;
//                        fntDialog.Font = FontInfo.GetControlFont(s as Control);                  
//                }
//            }
//            if (fntDialog.ShowDialog() == true)
//            {
//                Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//                foreach (TextBlock a in canva.Children.OfType<TextBlock>())
//                {
//                    if (a.Name == (sender as Button).Name)
//                    {
//                        FontInfo selectedFont = fntDialog.Font;
//                        if (selectedFont != null)
//                        {
//                            a.FontFamily = selectedFont.Family;
//                            a.FontSize = selectedFont.Size;
//                            a.FontWeight = selectedFont.Weight;
//                            a.FontStyle = selectedFont.Style;
//                        }
//                    }
//                }
//            }
//            //throw new NotImplementedException();
//        }

//        void cp_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<System.Windows.Media.Color> e)
//        {
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (TextBlock a in canva.Children.OfType<TextBlock>())
//            {
//                if (a.Name == (sender as Xceed.Wpf.Toolkit.ColorPicker).Name)
//                {
//                    a.Foreground = new SolidColorBrush((sender as Xceed.Wpf.Toolkit.ColorPicker).SelectedColor);                  
//                }
//            }
//            //throw new NotImplementedException();
//        }
        // image
        #region image
        //        void myimg_LostMouseCapture(object sender, MouseEventArgs e)
//        {
//            ((Image)sender).ReleaseMouseCapture();
//        }

//        void myimg_TextInput(object sender, TextCompositionEventArgs e)
//        {
//            ((Image)sender).ReleaseMouseCapture();
//        }

//        void myimg_MouseUp(object sender, MouseButtonEventArgs e)
//        {
//            ((Image)sender).ReleaseMouseCapture();
//        }

//        void myimg_MouseMove(object sender, MouseEventArgs e)
//        {
//            if (((Image)sender).IsMouseCaptured)
//            {
//                Point mouseCurrent = e.GetPosition(null);
//                double Left = mouseCurrent.X - mouseClick.X;
//                double Top = mouseCurrent.Y - mouseClick.Y;
//                mouseClick = e.GetPosition(null);
//                ((Image)sender).SetValue(Canvas.LeftProperty, canvasLeft + Left);
//                ((Image)sender).SetValue(Canvas.TopProperty, canvasTop + Top);
//                canvasLeft = Canvas.GetLeft(((Image)sender));
//                canvasTop = Canvas.GetTop(((Image)sender));
//            }
//        }
//// create editor
//        void myimg_MouseDown(object sender, MouseButtonEventArgs e)
//        {
//            mouseClick = e.GetPosition(null);
//            canvasLeft = Canvas.GetLeft(((Image)sender));
//            canvasTop = Canvas.GetTop(((Image)sender));
//            ((Image)sender).CaptureMouse();

//            Edit.Children.Clear();
//            Label l = new Label();
//            l.Content = "Image Editor";
//            Edit.Children.Add(l);

//            Label lWidth = new Label();
//            lWidth.FontSize = 10;
//            lWidth.Content = "Image Size";
//            Edit.Children.Add(lWidth);
//            //TextBox textWidth = new TextBox();
//            ////textWidth.TextChanged += text_TextChanged;
//            //textWidth.Text = Convert.ToString((sender as Image).ActualWidth);
//            //textWidth.Name = (sender as Image).Name;
//            //Edit.Children.Add(textWidth);

//            Slider sWidth = new Slider();
//            sWidth.Name = (sender as Image).Name;
//            sWidth.Minimum = 10;
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            sWidth.Maximum = canva.ActualWidth;
//            //sWidth.Maximum = 100;
//            //sWidth.LargeChange = 5;
//            //sWidth.SmallChange = 20;
//            sWidth.Value = (sender as Image).ActualWidth;
//            sWidth.ValueChanged += sWidth_ValueChanged;
//            //sWidth.Ticks = 1.0;
//            //sWidth.IsDirectionReversed = true;
//            sWidth.IsMoveToPointEnabled = true;
//            //sWidth.AutoToolTipPrecision = 0;
//            sWidth.AutoToolTipPlacement = AutoToolTipPlacement.BottomRight;
//            //sWidth.TickPlacement = TickPlacement.BottomRight;

//            //sWidth.IsSelectionRangeEnabled = true;
//            //sWidth.SelectionStart = 2.5;
//            //sWidth.SelectionEnd = 7.5;


//            sWidth.IsSnapToTickEnabled = true;
//            sWidth.TickFrequency = 5;
//            //sWidth.sel
//            //s.TickPlacement = BottomRight;
//            //Maximum="72" Value="10"             Minimum="8"
//            //SmallChange="0.5" LargeChange="2" HorizontalAlignment="Right" 
//            //VerticalAlignment="Bottom" Width="192" Margin="0,0,0,5" 
//            //TickPlacement="BottomRight" 
//            //AutoToolTipPlacement ="TopLeft" />
//            Edit.Children.Add(sWidth);

//            //Label lHeight = new Label();
//            //lHeight.FontSize = 10;
//            //lHeight.Content = "Image Height";
//            //Edit.Children.Add(lHeight);
//            //TextBox textHeight = new TextBox();
//            ////textHeight.TextChanged += text_TextChanged;
//            //textHeight.Text = Convert.ToString((sender as Image).ActualHeight);
//            //textHeight.Name = (sender as Image).Name;
//            //Edit.Children.Add(textHeight);
            

//            //Button r = new Button();
//            //r.Content = "Rotate";
//            //r.Name = (sender as Image).Name;
//            //r.Click += r_image_Click;
//            //Edit.Children.Add(r);
//            Label ltrRot = new Label();
//            ltrRot.FontSize = 10;
//            ltrRot.Content = "Image Rotate";
//            Edit.Children.Add(ltrRot);
//            Slider s = new Slider();
//            s.Name = (sender as Image).Name;
//            s.Maximum = 360;
//            s.Height = 24;
//            s.LargeChange = 0.1;
//            s.SmallChange = 1;
//            s.Value = (sender as Image).RenderTransform.Value.M11;
//            s.ValueChanged += s_ValueChanged;
 
//            Edit.Children.Add(s);
//         //<Slider Height="26" Margin="55,0,0,33.7233333333334" Minimum="-2" Maximum="2" SmallChange=".1"
//            //LargeChange=".1" VerticalAlignment="Bottom" HorizontalAlignment="Left" Width="128"  x:Name="slSclX" ValueChanged="O
//            Label ScaleX = new Label();
//            ScaleX.FontSize = 10;
//            ScaleX.Content = "Scale X";
//            Edit.Children.Add(ScaleX);
//            Slider s2 = new Slider();
//            s2.Name = (sender as Image).Name;
//            s2.Maximum = 2;
//            s2.Minimum = -2;
//            s2.Height = 20;
//            s2.LargeChange = 0.1;
//            s2.SmallChange = 0.1;
//            //s2.Value = (sender as Image).RenderTransform.Value.M11;
//            s2.ValueChanged += s_ValueChanged2;
//            Edit.Children.Add(s2);

//            //trScl.ScaleY = slSclY.Value;
//            //<Slider Height="26" LargeChange="0.1" Margin="253,0,257,32"
//            //Maximum="2" Minimum="-2" SmallChange="0.1" VerticalAlignment="Bottom" x:Name="slSclY" ValueChanged="OnValueChanged" />
//            Label ScaleY = new Label();
//            ScaleY.FontSize = 10;
//            ScaleY.Content = "Scale Y";
//            Edit.Children.Add(ScaleY);
//            Slider s3 = new Slider();
//            s3.Name = (sender as Image).Name;
//            s3.Maximum = 2;
//            s3.Minimum = -2;
//            s3.Height = 20;
//            s3.LargeChange = 0.1;
//            s3.SmallChange = 0.1;
//            //s2.Value = (sender as Image).RenderTransform.Value.M11;
//            s3.ValueChanged += s_ValueChanged3;
//            Edit.Children.Add(s3);
//            //trSkw.AngleX = slSkwX.Value;
//            //<Slider Height="26" HorizontalAlignment="Left" LargeChange="0.1"
//            //Margin="49,0,0,0" Maximum="50" Minimum="-50" SmallChange="0.1" VerticalAlignment="Bottom" Width="157" Name="slSkwX"
//            Label SkewX = new Label();
//            SkewX.FontSize = 10;
//            SkewX.Content = "Skew X";
//            Edit.Children.Add(SkewX);
//            Slider s4 = new Slider();
//            s4.Name = (sender as Image).Name;
//            s4.Maximum = 50;
//            s4.Minimum = -50;
//            s4.Height = 20;
//            s4.LargeChange = 0.1;
//            s4.SmallChange = 0.1;
//            //s2.Value = (sender as Image).RenderTransform.Value.M11;
//            s4.ValueChanged += s_ValueChanged4;
//            Edit.Children.Add(s4);
//            //trSkw.AngleY = slSkwY.Value;

//             //<Slider Height="26" LargeChange="0.1" Margin="248,0,235,0" Maximum="50" Minimum="-50" SmallChange="0.1" VerticalAlignment="Bottom" Name="slSkwY" 
//            Label SkewY = new Label();
//            SkewY.FontSize = 10;
//            SkewY.Content = "Skew Y";
//            Edit.Children.Add(SkewY);
//            Slider s5 = new Slider();
//            s5.Name = (sender as Image).Name;
//            s5.Maximum = 50;
//            s5.Minimum = -50;
//            s5.Height = 20;
//            s5.LargeChange = 0.1;
//            s5.SmallChange = 0.1;
//            //s2.Value = (sender as Image).RenderTransform.Value.M11;
//            s5.ValueChanged += s_ValueChanged5;
//            Edit.Children.Add(s5);
//            Button b = new Button();
//            b.Content = "Delete";
//            b.Name = (sender as Image).Name;
//            b.Click += b_image_Click;
//            Edit.Children.Add(b);
//        }

//        private void s_ValueChanged5(object sender, RoutedPropertyChangedEventArgs<double> e)
//        {
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (Image a in canva.Children.OfType<Image>())
//            {
//                if (a.Name == (sender as Slider).Name)
//                {
//                    a.RenderTransform = trGrp;
//                    //trRot.Angle = (sender as Slider).Value;
//                    trSkw.AngleY = (sender as Slider).Value;
//                    //trGrp2 = 0;
//                    trRot2 = trRot.CloneCurrentValue();
//                    trGrp2 = trGrp.CloneCurrentValue();
//                    a.RenderTransform = trGrp2;
//                    break;
//                }
//            }
//            //throw new NotImplementedException();
//        }

//        private void s_ValueChanged4(object sender, RoutedPropertyChangedEventArgs<double> e)
//        {
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (Image a in canva.Children.OfType<Image>())
//            {
//                if (a.Name == (sender as Slider).Name)
//                {
//                    a.RenderTransform = trGrp;
//                    //trRot.Angle = (sender as Slider).Value;
//                    trSkw.AngleX = (sender as Slider).Value;
//                    //trGrp2 = 0;
//                    trRot2 = trRot.CloneCurrentValue();
//                    trGrp2 = trGrp.CloneCurrentValue();
//                    a.RenderTransform = trGrp2;
//                    break;
//                }
//            }
//            //throw new NotImplementedException();
//        }

//        private void s_ValueChanged3(object sender, RoutedPropertyChangedEventArgs<double> e)
//        {
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (Image a in canva.Children.OfType<Image>())
//            {
//                if (a.Name == (sender as Slider).Name)
//                {
//                    a.RenderTransform = trGrp;
//                    //trRot.Angle = (sender as Slider).Value;
//                    trScl.ScaleY = (sender as Slider).Value;
//                    //trGrp2 = 0;
//                    trRot2 = trRot.CloneCurrentValue();
//                    trGrp2 = trGrp.CloneCurrentValue();
//                    a.RenderTransform = trGrp2;
//                    break;
//                }
//            }
//            //throw new NotImplementedException();
//        }

//        private void s_ValueChanged2(object sender, RoutedPropertyChangedEventArgs<double> e)
//        {
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (Image a in canva.Children.OfType<Image>())
//            {
//                if (a.Name == (sender as Slider).Name)
//                {
//                    a.RenderTransform = trGrp;
//                    //trRot.Angle = (sender as Slider).Value;
//                    trScl.ScaleX = (sender as Slider).Value;
//                    //trGrp2 = 0;
//                    trRot2 = trRot.CloneCurrentValue();
//                    trGrp2 = trGrp.CloneCurrentValue();
//                    a.RenderTransform = trGrp2;
//                    break;
//                }
//            }
//            //throw new NotImplementedException();
//        }

//        void s_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
//        {
//            //trRot.CenterX = (sender as Slider).Value;

//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (Image a in canva.Children.OfType<Image>())
//            {
//                if (a.Name == (sender as Slider).Name)
//                {
//                    a.RenderTransform = trGrp;
//                    trRot.Angle = (sender as Slider).Value;
//                    //trGrp2 = 0;
//                    trRot2 = trRot.CloneCurrentValue();
//                    trGrp2 = trGrp.CloneCurrentValue();
//                    a.RenderTransform = trGrp2;
//                    break;
//                }
//            }
            
            
//            //throw new NotImplementedException();
//        }
//        protected void OnValueChanged(object sender,
//                                System.Windows.RoutedEventArgs e)
//        {
//            //trRot.Angle = (sender as Slider).Value;
//            //trRot.CenterX = (sender as Slider).Value;
//            //trRot.CenterY = slRotY.Value;
//            //trScl.ScaleX = slSclX.Value;
//            //trScl.ScaleY = slSclY.Value;
//            //trScl.CenterX = slSclOX.Value;
//            //trScl.CenterY = slSclOY.Value;

//            //trSkw.AngleX = slSkwX.Value;
//            //trSkw.AngleY = slSkwY.Value;
//            //trSkw.CenterX = slSkwOX.Value;
//            //trSkw.CenterY = slSkwOY.Value;

//            ////trTns.X = slTrnX.Value;
//            ////trTns.Y = slTrnY.Value;
//        }
//        private void r_image_Click(object sender, RoutedEventArgs e)
//        {
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (Image a in canva.Children.OfType<Image>())
//            {
//                if (a.Name == (sender as Button).Name)
//                {
//                    //RotateTransform rotation = a.RenderTransform as RotateTransform;
//                    //if (rotation != null) // Make sure the transform is actually a RotateTransform
//                    //{
//                    //    double rotationInDegrees = rotation.Angle;
//                    //    // Do something with the rotationInDegrees here, if needed...
//                    //}
//                    ////If you want to just make another UIelement rotate in the same way, you can just assign the same transform:

//                    //a.RenderTransform = a.RenderTransform;
//                    //RotateTransform s = new RotateTransform();
//                    //((RotateTransform)a).Angle = 30;
//                    //s.Angle = a.A 30;
//                    //a.RenderTransform = new ScaleTransform().SetScale(3);
//                    //((RotateTransform)a.RenderTransform).Angle += 180;
//                    //((RotateTransform)a.RenderTransform).Angle += 180;
//                    //a.RenderTransform.Value.RotatePrepend(180);
//                    //a.RenderTransform.Value.RotateAt(45, 25, 50);
//                    break;
//                }
//            }
//            //throw new NotImplementedException();
//        }

//        void b_image_Click(object sender, RoutedEventArgs e)
//        {
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (Image a in canva.Children.OfType<Image>())
//            {
//                if (a.Name == (sender as Button).Name)
//                {
//                    Edit.Children.Clear();
//                    canva.Children.Remove(a);
//                    break;
//                }
//            }
            
//            //throw new NotImplementedException();
//        }



//        void sWidth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
//        {
//            Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
//            foreach (Image a in canva.Children.OfType<Image>())
//            {
//                if (a.Name == (sender as Slider).Name)
//                {
//                    //a.Foreground = new SolidColorBrush((sender as Xceed.Wpf.Toolkit.ColorPicker).SelectedColor);
//                    a.Width = (sender as Slider).Value;
//                }
//            }
//            //throw new NotImplementedException();
        //        }
        #endregion
        //main
        public MainWindow()
        {
            InitializeComponent();
            #region syst
            //System.Windows.Forms.FontDialog fd = new System.Windows.Forms.FontDialog();
            //trSkw = new SkewTransform(0, 0);
            //trRot = new RotateTransform(0);
            //trTns = new TranslateTransform(0, 0);
            //trScl = new ScaleTransform(1, 1);
            //trSkw2 = new SkewTransform(0, 0);
            //trRot2 = new RotateTransform(0);
            //trTns2 = new TranslateTransform(0, 0);
            //trScl2 = new ScaleTransform(1, 1);
            //trGrp2 = new TransformGroup();
            //trGrp2.Children.Add(trSkw2);
            //trGrp2.Children.Add(trRot2);
            //trGrp2.Children.Add(trTns2);
            //trGrp2.Children.Add(trScl2);
            //trGrp = new TransformGroup();
            //trGrp.Children.Add(trSkw);
            //trGrp.Children.Add(trRot);
            //trGrp.Children.Add(trTns);
            //trGrp.Children.Add(trScl);
            #endregion
            manager = new Manager(tabs, Background, Edit);
        }

        private void Resize(object sender, EventArgs e)
        {
            (((sender as TabItem).Content as StackPanel).Children[0] as Canvas).Width = tabs.ActualWidth;
            (((sender as TabItem).Content as StackPanel).Children[0] as Canvas).Height = tabs.ActualHeight;
        }
  //create tab
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            manager.Create_Poscard();
        }

 //add image button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            manager.Add_image();
            #region im
            //if (tabs.Items.Count == 0)
            //{
            //    return;
            //}
            //Canvas canva = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
            //Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            //// Set filter for file extension and default file extension
            //openFileDlg.DefaultExt = ".gif";
            //openFileDlg.Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";
            //// Display OpenFileDialog by calling ShowDialog method
            //openFileDlg.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory + @"Christmas Pictures";
            //Nullable<bool> result = openFileDlg.ShowDialog();
            //// Get the selected file name and display in a TextBox
            //if (result == true)
            //{
            //    // Open document
            //    string filename = openFileDlg.FileName;
            //    string ext = System.IO.Path.GetExtension(filename).ToLower();

            //    if (ext == ".jpg" || ext == ".bmp" || ext == ".png")
            //    {
            //        BitmapImage src = new BitmapImage();
            //        src.BeginInit();
            //        src.UriSource = new Uri(filename, UriKind.Absolute);
            //        src.EndInit();
            //        Image img = new Image();
            //        img.Name = "Image" + canva.Children.Count.ToString();
            //        img.Source = src;
            //        img.Width = src.Width;
            //        img.Height = src.Height;
            //        Canvas.SetLeft(img, 0);
            //        Canvas.SetTop(img, 0);
            //        img.PreviewMouseDown += new MouseButtonEventHandler(myimg_MouseDown);
            //        img.PreviewMouseMove += new MouseEventHandler(myimg_MouseMove);
            //        img.PreviewMouseUp += new MouseButtonEventHandler(myimg_MouseUp);
            //        img.TextInput += new TextCompositionEventHandler(myimg_TextInput);
            //        img.LostMouseCapture += new MouseEventHandler(myimg_LostMouseCapture);
            //        img.SetValue(Canvas.LeftProperty, 0.0);
            //        img.SetValue(Canvas.TopProperty, 0.0);
            //        img.SetValue(Canvas.LeftProperty, 0.0);
            //        img.SetValue(Canvas.TopProperty, 0.0);
            //        canva.Children.Add(img);
            //    }
            //    else if (ext == ".gif")
            //    {
            //        Image img = new Image();
                    
            //        var image = new BitmapImage();
            //        image.BeginInit();
            //        image.UriSource = new Uri(filename, UriKind.Absolute);
            //        image.EndInit();
            //        ImageBehavior.SetAnimatedSource(img, image);
            //        Canvas.SetLeft(img, 0);
            //        Canvas.SetTop(img, 0);
            //        img.PreviewMouseDown += new MouseButtonEventHandler(myimg_MouseDown);
            //        img.PreviewMouseMove += new MouseEventHandler(myimg_MouseMove);
            //        img.PreviewMouseUp += new MouseButtonEventHandler(myimg_MouseUp);
            //        img.TextInput += new TextCompositionEventHandler(myimg_TextInput);
            //        img.LostMouseCapture += new MouseEventHandler(myimg_LostMouseCapture);
            //        img.SetValue(Canvas.LeftProperty, 0.0);
            //        img.SetValue(Canvas.TopProperty, 0.0);
            //        img.SetValue(Canvas.LeftProperty, 0.0);
            //        img.SetValue(Canvas.TopProperty, 0.0);
            //        img.Name = "Image"  +canva.Children.Count.ToString() ;
            //        canva.Children.Add(img);
            //    }

            //}
            #endregion
        }

 //add text button
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            manager.Add_text();
        }
// tab config
        private void tabs_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
            foreach (object a in (sender as TabControl).Items)
            {
                (((a as TabItem).Content as StackPanel).Children[0] as Canvas).Width = tabs.ActualWidth;
                (((a as TabItem).Content as StackPanel).Children[0] as Canvas).Height = tabs.ActualHeight;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            manager.Save_postcard();
            #region save
            //try
            //{
            //    Microsoft.Win32.SaveFileDialog saveDialog = new Microsoft.Win32.SaveFileDialog();
            //    saveDialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory + @"Postcard";
            //    saveDialog.Filter = "JPeg Image(*.JPG)|*.jpg|Bitmap Image(*.BMP)|*.bmp|Png Image(*.PNG)|*.png|Gif Image(*.GIF)|*.gif";
            //    Canvas img = ((tabs.SelectedItem as TabItem).Content as StackPanel).Children[0] as Canvas;
            //    if (saveDialog.ShowDialog().Value == true)
            //    {
            //        // Save current canvas transform
            //        Transform transform = img.LayoutTransform;
            //        // reset current transform (in case it is scaled or rotated)
            //        img.LayoutTransform = null;

            //        // Get the size of canvas
            //        Size size = new Size(img.ActualWidth, img.ActualHeight);
            //        // Measure and arrange the surface
            //        // VERY IMPORTANT
            //        img.Measure(size);
            //        img.Arrange(new Rect(size));

            //        // Create a render bitmap and push the surface to it
            //        RenderTargetBitmap renderBitmap =
            //          new RenderTargetBitmap(
            //            (int)size.Width,
            //            (int)size.Height,
            //            96d,
            //            96d,
            //            PixelFormats.Default);
            //        renderBitmap.Render(img);
            //        BitmapEncoder encoder = new BmpBitmapEncoder();
            //        string extension = saveDialog.FileName.Substring(saveDialog.FileName.LastIndexOf('.'));
            //        switch (extension.ToLower())
            //        {
            //            case ".jpg":
            //                encoder = new JpegBitmapEncoder();
            //                break;
            //            case ".bmp":
            //                encoder = new BmpBitmapEncoder();
            //                break;
            //            case ".gif":
            //                encoder = new GifBitmapEncoder();
            //                break;
            //            case ".png":
            //                encoder = new PngBitmapEncoder();
            //                break;
            //        }
            //        // push the rendered bitmap to it
            //        encoder.Frames.Add(BitmapFrame.Create(renderBitmap));
            //        // Create a file stream for saving image
            //        using (FileStream fs = File.Open(saveDialog.FileName, FileMode.OpenOrCreate))
            //        {
            //            encoder.Save(fs);
            //        }
            //        // Restore previously saved layout
            //        img.LayoutTransform = transform;
            //    }

            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            #endregion
        }
    }
}
