using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager2 : MonoBehaviour
{
    public float delayInSeconds = 3f; 
    public GameObject objectToMove;
    public float moveSpeed = 2f;
    public bool shipMove = false;
    public AudioClip shipTakeoffSound;
    private AudioSource audioSource;
    public static bool l2 = false;
    public static bool l3 = false;
    public static bool l4 = false;
    public static bool l5 = false;
    public static bool l6 = false;
    
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = shipTakeoffSound;
        //Debug.Log("l2 = " + l2);
    }

    void Update()
    {
        if(shipMove == true){
            objectToMove.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            Collider2D hitboxCollider = objectToMove.GetComponent<Collider2D>();
            hitboxCollider.enabled = false;
        }
        if(LevelOneWinCondition.levelTwoLoaded == true && l2 == false){
            loadScene3();
            l2 = true;
            //Debug.Log("l2 = " + l2);
        }
        if(LevelTwoWinCondition.levelThreeLoaded == true && l3 == false){
            loadScene4();
            l3 = true;
        }
        if(LevelThreeWinCondition.levelFourLoaded == true && l4 == false){
            loadScene5();
            l4 = true;
        }
        if(LevelFourWinCondition.levelFiveLoaded == true && l5 == false){
            loadScene6();
            l5 = true;
        }
        //if(LevelFourWinCondition.levelSevenLoaded == true && l6 == false){
        //    loadScene7();
        //    l6 = true;
        //}

    }

    public void loadScene0(){
        audioSource.Play();
        shipMove = true;
        StartCoroutine(LoadScene0WithDelay());
        //SceneManager.LoadScene(0);
        Debug.Log("Loading scene 0...");
    }

    public void loadScene1(){
        audioSource.Play();
        shipMove = true;
        StartCoroutine(LoadScene1WithDelay());
        //SceneManager.LoadScene(1);
        Debug.Log("Loading scene 1...");
    }

    public void loadScene2(){
        audioSource.Play();
        shipMove = true;
        StartCoroutine(LoadScene2WithDelay());
        //SceneManager.LoadScene(2);
        Debug.Log("Loading scene 2...");
    }

    public void loadScene3(){
        audioSource.Play();
        shipMove = true;
        StartCoroutine(LoadScene3WithDelay());
        //SceneManager.LoadScene(3);
        Debug.Log("Loading scene 3...");
    }

    public void loadScene4(){
        audioSource.Play();
        shipMove = true;
        StartCoroutine(LoadScene4WithDelay());
        //SceneManager.LoadScene(4);
        Debug.Log("Loading scene 4...");
    }

    public void loadScene5(){
        audioSource.Play();
        shipMove = true;
        StartCoroutine(LoadScene5WithDelay());
        //SceneManager.LoadScene(5);
        Debug.Log("Loading scene 5...");
    }

    public void loadScene6(){
        audioSource.Play();
        shipMove = true;
        StartCoroutine(LoadScene6WithDelay());
        //SceneManager.LoadScene(5);
        Debug.Log("Loading scene 6...");
    }

    public void loadScene7(){
        audioSource.Play();
        shipMove = true;
        StartCoroutine(LoadScene7WithDelay());
        //SceneManager.LoadScene(5);
        Debug.Log("Loading scene 7...");
    }

    public void loadScene8(){
        audioSource.Play();
        shipMove = true;
        StartCoroutine(LoadScene8WithDelay());
        //SceneManager.LoadScene(5);
        Debug.Log("Loading scene 8...");
    }

    public void loadScene9(){
        audioSource.Play();
        shipMove = true;
        StartCoroutine(LoadScene9WithDelay());
        //SceneManager.LoadScene(5);
        Debug.Log("Loading scene 9...");
    }
    
    IEnumerator LoadScene0WithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(2);
        shipMove = false;
    }

        IEnumerator LoadScene1WithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(1);
        shipMove = false;
    }

        IEnumerator LoadScene2WithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(0);
        shipMove = false;
    }

        IEnumerator LoadScene3WithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(3);
        shipMove = false;
    }

        IEnumerator LoadScene4WithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(4);
        shipMove = false;
    }

    IEnumerator LoadScene5WithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(6);
        shipMove = false;
    }

    IEnumerator LoadScene6WithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(8);
        shipMove = false;
    }

    IEnumerator LoadScene7WithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(7);
        shipMove = false;
    }
    
    IEnumerator LoadScene8WithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(9);
        shipMove = false;
    }

    IEnumerator LoadScene9WithDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(10);
        shipMove = false;
    }

}
