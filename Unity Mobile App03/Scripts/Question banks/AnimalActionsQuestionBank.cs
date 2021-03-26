using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimalActionsQuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion animalActions001 = new SimpleQuestion();
    public static SimpleQuestion animalActions002 = new SimpleQuestion();
    public static SimpleQuestion animalActions003 = new SimpleQuestion();
    public static SimpleQuestion animalActions004 = new SimpleQuestion();
    public static SimpleQuestion animalActions005 = new SimpleQuestion();
    public static SimpleQuestion animalActions006 = new SimpleQuestion();
    public static SimpleQuestion animalActions007 = new SimpleQuestion();
    public static SimpleQuestion animalActions008 = new SimpleQuestion();
    public static SimpleQuestion animalActions009 = new SimpleQuestion();

    void Start()
    {
        animalActions001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "shark",
            fairyTalk = "A shark",
            answer = "swims",
            answerOptions = new List<string>()
            {
                "swims",
                "runs",
                "jumps",
                null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };

        animalActions002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "parrot",
            fairyTalk = "A parrot can",
            answer = "fly",
            answerOptions = new List<string>()
            {
                "jump",
                "fly",
                "hop",
               null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };

        animalActions003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "walk",
            fairyTalk = "Who walks?",
            answer = "tortoise",
            answerOptions = new List<string>()
            {
                "tortoise",
                "lizard",
                "mouse",
               null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };


        // tortoise joke



        animalActions004 = new SimpleQuestion()
        {
            number = 4,
            questionName = "penguin",
            fairyTalk = "I am a bird, but I can not",
            answer = "fly",
            answerOptions = new List<string>()
            {
                "fly",
                "run",
                null,
               null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };


        animalActions006 = new SimpleQuestion()
        {
            number = 6,
            questionName = "hop",
            fairyTalk = "Who hops?",
            answer = "rabbit",
            answerOptions = new List<string>()
            {
                "rabbit",
                "snail",
                "ant",
               null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };


        animalActions007 = new SimpleQuestion()
        {
            number = 7,
            questionName = "kangaroo",
            fairyTalk = "I am a kangaroo. I can",
            answer = "jump",
            answerOptions = new List<string>()
            {
                "run",
                "swim",
                "jump",
               null
            },
            tags = new List<string>()
            {
            "animals", "actions", "verbs"
            },
            size = 1
        };

        // kangaroo joke

        // Fairy talk: "Fairy: now you have to choose two correct answers."


    }

    public static void LoadQuestionList()
    {
        questions.Add(animalActions001);

        //questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    }
}