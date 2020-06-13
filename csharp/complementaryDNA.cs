public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            //Your code
            string final = "";
            
            foreach(char c in dna){
              switch(c){
                case 'T':
                  final+='A';
                  break;
                case 'A':
                  final+='T';
                  break;
                case 'G':
                  final+='C';
                  break;
                default:
                  final+='G';
                  break;
              }
            }
            
            return final;
        }
    }
