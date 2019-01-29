namespace Maloncher_v2.src {
    internal class InfoJeux {
        public string Chemin { set; get; }
        public string Label { set; get; }
        public string Miniature { set; get; }

        public InfoJeux( string chemin, string label, string miniature) 
        {
            Chemin = chemin;
            Label = label;
            Miniature = miniature;
        } 
    }
}