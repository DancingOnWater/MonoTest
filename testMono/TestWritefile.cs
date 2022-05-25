using System;
using System.IO;

namespace testMono
{
    static class TestWritefile
    {
        public static void start()
        {
            string outputPath = null;
            try
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                outputPath = Path.Combine(path, "testFile.html");
                StreamWriter sw = new StreamWriter(outputPath);
                sw.Write("<html><body>Здравствуй, Ритчи.</body></html>");
                sw.Flush();
                sw.Close();

            }
            catch(Exception e){
                MainClass.WriteErrorLine("Запись в файл: ", "failed", e.Message);
            }

            MainClass.WriteLine("Запись в файл: ", "Ok");
            try            {
                System.Diagnostics.Process.Start(outputPath);
            }catch(Exception e){
                MainClass.WriteErrorLine("Запуск ассоциированного приложения: ", "failed", e.Message);
            }
            MainClass.WriteLine("Запуск ассоциированного приложения: ", "Ok");


            MainClass.WriteLine(nameof(TestWritefile) + ": ", "finish");
        }
    }
}
