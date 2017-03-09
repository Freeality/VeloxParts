using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class SenhaTest {

	bool TestaSenha(string senha) {
		
		string erro = string.Empty;
		bool isValid = Validation.ValidatePassword (senha, out erro);
		Debug.Log ("Senha: " + senha + "\nO erro foi....: " + erro);

		return isValid;
	}

	[Test]
	public void Senha_1234_DeveSerInvalida() {

		//Assert
		//The object has a new name
		Assert.IsFalse(TestaSenha("1234"));
	}

	[Test]
	public void Senha_Senha_DeveSerValida() {

		Assert.IsFalse(TestaSenha("Senha"));
	}

	[Test]
	public void Senha_senha_DeveSerInvalida() {

		Assert.IsFalse (TestaSenha("senha"));
	}

	[Test]
	public void Senha_SenhaGrandeEE_DeveSerInvalida() {

		Assert.IsFalse (TestaSenha ("SenhaGrandeEE"));
	}

	[Test]
	public void Senha_SenhaGrandeE1_DeveSerInvalida() {

		Assert.IsFalse (TestaSenha ("SenhaGrandeE1"));
	}

	[Test]
	public void Senha_SenhaGrandeA1_DevePassar() {

		Assert.IsTrue (TestaSenha ("SenhaGrande@1"));
	}

	[Test]
	public void Senha_SenhaGradeA1Demais_DeveSerInvalida() {

		Assert.IsFalse (TestaSenha ("SenhaGrande@1Demais"));
	}
}
