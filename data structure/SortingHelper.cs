namespace data_structure_linked_list
{
    internal static class SortingHelper
    {
        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }

        public static void Merge(int[] arr,  int low, int mid, int high) // merge 2 sorted array
        {
            int[] res = new int[arr.Length];
            int l1 = low;
            int l2 = mid + 1;
            int i = low;
            while (l1 <= mid && l2 <= high)
            {
                if (arr[l1] < arr[l2])
                {
                    res[i] = arr[l1];
                    l1++;
                    i++;
                }
                else
                {
                    res[i] = arr[l2];
                    l2++;
                    i++;
                }
            }
            if (l1 <= mid)
            {
                while (l1 <= mid)
                {
                    res[i] = arr[l1];
                    l1++;
                    i++;
                }

            }
            else
            {
                while (l2 <= high)
                {
                    res[i] = arr[l2];
                    l2++;
                    i++;
                }
            }
            for (int j = low; j <= high; j++)
            {
                arr[j] = res[j];
            }
        }

        public static void InsertionSort(int[] arr, int start, int end)
        {
            for (int i = start+1; i <= end; i++)
            {
                int k = arr[i];
                int j = i - 1;
                while(j >= start && arr[j] > k)
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = k;
            }
        }

    }
}
