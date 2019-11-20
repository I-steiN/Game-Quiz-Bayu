using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    public string [] Question, Answer;
    public Text text_Question, text_Score;
    public InputField input_Answer;
    public GameObject Feed_Right, Feed_False, Done, Question_Spot;
    int urutan_soal = -1, Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        tampil_soal ();   
    }

    void tampil_soal ()
    {
        urutan_soal ++;
        text_Question.text = Question [urutan_soal];
    }

    public void answer () 
    {
        if (urutan_soal < Question.Length - 1)
        {
        if (input_Answer.text == Answer [urutan_soal])
        {
            Feed_Right.SetActive (false);
            Feed_Right.SetActive (true);
            Feed_False.SetActive (false);
            Score += 20;
    } else {
            Feed_Right.SetActive (false);
            Feed_False.SetActive (false);
            Feed_False.SetActive (true);
            }
            input_Answer.text = "";
            tampil_soal ();
        } else {
          if (input_Answer.text == Answer [urutan_soal])
          {
              Score += 20;
          }  
            Done.SetActive (true);
            Question_Spot.SetActive (false);
        }  
    }
        // Update is called once per frame
    void Update()
    {
        text_Score.text = Score.ToString ();  
    }
}
