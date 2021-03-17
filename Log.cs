using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Switch_LAN_Play_GUI
{
    class Log
    {
        public static WindowMain windowMain;

        public static void LogOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (outLine.Data == null || outLine.Data.Length <= 2)
                return;

            Output(outLine.Data);
        }

        public static void Output(string data)
        {
            string[] pString = data.Split(new string[] { ": " }, StringSplitOptions.None);

            switch (pString[0])
            {
                case "[ERROR]":
                    SetColor(windowMain.logError, Color.Red);
                    windowMain.logError.AppendText($"{TimeStamp()}{pString[pString.Length - 1]}\n");
                    ScrollToBottom(windowMain.logError);

                    SetColor(windowMain.logConsole, Color.Red);
                    windowMain.logConsole.AppendText($"{TimeStamp()}{pString[pString.Length - 1]}\n");
                    ScrollToBottom(windowMain.logConsole);
                    break;
                case "[APPLICATION]":
                    SetColor(windowMain.logConsole, Color.Blue);
                    windowMain.logConsole.AppendText($"{TimeStamp()}{pString[pString.Length - 1]}\n");
                    ScrollToBottom(windowMain.logConsole);
                    break;
                default:
                    SetColor(windowMain.logConsole, windowMain.logConsole.ForeColor);
                    windowMain.logConsole.AppendText($"{TimeStamp()}{pString[pString.Length - 1]}\n");
                    ScrollToBottom(windowMain.logConsole);
                    break;
            }
        }

        public static void Clear()
        {
            windowMain.logConsole.Clear();
            windowMain.logError.Clear();
        }

        public static void Export()
        {
            File.ExportText("logConsole.txt", windowMain.logConsole.Text);
            File.ExportText("logError.txt", windowMain.logError.Text);
        }

        private static void SetColor(RichTextBox textbox, Color color)
        {
            textbox.SelectionStart = textbox.TextLength;
            textbox.SelectionLength = 0;
            textbox.SelectionColor = color;
        }

        private static void ScrollToBottom(RichTextBox textbox)
        {
            textbox.SelectionStart = textbox.TextLength;
            textbox.ScrollToCaret();
        }

        private static string TimeStamp()
        {
            DateTime t = DateTime.Now;

            return $"{t.Hour:00}:{t.Minute:00}:{t.Second:00} ";
        }
    }
}
