using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyButton : MonoBehaviour
{
    public string key;
    public bool isCorrect;
    Image bgImage;
    // Start is called before the first frame update
    void Start()
    {
        bgImage = GetComponent<Image>();
    }

    public void SetColor(Color color,bool correct = false)
    {
        if (isCorrect)
            return;
        isCorrect = correct;
        bgImage.color = color;
    }

}
