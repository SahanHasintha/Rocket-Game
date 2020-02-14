using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnBehaviour : MonoBehaviour
{
    
    private Rocket rocket;

    public void Start()
    {
        rocket = FindObjectOfType<Rocket>();
    }

    public void StartBtn()
    {
        StartCoroutine(WaitSomeSecondsBeforeStart());
        
    }
    public void QuiteGame()
    {
        StartCoroutine(WaitSomeSecondsBeforeQuite());
    }
    public void PlayAgain()
    {
        StartCoroutine(WaitSomeSecondsBeforePlayAgain());
    }

    public void NextLevel()
    {
        StartCoroutine(WaitSomeSecondsBeforeNextLevel());
    }

    IEnumerator WaitSomeSecondsBeforeStart()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("LevelUnlock");
    }
    IEnumerator WaitSomeSecondsBeforeQuite()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("LevelUnlock");
    }
    IEnumerator WaitSomeSecondsBeforePlayAgain()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    IEnumerator WaitSomeSecondsBeforeNextLevel()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Btn01()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel1());
    }
    public void Btn02()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel2());
    }
    public void Btn03()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel3());
    }
    public void Btn04()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel4());
    }
    public void Btn05()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel5());
    }
    public void Btn06()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel6());
    }
    public void Btn07()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel7());
    }
    public void Btn08()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel8());
    }
    public void Btn09()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel9());
    }
    public void Btn10()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel10());
    }
    public void Btn11()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel11());
    }
    public void Btn12()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel12());
    }
    public void Btn13()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel13());
    }
    public void Btn14()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel14());

    }
    public void Btn15()
    {

        StartCoroutine(WaitSomeSecondsBeforeLevel15());
    }
    IEnumerator WaitSomeSecondsBeforeLevel1()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level01");
    }
    IEnumerator WaitSomeSecondsBeforeLevel2()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level02");
    }
    IEnumerator WaitSomeSecondsBeforeLevel3()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level03");
    }
    IEnumerator WaitSomeSecondsBeforeLevel4()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level04");
    }
    IEnumerator WaitSomeSecondsBeforeLevel5()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Level05");
    }
    IEnumerator WaitSomeSecondsBeforeLevel6()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level06");
    }
    IEnumerator WaitSomeSecondsBeforeLevel7()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level07");
    }
    IEnumerator WaitSomeSecondsBeforeLevel8()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level08");
    }
    IEnumerator WaitSomeSecondsBeforeLevel9()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level09");
    }
    IEnumerator WaitSomeSecondsBeforeLevel10()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level10");
    }
    IEnumerator WaitSomeSecondsBeforeLevel11()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level11");
    }
    IEnumerator WaitSomeSecondsBeforeLevel12()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level12");
    }
    IEnumerator WaitSomeSecondsBeforeLevel13()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level13");
    }
    IEnumerator WaitSomeSecondsBeforeLevel14()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level14");
    }
    IEnumerator WaitSomeSecondsBeforeLevel15()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level15");
    }

     void PlayAgainBtn()
    {
        StartCoroutine(PlayAgainBtnWaitSomeMinute());
    }

    IEnumerator PlayAgainBtnWaitSomeMinute()
    {
        yield return new WaitForSeconds(1f);
        rocket.GameOver();
    }

}
