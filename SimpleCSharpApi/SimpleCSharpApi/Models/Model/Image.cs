using SimpleCSharpApi.Models.Request;

namespace SimpleCSharpApi.Models.Model
{
    public class Image
    {
        public Image(ImageRequest i)
        {
            ShowImage = i.ShowImage;
        }

        public string ShowImage { get; set; }
    }
}