namespace homework;

public class HashСollections: Calculation {
    public override List<List<int>> FindThreeNumbers(int[] arr, int target) {
        List<List<int>> result = new List<List<int>>();
        HashSet<int> set = new HashSet<int>(arr);

        for (int i = 0; i < arr.Length - 2; i++) {
            for (int j = i + 1; j < arr.Length - 1; j++) {
                int remaining = target - (arr[i] + arr[j]);
                if (set.Contains(remaining)) {
                    result.Add(new List<int> { arr[i], arr[j], remaining });
                }
            }
        }

        return result;
    }
}