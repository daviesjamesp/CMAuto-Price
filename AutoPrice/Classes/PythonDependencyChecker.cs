using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPrice
{
    public class PythonDependencyChecker
    {
        private const string PY_AUTO_PKG_NAME = "PyAutoGUI";

        public static string PyScriptPath = Application.StartupPath + "\\CSharpInputMacro.py";

        /// <summary>
        /// Checks that a basic Python command runs successfully, indicating an install
        /// </summary>
        public static void CheckPython()
        {
            var checkString = RunPyCommand("py --version");

            if (string.IsNullOrEmpty(checkString))
                { throw new NotSupportedException("Python installation not found"); }
            else
            {
                CheckPyAutoGUI();
            }
        }


        /// <summary>
        /// Checks for the required module for GUI automation
        /// </summary>
        private static void CheckPyAutoGUI()
        {
            var checkString = RunPyCommand("py -m pip list");

            if (string.IsNullOrEmpty(checkString))
                { throw new NotSupportedException("Pip command did not run correctly."); }
            else if (!checkString.Contains(PY_AUTO_PKG_NAME))
            {
                InstallPyAuto();
            }
        }

        /// <summary>
        /// Installs PyAutoGUI if not found in pip list
        /// </summary>
        private static void InstallPyAuto()
        {
            RunPyCommand("py -m pip install pyautogui");
        }


        /// <summary>
        /// Reusable method for running single python commands behind the scenes
        /// </summary>
        /// <param name="command">python command to be run in a CMD window</param>
        /// <returns>CMD std output</returns>
        private static string RunPyCommand(string command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.RedirectStandardOutput = true;

            string output;
            using (Process process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                output = process.StandardOutput.ReadToEnd();
            }

            return output;
        }
    }
}
