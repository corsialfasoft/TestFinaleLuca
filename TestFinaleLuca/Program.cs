using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinaleLuca {
	public class Program {
		public static void Main(string[] args) {
			StampaNumeri();
			Console.WriteLine();
			OccorrenzeParole();
			Console.WriteLine();
			OrdinamentoListe();
		}

		public static void OrdinamentoListe(){
			List<int> lista1 = new List<int>() { { 1 }, { 9 }, { 8 }, { 7 }, { 6 }, { 54 }, { 56 } };
			List<int> lista2 = new List<int>() { {8765}, {4}, {3}, {4}, {56}, {78}, {998}, {76}, {54} };

			for (int h = 0; h < lista1.Count; h++)
				Console.Write($"{lista1[h]}, ");
			Console.WriteLine();

			Sort(lista1);

			for (int h = 0; h < lista1.Count; h++)
				Console.Write($"{lista1[h]}, ");
			Console.WriteLine();
			Console.WriteLine();

			for (int h = 0; h < lista2.Count; h++)
				Console.Write($"{lista2[h]}, ");
			Console.WriteLine();

			Sort(lista2);

			for (int h = 0; h < lista2.Count; h++)
				Console.Write($"{lista2[h]}, ");
			Console.WriteLine("\n");

			int l1 = 0;
			int l2 = 0;
			List<int> listaTot = new List<int>();
			while(l1 < lista1.Count && l2 < lista2.Count){
				if (lista1[l1] < lista2[l2]) {
					listaTot.Add(lista1[l1]);
					++l1;
				} else if (lista1[l1] > lista2[l2]) {
					listaTot.Add(lista2[l2]);
					++l2;
				} else {
					listaTot.Add(lista1[l1]);
					++l1;
					listaTot.Add(lista2[l2]);
					++l2;
				}
			}
			if (l1 >= lista1.Count) {
				while(l2 < lista2.Count) {
					listaTot.Add(lista2[l2]);
					++l2;
				}
			} else{
				while (l1 < lista1.Count) {
					listaTot.Add(lista1[l1]);
					++l1;
				}
			}

			//Console.WriteLine($"lista1.Count = {lista1.Count}");
			//Console.WriteLine($"lista2.Count = {lista2.Count}");
			//Console.WriteLine($"listaTot.Count = {listaTot.Count}");

			Console.Write("listaTot = ");
			for (int z = 0; z < listaTot.Count; z++)
				Console.Write($"{listaTot[z]}, ");
			Console.WriteLine("\n");		
		}

		private static void Sort(List<int> lista){
			for (int h = 0; h < lista.Count; h++) {
				for (int k = h + 1; k < lista.Count; k++) {
					if (lista[h] > lista[k]) {
						int aus = lista[k];
						lista[k] = lista[h];
						lista[h] = aus;
					}
				}
			}
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
