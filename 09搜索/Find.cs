using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09搜索
{
    public class Find
    {
        public int SequentialSearch(int[] arr, int x)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == x)
                    return i;
            }
            return -1;
        }
        public int BinarySearch(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;
            int count = 0; // 初始化计数器

            while(low <= high)
            {
                count++; // 每次循环时增加计数器
                int mid = low + (high - low) / 2;

                if(arr[mid] == x)
                    return count; // 找到目标时返回计数
                else if(arr[mid] < x)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return count; // 如果未找到，返回总的搜索次数
        }

        public class TreeNode
        {
            public int Value;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(int value)
            {
                this.Value = value;
                this.Left = null;
                this.Right = null;
            }
        }

        public class BinarySearchTree
        {
            public TreeNode Root;

            public BinarySearchTree()
            {
                Root = null;
            }

            public void Insert(int value)
            {
                Root = InsertRec(Root, value);
            }

            private TreeNode InsertRec(TreeNode root, int value)
            {
                if(root == null)
                {
                    root = new TreeNode(value);
                    return root;
                }

                if(value < root.Value)
                    root.Left = InsertRec(root.Left, value);
                else if(value > root.Value)
                    root.Right = InsertRec(root.Right, value);

                return root;
            }

            public int Search(int value)
            {
                int count = 0;
                var result = SearchRec(Root, value, ref count);
                return count;
            }

            private TreeNode SearchRec(TreeNode root, int value, ref int count)
            {
                count++;
                if(root == null || root.Value == value)
                    return root;

                if(value < root.Value)
                    return SearchRec(root.Left, value, ref count);
                else
                    return SearchRec(root.Right, value, ref count);
            }

            public string InOrderTraversal()
            {
                var sb = new System.Text.StringBuilder();
                InOrderRec(Root, sb);
                return sb.ToString().Trim(); // 去除末尾多余的空格
            }

            private void InOrderRec(TreeNode root, System.Text.StringBuilder sb)
            {
                if(root != null)
                {
                    InOrderRec(root.Left, sb);
                    sb.Append(root.Value + " "); // 将值添加到字符串，并添加空格
                    InOrderRec(root.Right, sb);
                }
            }
        }



    }



}
