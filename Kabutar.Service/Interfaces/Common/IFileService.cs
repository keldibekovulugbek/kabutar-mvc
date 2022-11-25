﻿using Microsoft.AspNetCore.Http;

namespace Kabutar.Service.Interfaces.Common;

public interface IFileService
{
    public string ImageFolderName { get; }
    Task<string> SaveImageAsync(IFormFile image);
    Task<bool> DeleteImageAsync(string relativeFilePath);
}
