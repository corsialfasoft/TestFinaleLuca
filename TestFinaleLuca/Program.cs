using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinaleLuca {
	public class Program {
		public static void Main(string[] args) {
			//StampaNumeri();
			//Console.WriteLine();
			//OccorrenzeParole();
			//Console.WriteLine();

			List<int> lista1 = new List<int>() { { 1 }, { 9 }, { 8 }, { 7 }, { 6 }, { 54 }, { 56 } };
			List<int> lista2 = new List<int>() { {8765}, {4}, {3}, {4}, {56}, {78}, {998}, {76}, {54} };

			for (int h = 0; h < lista1.Count; h++)
				Console.Write($"{lista1[h]}, ");
			Console.WriteLine();

			for (int h = 0; h < lista1.Count; h++){
				for (int k = h +1; k < lista1.Count; k++) {
					if(lista1[h] > lista1[k]){
						int aus = lista1[k];
						lista1[k] = lista1[h];
						lista1[h] = aus;
					}
				}
			}
			for (int h = 0; h < lista1.Count; h++)
				Console.Write($"{lista1[h]}, ");
			Console.WriteLine();
			Console.WriteLine();

			for (int h = 0; h < lista2.Count; h++)
				Console.Write($"{lista2[h]}, ");
			Console.WriteLine();

			for (int h = 0; h < lista2.Count; h++) {
				for (int k = h + 1; k < lista2.Count; k++) {
					if (lista2[h] > lista2[k]) {
						int aus = lista2[k];
						lista2[k] = lista2[h];
						lista2[h] = aus;
					}
				}
			}
			for (int h = 0; h < lista2.Count; h++)
				Console.Write($"{lista2[h]}, ");
		}

		public static void OccorrenzeParole(){
			string start = "Questa è una frase di esempio come un'altra frase di esempio";
			string frase = start;
			List<string> parole = new List<string>();
			int index = 0;
			int occorrenze = 1;
			int s1 = 0;
			while(frase.Length > 0 && frase.IndexOf(" ") > 0) {
				s1 = frase.IndexOf(" ");
				string str = frase.Substring(index, s1 - index);
				parole.Add(str);
				frase = frase.Substring(s1 - index + 1);
			}
			parole.Add(frase);
			List<string> confronta = new List<string>();
			for(int t = 0; t < parole.Count; t++){
				confronta.Add(parole[t]);
			}
			for (int k = 0; k < confronta.Count; k++){
				for (int j = k + 1; j < confronta.Count; j++) {
					if(confronta[k] == confronta[j]){
						++occorrenze;
					}
				}
				if(occorrenze >= 2){
					Console.WriteLine($"la parola \"{parole[k]}\" si ripete {occorrenze} volte");
				}
				occorrenze = 1;
			}		
		}

		public static void StampaNumeri(){
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
