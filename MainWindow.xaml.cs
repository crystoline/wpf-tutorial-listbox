using System.Collections.Generic;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var scoreBoard = new ScoreBoard("Today's Champions League Matches");
            
            scoreBoard.matches = new List<Match>()
            {
                new Match() { Team1 =  "Arsenal", Score1 = 3, Team2 = "Bayern Muchen", Score2 = 1, Progress = 66},
                new Match() { Team1 =  "Man United", Score1 = 0, Team2 = "Real Madrid", Score2 = 1, Progress = 82},
                new Match() { Team1 =  "Totenham", Score1 = 3, Team2 = "PSG", Score2 = 4, Progress = 42},
                new Match() { Team1 =  "Liver Pool", Score1 = 3, Team2 = "Sharktar Donest", Score2 = 1, Progress = 32}
                
            };
            this.DataContext = scoreBoard;
           // LiveScore.ItemsSource = matches;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this, "Hello");
            throw new System.NotImplementedException();
        }
    }

    public class ScoreBoard
    {
        public ScoreBoard(string title = "Default")
        {
            Title = title;
        }

       

        public string Title { get; set; }
        public List<Match> matches { get; set; }
    }
    public class Match
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Progress { get; set; }
    }
}