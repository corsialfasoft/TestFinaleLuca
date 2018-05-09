using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinaleLuca {
	class Program {
		static void Main(string[] args) {
			StampaNumeri();
			Console.WriteLine();
			OccorrenzeParole();
			Console.WriteLine();
		}

		static void OccorrenzeParole(){
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

		static void StampaNumeri(){
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
