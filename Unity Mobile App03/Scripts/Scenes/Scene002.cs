using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene002 : MonoBehaviour
{
    Color transparentTextColor;

    Image questionImage, fairyImage, answerImage1, answerImage2, answerImage3, answerImage4;
    private Sprite fairyIncorrect,
                   fairyNeutral,
                   fairyCorrect;
    int questionNumber = 0;
    Text answerText1, answerText2, answerText3, answerText4;
    public float timeRemaining = 0;
    bool timerReady, correctAnswer, finished = false;
    int score;
    public Text fairyTalk;

    void Start()
    {
        Application.targetFrameRate = 15;

        transparentTextColor.a = 0.0f;

        AnimalFoodQuestionBank.LoadQuestionList();

        answerText1 = GameObject.Find("Answer1Text").GetComponent<Text>();
        answerText2 = GameObject.Find("Answer2Text").GetComponent<Text>();
        answerText3 = GameObject.Find("Answer3Text").GetComponent<Text>();
        answerText4 = GameObject.Find("Answer4Text").GetComponent<Text>();

        answerImage1 = GameObject.Find("Answer 1").GetComponent<Image>();
        answerImage2 = GameObject.Find("Answer 2").GetComponent<Image>();
        answerImage3 = GameObject.Find("Answer 3").GetComponent<Image>();
        answerImage4 = GameObject.Find("Answer 4").GetComponent<Image>();


        questionImage = GetComponent<Image>();

        fairyImage = GameObject.Find("Fairy").GetComponent<Image>();
        fairyIncorrect = Resources.Load<Sprite>("FairyIncorrect");
        fairyNeutral = Resources.Load<Sprite>("FairyNeutral");
        fairyCorrect = Resources.Load<Sprite>("FairyCorrect");

        timerReady = false;

        fairyTalk = GameObject.Find("FairyTalk").GetComponent<Text>();

        if (!GameControl.scene2Started)
        {
            fairyTalk.text = "Learner, can you help the animal find their food? They will be very thankful if you do ☺.";
            answerText1.text = "Start";
            SimpleSoundManager.playNextLevelSound();
        }
        else
            Answer1();
    }

    public void Answer1()
    {
        if (finished)
        {
            //  SceneManager.LoadScene("Scene002");
        }

        else if (questionNumber == 0)
        {
            answerImage1.type = Image.Type.Simple;
            answerImage2.type = Image.Type.Simple;
            answerImage3.type = Image.Type.Simple;
            answerImage4.type = Image.Type.Simple;

            answerImage1.color = Color.white;
            answerImage2.color = Color.white;
            answerImage3.color = Color.white;
            answerImage4.color = Color.white;

            fairyTalk.fontSize = 76;

            answerText1.color = transparentTextColor;
            fairyTalk.text = AnimalFoodQuestionBank.questions[0].fairyTalk;

            answerImage1.sprite = AnimalFoodQuestionBank.questions[0].answerOptionsSprites[0];
            answerText1.text = AnimalFoodQuestionBank.questions[0].answerOptions[0];
            answerImage2.sprite = AnimalFoodQuestionBank.questions[0].answerOptionsSprites[1];
            answerText2.text = AnimalFoodQuestionBank.questions[0].answerOptions[1];
            answerImage3.sprite = AnimalFoodQuestionBank.questions[0].answerOptionsSprites[2];
            answerText3.text = AnimalFoodQuestionBank.questions[0].answerOptions[2];
            answerImage4.sprite = AnimalFoodQuestionBank.questions[0].answerOptionsSprites[3];
            answerText4.text = AnimalFoodQuestionBank.questions[0].answerOptions[3];

            questionNumber++;
            GameControl.scene2Started = true;
        }
        else
        {
            timeRemaining = 1;

            timerReady = true;

            if (AnimalFoodQuestionBank.questions[questionNumber - 1].answer == answerText1.text)
            {
                correctAnswer = true;
                MarkAsKnown();
            }

            // list
            else if (AnimalFoodQuestionBank.questions[questionNumber - 1].answerList.Contains(answerText1.text))
            {
                correctAnswer = true;
                MarkAsKnown();
            }

            else
            {
                correctAnswer = false;
                SimpleSoundManager.playIncorrectSound();
            }

            AnimalFoodQuestionBank.questions[questionNumber - 1].answered = true;
        }
    }
    public void Answer2()
    {
        if (questionNumber != 0)
        {
            timeRemaining = 1;

            timerReady = true;

            if (AnimalFoodQuestionBank.questions[questionNumber - 1].answer == answerText2.text)
            {
                correctAnswer = true;
                MarkAsKnown();
            }

            // list
            else if (AnimalFoodQuestionBank.questions[questionNumber - 1].answerList.Contains(answerText2.text))
            {
                correctAnswer = true;
                MarkAsKnown();
            }

            else
            {
                correctAnswer = false;
                SimpleSoundManager.playIncorrectSound();
            }

            AnimalFoodQuestionBank.questions[questionNumber - 1].answered = true;
        }
    }
    public void Answer3()
    {
        if (questionNumber != 0)
        {
            timeRemaining = 1;

            timerReady = true;

            if (AnimalFoodQuestionBank.questions[questionNumber - 1].answer == answerText3.text)
            {
                correctAnswer = true;
                MarkAsKnown();
            }

            // list
            else if (AnimalFoodQuestionBank.questions[questionNumber - 1].answerList.Contains(answerText3.text))
            {
                correctAnswer = true;
                MarkAsKnown();
            }

            else
            {
                correctAnswer = false;
                SimpleSoundManager.playIncorrectSound();
            }

            AnimalFoodQuestionBank.questions[questionNumber - 1].answered = true;
        }
    }
    public void Answer4()
    {
        if (questionNumber != 0)
        {
            timeRemaining = 1;

            timerReady = true;

            if (AnimalFoodQuestionBank.questions[questionNumber - 1].answer == answerText4.text)
            {
                correctAnswer = true;
                MarkAsKnown();
            }

            // list
            else if (AnimalFoodQuestionBank.questions[questionNumber - 1].answerList.Contains(answerText4.text))
            {
                correctAnswer = true;
                MarkAsKnown();
            }

            else
            {
                correctAnswer = false;
                SimpleSoundManager.playIncorrectSound();
            }

            AnimalFoodQuestionBank.questions[questionNumber - 1].answered = true;
        }
    }
    void ChangeQuestion()
    {
        if (timerReady == true)
        {

            Debug.Log(AnimalFoodQuestionBank.questions.Count);

            if (correctAnswer == true)
            {
                AnimalFoodQuestionBank.questions.RemoveAt(questionNumber - 1);
            }

            else if (questionNumber < AnimalFoodQuestionBank.questions.Count)
            {
                //questionNumber++;
                AnimalFoodQuestionBank.questions.Add(AnimalFoodQuestionBank.questions[0]);
                AnimalFoodQuestionBank.questions.RemoveAt(0);
            }
            else
                questionNumber = 1;

            if (AnimalFoodQuestionBank.questions.Count > 0)
            {
                fairyTalk.text = AnimalFoodQuestionBank.questions[questionNumber - 1].fairyTalk;
                answerImage1.sprite = AnimalFoodQuestionBank.questions[questionNumber - 1].answerOptionsSprites[0];
                answerText1.text = AnimalFoodQuestionBank.questions[questionNumber - 1].answerOptions[0];
                answerImage2.sprite = AnimalFoodQuestionBank.questions[questionNumber - 1].answerOptionsSprites[1];
                answerText2.text = AnimalFoodQuestionBank.questions[questionNumber - 1].answerOptions[1];
                answerImage3.sprite = AnimalFoodQuestionBank.questions[questionNumber - 1].answerOptionsSprites[2];
                answerText3.text = AnimalFoodQuestionBank.questions[questionNumber - 1].answerOptions[2];
                answerImage4.sprite = AnimalFoodQuestionBank.questions[questionNumber - 1].answerOptionsSprites[3];
                answerText4.text = AnimalFoodQuestionBank.questions[questionNumber - 1].answerOptions[3];
            }
            else
            {
                questionImage.sprite = null;
                fairyTalk.text = "All finished.";
                answerText1.text = "Next";
                answerText2.text = null;
                answerText3.text = null;
                answerText4.text = null;

                finished = true;
            }
        }
    }

    public void MarkAsKnown()
    {
        //AnimalNamesQuestionBank.questions[questionNumber - 1].known = true;

        if (AnimalFoodQuestionBank.questions[questionNumber - 1].number == 1)
        {
            GameControl.animalFood001known = true;
        }
        else if (AnimalFoodQuestionBank.questions[questionNumber - 1].number == 2)
        {
            GameControl.animalFood002known = true;
        }
        else if (AnimalFoodQuestionBank.questions[questionNumber - 1].number == 3)
        {
            GameControl.animalFood003known = true;
        }
        if (AnimalFoodQuestionBank.questions[questionNumber - 1].number == 4)
        {
            GameControl.animalFood004known = true;
        }
        else if (AnimalFoodQuestionBank.questions[questionNumber - 1].number == 5)
        {
            GameControl.animalFood005known = true;
        }
        else if (AnimalFoodQuestionBank.questions[questionNumber - 1].number == 6)
        {
            GameControl.animalFood006known = true;
        }
        if (AnimalFoodQuestionBank.questions[questionNumber - 1].number == 7)
        {
            GameControl.animalFood007known = true;
        }

    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (correctAnswer)
                fairyImage.sprite = fairyCorrect;
            else
                fairyImage.sprite = fairyIncorrect;
        }
        else
        {
            fairyImage.sprite = fairyNeutral;
            ChangeQuestion();
            timerReady = false;
        }

    }
}
