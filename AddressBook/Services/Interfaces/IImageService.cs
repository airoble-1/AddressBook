using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AddressBook.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileByteArrayAsync(IFormFile file);
        public string CovertByteArrayToFile(byte[] fileData, string extension);
    }
}
