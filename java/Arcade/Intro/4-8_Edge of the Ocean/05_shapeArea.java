int shapeArea(int n) {

  int count=0;
  int max=2*n-1;
  
   for (int i=1; i<n; i++)
   {
        int odd = 2 * i - 1;
        count +=odd*2;
    }
    count += max;     
  
    return count;
}