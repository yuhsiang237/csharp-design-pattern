namespace DesignPattern_Strategy
{
    /// <summary>
    /// Strategy設計模式
    /// 將核心演算法抽出放置於具體類別(ApplicationRunner)
    /// 再來把需要的抽象方法定義在IApplication介面裡，從這介面衍伸出FtoCStrategy類別
    /// 傳給ApplicationRunner就可以把具體要做的事委派給這介面去完成
    /// 這方式ApplicationRunner可以對底下類別一無所知。
    /// 較具靈活性
    /// 結構比Template Method好，但是使用代價高一些，多了些類別間接的層次，稍微多一點執行時間、資料儲存空間。
    /// 但可建立不同的IApplication傳入減省程式碼量(code space)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            (new ApplicationRunner(new FtoCStrategy())).run();
        }
    }
}
