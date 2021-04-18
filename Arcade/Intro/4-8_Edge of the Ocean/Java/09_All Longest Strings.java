String[] allLongestStrings(String[] inputArray) {
    
    List<String> results=new ArrayList<>();
    int longestStringSize=largestIndex(inputArray);
    
    for (int idx=0; idx<inputArray.length; idx++){
        if(inputArray[idx].length()==longestStringSize)
            results.add(inputArray[idx]);
    }  
        
   String[] result=new String[results.size()];
   
    return results.toArray(result);
}

static int largestIndex(String[] array){
    int largestIndexSize=0;
    for (int idx=0; idx<array.length; idx++){
          if(array[idx].length()>=largestIndexSize)
           largestIndexSize=array[idx].length();
    }
    return largestIndexSize;
}
