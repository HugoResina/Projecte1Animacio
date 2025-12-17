using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoBackScene : MonoBehaviour
{
    public string nombreEscenaDestino = "SampleScene";
    public GameObject particles;
    public GameObject particles2;

    void Start()
    {
        StartCoroutine(CambiarDespuesDeTiempo());
        StartCoroutine(DisableParticles());

    }

    IEnumerator CambiarDespuesDeTiempo()
    {
        yield return new WaitForSeconds(12f);  
        SceneManager.LoadScene(nombreEscenaDestino); 
    }
    IEnumerator DisableParticles()
    {
        yield return new WaitForSeconds(10f);
        particles.SetActive(false);
        particles2.SetActive(false);
        
    }
}
