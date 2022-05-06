﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDataLocally
{
    internal class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), filename);
        }
    }
}
