using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrlScript : MonoBehaviour {
    
    public void OpenGithubUrl()
    {
        Application.OpenURL("https://github.com/kayuminbou");
    }

    public void OpenTwitterUrl()
    {
        Application.OpenURL("https://twitter.com/kayumi_sec");
    }
}
