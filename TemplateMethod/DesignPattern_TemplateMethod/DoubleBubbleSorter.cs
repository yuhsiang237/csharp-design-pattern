namespace DesignPattern_TemplateMethod
{
    /// <summary>
    /// 繼承浮點數的氣泡排序
    /// </summary>
    public class DoubleBubbleSorter : BubbleSort
    {
        private double[] _array = null;
        public int Sort(double[] array)
        {
            _array = array;
            _length = _array.Length;
            return DoSort();
        }
        protected override bool OutOfOrder(int index)
        {
            return (_array[index] > _array[index + 1]);
        }

        protected override void Swap(int index)
        {
            double temp = _array[index];
            _array[index] = _array[index+1];
            _array[index + 1] = temp;
        }
    }
}
