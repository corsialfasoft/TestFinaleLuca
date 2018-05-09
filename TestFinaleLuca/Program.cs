using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinaleLuca {
	class Program {
		static void Main(string[] args) {
			int y = 0;
			int x = 0;
			bool stop = true;
			for(int n = 1; stop; n++){
				if(n % 2 == 0){
					Console.Write($"{n}, ");
					++y;
					if(y >= 15){
						stop = false;
						x = n;
					}
				}
			}
			Console.WriteLine("");
			Console.WriteLine("Fine numeri Pari");
			stop = true;
			for (int n = x; stop; n--) {
				if (n % 2 != 0) {
					Console.Write($"{n}, ");
					--y;
					if (n == 1) {
						stop = false;
					}
				}
			}
			Console.WriteLine("");
			Console.WriteLine("Fine numeri Dispari");
		}
	}
}
