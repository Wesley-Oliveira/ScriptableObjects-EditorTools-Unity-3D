using System;
using UnityEngine;

[Serializable]
public class Card
{
    public int cardId;
    public int manaCost;
    public int healthCost;
    public string cardName;
    public string cardDescription;
    public Rarity cardRarity;
    public Sprite cardSprite;

    public Card Copy()
    {
        Card card = new Card();
        card.cardId = cardId;
        card.manaCost = manaCost;
        card.healthCost = healthCost;
        card.cardName = cardName;
        card.cardDescription = cardDescription;
        card.cardRarity = cardRarity;
        card.cardSprite = cardSprite;
        return card;
    }
}

public enum Rarity
{
    Basic,
    Common,
    Rare,
    Epic,
    Legendary
}
