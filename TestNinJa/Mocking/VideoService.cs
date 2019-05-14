using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace TestNinJa.Mocking
{
    public class VideoService
    {
        private IFileReader _fileReader;
        public VideoService(IFileReader fileReader = null)
        {
            _fileReader = fileReader ?? new FileReader();
        }
        public string ReadVideoTitle()
        {
            var str = _fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUpocessedVideosCsv()
        {
            var videoIds = new List<int>();
            var context = new VideoContext();
            var videos = context.Videos.Where(x => !x.IsProcessed).ToList();

            foreach (var item in videos)
            {
                videoIds.Add(item.Id);
            }
            return string.Join(",", videoIds);
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : Context
    {
        public DbSet<Video> Videos { get; set; }
    }
}
