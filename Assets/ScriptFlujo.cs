using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ScriptFlujo : MonoBehaviour
{
    // Un canvas por pantalla 
    public Canvas inicio;
    public Canvas creditos;
    public Canvas registro1;
    public Canvas registro2;
    public Canvas registroCompletado;
    public Canvas recordarContrasena;
    public Canvas correoContrasena;
    public Canvas navInicio;
    public Canvas navConduccion;
    public Canvas destFavoritos;

    //Recuperar contrasena
    public InputField correoRecu;
    public Text errorMessageContrasena;
    private string emailPattern = @"^[^@\s]+@[^@\s]+.[^@\s]+$";

    //Registro 1
    public InputField inNombre;
    public InputField inApellidos;
    public InputField inCorreo;
    public InputField inContrasena;
    public Text errNombre;
    public Text errApellidos;
    public Text errCorreo;
    public Text errContrasena;

    // Start is called before the first frame update
    void Start()
    {
        // Solo se visualiza la pantalla inicial
        inicio.gameObject.SetActive(true);

        // Todas las demás empiezan ocultas
        creditos.gameObject.SetActive(false);
        registro1.gameObject.SetActive(false);
        registro2.gameObject.SetActive(false);
        registroCompletado.gameObject.SetActive(false);
        recordarContrasena.gameObject.SetActive(false);
        correoContrasena.gameObject.SetActive(false);
        navInicio.gameObject.SetActive(false);
        navConduccion.gameObject.SetActive( false);
        destFavoritos.gameObject.SetActive(false);

    }

    public bool CheckEmail(InputField inputF, Text errorMessage)
    {
        bool isValid = true;
        string email = inputF.text;

        if (string.IsNullOrWhiteSpace(email))
        {
            errorMessage.text = "El campo de correo no puede estar vacío.";
            isValid = false;
        }
        else if (!Regex.IsMatch(email, emailPattern))
        {
            errorMessage.text = "Formato de correo no válido.";
            isValid = false;
        }
        else
        {
            errorMessage.text = "";
            isValid = true;
        }
        return isValid;
    }

    public bool CheckOther(InputField inputF, Text errorMessage)
    {
        bool isValid = true;
        string other = inputF.text;

        if (string.IsNullOrWhiteSpace(other))
        {
            errorMessage.text = "El campo no puede estar vacío.";
            isValid = false;
        }
        else
        {
            errorMessage.text = "";
            isValid = true;
        }
        return isValid;
    }

    public void inicio_a_creditos()
    {
        inicio.gameObject.SetActive(false);
        creditos.gameObject.SetActive(true);
    }

    public void creditos_a_inicio()
    {
        creditos.gameObject.SetActive(false);
        inicio.gameObject.SetActive(true);
    }

    public void inicio_a_registro1()
    {
        inicio.gameObject.SetActive(false);
        registro1.gameObject.SetActive(true);
    }

    public void registro1_a_inicio()
    {
        registro1.gameObject.SetActive(false);
        inicio.gameObject.SetActive( true);
    }

    public void registro1_a_registro2()
    {
        bool result = true;
        if (!CheckOther(inNombre, errNombre))
        {
            result = false;
        }
        if (!CheckEmail(inCorreo, errCorreo))
        {
            result = false;
        }
        if (!CheckOther(inApellidos, errApellidos))
        {
            result = false;
        }
        if (!CheckOther(inContrasena, errContrasena))
        {
            result = false;
        }
        if (result)
        {
            registro1.gameObject.SetActive(false);
            registro2.gameObject.SetActive(true);
        }

    }

    public void registro2_a_registro1()
    {
        registro2.gameObject.SetActive(false);
        registro1.gameObject.SetActive(true);   
    }

    public void registro2_a_registroCompletado()
    {
        registro2.gameObject.SetActive(false);
        registroCompletado.gameObject.SetActive(true);
    }

    public void inicio_a_recordarContrasena()
    {
        inicio.gameObject.SetActive(false);
        recordarContrasena.gameObject.SetActive(true);
    }

    public void recordarContrasena_a_correoContrasena()
    {
        if (CheckEmail(correoRecu,errorMessageContrasena))
        {
            recordarContrasena.gameObject.SetActive(false);
            correoContrasena.gameObject.SetActive(true);
        }
    }

    public void correoContrasena_a_incio()
    {
        correoContrasena.gameObject.SetActive(false);
        inicio.gameObject.SetActive(true);
    }

    public void registroCompletado_a_navInicio()
    {
        registroCompletado.gameObject.SetActive(false);
        navInicio.gameObject.SetActive(true);
    }

    public void inicio_a_navInicio()
    {
        inicio.gameObject.SetActive( false);
        navInicio.gameObject.SetActive( true);
    }

    public void navInicio_a_navConduccion()
    {
        navInicio.gameObject.SetActive(false);
        navConduccion.gameObject.SetActive(true);
    }

    public void navConduccion_a_navInicio()
    {
        navConduccion.gameObject.SetActive(false);
        navInicio.gameObject.SetActive(true);
    }

    public void navInicio_a_destinosFav()
    {
        navInicio.gameObject.SetActive(false);
        destFavoritos.gameObject.SetActive(true);
    }

    public void destinosFav_a_navInicio()
    {
        destFavoritos.gameObject.SetActive(false);
        navInicio.gameObject.SetActive(true);
    }
}
