using System.Diagnostics;

namespace SmartFitExpert.Core.BLL.CreateTrainingPlan
{
    public class GenerateInitialPlanService
    {
        private readonly string _pythonExePath;
        public GenerateInitialPlanService(string pythonExePath)
        {
            _pythonExePath = pythonExePath;
        }

        private ScriptContentDto FormatPostgreSql(string inputSql)
        {
            var assemblyPath = typeof(GenerateInitialPlanService).Assembly.Location.Split('\\').SkipLast(1);
            var filePath = string.Join("\\", assemblyPath) + "\\Services\\CreateTrainingPlan\\KnowledgeBase.py";

            string argsFile = string.Format("{0}\\{1}.txt", Path.GetDirectoryName(filePath), Guid.NewGuid());

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = _pythonExePath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = false,
                RedirectStandardError = true
            };

            var result = string.Empty;

            try
            {
                using var sw = new StreamWriter(argsFile);

                sw.WriteLine(inputSql);
                startInfo.Arguments = string.Format(
                    "{0} {1}", string.Format(@"""{0}""", filePath), string.Format(@"""{0}""", argsFile));

                PythonScriptExecutor.ExecuteScript(startInfo, out result);
            }
            finally
            {
                File.Delete(argsFile);
            }
            return new ScriptContentDto { Content = result };
        }
    }
}
