using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour
{
    private string getUrlEscribir = "tadeolabhack.com:8081/test/Datos/phpMariana/escribir.php";
    // Start is called before the first frame update
    
    private string nombreTutor = "";
    private string apellidoTutor = "";
    private int celularTutor = 0;
    private int contrasenaTutor = 0;

    public InputField campoNombre;
    public InputField campoApellido;
    public InputField campoCelular;
    public InputField campoContrasena;

    public void SendData()
    {
        StartCoroutine(enviarDatosUsuario());
    }
    private IEnumerator enviarDatosUsuario()
    {
        if (campoNombre.text != "")
        {
            nombreTutor = campoNombre.text;
        }
        else
        {
            print("El campo de nombre no puede estar vacío");
        }

        if (campoApellido.text != "")
        { 
            apellidoTutor = campoApellido.text;
        }
        else
        {
            print("El campo de apellido no puede estar vacío");
        }
        if (campoCelular.text != "")
        {
            celularTutor = int.Parse(campoCelular.text);

        }
        else
        {
            print("El campo de edad no puede estar vacío");
        }

        if (campoContrasena.text != "")
        {
            contrasenaTutor = int.Parse(campoContrasena.text);
        }

        else
        {
            print("El campo de la contraseña no puede estar vacío");
        }

        print(nombreTutor + " " + apellidoTutor + " " + celularTutor + " " + contrasenaTutor);

        if (nombreTutor == "" || apellidoTutor == "" || celularTutor == 0 || contrasenaTutor == 0)
        {
            print("Los campos de nombre, apellido, celular y contraseña deben tener información");
        }

        else
        {
            WWWForm form = new WWWForm();
            form.AddField("nom", nombreTutor);
            form.AddField("ape", apellidoTutor);
            form.AddField("cel", celularTutor);
            form.AddField("cont", contrasenaTutor);

            WWW retroalimentacion = new WWW(getUrlEscribir, form);
            yield return retroalimentacion;

            print(retroalimentacion.text);
        }
        
    }

}
