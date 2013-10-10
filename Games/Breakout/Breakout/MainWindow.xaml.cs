using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Breakout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Rectangle _blueRectangle;
        private readonly Canvas _rootcanvas;

        private int _playerX = 650;

        public MainWindow()
        {
            InitializeComponent();

            _rootcanvas = new Canvas {Width = 1300, Height = 800};
            Window.Width = 1300;
            Window.Height = 800;
            LayoutRoot.Children.Add(_rootcanvas);
            CreateRectangle();
            
        }

        private void KeyListener(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(e.Key);
            switch (e.Key)
            {
                
                case Key.Left:
                    _playerX -= 10;
                    Canvas.SetLeft(_blueRectangle, _playerX);
                    break;

                case Key.Right:
                    _playerX += 10;
                    Canvas.SetLeft(_blueRectangle, _playerX);
                    break;
            }
        }

        public void CreateRectangle()
        {
            // Create a Rectangle
            _blueRectangle = new Rectangle {Height = 30, Width = 100};


            Canvas.SetTop(_blueRectangle, 700);
            Canvas.SetLeft(_blueRectangle, _playerX);


            // Create a blue and a black Brush
            var blueBrush = new SolidColorBrush {Color = Colors.Blue};
            // SolidColorBrush blackBrush = new SolidColorBrush();
           // blackBrush.Color = Colors.Black;

            // Set Rectangle's width and color
            _blueRectangle.StrokeThickness = 4;
            //blueRectangle.Stroke = blackBrush;
            // Fill rectangle with blue color
            _blueRectangle.Fill = blueBrush;
            _blueRectangle.RadiusX = 20;
            _blueRectangle.RadiusY = 20;
            // Add Rectangle to the Grid.
            _rootcanvas.Children.Add(_blueRectangle);
        }
    }
}
