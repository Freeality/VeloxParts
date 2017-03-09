using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using System.Text.RegularExpressions;
using System;

public class LicencaController : MonoBehaviour {

	public InputField Email;
	public InputField Senha;

	public void VerificaLicenca() {

		string erro = string.Empty;

		Debug.Log ("O email digitado foi..." + Email.text);
		Debug.Log ("A senha digitada foi..." + Senha.text);

		if (EntradaValida (out erro)) {
			Debug.Log ("Tudo certo!");
			return;
		}

		Debug.Log ("Algo errado..." + erro);
	}

	bool EntradaValida(out string erro) {

		erro = string.Empty;

		bool isEmail = Validation.validaEmail (Email.text, out erro);
		bool isValidPassword = Validation.ValidatePassword (Senha.text, out erro);

		if (!isEmail) {
			erro = "Email inválido";
			return false;
		}

		if (!isValidPassword) {
			erro = "Senha inválida";
			return false;
		}

		return true;
	}

}
