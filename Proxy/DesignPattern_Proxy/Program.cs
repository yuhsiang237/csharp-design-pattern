using System;

namespace DesignPattern_Proxy
{
    /// <summary>
    /// 代理模式（英語：Proxy Pattern）是程式設計中的一種設計模式。
    /// 所謂的代理者是指一個類別可以作為其它東西的介面。
    /// 代理者可以作任何東西的介面：網路連接、記憶體中的大物件、
    /// 檔案或其它昂貴或無法複製的資源
    /// 
    /// 當一個複雜物件的多份副本須存在時，代理模式可以結合享元模式以減少記憶體用量。
    /// 典型作法是建立一個複雜物件及多個代理者，每個代理者會參照到原本的複雜物件。
    /// 而作用在代理者的運算會轉送到原本物件。
    /// 一旦所有的代理者都不存在時，複雜物件會被移除。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("HiRes_Image");
            for (int i = 0; i < 10; i++)
                image.Display();
        }
    }
}
