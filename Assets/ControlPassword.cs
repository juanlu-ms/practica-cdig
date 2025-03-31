using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPassword : MonoBehaviour
{
    public InputField passwordField;
    public Image toggleIcon; 
    public Sprite eyeOpenSprite;
    public Sprite eyeClosedSprite; 
    private bool isPasswordHidden = true;

    // Start is called before the first frame update
    void Start()
    {
        if (passwordField != null)
        {
            passwordField.contentType = InputField.ContentType.Password;
            passwordField.ForceLabelUpdate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void togglePassword() 
    {
        if (isPasswordHidden)
        {
            passwordField.contentType = InputField.ContentType.Standard;
            toggleIcon.sprite = eyeOpenSprite;
        }
        else
        {
            passwordField.contentType = InputField.ContentType.Password;
            toggleIcon.sprite = eyeClosedSprite;
        }

        isPasswordHidden = !isPasswordHidden;
        passwordField.ForceLabelUpdate();

    }
}
