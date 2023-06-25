using System.Linq.Expressions;
using System.Xml.Linq;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  Person person = new Person
              {
                  FirstName ="John",
                  DOB=new DateTime(1978,12,12)
              };

              Person p2 = person.Copy();
              p2.FirstName = "Jack";
              Console.Write(person.FirstName);*/


            /*
                        int a = 40;
                        var n = a.Res(2);
                        Console.Write(n);*/

            /*     Person person = new Person();

                 person.FirstName = "poxos";
                 person.DOB = new DateTime(2003, 04, 04);



                 Person[] persons = { person, new Person { FirstName = "John" } };
                 foreach(var item in persons)
                 {
                     Console.Write(item );
                 }
     */
            try
            {
                Person p = null;
                Console.Write(p.FirstName);
                int b = 0;
                int a = 5 / b;
            }
            
           /* catch (Exception ex)
            {
                Console.Write(" Error ");
            }*/
           
      /*      catch(DivideByZeroException ex){
                Console.Write(" Error divide 0 ");
            }*/
      catch(StackOverflowException ex)
            {

            }
            finally
            {

            }


        }
    }
}