boolean areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight) {
    
    boolean results=true;
    
    if(yourLeft==friendsRight && yourRight==friendsLeft ||yourRight==friendsRight && yourLeft==friendsLeft ){
        results=true;
    } else {
        results=false;
    }
    
 return results;
}
