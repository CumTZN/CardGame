using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardDisplay : MonoBehaviour
{
    public Card1 card1;

    public Text nameText;
    public Text descriptionText;

    public Image artworkImage;

    public Text manaText;
    public Text attackText;
    public Text health;

    void Start()
    {
        nameText.text = card1.name;
        descriptionText.text = card1.description;

        artworkImage.sprite = card1.artwork;

        manaText.text = card1.manaCost.ToString();
        attackText.text = Card1.attack.ToString();
        health.text = card1.health.ToString();

    }

}