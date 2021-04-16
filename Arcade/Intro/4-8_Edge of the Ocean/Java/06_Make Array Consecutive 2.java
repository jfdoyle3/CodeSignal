int makeArrayConsecutive2(int[] statues) {
    Arrays.sort(statues);
    int size=statues.length;
    int low=statues[0];
    int high=statues[size-1];
    int difference=(high-low)+1;
    int results=difference-size;

    return results;
}
