using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "rundll32.exe",
                Arguments = "sysdm.cpl,EditEnvironmentVariables",
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine("エラー: " + ex.Message);
        }
    }
}
