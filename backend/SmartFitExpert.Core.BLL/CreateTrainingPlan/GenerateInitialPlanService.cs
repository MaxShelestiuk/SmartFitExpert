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
    }
}
