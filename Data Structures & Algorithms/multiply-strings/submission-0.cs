public class Solution {
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
        {
            return "0";
        }

        int[] result = new int[num1.Length + num2.Length];

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                int digit1 = num1[i] - '0';
                int digit2 = num2[j] - '0';

                int mul = digit1 * digit2;

                int posEnd = i + j + 1;
                int posStart = i + j;

                int sum = mul + result[posEnd];

                result[posEnd] = sum % 10;
                result[posStart] += sum / 10;
            }
        }

        StringBuilder product = new StringBuilder();

        foreach (int num in result)
        {
            // skip leading zeros
            if (!(product.Length == 0 && num == 0))
            {
                product.Append(num);
            }
        }

        return product.Length == 0 ? "0" : product.ToString();
    }
}
