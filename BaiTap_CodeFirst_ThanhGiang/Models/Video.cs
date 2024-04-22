namespace BaiTap_CodeFirst_ThanhGiang.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int ContentCreatorId { get; set; }   

        public virtual ContentCreator ContentCreator { get; set; }  

    }
}
