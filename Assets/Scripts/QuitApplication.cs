using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class QuitApplication : MonoBehaviour
{
    public ARSession session;

    public void Quit()
    {
        if (session != null)
        {
            StartCoroutine(DoPreperationForQuit());
            Application.Quit();
        }
    }

    IEnumerator DoPreperationForQuit()
    {
        Destroy(session.gameObject);
        yield return null;
    }
}
