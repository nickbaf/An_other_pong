using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreController : MonoBehaviour
{
    private int scoreP1 = 0;
    private int scoreP2 = 0;

    public GameObject textP1;
    public GameObject textP2;

    public int gtW;

    // Update is called once per frame
    void Update()
    {
        if(this.scoreP1>=this.gtW || this.scoreP2 >= this.gtW)
        {
            Debug.Log("Won");
            SceneManager.LoadScene("GameOver");
        }
    }


    public void GoalP1()
    {
        this.scoreP1++;
    }


    public void GoalP2()
    {
        this.scoreP2++;
    }

    private void FixedUpdate()
    {
        Text uiScoreP1 = this.textP1.GetComponent<Text>();
        uiScoreP1.text = this.scoreP1.ToString();


        Text uiScoreP2 = this.textP1.GetComponent<Text>();
        uiScoreP2.text = this.scoreP2.ToString();
    }
}
