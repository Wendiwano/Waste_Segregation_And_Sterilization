using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransitionManager : MonoBehaviour
{
    public FadeScreen fadeScreen;
   
public void GoToScene(int scenelndex)
    {
        StartCoroutine(GoToSceneRoutine(scenelndex));

    }



IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
        SceneManager.LoadScene(sceneIndex);
    }








}
