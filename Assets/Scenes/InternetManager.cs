using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InternetManager : MonoBehaviour
{
    public Text checkInternet;

    private string urlData = "tadeolabhack.com:8081/test/Datos/phpMariana/isConection.php";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_checkInternet());

    }
    public IEnumerator _checkInternet()
    {
        //www se usa para acceder a una pag web
        WWW getData = new WWW(urlData);
        yield return getData;

        print(getData.text);

        if (getData.text == "ConexionEstablecida")
        {
            checkInternet.text = "El usuario se conectó";
        }
        else
        {
            checkInternet.text = "Sin conexión";
        }
    }
    // Update is called once per frame
   
}
