# Тестирование

https://ulearn.me/Course/testing-2022/Znakomstvo_41b8e6be-7800-4c4a-9f5a-6f91dd8546cd

##  🛠️ Инструменты 

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![Git](https://img.shields.io/badge/git-%23F05033.svg?style=for-the-badge&logo=git&logoColor=white)


# NUnit

# Принципы

- Общепринято создавать по одному тестовому классу на каждый тестируемый, по одному проекту автономных тестов на
каждый тестируемый проект (для интеграционных тестов создается отдельный проект) и по крайней мере по одному тестовому методу на каждую единицу работы (которая может состоять как из одного-единственного метода, так и из нескольких
классов).
- Давайте тестам понятные имена, устроенные по образцу [Единица работы]_[Сценарий]_[Ожидаемое поведение]
- Применяйте фабричные методы для повторного использования кода в тестах, например, для создания и инициализации
объектов, необходимых всем тестам.
- Не используйте атрибуты [SetUp] и [TearDown], если можете
без них обойтись. Из-за них тесты становятся менее понятными.



Чтобы знать, какие методы вызывать, исполнителю NUnit нужны
по меньшей мере два атрибута.
• Атрибут [TestFixture] помечает класс, содержащий автоматизированные тесты (было бы понятнее, если бы вместо
Fixture фигурировало слово Class, но при такой замене код
не откомпилируется). Поместите этот атрибут в начало класса
LogAnalyzerTests .
• Атрибутом [Test] помечаются методы, которые следует вызывать при автоматизированном прогоне тестов. Поместите
этот атрибут в начало тестового метода.



```Csharp
        /// <summary>
        /// Проверка ссылки на один объект
        /// </summary>
        [Test]
        public void TestMethod2()
        {
            var a = "3";
            var b = "4";

            var expectedObject = a;
            var actualObject = b;   

            Assert.AreSame(expectedObject, actualObject, "Объекты а и b не ссылаются на один и тот же объект");
        }
```

## TestCase

```Csharp
        [TestCase("3")]
        [TestCase("4")]
        [TestCase("5")]
        [TestCase("1")]
        [TestCase("2")]
        public void TestMethod3(string str)
        {
            var a = str;
            var b = "4";

            var expectedObject = str;
            var actualObject = b;

            Assert.AreSame(expectedObject, actualObject, $"Объекты {str} и b не ссылаются на один и тот же объект");
        }
```



щих тестов.
Чтобы взять на себя контроль над тем, что происходит во время
подготовки и очистки, мы воспользуемся двумя атрибутами NUnit:
• [SetUp] – этот атрибут можно применить к методу, как и атрибут [Test]; помеченный так метод NUnit будет вызывать
перед запуском любого теста в классе.
• [TearDown] – этим атрибутом помечается метод, который должен вызываться после выполнения любого теста в классе.


# SetUp and TearnDown

**Замечание**: атрибуты ```[TestFixtureSetUp]``` и
```[TestFixtureTearDown]``` позволяют однократно инициализировать
состояние до выполнения всех тестов в одном прогоне класса и после
завершения прогона в целом (один раз на фикстуру). Это полезно,
когда подготовка или очистка занимают много времени, и желательно
производить их только один раз для всех тестов в составе фикстуры. 


Методы будут выполняться для каждого тестового метода в классе

```Csharp
        [SetUp]
        public void TestSetUP()
        {
            Console.WriteLine("Настройка теста");
        }

        [TearDown]
        public void TestTearnDown()
        {
            Console.WriteLine("Операции после теста");
        }
```


# Assert.Catch<T>(delegate)

Метод ```Assert.Catch()``` дает возможность надежно проверить,
что код возбуждает исключения именно тогда, когда должен.


```Csharp
public void ExampleMethod()
{
    throw new ArgumentException("Параметр должен быть задан");
}
```

```Csharp
/// <summary>
/// Тест на проверку выдачи исключения в методе
/// </summary>
/// <param name="str"></param>
[Test]
public void TestMethod4()
{
    {
        var ex = Assert.Catch<Exception>(() => this.ExampleMethod());
        StringAssert.Contains("Параметр должен быть задан", ex.Message);
    }

}
```

# Ignore

Для пропуска тестов, нуждающихся в исправлении, мы указывали атрибут ```[Ignore]```.

```Csharp
[Test]
[Ignore("Параметр должен быть задан")]
public void TestMethod4()
{
    {
        var ex = Assert.Catch<Exception>(() => this.ExampleMethod());
        StringAssert.Contains("Параметр должен быть задан", ex.Message);
    }

}
```

# Category

Категории позволяют создавать логические
группы тестов, а не просто объединять их по классу и пространству
имен.

```
[Test]
[Category("Новая категория")]
public void TestMethod4()
{
    {
        var ex = Assert.Catch<Exception>(() => this.ExampleMethod());
        StringAssert.Contains("Параметр должен быть задан", ex.Message);
    }

}
```



