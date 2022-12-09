boolean solution(int[] sequence) {
    boolean isSequenced=true;
    boolean isRemoved=false;
    int countFalse=0;
    
    // a0 < a1 < a2 < a3
  
    for (int num=0; num<sequence.length-1; num++){
        if(sequence[num]<sequence[num+1])
            System.out.print("T"+num+ " ");
        else{
            countFalse++;
            System.out.println("F"+num+" ");
        }
    }
    if (countFalse>=2)
        return false;


    return isSequenced;
}
