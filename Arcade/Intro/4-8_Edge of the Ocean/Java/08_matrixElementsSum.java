int matrixElementsSum(int[][] matrix) { 
  int sum=0;
   for(int col=0; colmatrix[0].length; col++){
      for (int row=0; rowmatrix.length; row++){
         if(matrix[row][col]!=0) {
               sum += matrix[row][col];
         }         
         else  {
            break;
         }
      }
     
   }
 
   return sum;

}
