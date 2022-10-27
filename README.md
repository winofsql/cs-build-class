# cs-build-class

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

## コンストラクタ作成 ( MyClass の文字列をクリックしてランプ参照 )
![image](https://user-images.githubusercontent.com/1501327/184286277-013d7bf1-b858-4814-8aca-f0ca73202b15.png)

## 自動プロパティ作成( prop )
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

## プロパティ作成( **propfull** )

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

## インスタンスメソッド作成
![image](https://user-images.githubusercontent.com/1501327/184288808-d0a7cbaa-0417-450c-83ae-8439fbceb769.png)
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

        internal void StartMessage(string v)
        {
            //throw new NotImplementedException();
            Debug.WriteLine($"DBG:{v}");
        }

        internal static void print(string v)
        {
            //throw new NotImplementedException();
            Debug.WriteLine($"DBG:{v}");
        }
    }
}
```

## 複数行のブロック処理
## for ループ
- 対象行選択\
    ![image](https://user-images.githubusercontent.com/1501327/184294491-a8e99c68-ea5d-4b04-be31-0a59fbd6b002.png)
- Ctrl+.(ドット)\
    ![image](https://user-images.githubusercontent.com/1501327/184294606-5489ef89-1038-41d3-a753-45e681419a34.png)
- 選択\
    ![image](https://user-images.githubusercontent.com/1501327/184294700-458e9c19-51a1-436b-8fe7-889cafb4dc7b.png)
- 生成コード\
    ![image](https://user-images.githubusercontent.com/1501327/184294844-bd23f85b-f12a-4d3c-89d6-719a499e7577.png)
