boolean solution(int[] sequence) {
    boolean isSequenced=true;
    boolean isRemoved=false;
    int countFalse=0;
  
    for (int num=0; num<sequence.length-1; num++){
        if(sequence[num]<sequence[num+1])
            System.out.print("T"+num+ " ");
        else{
            countFalse++;
            if(countFalse>1 && sequence[num]<sequence[num+2]){
                isRemoved=true;
                isSequenced=true;
                break;
                
            }
                
            System.out.println("F"+num+" ");
        }
    }
    if (countFalse>=2)
        return false;


    return isSequenced;
}
