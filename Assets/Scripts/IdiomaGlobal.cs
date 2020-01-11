using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IdiomaGlobal : MonoBehaviour {
	public static string IdiomaActual = "Español";
	public bool toggleEspañol;
	public bool toggleIngles;
	public bool EsEscenaMenu=true;

	void Awake(){
		//DontDestroyOnLoad (transform.gameObject);

	}
	public string RetornaIdioma(){
		return(IdiomaActual);
	}

	void Start(){
		CambiarIdioma (IdiomaActual);
	}
	public void CambiarIdioma(string idioma){
		IdiomaActual = idioma;
		NotificationCenter.DefaultCenter ().PostNotification (this, "CambiarIdioma_"); 

		if (EsEscenaMenu) {
			if (idioma == "Español") {
				//toggleEspañol. <GameObject> ().GetComponentInChildren<Image> ().gameObject.SetActive (true);
				toggleEspañol = true;
                toggleIngles = false;

            } else if (idioma == "Ingles") {
				//toggleIngles.GetComponentInChildren <GameObject> ().GetComponentInChildren<Image> ().gameObject.SetActive (true);
				toggleIngles = true;
                toggleEspañol = false;
            } 
		}

	}

}
