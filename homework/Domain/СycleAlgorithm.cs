namespace homework; 

public class СycleAlgorithm: Calculation {
    public override List<List<int>> FindThreeNumbers(int[] arr, int target) {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(arr);
        for (int i = 0; i < arr.Length - 2; i++) {
            int left = i + 1;
            int right = arr.Length - 1;
            while (left < right) {
                int sum = arr[i] + arr[left] + arr[right];
                if (sum == target) {
                    result.Add(new List<int> { arr[i], arr[left], arr[right] });
                    left++;
                    right--;
                } else if (sum < target) {
                    left++;
                } else {
                    right--;
                }
            }
        }
        return result;
    }
}