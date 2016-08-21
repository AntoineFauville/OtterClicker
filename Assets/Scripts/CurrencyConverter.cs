using UnityEngine;
using System.Collections;

public class CurrencyConverter : MonoBehaviour {

	private static CurrencyConverter instance;
	public static CurrencyConverter Instance {
		get {
			return instance;
		}
	}

	void Awake () {
		CreateInstance ();
	}

	void CreateInstance () {
		if (instance == null) {
			instance = this;
		}
	}

	public string GetCurrencyIntoString (float valueToConvert, bool currencyPerSec, bool currencyPerClick, bool costOf){
		string converted;

		if (valueToConvert >= 1e60 ) {
			converted = (valueToConvert / 1e60 ).ToString ("f2") + " J";
		}else if (valueToConvert >= 1e57 ) {
			converted = (valueToConvert / 1e57 ).ToString ("f2") + " I";
		}else if (valueToConvert >= 1e54 ) {
			converted = (valueToConvert / 1e54 ).ToString ("f2") + " H";
		}else if (valueToConvert >= 1e51 ) {
			converted = (valueToConvert / 1e51 ).ToString ("f2") + " G";
		}else if (valueToConvert >= 1e48 ) {
			converted = (valueToConvert / 1e48 ).ToString ("f2") + " F";
		}else if (valueToConvert >= 1e45 ) {
			converted = (valueToConvert / 1e45 ).ToString ("f2") + " E";
		}else if (valueToConvert >= 1e42 ) {
			converted = (valueToConvert / 1e42 ).ToString ("f2") + " D";
		}else if (valueToConvert >= 1e39 ) {
			converted = (valueToConvert / 1e39 ).ToString ("f2") + " C";
		}else if (valueToConvert >= 1e36 ) {
			converted = (valueToConvert / 1e36f ).ToString ("f2") + " B";
		}else if (valueToConvert >= 1e33 ) {
			converted = (valueToConvert / 1e33f ).ToString ("f2") + " A";
		}else if (valueToConvert >= 1e30 ) {
			converted = (valueToConvert / 1e30f ).ToString ("f2") + " Deci";
		}else if (valueToConvert >= 1e27 ) {
			converted = (valueToConvert / 1e27f ).ToString ("f2") + " Noni";
		} else if (valueToConvert >= 1e24 ) {
			converted = (valueToConvert / 1e24f ).ToString ("f2") + " Octi";
		} else if (valueToConvert >= 1e21) {
			converted = (valueToConvert / 1e21f ).ToString ("f2") + " Sept";
		} else if (valueToConvert >= 1000000000000000000) {
			converted = (valueToConvert / 1000000000000000000f).ToString ("f2") + " Sext";
		} else if (valueToConvert >= 1000000000000000) {
			converted = (valueToConvert / 1000000000000000f).ToString ("f2") + " Qui";
		} else if (valueToConvert >= 1000000000000) {
			converted = (valueToConvert / 1000000000000f).ToString ("f2") + " Qua";
		} else if (valueToConvert >= 1000000000) {
			converted = (valueToConvert / 1000000000f).ToString ("f2") + " T";
		} else if (valueToConvert >= 1000000) {
			converted = (valueToConvert / 1000000f).ToString ("f2") + " M";
		} else if (valueToConvert >= 1000) {
			converted = (valueToConvert / 1000f).ToString ("f2") + " K";
		}

			//unity said too large...

		 /*else if (valueToConvert >= 1000000000000000000000) {
			converted = (valueToConvert / 1000000000000000000000f).ToString ("f2") + " Sept";
		} else if (valueToConvert >= 1000000000000000000000000) {
			converted = (valueToConvert / 1000000000000000000000000f).ToString ("f2") + " Octi";
		} else if (valueToConvert >= 1000000000000000000000000000) {
			converted = (valueToConvert / 1000000000000000000000000000f).ToString ("f2") + " Noni";
		} else if (valueToConvert >= 1000000000000000000000000000000) {
			converted = (valueToConvert / 1000000000000000000000000000000f).ToString ("f2") + " Deci";
		} else if (valueToConvert >= 1000000000000000000000000000000000) {
			converted = (valueToConvert / 1000000000000000000000000000000000f).ToString ("f2") + " A";
		} else if (valueToConvert >= 1000000000000000000000000000000000000) {
			converted = (valueToConvert / 1000000000000000000000000000000000000f).ToString ("f2") + " B";
		} else if (valueToConvert >= 1000000000000000000000000000000000000000) {
			converted = (valueToConvert / 1000000000000000000000000000000000000000f).ToString ("f2") + " C";
		} */ else {
		converted = "" + (valueToConvert).ToString ("f0");
		}

		if (currencyPerSec == true) {
			converted = (valueToConvert).ToString ("f2") + " C/s";
		}

		if (costOf == true) {
			converted = (valueToConvert).ToString ("f2") + " CTN";
		}

		if (currencyPerClick == true) {
			converted = (valueToConvert).ToString ("f2") + " C/c";
		}
		return converted;
	}
}