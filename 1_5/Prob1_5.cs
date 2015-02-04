using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProject
{
	public class Prob1_10
	{
		/*
		 * https://projecteuler.net/problem=1
		 */
		public static int Problem1(){
			int total = 0;
			for (int i = 0; i < 1000; i++) {
				if (i % 3 == 0)
					total += i;
				else if(i % 5 == 0)
					total += i;
			}
			return total;
		}

		/*
		 * https://projecteuler.net/problem=2
		 */
		public static int Problem2(){
			int sum = 2;
			Tuple<int, int> tup = Tuple.Create (1, 2);
			while (tup.Item2 < 4000000) {
				tup = Tuple.Create (tup.Item2, tup.Item1 + tup.Item2);
				if (tup.Item2 % 2 == 0)
					sum += tup.Item2;
			}
			return sum;
		}

		/*
		 * https://projecteuler.net/problem=3
		 * Brute force? doesn't seem to work efficiently
		 */
		public static Int64 Problem3(){
			Int64 init = 600851475143;

			for (Int64 i = init / 2; i > 2; --i) {
				if (init % i == 0) {
					if (isPrime (init / i))
						return init / i;
				}
			}
			return -1;
		}

		/*
		 * Helper for Problem 3. Returns true if num is prime
		 */
		public static bool isPrime(Int64 num){
			Int64 bound = (Int64) Math.Sqrt(num);
			if (num == 1) return false;
			if (num == 2) return true;
			for (int i = 2; i <= bound; ++i)  {
				if (num % i == 0)  return false;
			}
			return true;
		}

		/*
		 * https://projecteuler.net/problem=4
		 */
		public static int Problem4(){
			List<Int32> candidates = new List<Int32> ();
			for (int i = 999; i > 99; --i) {
				for (int j = 999; j > 99; --j) {
					string s = (i * j).ToString ();
					char[] charArray = s.ToCharArray ();
					Array.Reverse (charArray);
					if (s.Equals (new string (charArray)))
						candidates.Add (i * j);
				}
			}
			return candidates.Max ();
		}

		/*
		 * https://projecteuler.net/problem=5
		 */
		public static int Problem5(){
			for (int num = 20; true; num+=20) {
				if(DivisibleByAllBelow (num, 20)) return num;
			}
		}

		/*
		 * Helper for problem 5
		 */
		public static bool DivisibleByAllBelow(int num, int divisor){
			if (divisor == 1)
				return true;
			if (num % divisor == 0) {
				return DivisibleByAllBelow (num, --divisor);
			} else
				return false;
		}




	}
}

