using System;
using System.IO;

//В Production Code написать класс FileService с методом int MergeTemporaryFiles(string
//dir). В данном методе класс обращается к директории dir и компонует из всех файлов с
//расширением .tmp в данной директории один файл backup.tmp (простой
//конкатенацией), после чего удаляет все учтенные файлы. Метод возвращает количество
//учтенных файлов; если передан путь несуществующего каталога, должно быть брошено
//исключение. Данный метод должен вызываться, в свою очередь, из метода
//PrepareData() класса ReportViewer.Этот метод должен сразу прекратить выполнение,
//если количество учтенных файлов было равно нулю; иначе – присвоить свойству
//BlockCount класса ReportViewer это количество. Протестировать все ситуации.

namespace _1_1
{
    public class FileService : IFileAccesser
    {
        public void Delete(string[] files)
        {
            // удаление файлов
            foreach (string fl in files)
            {
                File.Delete(fl);

            }
        }
        public int Backup(string dir, string[] files)
        {
            int count = 0;
            //объединение содержимого файлов в один 
            using (StreamWriter writer = new StreamWriter(dir + @"\backuup.tmp"))
            {
                for (int i = 0; i < files.Length; i++)
                {
                    count++;
                    using (StreamReader reader = File.OpenText(files[i]))
                    {
                        writer.Write(reader.ReadToEnd());

                    }

                }
            }
            return count;
        }
        public int MergeTemporaryFiles(string dir)
        {
            int count = 0;
            if (Directory.Exists(dir))
            {
                string[] files = Directory.GetFiles(dir, "*.tmp");
                if (files.Length == 0)
                {
                    return count;
                }

                count += Backup(dir, files);
                Delete(files);//delete files


            }
            else
            {
                throw new ArgumentException();
                //Console.WriteLine("Каталога не существует!"); 
            }

            return count;
        }
    }
}
