namespace LeetSpeak
{
  public class Translate
  {
    public string LeetTranslate(string str)
    {
      // string demo = "there once was a man from Indiana";
      char[] array = str.ToCharArray();
      for(int i=0; i < array.Length; i++)
      {
        switch (array[i])
        {
          case 'e': 
            array[i] = '3';
            break;
          case 'E': 
            array[i] = '3';
            break;
          case 'o': 
            array[i] = '0';
            break;
          case 'O': 
            array[i] = '0';
            break;
            
          default:
            break;
        }
      }
      string result = string.Join("", array);
      return result;
    }
  }
}