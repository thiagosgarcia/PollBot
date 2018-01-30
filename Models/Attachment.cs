namespace TollBot.Models
{
    public class Attachment : Entity
    {
        public string content_type { get; set; }
        public string content_id { get; set; }
        public string file_name { get; set; }
        public long file_so { get; set; }
        public string path { get; set; }

        //     {
        //   "content_type": "text/html",
        //   "content_id": "4e8b0e5bdccc2_4eec800c21ac57014@ciMac.local.mail",
        //   "file_name": "cucumber.html",
        //   "file_size": 27798, // Size in bytes
        //   "path": "/private/1/2/files/ec53a7aa7a974cdc9d07c5ca395a2f05/cucumber.html"
        // }
    }

}