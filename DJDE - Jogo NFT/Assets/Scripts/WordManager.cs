using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Word
{
    public Text[] letters;
    public Image[] letterBg;
}

public class WordManager : MonoBehaviour
{
    public string[] wordList;
    public int tentativa;
    public string chosenWord;
    public Word[] words;
    public Color wrongColor, rightColor, yellow;
    KeyButton[] keyButtons;
    int letterIndex;
    int wordIndex;
    // Start is called before the first frame update
    void Start()
    {
        chosenWord = wordList[Random.Range(0,wordList.Length)];
        keyButtons = FindObjectsOfType<KeyButton>();
    }


    public void SetLetter(string letter)
    {
        if(letterIndex > 4)
        {
            return;
        }
        words[wordIndex].letters[letterIndex].text = letter;
        letterIndex++;
    }


    public void BackSpace()
    {
        if(letterIndex == 0)
        {
            return;
        }

        letterIndex--;
        words[wordIndex].letters[letterIndex].text = "";
    }


  public void Enter()
{
    if (letterIndex <= 4)
        return;
    
    string newWord = chosenWord;
    char[] newWordArray = newWord.ToCharArray();

    List<int> rightLetters = new List<int>();
    for(int i = 0; i < 5; i++)
    {
        if(words[wordIndex].letters[i].text==chosenWord[i].ToString())
        {
            words[wordIndex].letterBg[i].color = rightColor;
            newWordArray[i] = ' ';
            rightLetters.Add(i);
            SetKeyColor(words[wordIndex].letters[i].text,rightColor,true);
        }
    }

    newWord = new string(newWordArray);
    bool wordIsCorrect = true;
    for(int i = 0; i < 5; i++)
    {
        if(!rightLetters.Contains(i))
        {
            if(newWord.Contains(words[wordIndex].letters[i].text))
            {
                words[wordIndex].letterBg[i].color = yellow;
                SetKeyColor(words[wordIndex].letters[i].text,yellow);
                wordIsCorrect = false;
            }
            else
            {
                words[wordIndex].letterBg[i].color = wrongColor;
                SetKeyColor(words[wordIndex].letters[i].text,wrongColor);
                wordIsCorrect = false;
            }
        }
    }

    if (wordIsCorrect)
    {
        Debug.Log("Você acertou a palavra!");
    }
    else
    {
        tentativa +=1;
        Debug.Log("tentativa numero:"+tentativa+"de 6");
        Debug.Log("Você errou a palavra!");
        if(tentativa ==6){
            Debug.Log("Perdeu!");
            
        }
    }

    wordIndex++;
    letterIndex = 0;
}



    void SetKeyColor(string letter,Color color, bool correct = false)
    {
        for(int i=0; i < keyButtons.Length;i++)
        {
            if(keyButtons[i].key == letter)
            {
                keyButtons[i].SetColor(color,correct);
                break;
            }
        }
    }

}
