using System;
using System.Windows;
using DevExpress.Xpf.Map;

namespace BuildInCoordinateConverters {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            map.ZoomToFitLayerItems(0.4);
        }
    }

    public class MapData {
        public Uri FileUri { get; set; }
        public SourceCoordinateSystem CoordinateSystem { get; set; }

        public override string ToString() {
            return String.Format("MapData[FileUri = {0}, CoordinateSystem = {1}]", FileUri, CoordinateSystem);
        }
    }
}
