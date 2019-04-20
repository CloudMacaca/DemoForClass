using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroUI : MonoBehaviour {

    [Header("請將卡片資料置於以下欄位")]
    [SerializeField]
    Card card;

    [Space]
    [SerializeField]
    Image heroImage;
    [SerializeField]
    Text heroNameText;
    [SerializeField]
    Text heroATKText;
    [SerializeField]
    Text heroHPText;
    [SerializeField]
    Image[] rankStars;

    public void SetHeroUI(Sprite image,string heroName,int ATK,int HP,int rank)
    {
        heroImage.sprite = image;
        heroNameText.text = heroName;
        heroATKText.text = ATK.ToString();
        heroHPText.text = HP.ToString();
        SetRankView(rank);
    }

    public void SetRankView(int rank)
    {
        for (int i = 0; i < rankStars.Length; i++)
        {
            bool isShow = i < rank;
            rankStars[i].enabled = isShow;
        }
    }

    private void Update()
    {
        if (card != null)
            SetHeroUI(card.cardImage, card.cardName, card.attack, card.health, card.rare);
    }
}
