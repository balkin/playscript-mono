// Copyright 2013 Zynga Inc.
//	
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//		
//      Unless required by applicable law or agreed to in writing, software
//      distributed under the License is distributed on an "AS IS" BASIS,
//      WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//      See the License for the specific language governing permissions and
//      limitations under the License.

using System;

namespace _root
{
	[PlayScript.Extension(typeof(int))]
	public static class @int
	{
		//
		// Methods
		//

		public static string toExponential(this int i, uint fractionDigits) {
			throw new NotImplementedException();
		}
			
		public static string toFixed(this int i, uint fractionDigits) {
			throw new NotImplementedException();
		}
			
		public static string toPrecision(this int i, uint precision) {
			throw new NotImplementedException();
		}
			
		public static string toString(this int i) {
			return Convert.ToString(i);
		}
	
		public static string toString(this int i, uint radix) {
			return Convert.ToString(i, (int)radix);
		}
			
		public static int valueOf(this int i) {
			return i;
		}

		//
		// Constants
		//
			
		public const int MAX_VALUE = System.Int32.MaxValue;
		public const int MIN_VALUE = System.Int32.MinValue;
	}

	[PlayScript.Extension(typeof(uint))]
	public static class @uint
	{
		public const uint MAX_VALUE = System.UInt32.MaxValue;
		public const uint MIN_VALUE = System.UInt32.MinValue;

		public static string toString(this uint i) {
			return Convert.ToString(i);
		}

		public static string toString(this uint i, uint radix) {
			return Convert.ToString(i, (int)radix);
		}

		public static uint valueOf(this uint i) {
			return i;
		}

	}
}

