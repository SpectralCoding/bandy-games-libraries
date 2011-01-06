using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BandyLib {
	public static class Functions {

		public static Boolean IsAlphaNumeric(String InputStr) {
			if (string.IsNullOrEmpty(InputStr)) {
				return false;
			}
			for (int i = 0; i < InputStr.Length; i++) {
				if (!(Char.IsLetter(InputStr[i])) && (!(Char.IsNumber(InputStr[i])))) {
					return false;
				}
			}
			return true;
		}



		public static Boolean HasNonKeyboardCharacters(String InputStr) {
			int AsciiEquiv;
			foreach (Char CurrentChar in InputStr.ToCharArray()) {
				AsciiEquiv = (int)CurrentChar;
				if ((AsciiEquiv < 32) || (AsciiEquiv > 126)) {
					return true;
				}
			}
			return false;
		}

		public static Boolean ContainsAlpha(String InputStr) {
			int AsciiEquiv;
			foreach (Char CurrentChar in InputStr.ToCharArray()) {
				AsciiEquiv = (int)CurrentChar;
				if (((AsciiEquiv > 64) && (AsciiEquiv < 91)) || ((AsciiEquiv > 96) && (AsciiEquiv < 123))) {
					return true;
				}
			}
			return false;
		}

		public static Boolean ContainsNumeric(String InputStr) {
			int AsciiEquiv;
			foreach (Char CurrentChar in InputStr.ToCharArray()) {
				AsciiEquiv = (int)CurrentChar;
				if ((AsciiEquiv > 47) && (AsciiEquiv < 58)) {
					return true;
				}
			}
			return false;
		}

	}
}
