using System;

namespace UploadFiles.DAL.Data
{
    public class CustomerModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = "bagan";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
    }
}
