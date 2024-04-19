using System.Collections.Concurrent;
using System.Text;

namespace GitExtUtils
{
    public class FileLogger
    {
        public static readonly FileLogger Instance = new();

        private ConcurrentQueue<string> _queue = new();

        private FileLogger()
        {
            string path = Path.Combine("C:/Workplace/personal/gitextensions/logs", $"{DateTime.Now:yyyy-MM-dd}.log"); // HHmmss
            new FileInfo(path).Directory.Create();

            Task.Run(async () =>
            {
                while (true)
                {
                    if (!_queue.TryDequeue(out string msg))
                    {
                        await Task.Delay(50);
                        continue;
                    }

                    try
                    {
                        await File.AppendAllLinesAsync(path, [FormatLog(msg)]);
                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debugger.Break();
                    }
                }
            });
        }

        private string FormatLog(string msg)
        {
            return $"{DateTime.Now:HH:mm:ss.fff} {msg}";
        }

        private void LogInternal(string msg)
        {
            _queue.Enqueue(msg);
        }

        public static void Log(string msg, params object[] prms)
        {
            StringBuilder sb = new(msg);

            foreach (object prm in prms)
            {
                sb.AppendLine($"   {System.Text.Json.JsonSerializer.Serialize(prm)}");
            }

            Instance.LogInternal(sb.ToString());
        }
    }
}
