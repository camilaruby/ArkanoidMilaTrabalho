using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour {

	public static int contador;

	void OnCollisionEnter2D(Collision2D collisionInfo){
		//acaba com o bloquinho hehe


			contador++;
			Destroy (gameObject);

			if (contador == 28) {
				Application.LoadLevel ("Scene");
			}
		

	}
}
 