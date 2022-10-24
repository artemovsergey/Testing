using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger
{
    // Exercise 4

    public enum ActionType
    {
        login_correct,
        login_err_passw,
        login_close,
        form_main_close,
        new_settings_saved
    }

    public class Log
    {
        public DateTime timeOfOperation;
        public ActionType typeOfOperation;
        public string user_;

        public Log(DateTime time, ActionType type, string user)
        {
            timeOfOperation = time;
            typeOfOperation = type;
            user_ = user;
        }
    }

    public class Logger
    {
        public static string logPath_ = @"log.txt";

        public static List<Log> Logs = new List<Log>();
        public static Dictionary<ActionType, string> ActionsText = new Dictionary<ActionType, string>();

        public Logger()
        {
            if (ActionsText.Count == 0)
            {
                ActionsText.Add(ActionType.login_correct, "LOGIN: Access granted");
                ActionsText.Add(ActionType.login_err_passw, "LOGIN: Access denied");
                ActionsText.Add(ActionType.login_close, "LOGIN: Access canceled");
                ActionsText.Add(ActionType.form_main_close, "WORK_SESSION: Ended (closed)");
                ActionsText.Add(ActionType.new_settings_saved, "WORK_SESSION: Settings saved");
            }
        }

        public string addLog(Log log)
        {
            Logs.Add(log);

            using (StreamWriter writer = File.AppendText(logPath_))
            {
                writer.WriteLine("\n {0,10} | {1,20} | {2,20}", log.timeOfOperation, log.user_, ActionsText[log.typeOfOperation]);
            }
            return String.Format("{0,10} | {1,20} | {2,20}", log.timeOfOperation, log.user_, ActionsText[log.typeOfOperation]);
        }
    }
}
