using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Apriori
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            readConfig();
            Application.Run(new AuthForm());
        }
        private static void readConfig()
        {
            try
            {
                StreamReader sr = new StreamReader("config.ini");
                String str = sr.ReadLine();
                if (str != "")
                    Apriori.Properties.Settings.Default["cafeConnectionString"] = str;
                else MessageBox.Show("Неверный файл конфигурации программы!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Не найден файл конфигурации программы!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
