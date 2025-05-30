﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.IO.Compression;

namespace EU.Core.Extensions;

/// <summary>
/// 将前端UI压缩文件进行解压
/// </summary>
public static class UiFilesZipSetup
{
    public static void AddUiFilesZipSetup(this IServiceCollection services, IWebHostEnvironment _env)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        string wwwrootFolderPath = Path.Combine(_env.ContentRootPath, "wwwroot");
        string zipUiItemFiles = Path.Combine(wwwrootFolderPath, "ui.zip");
        if (!File.Exists(Path.Combine(wwwrootFolderPath, "ui", "index.html")))
        {
            ZipFile.ExtractToDirectory(zipUiItemFiles, wwwrootFolderPath);
        }
    }
}
