using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Location : MonoBehaviour
{

    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private Animator anim;

    public Sprite symbol;
    public string locationName;

    [SerializeField]
    private Image image;

    [SerializeField]
    private TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        canvas.worldCamera = Camera.main;
        text.text = locationName;
        image.sprite = symbol;
    }

    public void Reveal()
    {
        anim.SetTrigger("Reveal");
        Debug.Log("CLick su " + this.gameObject.name);
    }

    public void Hide()
    {
        anim.SetTrigger("Hide");
    }
}
