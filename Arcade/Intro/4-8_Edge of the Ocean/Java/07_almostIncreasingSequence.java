boolean solution(int[] sequence) {
    boolean isSequenced=false;
    boolean isRemoved=false;
    
    /* Given a sequence of integers as an array, determine whether it is possible to obtain a strictly increasing sequence 	
		by removing no more than one element from the array.
		a0 < a1 < a2 < a3
	*/
	
    for (int num=0; num<sequence.length-1; num++){
        if(sequence[num]<sequence[num+1])
            System.out.print("T"+num+ " ");
        else{
            System.out.println("F"+num+" ");
        }
    }
        


    return isSequenced;
}

