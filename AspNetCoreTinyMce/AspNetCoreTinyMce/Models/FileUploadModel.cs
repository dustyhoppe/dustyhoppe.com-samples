using System.Runtime.Serialization;

namespace AspNetCoreTinyMce.Models
{
    [DataContract]
    public class FileUploadModel
    {
        [DataMember(Name = "fileName")]
        public string FileName { get; set; }

        [DataMember(Name = "fileBytes")]
        public byte[] FileBytes { get; set; }
    }
}
