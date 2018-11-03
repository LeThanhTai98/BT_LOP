using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	class vessel
	{
		List<Stack<int>> A = new List<Stack<int>>();
		int soLuong;
		int chieuCaoStack;
		public int SoLuong { get => soLuong; set => soLuong = value; }
		public int ChieuCaoStack { get => chieuCaoStack; set => chieuCaoStack = value; }
		public int totalContainerInVessel() { return soLuong * chieuCaoStack; }
		public void create_vessel()
		{
			Random random = new Random();
			for (int i = 0; i < soLuong; i++)
			{
				A.Add(new Stack<int>());
				for (int j = 0; j < ChieuCaoStack; j++)
				{
					A[i].Push(random.Next(101));
				}
			}
		}

		public void show_vessel()
		{
			/*
				25	65
				52	7
				8	3
				--> Có 3 hàng 2 cột --> Tạo mảng 2 chiều ngược lại --> 2 hàng 3 cột
				25	52	8
				65	7	3
			*/

			// Version-01 --> Chưa tối ưu vì phải đếm số lượng từng Stack trong khi đã biết chieuCaoStack
			/*if (A[0] != null)
			{
				int maxCount = A[0].Count;
				for (int i = 1; i < soLuong; i++)
				{
					if(A[i].Count > maxCount)
					{
						maxCount = A[i].Count;
					}
				}
				
				int[,] bienTam = new int[soLuong, maxCount];
				for(int i = 0; i < soLuong; i++)
				{
					int[] tempArr = new int[maxCount];
					tempArr = A[i].ToArray(); // Chuyển sang Mảng
					for(int j = 0; j < tempArr.Length; j++)
					{
						bienTam[i, j] = tempArr[j];
					}
				}
				for (int i = 0; i < maxCount; i++)
				{
					for(int j = 0; j < soLuong; j++)
					{
						Console.Write("\t" + bienTam[j, i]);
					}
					Console.WriteLine();
				}
			}*/

			// Version-02 --> sử dụng chieuCaoStack --> không chạy vòng lặp
			int[,] bienTam = new int[soLuong, chieuCaoStack];
			for (int i = 0; i < soLuong; i++)
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
				for (int j = 0; j < soLuong; j++)
				{
					Console.Write("\t" + bienTam[j, i]);
				}
				Console.WriteLine();
			}
		}

		public temp grap(int soLuongThemVao)
		{
			temp myTemp = new temp();
			//List<int> tam = new List<int>();
			int dem = 0;
			for (int i = 0; i < soLuongThemVao; i++)
			{
				if(i == soLuong)
				{
					i -= soLuong;
				}
				myTemp.in_temp(A[i].Pop());
				dem++;
				if (dem == soLuongThemVao)
				{
					break;
				}
				
			}
			return myTemp;
		}
	}
}
