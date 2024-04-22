namespace BaiTap_CodeFirst_ThanhGiang.Models
{
    public class ContentCreator
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public int Age { get;set; }
        public int SubscribersCount { get; set; }   
        public DateTime JoinedData { get; set; }
        public List<Video> videos { get; set; }
    }
}
