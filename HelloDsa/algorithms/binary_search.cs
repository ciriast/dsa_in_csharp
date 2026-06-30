namespace HelloDsa.Algos;

public class MyBinarySearch
{
    public int MyResult(List<int> myList, int myKey)
    {
        int end = myList.Count() - 1;
        int start = 0;
        
        while (start <= end)
        {
            int mid = (start + end) / 2;

            if (myList[mid] == myKey)
            {
                return mid;
            }

            if (myList[mid] < myKey)
            {
                start = mid + 1;
            }

            if (myList[mid] > myKey)
            {
                end = mid - 1;
            }
        }

        return -1;
    }
}
