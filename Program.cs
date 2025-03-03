using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;


namespace ExamG11;
internal class Program
{
    public void MaxArray2(int[] array)
    {
        int number = array[0];
        int number2 = array[0];
        int number3 = array[0];
        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] > number)
            {
                number = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > number2 && array[i] != number)
            {
                number2 = array[i];
            }
        }
        Console.WriteLine("Arraydagi 2-eng katta son: " + number2);
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > number3 && array[i] != number && array[i] != number2)
            {
                number3 = array[i];
            }
        }
        Console.WriteLine("Arraydagi 3-eng katta son: " + number3);
    }
    public static void Main(string[] args)
    {
        int[] array = { 5, 12, 34, 13, 63, 59, 26, 94 };
        var newObject = new Program();
        newObject.MaxArray2(array);
    }
}
