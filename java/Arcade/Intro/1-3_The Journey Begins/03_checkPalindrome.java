boolean checkPalindrome(String inputString) {
    
    String[] arrString=inputString.split("");
    List<String> listString=Arrays.asList(arrString);
    Collections.reverse(listString);
    String asPalin=String.join("",listString);
    if(inputString.equals(asPalin)){
        return true;
    }
        return false;
}