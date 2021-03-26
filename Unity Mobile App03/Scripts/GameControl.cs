using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    public static string currentSceneName;
    public static bool scene1Started, scene2Started;

    public string playerName;
    public static bool
                        animalName001known,
                        animalName002known,
                        animalName003known,
                        animalName004known,
                        animalName005known,
                        animalName006known,
                        animalName007known,
                        animalName008known,
                        animalName009known,
                        animalName010known,
                        animalName011known,
                        animalName012known,
                        animalName013known,
                        animalName014known,
                        animalName015known,
                        animalName016known,
                        animalName017known,
                        animalName018known,
                        animalName019known,
                        animalName020known,
                        animalName021known,
                        animalName022known,
                        animalName023known,
                        animalName024known,
                        animalName025known,
                        animalName026known,
                        animalName027known,
                        animalName028known,
                        animalName029known,
                        animalName030known,
                        animalName031known,
                        animalName032known,

                        animalFood001known,
                        animalFood002known,
                        animalFood003known,
                        animalFood004known,
                        animalFood005known,
                        animalFood006known,
                        animalFood007known;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    public void Save()
    {
        Debug.Log("saving");

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.playerName = playerName;
        data.scene1Started = scene1Started;
        data.scene2Started = scene2Started;
        data.animalName001known = animalName001known;
        data.animalName002known = animalName002known;
        data.animalName003known = animalName003known;
        data.animalName004known = animalName004known;
        data.animalName005known = animalName005known;
        data.animalName006known = animalName006known;
        data.animalName007known = animalName007known;
        data.animalName008known = animalName008known;
        data.animalName009known = animalName009known;
        data.animalName010known = animalName010known;
        data.animalName011known = animalName011known;
        data.animalName012known = animalName012known;
        data.animalName013known = animalName013known;
        data.animalName014known = animalName014known;
        data.animalName015known = animalName015known;
        data.animalName016known = animalName016known;
        data.animalName017known = animalName017known;
        data.animalName018known = animalName018known;
        data.animalName019known = animalName019known;
        data.animalName020known = animalName020known;
        data.animalName021known = animalName021known;
        data.animalName022known = animalName022known;
        data.animalName023known = animalName023known;
        data.animalName024known = animalName024known;
        data.animalName025known = animalName025known;
        data.animalName026known = animalName026known;
        data.animalName027known = animalName027known;
        data.animalName028known = animalName028known;
        data.animalName029known = animalName029known;
        data.animalName030known = animalName030known;
        data.animalName031known = animalName031known;
        data.animalName032known = animalName032known;

        data.animalFood001known = animalFood001known;
        data.animalFood002known = animalFood002known;
        data.animalFood003known = animalFood003known;
        data.animalFood004known = animalFood004known;
        data.animalFood005known = animalFood005known;
        data.animalFood006known = animalFood006known;
        data.animalFood007known = animalFood007known;


        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            playerName = data.playerName;
            scene1Started = data.scene1Started;
            scene2Started = data.scene2Started;

            animalName001known = data.animalName001known;
            animalName002known = data.animalName002known;
            animalName003known = data.animalName003known;
            animalName004known = data.animalName004known;
            animalName005known = data.animalName005known;
            animalName006known = data.animalName006known;
            animalName007known = data.animalName007known;
            animalName008known = data.animalName008known;
            animalName009known = data.animalName009known;
            animalName010known = data.animalName010known;
            animalName011known = data.animalName011known;
            animalName012known = data.animalName012known;
            animalName013known = data.animalName013known;
            animalName014known = data.animalName014known;
            animalName015known = data.animalName015known;
            animalName016known = data.animalName016known;
            animalName017known = data.animalName017known;
            animalName018known = data.animalName018known;
            animalName019known = data.animalName019known;
            animalName020known = data.animalName020known;
            animalName021known = data.animalName021known;
            animalName022known = data.animalName022known;
            animalName023known = data.animalName023known;
            animalName024known = data.animalName024known;
            animalName025known = data.animalName025known;
            animalName026known = data.animalName026known;
            animalName027known = data.animalName027known;
            animalName028known = data.animalName028known;
            animalName029known = data.animalName029known;
            animalName030known = data.animalName030known;
            animalName031known = data.animalName031known;
            animalName032known = data.animalName032known;

            animalFood001known = data.animalFood001known;
            animalFood002known = data.animalFood002known;
            animalFood003known = data.animalFood003known;
            animalFood004known = data.animalFood004known;
            animalFood005known = data.animalFood005known;
            animalFood006known = data.animalFood006known;
            animalFood007known = data.animalFood007known;
        }
    }

    public static void SavePreviousSceneName()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }
}

[Serializable]
class PlayerData
{
    public string playerName;
    public bool scene1Started;
    public bool scene2Started;
    public bool animalName001known;
    public bool animalName002known;
    public bool animalName003known;
    public bool animalName004known;
    public bool animalName005known;
    public bool animalName006known;
    public bool animalName007known;
    public bool animalName008known;
    public bool animalName009known;
    public bool animalName010known;
    public bool animalName011known;
    public bool animalName012known;
    public bool animalName013known;
    public bool animalName014known;
    public bool animalName015known;
    public bool animalName016known;
    public bool animalName017known;
    public bool animalName018known;
    public bool animalName019known;
    public bool animalName020known;
    public bool animalName021known;
    public bool animalName022known;
    public bool animalName023known;
    public bool animalName024known;
    public bool animalName025known;
    public bool animalName026known;
    public bool animalName027known;
    public bool animalName028known;
    public bool animalName029known;
    public bool animalName030known;
    public bool animalName031known;
    public bool animalName032known;

    public bool animalFood001known;
    public bool animalFood002known;
    public bool animalFood003known;
    public bool animalFood004known;
    public bool animalFood005known;
    public bool animalFood006known;
    public bool animalFood007known;

}

