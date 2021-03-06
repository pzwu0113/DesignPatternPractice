# DesignPatternPractice
使用C#練習DesignPattern

## 物件導向程式語言特性

* 封裝：將變化封裝至函式中，外部程式碼在使用時只需要知道方法簽章，不需要了解內部實作的細節。

* 繼承：可以從父類別衍生出子類別，子類別可以實作屬於自己的函式。

* 多型：從父類別衍生出的子類別，可以替代子類別，而不會出錯


## 物件導向程式設計的基本原則 - SOLID

* 單一職責(**S**ingle responsibility principle)：
對一個類別來說，應該只有**一個**引起他變化的原因。如果類別承擔的職責太多，在產生變化時，會遭受意想不到的破壞。如果你想到超過一個原因去修改類別，那該類別就承擔了過多的職責。


* 開放封閉(**O**pen/closed principle)：設計類別時對類別的**擴充**保持**開放**，對**修改**保持**封閉**。當面對需求變化時，一定會有無法封閉的變化，這時候就必須構造抽象點來隔離那些變化。


* 里氏替換(**L**iskov substitution principle)：
**子**類別必須可以替換他們的**父**類別，子類別的可替換性使得父類別的模組在無需修改的情況下可以擴展。


* 介面隔離(**I**nterface segregation principle)：
針對**介面**程式設計，而非對**實現(Implement)**程式設計。抽取相同功能形成介面，讓各類別去實作，對呼叫的程式端來說，只須在意開放出來介面提供的功能，且將來需要抽換時只需要實作相同介面的類別即可。


* 依賴倒轉(**D**ependency inversion principle)
**高層模組**不應該依賴**低層模組**，兩者都應該依賴**抽象**。模組之間如果太過耦合，很容易出現改了A被迫要修改B，如果都依賴抽象，兩者都只要關注自己本身即可。



## Patterns

* [Simple Factory - 簡單工廠](https://github.com/BryanYu/DesignPatternPractice/tree/master/SimpleFactory)
* [Strategy - 策略模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Strategy)
* [Decorator - 裝飾者模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Decorator)
* [Proxy - 代理模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Proxy)
* [FactoryMethod - 工廠方法](https://github.com/BryanYu/DesignPatternPractice/tree/master/FactoryMethod)
* [Prototype - 原型模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Prototype)
* [TemplateMethod - 範本方法](https://github.com/BryanYu/DesignPatternPractice/tree/master/TemplateMethod)
* [Facade - 外觀模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Facade)
* [Builder - 建造者模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Builder)
* [Observer - 觀察者模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Observer)
* [AbstractFactory - 抽象工廠](https://github.com/BryanYu/DesignPatternPractice/tree/master/AbstractFactory) 
* [State - 狀態模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/State) 
* [Memento - 備忘錄模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Memento)
* [Composite - 組合模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Composite)
* [Iterator - 迭代器模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Iterator)
* [Singleton - 獨體模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Singleton)
* [Bridage - 橋接模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Bridage)
* [Command - 命令模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Command)
* [ChainOfResponsibility - 責任鏈模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/ChainOfResponsibility)
* [Mediator - 中介者模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Mediator)
* [FlyWeight - 享元模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/FlyWeight)
* [Visitor - 訪問者模式](https://github.com/BryanYu/DesignPatternPractice/tree/master/Visitor)

## 參考書籍：
* [大話設計模式](https://www.tenlong.com.tw/products/9789866072116/)
