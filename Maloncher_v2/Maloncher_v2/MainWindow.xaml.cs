using Maloncher_v2.src;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Newtonsoft.Json;

namespace Maloncher_v2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private InfoWindow infos;
     
        public MainWindow() {
            using ( StreamReader file = File.OpenText( "configuration.json" ) ) {
                JsonSerializer serializer = new JsonSerializer();
                infos = (InfoWindow) serializer.Deserialize(file, typeof( InfoWindow ) );
            }
            this.Content = this.initialisationDeLaGrille();
            InitializeComponent();
        }

        private void Button_Click( object sender, RoutedEventArgs e ) {
            ProcessStartInfo notepadStartInfo = new ProcessStartInfo(infos.Jeux.First().Chemin);

            Process notepad = new Process();
            notepad.StartInfo = notepadStartInfo;
            notepad.Start();
        }

        private Grid initialisationDeLaGrille() {
            Grid contenu = new Grid();
            // titre :
            TextBlock titre = new TextBlock();
            titre.HorizontalAlignment = HorizontalAlignment.Center;
            titre.VerticalAlignment = VerticalAlignment.Top;
            titre.Margin = new Thickness(0,10,0,0);
            titre.TextWrapping = TextWrapping.Wrap;
            titre.Text = infos.Titre;
            contenu.Children.Add( titre );

            //bouton jeux :
            foreach ( InfoJeux jeu in infos.Jeux ) {
                Button jeuN = new Button();
                jeuN.Click += Button_Click;
                jeuN.Content = jeu.Label;
                jeuN.Width = 100;
                jeuN.Height = 100;
                jeuN.Background = new ImageBrush( new BitmapImage( new Uri( jeu.Miniature, UriKind.Relative ) ) );
                contenu.Children.Add( jeuN );
            }


            return contenu;
        }
    }
}
