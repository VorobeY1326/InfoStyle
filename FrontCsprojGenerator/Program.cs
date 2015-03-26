﻿using System.IO;
using System.Text;

namespace Generator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var infostylePath = @"..\..\..\Infostyle\";
            var templatePath = infostylePath + @"infostyleAutogeneratedTemplate.csproj";
            var resultCsprojPath = infostylePath + @"infostyleAutogenerated.csproj";
            var text = File.ReadAllText(templatePath);
            var contentIncludes = GetIncludes(infostylePath);
            File.WriteAllText(resultCsprojPath, text.Replace("<!--includehere-->", contentIncludes));
        }

        private static string GetIncludes(string baseDirectory)
        {
            var sb = new StringBuilder();
            foreach (var file in Directory.EnumerateFiles(baseDirectory, "*.*", SearchOption.AllDirectories))
            {
                if (!file.EndsWith("csproj"))
                    sb.AppendFormat("    <Content Include=\"{0}\" />\r\n", file.Replace(baseDirectory, ""));
            }
            return sb.ToString();
        }
    }
}
