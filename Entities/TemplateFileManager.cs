using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaModdingTool
{
    public class TemplateFileManager
    {
        private const string TEMPLATE_DIR = "templates";
        private static TemplateFileManager instace;
        public static TemplateFileManager Instance
        {
            get
            {
                if (instace == null)
                {
                    instace = new TemplateFileManager();
                }
                return instace;
            }
        }

        private List<TemplateFile> templateFiles;
        public List<TemplateFile> TemplateFiles
        {
            get
            {
                return templateFiles;
            }
        }

        public TemplateFileManager()
        {
            templateFiles = new List<TemplateFile>();
            templateFiles.Add(new TemplateFile()
            {
                FileName = "template_kingdoms.xml",
                Type = "Kingdom"
            });
            templateFiles.Add(new TemplateFile()
            {
                FileName = "template_npccharacters.xml",
                Type = "NPCCharacter"
            });
        }

        public void FindFileByTypeAndCopy(string type, string destFileName)
        {
            var templateFile = templateFiles.Where(o => o.Type == type).FirstOrDefault();
            if (templateFile != null)
            {
                templateFile.CopyTo(Path.Combine(Environment.CurrentDirectory, TEMPLATE_DIR), destFileName);
            }
        }
    }
}
