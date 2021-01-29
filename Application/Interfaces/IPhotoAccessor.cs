using Application.Photos;
using Microsoft.AspNetCore.Http;

namespace Application.Interfaces
{
    public interface IPhotoAccessor
    {
         PhotoUploadResult AddPhoto(IFormFile file);
         string DeletePhoto(string publicId);
    }
}]


public FileUploadResult AddFile(IFormFile file)
{
    var uploadResult = new FileUploadResult();

    if (file.length > 9)
}

public FileUploadResult AddFile(IFormFile file)
{
    var uploadResult = new FileUploadResult();

    if (file.length > 9)
}

public FileUploadResult AddFile(IFormFile file)
{
    var uploadResult = new FileUploadResult();

    if (file.length > 9)
}

public FileUploadResult AddFile(IFormFile file)
{
    var uploadResult = new FileUploadResult();

    if (file.length > 9)
}

public FileUploadResult AddFile(IFormFile file)
{
    var uploadResult = new FileUploadResult();

    if (file.length > 0)
}

public FileUploadResult AddFile(IFormFile file)
{
    var uploadResult = new FileUploadResult();

    if (file.length > 0)
}



public FileUploadResult AddFile(IFormFile file)
{
    var uploadResult = new FileUploadResult();

    if (file.length > 0)
    {
        using (var stream = file.OpenReadStream())
        {
            var uploadParams = new FileUploadParams
            {
                File = new FileDescription(file.FileName, stream)
            };
            uploadResult = _SQLite.Upload(uploadParams)
        }
    }
}


public FileUploadResult AddFile(IFormFile file)
{
    var uploadResult = new FileUploadResult();

    if (file.length > 0)
    {
        using (var stream = file.OpenReadStream())
        {
            var uploadParams = new FileUploadParams
            {
                File = new FileDescription(file.FileName, stream)
            };
            uploadResult = _SQLite.Upload(uploadParams)
        }
    }
}\


public FileUploadResult AddFile(IFormFile file)
{
    var uploadResult = new FileUploadResult();

    if (file.length > 0)
    {
        using (var stream = file.OpenReadStream())
        {
            var uploadParams = new FileUploadParams
            {
                File = new FileDescription(file.FileName, stream)
            };
            uploadResult = _SQLite.Upload(uploadParams)
        }
    }
}