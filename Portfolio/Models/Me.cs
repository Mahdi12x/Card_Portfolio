namespace Portfolio.Models
{
    public class Me
    {
        public string Name { get; set; }
        public string MainBio { get; set; }

        public Me(string name,string mainbio)
        {
            Name = name;
            MainBio = mainbio;
        }
    }

}