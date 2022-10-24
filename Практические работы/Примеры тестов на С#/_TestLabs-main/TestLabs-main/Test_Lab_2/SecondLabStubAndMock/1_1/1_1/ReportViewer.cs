using System;

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
    public class ReportViewer
    {
        IFileAccesser fs;

        public int BlockCount { get; private set; }

        public ReportViewer(IFileAccesser _fs)
        { 
            fs = _fs;
        }

        public void PrepareData(string tmp_dir)
        {
            int count = 0;
            try 
            {
                count = fs.MergeTemporaryFiles(tmp_dir);
            }
            catch { }

            if (count == 0)
            {
                throw new ArgumentException("Нет обработанных файлов. Проверьте правильность имени папки и ее содержимое");
            }

            BlockCount = count;
        }
    }
}