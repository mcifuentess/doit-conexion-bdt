using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserNinoData : MonoBehaviour
{
    private string getUrlEscribir = "tadeolabhack.com:8081/test/Datos/phpMariana/escribirUsuario.php";
    // Start is called before the first frame update

    private string nombreNino = "";
    private string apellidoNino = "";
    private int edadNino = 0;
 

    public InputField campoNombre;
    public InputField campoApellido;
    public InputField campoEdad;

    public void SenData()
    {
        StartCoroutine(enviarDatosUsuario());
    }
    private IEnumerator enviarDatosUsuario()
    {
        nombreNino = campoNombre.text;
        apellidoNino = campoApellido.text;

        edadNino = int.Parse(campoEdad.text);

        print(nombreNino + " " + apellidoNino + " " + edadNino);

        WWWForm form = new WWWForm();
        form.AddField("nom", nombreNino);
        form.AddField("ape", apellidoNino);
        form.AddField("ed", edadNino);

        WWW retroalimentacion = new WWW(getUrlEscribir, form);
        yield return retroalimentacion;

        print(retroalimentacion.text);
    }

}
