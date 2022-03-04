using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaModdingTool
{
    public class TemplateFile
    {
        public string FileName { get; set; }
        public string Type { get; set; }
        public void CopyTo(string templateFileDir, string destFileName)
        {
            string fullPath = Path.Combine(templateFileDir, FileName);
            File.Copy(fullPath, destFileName, true);
        }
    }
}
