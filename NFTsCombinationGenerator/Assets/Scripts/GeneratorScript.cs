using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class GeneratorScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI numberOfNFTs;
    [SerializeField]
    private List<Sprite> planets;
    [SerializeField]
    private List<Sprite> moons;
    [SerializeField]
    private List<Sprite> rings;
    [SerializeField]
    private List<Sprite> cards;
    [SerializeField]
    private List<Sprite> words;

    private FileInfo[] fileInfo;

    void Start()
    {
        LoadPlanets();
        LoadRings();
        LoadMoons();
        LoadCards();
        LoadWords();
    }

    void Update()
    {
        
    }

    void LoadPlanets()
    {
        var info = new DirectoryInfo("Assets/Resources/Planets");
        fileInfo = info.GetFiles();

        for (int i = 0; i < fileInfo.Length / 2; i++)
        {
            planets.Add(Resources.Load<Sprite>("Planets/" + i.ToString()));
        }
    }

    void LoadRings()
    {
        var info = new DirectoryInfo("Assets/Resources/Rings");
        fileInfo = info.GetFiles();

        for (int i = 0; i < fileInfo.Length / 2; i++)
        {
            rings.Add(Resources.Load<Sprite>("Rings/" + i.ToString()));
        }
    }

    void LoadMoons()
    {
        var info = new DirectoryInfo("Assets/Resources/Moons");
        fileInfo = info.GetFiles();

        for (int i = 0; i < fileInfo.Length / 2; i++)
        {
            moons.Add(Resources.Load<Sprite>("Moons/" + i.ToString()));
        }
    }

    void LoadCards()
    {
        var info = new DirectoryInfo("Assets/Resources/Cards");
        fileInfo = info.GetFiles();

        for (int i = 0; i < fileInfo.Length / 2; i++)
        {
            cards.Add(Resources.Load<Sprite>("Cards/" + i.ToString()));
        }
    }

    void LoadWords()
    {
        var info = new DirectoryInfo("Assets/Resources/Words");
        fileInfo = info.GetFiles();

        for (int i = 0; i < fileInfo.Length / 2; i++)
        {
            words.Add(Resources.Load<Sprite>("Words/" + i.ToString()));
        }
    }
}
