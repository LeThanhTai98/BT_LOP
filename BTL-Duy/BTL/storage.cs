using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	class storage
	{
		List<Stack<int>> A = new List<Stack<int>>(); // List các Stack
		int soLuongCot; // số cột
		int chieuCaoStack; // chiều cao = số hàng

		public int SoLuongCot { get => soLuongCot; set => soLuongCot = value; }
		public int ChieuCaoStack { get => chieuCaoStack; set => chieuCaoStack = value; }
		public int totalContainerInStorage() { return soLuongCot * chieuCaoStack; }
		public bool conditional_storage(vessel myVessel)
		{
			if (myVessel.totalContainerInVessel() <= totalContainerInStorage() && chieuCaoStack > myVessel.ChieuCaoStack)
			{
				Console.WriteLine("OK");
				return true;
			}
			else
			{
				Console.WriteLine("NOT OK");
				return false;
			}
		}
		public void create_storage()
		{
			for (int i = 0; i < soLuongCot; i++)
			{
				A.Add(new Stack<int>());
			}
		}
		public void show_storage()
		{
			int[,] bienTam = new int[soLuongCot, chieuCaoStack];
			for (int i = 0; i < soLuongCot; i++)
			{
				int[] tempArr = new int[chieuCaoStack];
				tempArr = A[i].ToArray(); // Chuyển sang Mảng
				for (int j = 0; j < tempArr.Length; j++)
				{
					bienTam[i, j] = tempArr[j];
				}
			}
			for (int i = 0; i < chieuCaoStack; i++)
			{
				for (int j = 0; j < soLuongCot; j++)
				{
					Console.Write("\t" + bienTam[j, i]);
				}
				Console.WriteLine();
			}
		}
	}
}
