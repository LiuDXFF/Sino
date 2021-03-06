# 依赖注入  

## 额外支持特性  

通过替换系统默认的IOC从而能够实现更丰富的功能，为此我们需要了解并掌握使用
这些新特性，下述文档将会通过相关代码实例介绍具体的使用方式。  

### 多构造函数  

在大多数实际使用中，我们往往会将需要注入的对象同构构造函数逐一列举，防止
依赖注入无法选择适合的构造函数，而在全新的依赖注入框架下我们就能够实现多
构造函数，并根据当前实际已存在的对象使IOC自行选择，从而实现更加丰富的功能
支持，下面将通过几个简单的例子进行说明。  


将设我们定以了`A`、`B`、`C`三个类，并且`ServiceUser`类存在以下三种构造函数。  

```csharp
public ServiceUser(A a)
public ServiceUser(A a, B b) : this(a)
public ServiceUser(A a, B b, C c) : this(a, b)
```

此时当我们将`ServiceUser`通过IOC进行实例话的时候，其IOC会根据当前是否注册了
对应的`A`、`B`、`C`类来决定采用那个构造函数，意思就是当前如果仅有`A`类注册
了，那么就是调用`public ServiceUser(A a)`构造函数，如果存在`A`、`B`类则采用
`ServiceUser(A a, B b)`该构造函数，当然如果仅仅只有`B`类，当然就不满足任何
构造函数了。  

