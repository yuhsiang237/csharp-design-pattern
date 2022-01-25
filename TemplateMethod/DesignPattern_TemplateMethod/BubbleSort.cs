namespace DesignPattern_TemplateMethod
{
    /// <summary>
    /// 核心氣泡排序邏輯
    /// </summary>
    public abstract class BubbleSort
    {
        private int _operations = 0;
        protected int _length = 0;

        /// <summary>
        /// 核心排序
        /// </summary>
        /// <returns></returns>
        protected int DoSort()
        {
            _operations = 0;
            if (_length <= 1)
            {
                return _operations;
            }

            for(int nextToLast = _length - 2; nextToLast >= 0; nextToLast--)
            {
                for(int index = 0; index <= nextToLast; index++)
                {
                    if (OutOfOrder(index))
                    {
                        Swap(index);
                    }
                    _operations++;
                }
            }
            return _operations;
        }
        /// <summary>
        /// 交換
        /// </summary>
        /// <param name="index"></param>
        protected abstract void Swap(int index);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected abstract bool OutOfOrder(int index);
    }
}
