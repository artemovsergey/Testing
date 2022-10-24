using NUnit.Framework;
using System;
using _1_1;

//¬ Production Code написать класс FileService с методом int MergeTemporaryFiles(string
//dir). ¬ данном методе класс обращаетс€ к директории dir и компонует из всех файлов с
//расширением .tmp в данной директории один файл backup.tmp (простой
//конкатенацией), после чего удал€ет все учтенные файлы. ћетод возвращает количество
//учтенных файлов; если передан путь несуществующего каталога, должно быть брошено
//исключение. ƒанный метод должен вызыватьс€, в свою очередь, из метода
//PrepareData() класса ReportViewer.Ётот метод должен сразу прекратить выполнение,
//если количество учтенных файлов было равно нулю; иначе Ц присвоить свойству
//BlockCount класса ReportViewer это количество. ѕротестировать все ситуации.

namespace _1_1_Tests
{
    public class ReportViewerWithStubTests
    {
        IFileAccesser _fa;
        _1_1.ReportViewer _rv;

        [Test]
        public void DirectoryDoesntExistException()
        {
            _fa = new Classes.StubMergeTemporaryFiles(null);
            _rv = new _1_1.ReportViewer(_fa);

            Assert.Throws<ArgumentException>(() => _rv.PrepareData("dir"));
        }

        [Test]
        public void DirectoryIsEmptyException()
        {
            _fa = new Classes.StubMergeTemporaryFiles(new string[] { });
            _rv = new _1_1.ReportViewer(_fa);

            Assert.Throws<ArgumentException>(() => _rv.PrepareData("dir"));
        }

        [Test]
        public void DirectoryWithFiles_CountReturns()
        {
            _fa = new Classes.StubMergeTemporaryFiles(new string[] { "1.tmp", "2.tmp"});
            _rv = new _1_1.ReportViewer(_fa);
            _rv.PrepareData("dir");

            Assert.That(_rv.BlockCount, Is.EqualTo(2));
        }

    }
}
