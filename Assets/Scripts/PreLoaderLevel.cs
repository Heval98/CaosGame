using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreLoaderLevel : MonoBehaviour {

    // Use this for initialization
   // public RectTransform progressBar;
    public Text textComponent;
    public bool immediateActivateScene;

    protected AsyncOperation async;
    protected float progressPercent;

    void Awake()
    {
    }

    public virtual void Start()
    {
        // obtenemos de la escena anterior el index de la siguiente a cargar
        int nex_level = PlayerPrefs.GetInt("next_level");
        // si no tiene valor hubo un error y devuelve a menu principal
        if (!PlayerPrefs.HasKey("next_level"))
        {
            nex_level = 0;
        }
        else
        {
            // se resetea el dato persistente para evitar errores
            PlayerPrefs.DeleteKey("next_level");
            PlayerPrefs.Save();
        }
        // se inicia la carca asincrona del nivel
        async = Application.LoadLevelAsync(nex_level);
        // se establece si se activara la escena inmediatamente
        async.allowSceneActivation = immediateActivateScene;
    }

    public virtual void Update()
    {
        if (async != null)
        {
            progressPercent = async.progress * 100;
        }

        if (textComponent)
        {
            textComponent.text = ((int)progressPercent).ToString() + " %";
        }

        //if (progressBar)
        //{
        //    // aqui cada implementacion puede ser diferente
        //    float parentWidth = (progressBar.parent as RectTransform).rect.width;
        //    Vector2 progressBarSizeDelta = progressBar.sizeDelta;
        //    // ValueFromPercent calcula el valor de un porcentaje en base a su maximo valor x = (maxFactor / 100) * porentaje
        //    progressBarSizeDelta.x = ((parentWidth/100)*progressPercent);   
        //    progressBar.sizeDelta = progressBarSizeDelta;
        //}
    }
}
