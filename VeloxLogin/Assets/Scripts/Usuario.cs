using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usuario : MonoBehaviour {

	const string EmailInvalido = "email inválido";
	const string SenhaInvalida = "senha inválida";

	string Email { 
		get {
			if (Email.Length == 0) {
				Email = EmailInvalido;
			}
			return Email;
		}
		set {
			if (value.Length == 0) {
				Email = EmailInvalido;
			}
		} 
	}

	string Senha { 
		get {
			if (Senha.Length == 0) {
				Senha = SenhaInvalida;
			}
			return Senha;
		}
		set { 
			if (value.Length == 0) {
				Senha = SenhaInvalida;
			}
		}
	}

	public Usuario (string email, string senha) {
		Email = email;
		Senha = senha;
	}
}
