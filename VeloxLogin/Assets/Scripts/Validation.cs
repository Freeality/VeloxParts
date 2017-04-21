using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using System;

public class Validation : MonoBehaviour {

	const string EmailRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
	const string SenhaRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
	const string SenhaDeveConter = "Senha deve conter pelo menos ";

	// Faz os testes, retorna o resultado e a mensagem.
	static public bool ValidatePassword(string password, out string errorMessage) {

		errorMessage = "Tudo certo!";

		if (string.IsNullOrEmpty(password)) {
			throw new Exception("Senha não pode ser vazia");
		}

		Regex hasNumber = new Regex(@"[0-9]+");
		Regex hasUpperChar = new Regex(@"[A-Z]+");
		Regex hasMiniMaxChars = new Regex(@"^.{8,13}$");
		Regex hasLowerChar = new Regex(@"[a-z]+");
		Regex hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

		if (!hasLowerChar.IsMatch(password)) {
			errorMessage = SenhaDeveConter + "uma MINúscula";
			return false;
		}

		if (!hasUpperChar.IsMatch(password)) {
			errorMessage = SenhaDeveConter + "uma MAIúscula";
			return false;
		}

		if (!hasMiniMaxChars.IsMatch(password)) {
			errorMessage = "Senha deve conter entre 8 e 12 caracteres";
			return false;
		}

		if (!hasNumber.IsMatch(password)) {
			errorMessage = SenhaDeveConter + "um caracter numerico";
			return false;
		}

		if (!hasSymbols.IsMatch(password)) {
			errorMessage = SenhaDeveConter + "um caracter especial";
			return false;
		}

		return true;
	}

	static public bool validaEmail(string email, out string erro) {

		erro = string.Empty;

		bool isValid = Regex.IsMatch (email, EmailRegex, RegexOptions.IgnoreCase);

		if (!isValid) {
			erro = "email inválido";
		}

		return isValid;
	}
}
