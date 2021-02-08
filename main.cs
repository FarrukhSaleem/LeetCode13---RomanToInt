using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    string s = "DCXXI";
    int result=RomanToInt(s);
    Console.WriteLine(result.ToString());
  }
  public static int RomanToInt(string s){
    int result=0;
    Dictionary<char,int> RomanLst = new Dictionary<char,int>();
    RomanLst['I']=1;
    RomanLst['V']=5;
    RomanLst['X']=10;
    RomanLst['L']=50;
    RomanLst['C']=100;    
    RomanLst['D']=500;
    RomanLst['M']=1000;
    char[] rmncr = s.ToCharArray();
    for (int i =0;i<rmncr.Length;i++){
      if(rmncr[i]=='I'){        
        if(i+1<rmncr.Length && rmncr[i+1]=='V'){
          result +=4;
          i++;
        }        
        else if(i+1<rmncr.Length && rmncr[i+1]=='X'){
          result +=9;
          i++;
        }
        else{
          result += RomanLst[rmncr[i]];
        }
      }
      else if (rmncr[i]=='X'){
        if(i+1<rmncr.Length && rmncr[i+1]=='L'){
          result +=40;
          i++;
        }
        else if(i+1<rmncr.Length && rmncr[i+1]=='C'){
          result +=90;
          i++;
        }
        else{
          result += RomanLst[rmncr[i]];
        }
      }
      else if (rmncr[i]=='C'){
        if(i+1<rmncr.Length && rmncr[i+1]=='D'){
          result +=400;
          i++;
        }
        else if(i+1<rmncr.Length && rmncr[i+1]=='M'){
          result +=900;
          i++;
        }
        else {
          result += RomanLst[rmncr[i]];
        }
      }
      else{
        result += RomanLst[rmncr[i]];
      }
    }          
    return result;
  }
}