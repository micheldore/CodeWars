using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    string final = "";
    string like = " like this";
    switch(name.Length){
      case 0:
        final = "no one likes this";
        break;
      case 1:
        final = name[0]+" likes this";
        break;
      case 2:
        final = name[0] + " and " + name[1] + like;
        break;
      case 3: 
        final = name[0] + ", " + name[1] + " and " + name[2] + like;
        break;
      default:
        final = name[0] + ", " + name[1] + " and " + (name.Length-2).ToString() + " others" + like;
        break;
    }
    return final;
  }
}
