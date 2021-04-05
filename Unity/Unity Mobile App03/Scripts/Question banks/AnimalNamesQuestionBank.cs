using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AnimalNamesQuestionBank : SimpleQuestion
{
    public static List<SimpleQuestion> questions = new List<SimpleQuestion>();
    public static SimpleQuestion animalName001 = new SimpleQuestion();
    public static SimpleQuestion animalName002 = new SimpleQuestion();
    public static SimpleQuestion animalName003 = new SimpleQuestion();
    public static SimpleQuestion animalName004 = new SimpleQuestion();
    public static SimpleQuestion animalName005 = new SimpleQuestion();
    public static SimpleQuestion animalName006 = new SimpleQuestion();
    public static SimpleQuestion animalName007 = new SimpleQuestion();
    public static SimpleQuestion animalName008 = new SimpleQuestion();
    public static SimpleQuestion animalName009 = new SimpleQuestion();
    public static SimpleQuestion animalName010 = new SimpleQuestion();
    public static SimpleQuestion animalName011 = new SimpleQuestion();
    public static SimpleQuestion animalName012 = new SimpleQuestion();
    public static SimpleQuestion animalName013 = new SimpleQuestion();
    public static SimpleQuestion animalName014 = new SimpleQuestion();
    public static SimpleQuestion animalName015 = new SimpleQuestion();
    public static SimpleQuestion animalName016 = new SimpleQuestion();
    public static SimpleQuestion animalName017 = new SimpleQuestion();
    public static SimpleQuestion animalName018 = new SimpleQuestion();
    public static SimpleQuestion animalName019 = new SimpleQuestion();
    public static SimpleQuestion animalName020 = new SimpleQuestion();
    public static SimpleQuestion animalName021 = new SimpleQuestion();
    public static SimpleQuestion animalName022 = new SimpleQuestion();
    public static SimpleQuestion animalName023 = new SimpleQuestion();
    public static SimpleQuestion animalName024 = new SimpleQuestion();
    public static SimpleQuestion animalName025 = new SimpleQuestion();
    public static SimpleQuestion animalName026 = new SimpleQuestion();
    public static SimpleQuestion animalName027 = new SimpleQuestion();
    public static SimpleQuestion animalName028 = new SimpleQuestion();
    public static SimpleQuestion animalName029 = new SimpleQuestion();
    public static SimpleQuestion animalName030 = new SimpleQuestion();
    public static SimpleQuestion animalName031 = new SimpleQuestion();
    public static SimpleQuestion animalName032 = new SimpleQuestion();

    void Start()
    {
        animalName001 = new SimpleQuestion()
        {
            number = 1,
            questionName = "cat",
            sprite = Resources.Load<Sprite>("Questions/Animals/Cat"),
            answerOptions = new List<string>()
        {
            "bear",
            "dog",
            "cat",
            "horse"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName002 = new SimpleQuestion()
        {
            number = 2,
            questionName = "dog",
            sprite = Resources.Load<Sprite>("Questions/Animals/Dog"),
            answerOptions = new List<string>()
        {
            "mouse",
            "cat",
            "duck",
            "dog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName003 = new SimpleQuestion()
        {
            number = 3,
            questionName = "horse",
            sprite = Resources.Load<Sprite>("Questions/Animals/Horse"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName004 = new SimpleQuestion()
        {
            number = 4,
            questionName = "bear",
            sprite = Resources.Load<Sprite>("Questions/Animals/Bear"),
            answerOptions = new List<string>()
        {
            "bear",
            "horse",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName005 = new SimpleQuestion()
        {
            number = 5,
            questionName = "wolf",
            sprite = Resources.Load<Sprite>("Questions/Animals/Wolf"),
            answerOptions = new List<string>()
        {
            "cat",
            "wolf",
            "mouse",
            "ant"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName006 = new SimpleQuestion()
        {
            number = 6,
            questionName = "zebra",
            sprite = Resources.Load<Sprite>("Questions/Animals/Zebra"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "mouse",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName007 = new SimpleQuestion()
        {
            number = 7,
            questionName = "owl",
            sprite = Resources.Load<Sprite>("Questions/Animals/Owl"),
            answerOptions = new List<string>()
        {
            "dog",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName008 = new SimpleQuestion()
        {
            number = 8,
            questionName = "monkey",
            sprite = Resources.Load<Sprite>("Questions/Animals/Monkey"),
            answerOptions = new List<string>()
        {
            "monkey",
            "horse",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName009 = new SimpleQuestion()
        {
            number = 9,
            questionName = "parrot",
            sprite = Resources.Load<Sprite>("Questions/Animals/Parrot"),
            answerOptions = new List<string>()
        {
            "monkey",
            "parrot",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName010 = new SimpleQuestion()
        {
            number = 10,
            questionName = "giraffe",
            sprite = Resources.Load<Sprite>("Questions/Animals/Giraffe"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "owl",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName011 = new SimpleQuestion()
        {
            number = 11,
            questionName = "lion",
            sprite = Resources.Load<Sprite>("Questions/Animals/Lion"),
            answerOptions = new List<string>()
        {
            "giraffe",
            "parrot",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName012 = new SimpleQuestion()
        {
            number = 12,
            questionName = "crocodile",
            sprite = Resources.Load<Sprite>("Questions/Animals/Crocodile"),
            answerOptions = new List<string>()
        {
            "crocodile",
            "parrot",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName013 = new SimpleQuestion()
        {
            number = 13,
            questionName = "cow",
            sprite = Resources.Load<Sprite>("Questions/Animals/Cow"),
            answerOptions = new List<string>()
        {
            "cow",
            "parrot",
            "lion",
            "zebra"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName014 = new SimpleQuestion()
        {
            number = 14,
            questionName = "duck",
            sprite = Resources.Load<Sprite>("Questions/Animals/Duck"),
            answerOptions = new List<string>()
        {
            "cow",
            "parrot",
            "lion",
            "duck"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName015 = new SimpleQuestion()
        {
            number = 15,
            questionName = "pig",
            sprite = Resources.Load<Sprite>("Questions/Animals/Pig"),
            answerOptions = new List<string>()
        {
            "cow",
            "parrot",
            "pig",
            "duck"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName016 = new SimpleQuestion()
        {
            number = 16,
            questionName = "donkey",
            sprite = Resources.Load<Sprite>("Questions/Animals/Donkey"),
            answerOptions = new List<string>()
        {
            "cow",
            "parrot",
            "pig",
            "donkey"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName017 = new SimpleQuestion()
        {
            number = 17,
            questionName = "rabbit",
            sprite = Resources.Load<Sprite>("Questions/Animals/Rabbit"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "donkey"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName018 = new SimpleQuestion()
        {
            number = 18,
            questionName = "frog",
            sprite = Resources.Load<Sprite>("Questions/Animals/Frog"),
            answerOptions = new List<string>()
        {
            "rabbit",
            "parrot",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName019 = new SimpleQuestion()
        {
            number = 19,
            questionName = "tiger",
            sprite = Resources.Load<Sprite>("Questions/Animals/Tiger"),
            answerOptions = new List<string>()
        {
            "tiger",
            "parrot",
            "pig",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName020 = new SimpleQuestion()
        {
            number = 20,
            questionName = "goat",
            sprite = Resources.Load<Sprite>("Questions/Animals/Goat"),
            answerOptions = new List<string>()
        {
            "tiger",
            "parrot",
            "goat",
            "frog"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName021 = new SimpleQuestion()
        {
            number = 21,
            questionName = "chicken",
            sprite = Resources.Load<Sprite>("Questions/Animals/Chicken"),
            answerOptions = new List<string>()
        {
            "tiger",
            "parrot",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName022 = new SimpleQuestion()
        {
            number = 22,
            questionName = "elephant",
            sprite = Resources.Load<Sprite>("Questions/Animals/Elephant"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "chicken"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName023 = new SimpleQuestion()
        {
            number = 23,
            questionName = "lizard",
            sprite = Resources.Load<Sprite>("Questions/Animals/Lizard"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "goat",
            "lizard"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName024 = new SimpleQuestion()
        {
            number = 24,
            questionName = "bat",
            sprite = Resources.Load<Sprite>("Questions/Animals/Bat"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "bat",
            "lizard"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName025 = new SimpleQuestion()
        {
            number = 25,
            questionName = "eagle",
            sprite = Resources.Load<Sprite>("Questions/Animals/Eagle"),
            answerOptions = new List<string>()
        {
            "tiger",
            "elephant",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName026 = new SimpleQuestion()
        {
            number = 26,
            questionName = "kangaroo",
            sprite = Resources.Load<Sprite>("Questions/Animals/Kangaroo"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "elephant",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName027 = new SimpleQuestion()
        {
            number = 27,
            questionName = "panda",
            sprite = Resources.Load<Sprite>("Questions/Animals/Panda"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "eagle"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName028 = new SimpleQuestion()
        {
            number = 28,
            questionName = "penguin",
            sprite = Resources.Load<Sprite>("Questions/Animals/Penguin"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "penguin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName029 = new SimpleQuestion()
        {
            number = 29,
            questionName = "sheep",
            sprite = Resources.Load<Sprite>("Questions/Animals/Sheep"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "bat",
            "sheep"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName030 = new SimpleQuestion()
        {
            number = 30,
            questionName = "snake",
            sprite = Resources.Load<Sprite>("Questions/Animals/Snake"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "snake",
            "penguin"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName031 = new SimpleQuestion()
        {
            number = 31,
            questionName = "swan",
            sprite = Resources.Load<Sprite>("Questions/Animals/Swan"),
            answerOptions = new List<string>()
        {
            "kangaroo",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };

        animalName032 = new SimpleQuestion()
        {
            number = 32,
            questionName = "tortoise",
            sprite = Resources.Load<Sprite>("Questions/Animals/Tortoise"),
            answerOptions = new List<string>()
        {
            "tortoise",
            "panda",
            "swan",
            "sheep"
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1
        };
    }

    public static void LoadQuestionList()
    {
        if (GameControl.animalName001known == false)
            questions.Add(animalName001);

        if (!GameControl.animalName002known)
            questions.Add(animalName002);

        if (!GameControl.animalName003known)
            questions.Add(animalName003);

        if (!GameControl.animalName004known)
            questions.Add(animalName004);

        if (!GameControl.animalName005known)
            questions.Add(animalName005);

        if (!GameControl.animalName006known)
            questions.Add(animalName006);

        if (!GameControl.animalName007known)
            questions.Add(animalName007);

        if (!GameControl.animalName008known)
            questions.Add(animalName008);

        if (!GameControl.animalName009known)
            questions.Add(animalName009);

        if (!GameControl.animalName010known)
            questions.Add(animalName010);

        if (!GameControl.animalName011known)
            questions.Add(animalName011);

        if (!GameControl.animalName012known)
            questions.Add(animalName012);

        if (!GameControl.animalName013known)
            questions.Add(animalName013);

        if (!GameControl.animalName014known)
            questions.Add(animalName014);

        if (!GameControl.animalName015known)
            questions.Add(animalName015);

        if (!GameControl.animalName016known)
            questions.Add(animalName016);

        if (!GameControl.animalName017known)
            questions.Add(animalName017);

        if (!GameControl.animalName018known)
            questions.Add(animalName018);

        if (!GameControl.animalName019known)
            questions.Add(animalName019);

        if (!GameControl.animalName020known)
            questions.Add(animalName020);

        if (!GameControl.animalName021known)
            questions.Add(animalName021);

        if (!GameControl.animalName022known)
            questions.Add(animalName022);

        if (!GameControl.animalName023known)
            questions.Add(animalName023);

        if (!GameControl.animalName024known)
            questions.Add(animalName024);

        if (!GameControl.animalName025known)
            questions.Add(animalName025);

        if (!GameControl.animalName026known)
            questions.Add(animalName026);

        if (!GameControl.animalName027known)
            questions.Add(animalName027);

        if (!GameControl.animalName028known)
            questions.Add(animalName028);

        if (!GameControl.animalName029known)
            questions.Add(animalName029);

        if (!GameControl.animalName030known)
            questions.Add(animalName030);

        if (!GameControl.animalName031known)
            questions.Add(animalName031);

        if (!GameControl.animalName032known)
            questions.Add(animalName032);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        Debug.Log(questions.Count);
    }
}

