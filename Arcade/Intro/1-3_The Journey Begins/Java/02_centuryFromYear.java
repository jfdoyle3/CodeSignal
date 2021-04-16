int centuryFromYear(int year) {
    int century=0;
    int centuryEnd=year%100;
    if(centuryEnd==0){
       century=year/100;
    }else{
     century=(year/100)+1;
    }
    return century;
}