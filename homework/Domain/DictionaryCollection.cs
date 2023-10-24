namespace homework;

public class DictionaryCollection: Calculation {
    public override List<List<int>> FindThreeNumbers(int[] arr, int target) {
        List<List<int>> result = new List<List<int>>();
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++) {
            dictionary[arr[i]] = i;
        }

        for (int i = 0; i < arr.Length - 2; i++) {
            for (int j = i + 1; j < arr.Length - 1; j++) {
                int remaining = target - (arr[i] + arr[j]);
                if (dictionary.TryGetValue(remaining, out int index) && index != i && index != j) {
                    result.Add(new List<int> { arr[i], arr[j], remaining });
                }
            }
        }

        return result;
    }
}