int adjacentElementsProduct(int[] inputArray) {
            int[] results = new int[inputArray.length - 1];

            for (int idx = 0; idx < inputArray.length - 1; idx++)
            {
                results[idx] = inputArray[idx] * inputArray[idx + 1];
            }
           
            Arrays.sort(results);
            
            return results[results.length-1];
}
