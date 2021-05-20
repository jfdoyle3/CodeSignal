//
// Binary trees are already defined with this interface:
// class Tree<T> {
//   Tree(T x) {
//     value = x;
//   }
//   T value;
//   Tree<T> left;
//   Tree<T> right;
// }
boolean hasPathWithGivenSum(Tree<Integer> t, int s) {
      
    if(t==null)
        return false;

    if(t.value==s)
        return true;
    System.out.println(t.value);
    s-=(int)t.value;
  //  System.out.println("S: "+s);
   
    if((int)s==0)
        return false;
    
   
    if(t.left!=null){
         System.out.println("Left Side");
        hasPathWithGivenSum(t.left, s);
    }   
    
         
    if(t.right!=null){
         System.out.println("Right Side");
        hasPathWithGivenSum(t.right, s);
    }
   return true;
    }
