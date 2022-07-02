using System.IO;
using AddressBook.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace AddressBook.Services
{
    public class BasicImageService : IImageService
    {
        public async Task<byte[]> ConvertFileByteArrayAsync(IFormFile file)
        {
            MemoryStream memoryStream = new();
            await file.CopyToAsync(memoryStream);
            byte[] byteFile = memoryStream.ToArray();

            return byteFile;
        }

        public string CovertByteArrayToFile(byte[] fileData, string extension)
        {
           if (fileData == null) return string.Empty;

            string imageBase64Data = Convert.ToBase64String(fileData);
            return $"data:{extension};base64,{imageBase64Data}";
        }
    }
}
