# cs-build-class

![image](https://user-images.githubusercontent.com/1501327/184283171-28283e60-8a63-4ce3-ad2a-4352ad2a9eae.png)

## クラス作成
![image](https://user-images.githubusercontent.com/1501327/184286070-e1ec5188-7e78-49d7-a6f9-ac0a36b0c2c5.png)

### MyClass.cs
```cs
namespace form_01
{
    internal class MyClass
    {
    }
}
```

## コンストラクタ作成
![image](https://user-images.githubusercontent.com/1501327/184286277-013d7bf1-b858-4814-8aca-f0ca73202b15.png)

## 自動プロパティ作成
![image](https://user-images.githubusercontent.com/1501327/184286512-4eee171d-7530-4887-8cf3-be83329fbbdb.png)

```cs
namespace form_01
{
    internal class MyClass
    {
        public MyClass()
        {
        }

        public string? Title { get; set; }

    }
}
```

## プロパティ作成

```cs
namespace form_01
{
    internal class MyClass
    {
        public MyClass()
        {
        }

        public string? Title { get; set; }

        private string? myName;
        public string? Name
        {
            get { return myName; }
            set { myName = value; }
        }

    }
}
```
![image](https://user-images.githubusercontent.com/1501327/184286840-f0064165-2462-4684-8253-5dd3322646ff.png)

## クラスメソッド作成
![image](https://user-images.githubusercontent.com/1501327/184287460-eab98f10-10e8-41f4-b403-644535b3c46f.png)
```cs
using System.Diagnostics;
namespace form_01
{
    internal class MyClass
    {
        public MyClass()
        {
        }

        public string? Title { get; set; }

        private string? myName;
        public string? Name
        {
            get { return myName; }
            set { myName = value; }
        }

        internal static void print(string v)
        {
            //throw new NotImplementedException();
            Debug.WriteLine($"DBG:{v}");
        }
    }
}
```
