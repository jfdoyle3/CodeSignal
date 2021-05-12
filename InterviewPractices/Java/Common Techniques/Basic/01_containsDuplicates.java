boolean containsDuplicates(int[] a) {
    
    for(int first=0; first<a.length-1; first++){
        int firstNum=a[first];
        for(int second=first+1; second<a.length; second++){
            int secondNum=a[second];
            if(firstNum==secondNum)
                return true;
        }
    }
    return false;
}