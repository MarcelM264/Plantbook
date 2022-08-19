namespace Plantbook.Models
{
    public class PlantPosting
    {
        public int Id { get; set; }

        public string Species { get; set; }

        public int Age { get; set; }

        public int Height { get; set; }

        public string Location { get; set; }

        public string Note { get; set; }

        public byte[] PlantImage { get; set; }
    }
}
