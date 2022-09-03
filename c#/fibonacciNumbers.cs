namespace HellowWorld {
    class FibonacciNumbers {
        static void m(string[] args) {
            // int n = 2;
            // var fibonacciNumbers = new List<int> {1, 1};
            // int fibN = 0;
            // if (n == 1 || n == 2) fibN = 1;
            // else if (n > 2) {
            //     for (int i = 2; i < n; i++) {
            //         fibN = fibonacciNumbers[i-1] + fibonacciNumbers[i-2];
            //         fibonacciNumbers.Add(fibN);
            //     }
            // }
            // Console.WriteLine(fibN);

            // int n = 20;
            // var fibonacciNumbers = new List<int> {1, 1};
            // int fibN = 0;
            // if (n == 1 || n == 2) fibN = 1;
            // else if (n > 2) {
            //     for (int i = 2; i < n; i++) {
            //         fibN = fibonacciNumbers[i-1] + fibonacciNumbers[i-2];
            //         fibonacciNumbers.Add(fibN);
            //     }
            // }
            // foreach (int f in fibonacciNumbers)
            //     Console.WriteLine(f);

            // int n = 20;
            // var fibonacciNumbers = new List<int> {1, 1};
            // int fibN = 0;
            // if (n == 1 || n == 2) fibN = 1;
            // else if (n > 2) {
            //     while (fibonacciNumbers.Count < 20) {
            //         int c = fibonacciNumbers.Count;
            //         fibN = fibonacciNumbers[c-1] + fibonacciNumbers[c-2];
            //         fibonacciNumbers.Add(fibN);
            //     }
            // }
            // foreach (int f in fibonacciNumbers)
            //     Console.WriteLine(f);

            
            int n = 8;
            var fibonacciNumbers = new List<int> {1, 1};
            int fibN = 0;
            if (n == 1 || n == 2) fibN = 1;
            else if (n > 1) {
                for (int i = 3; i <= n; i++) {
                    fibN = fibonacciNumbers[1] + fibonacciNumbers[0];
                    fibonacciNumbers[0] = fibonacciNumbers[1];
                    fibonacciNumbers[1] = fibN;
                }
            }
            Console.WriteLine(fibN);
        }
    }
}