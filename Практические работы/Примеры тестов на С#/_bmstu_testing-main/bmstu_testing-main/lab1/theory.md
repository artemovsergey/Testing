# Теория по 1 лабе

## Классический vs Лондонский подходы
[Classical vs London schools](https://freecontent.manning.com/what-is-a-unit-test-part-2-classical-vs-london-schools/)

## Mock vs Stub
**Test Double (дублер)** - объект, который заменяет реальный объект, от которого зависит SUT(тестируемый объект), в тестовых целях.

Когда нужно использовать test double?
* Низкая скорость выполнения тестов с реальными объектами (если это, например, работа с базой, файлами, почтовым сервером и т.п.)
* Когда есть необходимость запуска тестов независимо от окружения (например, на машине у любого разработчика)
* Система, в которой работает код, не дает возможности (или дает, но это сложно делать) запустить код с определенным входным набором данных.
* Нет возможности проверить, что SUT отработал правильно, например, он меняет не свое состояние, а состояние внешней системы. И там эту проверку сделать сложно.

### Типы дублеров:  
* **Dummy** - это объекты, которые передаются в методы, но на самом деле не используются. В основном, это параметры методов (если конечно, они не влияют в тесте на то, что мы хотим проверить). Иногда это просто NULL

* **Fake** - это объекты, которые имеют внутреннюю реализацию, но обычно она сильно урезанная и их нельзя использовать в готовом коде.

* **Stubs** - обеспечивают жестко зашитый ответ на вызовы во время тестирования. Применяются для замены тех объектов, которые обеспечивают SUT входными данными. Также они могут сохранять в себе информацию о вызове (например параметры или количество этих вызовов) - такие иногда называют своим термином Test Spy. Такая "запись" позволяет оценить работу SUT, если состояние самого SUT не меняется.

* **Mocks** - объекты, которые настраиваются (например специфично каждому тесту) и позволяют задать ожидания в виде своего рода спецификации вызовов, которые мы планируем получить. Проверки соответствия ожиданиям проводятся через вызовы к Mock-объекту.

Из всех этих дублеров только Mock'и работают на верификацию поведения. Остальные, как правило, используются для проверки состояния.

### Сравнение
**Использование реальных объектов:**  
*Если в одном из методов была допущена ошибка, "красными" станут все тесты, в которых этот метод используется* (независимо от того, тестируется он в них или просто используется другим объектом).    
Локализация проблемы может стать трудной задачей.

**Мокирование:**  
Поведенческие тесты жестко фиксируют внутреннюю реализацию SUT. Что и как вызывается, с какими аргументами, какое API используется и тп. Все это *создает трудности при рефакторинге* и возможных изменениях в SUT - вместе с кодом все тесты придется писать заново.

## Паттерн написания Unit-тестов ААА

AAA -- arrange, act, and assert  
* **Arrange** - подготавливается объект тестирования, контекст выполнения методов, инициализируются переменные среды
* **Act** - выполняется метод, который требуется протестировать
* **Assert** - проверяется выходной результат и параметры среды после выполнения метода  

Given-When-Then -- аналогичный паттерн, используется в BDD\TDD фреймворках.

### Рекомендации
* **Arrange** - почти половина всего кода теста будет тут:
    * Object Mother pattern - создание, модификация и хранение объектов, которые нужны для выполнения тестов
    * Builder pattern - генерация тестовых данных для избегания хардкода и обеспечения покрытия разных наборов входных данных для одного и того же теста
* **Act** - один тест, одна строчка в секции, один вызов одного метода
* **Assert** - оставшаяся почти половина кода теста будет тут. Unit - это не только про код. Unit - про поведение объекта тестирования.
* Использование Teardown-методов, Test fixture и хэлперов
* Модификация одного теста не должна приводить к изменению результатов другого
* По названию теста должно быть понятно, что и под какими условиями он тестирует

### Пример
``` cs
[Test]
public void PurchaseFailsWhenNotEnoughInventoryTest()
{
    // Arrange
    var storeMock = new Mock<IStore>();
    storeMock
        .Setup(x => x.HasEnoughInventory(Product.Shampoo, 5))
        .Returns(false);
    var customer = new Customer();
  
    // Act
    bool success = customer.Purchase(storeMock.Object, Product.Shampoo, 5);
  
    // Assert
    Assert.False(success);
    storeMock.Verify(
        x => x.RemoveInventory(Product.Shampoo, 5),
        Times.Never);
}
```

## Data Builder и Object Mother
[Test Data Builder Pattern](https://ericvruder.dk/20191209/test-data-builder-pattern/)  
[Improve Tests with the Builder Pattern for Test Data](https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data/)

### Проблема
Для тестирования могут понадобиться большие сущности. Причем эти сущности в тестах могут отличаться одним полем или не отличаться вовсе. Это порождает проблему инициализации сущностей тестовыми данными.

### Решение1: Static Helpers
Можно создать класс, который попросту будет инициализировать и возвращать нужную сущность.

``` cs
public static class TestDataHelpers
{
  public static GetTestAddress()
  {
    return new AddressDTO
    {
      Description = "Test Address",
      AttentionTo = "Steve Smith",
      Line1 = "123 Main Street",
      Line2 = "",
      City = "Gotham City",
      State = "OH",
      Country = "US",
      ZipCode = "43210"
    };
  }
}
```

### Решение2: Data Builder Pattern
``` cs
public class AddressDTOBuilder
{
    private AddressDTO _entity = new Address;
    public AddressBuilder Id(int id)
    {
        _entity.Id = id;
        return this;
    }

    public AddressBuilder Line1(string line1)
    {
        _entity.Line1 = line1;
        return this;
    }

    public AddressBuilder Line2(string line2)
    {
        _entity.Line2 = line2;
        return this;
    }

    public AddressBuilder AttentionTo(string attn)
    {
        _entity.AttentionTo = attn;
        return this;
    }

    // more methods omitted

    public AddressDTO Build()
    {
        return _entity;
    }

    // This approach allows easy modification of test values
    // Another approach would just have a static method returning AddressDTO
    public AddressBuilder WithTestValues()
    {
        _entity = new AddressDTO
        {
            Line1 = "12345 Test Street",
            Line2 = "3rd Floor",
            AttentionTo = "Test Person",
            City = "Test City",
            State = "OH",
            ZipCode = "43210",
            Country = "US",
            Description = "Test Description",
            Id = Constants.TEST_ADDRESS_ID
        }
        return this;
    }
}
```

Пример работы с этим билдером:
``` cs
_testAddress = new AddressDTOBuilder()
    .WithTestValues()
    .Id(TEST\_ADDRESS\_ID1)
    .Build();
_testAddress2 = new AddressDTOBuilder()
    .WithTestValues()
    .Id(TEST\_ADDRESS\_ID2)
    .Line1("A Different Test Street")
    .City("Columbus")
    .ZipCode("43200")
    .Description("Another test Address")
    .Build();
```
