boolean sumOfTwo(int[] a, int[] b, int v) {

    for(int first=0; first<a.length; first++){
        int firstNum=a[first];
        
        for(int second=0; second<b.length; second++){
            int secondNum=b[second];
            int sum=firstNum+secondNum;
            if(sum==v)
                return true;
        }
    }
    return false;
}