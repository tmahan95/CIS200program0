/*Grading ID: D2575
 * Program 0
 * Due 9/24/2016
 * Course Section: 200-76
 * 
 * Description: This program creates address objects and from those address objects constructs letters and utilizes a CalcCost method for each Letter.
 * The created letters then use an overriden ToString method to display the origin address, destintion address, and cost of each letter in a console.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            decimal fixedCost = 5m;

            //Create 4 Address objects with name, two addresses, a city, state and zip
            Address address1 = new Address("P. Sherman", "42 Wallaby Way", "", "Sydney", "New South Wales", 12345); //address1 object, to be used in creating Parcel objects
            Address address2 = new Address("Shrek Ogre","1835 Swamp Ave","","Louisville","KY",40229);//address2 object, to be used in creating Parcel objects
            Address address3 = new Address("Aladdin","1992 Dirt Rd","","Las Vegas","NV",55555);//address3 object, to be used in creating Parcel objects
            Address address4 = new Address("Mike Wazowsksi","2001 Pixar Way","","Monstropolis","ND",91357);//address4 object, to be used in creating Parcel objects

             //Initialize a list of Letters
             // List<Letter> letters = new List<Letter>()

            Letter letter1 = new Letter(address3, address2, fixedCost); //create Letter objects from Address objects 2 and 3
            Letter letter2 = new Letter(address3, address4, fixedCost); //Letter object from Address objects 3 and 4
            Letter letter3 = new Letter(address4, address1, fixedCost); //Letter object from Address object 4 and 1
            Letter letter4 = new Letter(address1, address2, fixedCost); //Letter object from Address object 1 and 2

            //new list that will contain parcel objects
            List<Parcel> parcels = new List<Parcel>();

            parcels.Add(letter1); //add letter1 to new parcel list
            parcels.Add(letter2);//and so on
            parcels.Add(letter3);
            parcels.Add(letter4);
            
             //foreach loop to display each letter in the parcels list.
            foreach(var letter in parcels)
            { Console.WriteLine(letter);
                Console.WriteLine("----------------------------------"); }
        }
    }
}
