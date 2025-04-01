using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ControlCamposVacios : MonoBehaviour
{
    public InputField correo;
    public Text errorMessage;
    private string emailPattern = @"^[^@\s]+@[^@\s]+.[^@\s]+$";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool CheckEmail(string email)
    {
        bool isValid = true;

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
        }
        return isValid;
    }

}
