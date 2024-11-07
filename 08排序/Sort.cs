using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08排序
{
    public class Sort
    {
        public static void StraightInsertSort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            for(int i = 1; i < n; i++)
            {
                T key = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        private static void Shell<T>(int delta, T[] array) where T : IComparable<T>
        {
            for(int i = delta; i < array.Length; i++)
            {
                int j = i - delta;
                T current = array[i];
                while(j >= 0 && array[j].CompareTo(current) > 0)
                {
                    array[j + delta] = array[j];
                    j = j - delta;
                }
                array[j + delta] = current;
            }
        }
        public static void ShellInsertSort<T>(T[] array) where T : IComparable<T>
        {
            for(int delta = array.Length / 2; delta > 0; delta = delta / 2)
            {
                Shell(delta, array);
            }
        }
        public static void SelectionSortAlgorithm<T>(T[] array) where T : IComparable<T>
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                T min = array[i];

                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j].CompareTo(min) < 0)
                    {
                        min = array[j];
                        minIndex = j;
                    }
                }

                if(minIndex != i)
                {
                    array[minIndex] = array[i];
                    array[i] = min;
                }
            }
        }
        private static void Restore<T>(T[] array, int j, int vCount) where T : IComparable<T>
        {
            while(j <= vCount / 2)
            {
                int m = (2 * j + 1 <= vCount && array[2 * j + 1].CompareTo(array[2 * j]) > 0)
                ? 2 * j + 1
                : 2 * j;
                if(array[m].CompareTo(array[j]) > 0)
                {
                    T temp = array[m];
                    array[m] = array[j];
                    array[j] = temp;
                    j = m;
                }
                else
                {
                    break;
                }
            }
        }
        public static void HeapSelectSort<T>(T[] array) where T : IComparable<T>
        {
            int vCount = array.Length;
            T[] tempArray = new T[vCount + 1];
            for(int i = 0; i < vCount; i++)
                tempArray[i + 1] = array[i];
            for(int i = vCount / 2; i >= 1; i--)
                Restore(tempArray, i, vCount);
            for(int i = vCount; i > 1; i--)
            {
                T temp = tempArray[i];
                tempArray[i] = tempArray[1];
                tempArray[1] = temp;
                Restore(tempArray, 1, i - 1);
            }
            for(int i = 0; i < vCount; i++)
                array[i] = tempArray[i + 1];
        }
        public static void BubbleExchangeSortImproved<T>(T[] array) where T : IComparable<T>
        {
            for(int i = 0; i < array.Length - 1; i++)
{
                bool flag = false;
                for(int j = array.Length - 1; j > i; j--)
{
                    if(array[j].CompareTo(array[j - 1]) < 0)
                    {
                        T temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        flag = true;
                    }
                }
                if(flag == false)
                    break;
            }
        }
        private static void QuickSortImproved<T>(T[] array, int left, int right) where T :
IComparable<T>
        {
            if(left < right)
            {
                T current = array[left];
                int i = left;
                int j = right;
                while(i < j)
                {
                    while(array[j].CompareTo(current) > 0 && i < j)
                        j--;
                    array[i] = array[j];
                    while(array[i].CompareTo(current) <= 0 && i < j)
                        i++;
                    array[j] = array[i];
                }
                array[j] = current;
                if(left < j - 1) QuickSortImproved(array, left, j - 1);
                if(right > j + 1) QuickSortImproved(array, j + 1, right);
            }
        }
        public static void QuickExchangeSortImproved<T>(T[] array) where T : IComparable<T>
        {
            QuickSortImproved(array, 0, array.Length - 1);
        }
        private static void Merge<T>(T[] array, int left, int mid, int right) where T :
IComparable<T>
        {
            T[] temp = new T[right - left + 1];
            int i = left;
            int j = mid + 1;
            int k = 0;
            while(i <= mid && j <= right)
            {
                if(array[i].CompareTo(array[j]) < 0)
                {
                    temp[k++] = array[i++];
                }
                else
                {
                    temp[k++] = array[j++];
                }
            }
            while(i <= mid)
            {
                temp[k++] = array[i++];
            }
            while(j <= right)
            {
                temp[k++] = array[j++];
            }
            for(int n = 0; n < temp.Length; n++)
            {
                array[left + n] = temp[n];
            }
        }
        private static void MergeSort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if(left >= right)
                return;
            int mid = (left + right) / 2;
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);
            Merge(array, left, mid, right); 
        }
        public static void MergeSort<T>(T[] array) where T : IComparable<T>
        {
            MergeSort(array, 0, array.Length - 1);
        }
        public static void StraightSelectSort<T>(T[] array) where T : IComparable<T>
        {
            for(int i = 0; i < array.Length - 1; i++)
{
                int minIndex = i;
                T min = array[i];
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j].CompareTo(min) < 0)
                    {
                        min = array[j];
                        minIndex = j;
                    }
                }
                if(minIndex != i)
                {
                    array[minIndex] = array[i];
                    array[i] = min;
                }
            }
        }


    }
}
