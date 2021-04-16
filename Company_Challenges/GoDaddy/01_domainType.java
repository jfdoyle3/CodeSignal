String[] domainType(String[] domains) {

int domainsLen=domains.length;
String[] result=new String[domainsLen];

for(int idx=0; idx<domainsLen; idx++){

   char lastLetter=domains[idx].charAt(domains[idx].length()-1);
   
   switch(lastLetter)
   {
        case 'g' :
            result[idx]="organization";
            break;
        case 'm':
            result[idx]="commercial";
            break;
        case 't':
            result[idx]="network";
            break;
        case 'o':
            result[idx]="information";
            break;
        default:
            result[idx]="none";
   }
}
return result;
}