using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardLoader : MonoBehaviour
{
    public Image cardImage;
    public Text manaCost;
    public Text healthCost;
    public Text cardTitle;
    public Text cardDescription;
    public Card cardInfo;

    public string cardNameIdentity;
    public Image rarityImage;
    public Color basicColor, commonColor, rareColor, epicColor, legendaryColor;

    void Start()
    {
        LoadCard(cardNameIdentity);
    }

    public void LoadCard(string cardName)
    {
        var cardSO = Resources.Load<CardScriptableObject>("Cards/" + cardName);
        cardInfo = cardSO.card.Copy();

        cardImage.sprite = cardInfo.cardSprite;
        manaCost.text = cardInfo.manaCost.ToString();
        healthCost.text = cardInfo.healthCost.ToString();
        cardTitle.text = cardInfo.cardName;
        cardDescription.text = cardInfo.cardDescription;

        switch(cardInfo.cardRarity)
        {
            case Rarity.Basic:
                rarityImage.color = basicColor;
                break;
            case Rarity.Common:
                rarityImage.color = commonColor;
                break;
            case Rarity.Rare:
                rarityImage.color = rareColor;
                break;
            case Rarity.Epic:
                rarityImage.color = epicColor;
                break;
            case Rarity.Legendary:
                rarityImage.color = legendaryColor;
                break;
        }
    }
}
