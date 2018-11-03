using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	class Program
	{
		static void Main(string[] args)
		{
			/*______________ vessel ________________*/
			vessel myVessel = new vessel();
			myVessel.SoLuong = 2;
			myVessel.ChieuCaoStack = 4;
			
			myVessel.create_vessel();
			Console.WriteLine("Ban dau: ");
			myVessel.show_vessel();
			Console.WriteLine("----------------------");
			Console.WriteLine("Total Container In Vessel: {0}", myVessel.totalContainerInVessel());

			/*___________________________________________________________________________________________*/

			/*______________ storage ________________*/
			storage myStorage = new storage();
			myStorage.SoLuongCot = 3;
			myStorage.ChieuCaoStack = 9;

			Console.WriteLine("Total Container In Storage: {0}", myStorage.totalContainerInStorage());
			
			if(myStorage.conditional_storage(myVessel))
			{
				myStorage.create_storage();
				int putIntoTemp = myStorage.ChieuCaoStack - myVessel.ChieuCaoStack;
				Console.WriteLine("Chenh lech: {0}", putIntoTemp);
				temp myTemp = myVessel.grap(putIntoTemp);
				Console.WriteLine("Trong bai tam:");
				for(int i = 0; i < myTemp.count_temp(); i++)
				{
					Console.Write("\t" + myTemp.out_temp()[i]);
				}
				Console.WriteLine();
				Console.WriteLine("--------------------");
				Console.WriteLine("Luc sau: ");
				myVessel.show_vessel();
			}
			//Console.WriteLine("-------------------");
			//myStorage.show_storage();

			/*___________________________________________________________________________________________*/

			/*______________ temp ________________*/

			Console.ReadKey();
		}
	}
}
