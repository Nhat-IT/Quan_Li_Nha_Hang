using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Li_Nha_Hang
{
    class QuickSort
    {

        private static QuickSort instance;

        internal static QuickSort Instance 
        {
            get
            {
                if (instance == null) instance = new QuickSort();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private QuickSort() { }

        #region algorithm

        //QuickSort
        public int partition(string[] list, int low, int high, int TangOrGiam, int LoaiSapXep)
        {
            string pivot = list[high];
            int check = 0;
            int Gia1 = 0;
            int Gia2 = 0;
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (LoaiSapXep == 1)
                {
                    check = compareTwoString(list[j], pivot);
                }
                else if (LoaiSapXep == 2)
                {
                    Gia1 = Convert.ToInt32(list[j]);
                    Gia2 = Convert.ToInt32(pivot);
                    check = compareTwoString(Gia1, Gia2);
                }
                if (check == TangOrGiam)
                {
                    i++;
                    string temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
            string temp1 = list[i + 1];
            list[i + 1] = list[high];
            list[high] = temp1;

            return i + 1;
        }

        public void QuickSortWithLoai(string[] list, int first, int last, int num, int LoaiSapXep)
        {
            if (first < last)
            {

                int pivot = partition(list, first, last, num, LoaiSapXep);

                QuickSortWithLoai(list, first, pivot - 1, num, LoaiSapXep);
                QuickSortWithLoai(list, pivot + 1, last, num, LoaiSapXep);
            }
        }

        public int compareTwoString(string a, string b)
        {
            int lenghtA = a.Length;
            int lenghtB = b.Length;
            char[] A = a.ToCharArray();
            char[] B = b.ToCharArray();
            int[] A1 = new int[lenghtA];
            int[] B1 = new int[lenghtB];
            int length = lenghtA;
            if (lenghtA > lenghtB) length = lenghtB;
            else if (lenghtA < lenghtB) length = lenghtA;
            for (int i = 0; i < length; i++)
            {
                A1[i] = Convert.ToInt32(A[i]);
                B1[i] = Convert.ToInt32(B[i]);
                if (A1[i] > B1[i] || A1[i] - 32 > B1[i]) return 1;
                else if (A1[i] < B1[i] || B1[i] - 32 > A1[i]) return 2;
                else if (A1[i] == B1[i] || Math.Abs(A1[i] - B1[i]) == 32)
                {
                    if (lenghtA > lenghtB && i == length - 1) return 1;
                    else if (lenghtA < lenghtB && i == length - 1) return 2;
                    else if (lenghtA == lenghtB && i == length - 1) return 0;
                }
            }
            return 3;
        }

        public int compareTwoString(int a, int b)
        {
            if (a > b) return 1;
            else if (a < b) return 2;
            else if (a == b) return 0;
            return 3;
        }

        #endregion
    }
}
