using UnityEngine;
using System.Collections;
using TMPro;

public class ButtonCanvas : MonoBehaviour
{
    public GameObject cubePrefab;

    public void GetMoreCubes()
    {
        StartCoroutine(NextCubeFly());
        // instantiate 3 cubes with an interval of 3 sec
    }

    IEnumerator NextCubeFly()
    {
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
    }

    public void GameStart()
    {
        StartCoroutine(CubeFly());
        // instantiate cubes with an interval of 3 sec, from 1 to 3 each time
    }

    IEnumerator CubeFly()
    {
        //game start
        GameObject.Find("CountDown Animation").GetComponent<Animator>().SetTrigger("Play");
        FindObjectOfType<AudioManager>().Play("Count Down");

        // starting level 1
        GameObject.Find("Level Text").GetComponent<TextMeshProUGUI>().text = "LEVEL 1";
        yield return new WaitForSeconds(3);
        // one by one, 5 times
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);

        // starting level 2
        GameObject.Find("Level Text").GetComponent<TextMeshProUGUI>().text = "LEVEL 2";
        yield return new WaitForSeconds(2);
        GameObject.Find("CountDown Animation").GetComponent<Animator>().SetTrigger("Next");
        yield return new WaitForSeconds(3);
        // 2 by 2, 5 times
        Instantiate(cubePrefab);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        Instantiate(cubePrefab);

        // starting level 3
        GameObject.Find("Level Text").GetComponent<TextMeshProUGUI>().text = "LEVEL 3";
        yield return new WaitForSeconds(2);
        GameObject.Find("CountDown Animation").GetComponent<Animator>().SetTrigger("Next");
        yield return new WaitForSeconds(3);
        // 3 by 3, each with 1s interval, 5 times
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(1);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(1);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(1);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(1);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(1);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(1);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(1);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(1);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(1);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(1);
        Instantiate(cubePrefab);

        // starting level 4
        GameObject.Find("Level Text").GetComponent<TextMeshProUGUI>().text = "LEVEL 4";
        yield return new WaitForSeconds(2);
        GameObject.Find("CountDown Animation").GetComponent<Animator>().SetTrigger("Next");
        yield return new WaitForSeconds(3);
        // 3 by 3, each with 0.5s interval, 5 times
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.5f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.5f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.5f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.5f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.5f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.5f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.5f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.5f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.5f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.5f);
        Instantiate(cubePrefab);

        // starting level 5
        GameObject.Find("Level Text").GetComponent<TextMeshProUGUI>().text = "LEVEL 5";
        yield return new WaitForSeconds(2);
        GameObject.Find("CountDown Animation").GetComponent<Animator>().SetTrigger("Next");
        yield return new WaitForSeconds(3);
        // 3 by 3, each with 0.1s interval, 5 times
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.1f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.1f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.1f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.1f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.1f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.1f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.1f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.1f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(3);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.1f);
        Instantiate(cubePrefab);
        yield return new WaitForSeconds(0.1f);
        Instantiate(cubePrefab);

        // game finished, calculate Score
        yield return new WaitForSeconds(3);
        GameObject.Find("Firework Particle").gameObject.GetComponent<ParticleSystem>().Play();
        FindObjectOfType<AudioManager>().Play("Firework");
        GameObject.Find("CountDown Animation").GetComponent<Animator>().SetTrigger("End");
        // int score = FindObjectOfType<ScoreCanvas>().Score;
        GameObject.Find("CountDown Canvas").transform.Find("GameEnd").GetComponent<TextMeshProUGUI>().text = "GREAT!!";
        yield return new WaitForSeconds(5f);
        FindObjectOfType<ScoreCanvas>().Score = 0; // reset score
        //FindObjectOfType<ScoreCanvas>().UpdateScore();
    }

    void Start()
    {
        GameObject.Find("Firework Particle").gameObject.GetComponent<ParticleSystem>().Stop();
    }
}
