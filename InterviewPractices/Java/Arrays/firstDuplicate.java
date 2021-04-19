int firstDuplicate(int[] a) {

HashMap<Integer, List<Integer>> arrayMap=new HashMap<>();

for(int idx=0; idx<a.length; idx++){
    if(arrayMap.containsKey(a[idx])){
        List<Integer> indexes=arrayMap.get(a[idx]);
        indexes.add(idx);
        arrayMap.put(a[idx],indexes);
}
         else {
         arrayMap.put(a[idx],new ArrayList<Integer>());
          List<Integer> indexes=arrayMap.get(a[idx]);
          indexes.add(idx);
         }
}
List<Integer> keys=new ArrayList<>();
    for (Map.Entry<Integer,List<Integer>> entry : arrayMap.entrySet()) {
        Integer k = entry.getKey();
        Integer v = entry.getValue();
        System.out.println("Key: " + k + ", Value: " + v);
    }



//System.out.println(arrayMap.toString());





int index=findIndex(a, 3);

return 0;
}

static int findIndex(int[] array, int number){
    if(array==null) return -1;
    int arrayLen=array.length;
    for(int idx=0; idx<arrayLen; idx++){
        if(array[idx]==number)
            return idx;
    }
    return -1;
}