using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour

{
    public GameObject often;
    public GameObject roll;
    public GameObject home;
    public GameObject whatthehell;
    public GameObject gachapon;
    public GameObject kiara;

    public string sceneName;
    
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(Delay());
    }

    // Update is called once per frame
    public IEnumerator Delay()
    {
        often.SetActive(true);
        yield return new WaitForSeconds(1);
        roll.SetActive(true);
        yield return new WaitForSeconds(1);
        home.SetActive(true);
        kiara.SetActive(true);
        yield return new WaitForSeconds(1.501F);

        often.SetActive(false);
        roll.SetActive(false);
        home.SetActive(false);
        kiara.SetActive(false);
        yield return new WaitForSeconds(0.001F);
        whatthehell.SetActive(true);
        gachapon.SetActive(true);
        yield return new WaitForSeconds(1.501F);

        SceneManager.LoadScene(sceneName);
    }
}
