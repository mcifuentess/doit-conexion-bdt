using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUser : MonoBehaviour
{
    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/MostrarPosXusuario.php";

    private string UrlClicks = "http://tadeolabhack.com:8081/test/Datos/MostrarBotonXusuario.php";

    public Text TextoPuesto;
    public Text TextClick;

    public int idUser = 85;

    public void obtenerInfo()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {
        string info = UrlPosition + "?IDuser=" + idUser;

        WWW resultInfo = new WWW(info);

        yield return resultInfo;

        print(resultInfo.text);

        TextoPuesto.text = resultInfo.text;

        string info2 = UrlClicks + "?IDuser=" + idUser;

        WWW resultInfo2 = new WWW(info2);

        yield return resultInfo2;
        print(resultInfo2.text);

        TextClick.text = resultInfo2.text;


    }






}
