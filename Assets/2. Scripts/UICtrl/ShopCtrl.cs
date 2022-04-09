using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class ShopCtrl : MonoBehaviour
{
    public bool isShop = true;
    private Items item;

    MoneyCtrl moneyCtrl;

    [HideInInspector]
    public Object cactus;
    private bool isCactusSoldOut;
    Image cactusImg;
    Text costCactusText, soldOutCactusText;

    [HideInInspector]
    public Object armchair;
    private bool isArmchairSoldOut;
    Image ArmchairImg;
    Text costArmchairText, soldOutArmchairText;
    
    [HideInInspector]
    public Object book;
    private bool isBookSoldOut;
    Image BookImg;
    Text costBookText, soldOutBookText;
    
    [HideInInspector]
    public Object Cup;
    private bool isCupSoldOut;
    Image CupImg;
    Text costCupText, soldOutCupText;
    
    [HideInInspector]
    public Object Grass;
    private bool isGrassSoldOut;
    Image GrassImg;
    Text costGrassText, soldOutGrassText;
    
    [HideInInspector]
    public Object Tree;
    private bool isTreeSoldOut;
    Image TreeImg;
    Text costTreeText, soldOutTreeText;
    
    [HideInInspector]
    public Object Furniture;
    private bool isFurnitureSoldOut;
    Image FurnitureImg;
    Text costFurnitureText, soldOutFurnitureText;
    
    [HideInInspector]
    public Object Picture1;
    private bool isPicture1SoldOut;
    Image Picture1Img;
    Text costPicture1Text, soldOutPicture1Text;
    
    [HideInInspector]
    public Object Picture2;
    private bool isPicture2SoldOut;
    Image Picture2Img;
    Text costPicture2Text, soldOutPicture2Text;



    public enum Items
    {
        Cactus, Armchair, Book, Cup, Grass, Tree, Furniture, Picture1, Picture2
    }

    public void SetTypeAsCactus()
    {
        item = Items.Cactus;
    }
    public void SetTypeAsSofa()
    {
        item = Items.Armchair;
    }
    public void SetTypeAsBook()
    {
        item = Items.Book;
    }
    public void SetTypeAsCup()
    {
        item = Items.Cup;
    }
    public void SetTypeAsGrass()
    {
        item = Items.Grass;
    }
    public void SetTypeAsTree()
    {
        item = Items.Tree;
    }
    public void SetTypeAsFurniture()
    {
        item = Items.Furniture;
    }
    public void SetTypeAsPicture1()
    {
        item = Items.Picture1;
    }
    public void SetTypeAsPicture2()
    {
        item = Items.Picture2;
    }

    public void BuyItem()
    {
        if (!isShop)
        {
            return;
        }
        switch (item)
        {
            case Items.Cactus:
                string costStr = Regex.Replace(costCactusText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isCactusSoldOut)
                {
                    cactus = Instantiate(Resources.Load("Flower3"));
                    DontDestroyOnLoad(cactus);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isCactusSoldOut = true;
                    soldOutCactusText.text = "SOLD OUT";
                    cactusImg.color = Color.gray;
                }
                break;
            case Items.Armchair:
                string costStr2 = Regex.Replace(costArmchairText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr2) && !isArmchairSoldOut)
                {
                    armchair = Instantiate(Resources.Load("Armchair"));
                    DontDestroyOnLoad(armchair);
                    moneyCtrl.Purchase(int.Parse(costStr2));
                    isArmchairSoldOut = true;
                    soldOutArmchairText.text = "SOLD OUT";
                    ArmchairImg.color = Color.gray;
                }
                break;
            case Items.Book:
                string costStr3 = Regex.Replace(costBookText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr3) && !isBookSoldOut)
                {
                    book = Instantiate(Resources.Load("Book3"));
                    DontDestroyOnLoad(book);
                    moneyCtrl.Purchase(int.Parse(costStr3));
                    isBookSoldOut = true;
                    soldOutBookText.text = "SOLD OUT";
                    BookImg.color = Color.gray;
                }
                break;
            case Items.Cup:
                string costStr4 = Regex.Replace(costCupText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr4) && !isCupSoldOut)
                {
                    Cup = Instantiate(Resources.Load("Cup"));
                    DontDestroyOnLoad(Cup);
                    moneyCtrl.Purchase(int.Parse(costStr4));
                    isCupSoldOut = true;
                    soldOutCupText.text = "SOLD OUT";
                    CupImg.color = Color.gray;
                }
                break;
            case Items.Grass:
                string costStr5 = Regex.Replace(costGrassText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr5) && !isGrassSoldOut)
                {
                    Grass = Instantiate(Resources.Load("Flower1"));
                    DontDestroyOnLoad(Grass);
                    moneyCtrl.Purchase(int.Parse(costStr5));
                    isGrassSoldOut = true;
                    soldOutGrassText.text = "SOLD OUT";
                    GrassImg.color = Color.gray;
                }
                break;
            case Items.Tree:
                string costStr6 = Regex.Replace(costTreeText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr6) && !isTreeSoldOut)
                {
                    Tree = Instantiate(Resources.Load("Flower2"));
                    DontDestroyOnLoad(Tree);
                    moneyCtrl.Purchase(int.Parse(costStr6));
                    isTreeSoldOut = true;
                    soldOutTreeText.text = "SOLD OUT";
                    TreeImg.color = Color.gray;
                }
                break;
            case Items.Furniture:
                string costStr7 = Regex.Replace(costFurnitureText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr7) && !isFurnitureSoldOut)
                {
                    Furniture = Instantiate(Resources.Load("Furniture"));
                    DontDestroyOnLoad(Furniture);
                    moneyCtrl.Purchase(int.Parse(costStr7));
                    isFurnitureSoldOut = true;
                    soldOutFurnitureText.text = "SOLD OUT";
                    FurnitureImg.color = Color.gray;
                }
                break;
            case Items.Picture1:
                string costStr8 = Regex.Replace(costPicture1Text.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr8) && !isPicture1SoldOut)
                {
                    Picture1 = Instantiate(Resources.Load("Picture1"));
                    DontDestroyOnLoad(Picture1);
                    moneyCtrl.Purchase(int.Parse(costStr8));
                    isPicture1SoldOut = true;
                    soldOutPicture1Text.text = "SOLD OUT";
                    Picture1Img.color = Color.gray;
                }
                break;
            case Items.Picture2:
                string costStr9 = Regex.Replace(costPicture2Text.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr9) && !isPicture2SoldOut)
                {
                    Picture2 = Instantiate(Resources.Load("Picture2"));
                    DontDestroyOnLoad(Picture2);
                    moneyCtrl.Purchase(int.Parse(costStr9));
                    isPicture2SoldOut = true;
                    soldOutPicture2Text.text = "SOLD OUT";
                    Picture2Img.color = Color.gray;
                }
                break;
        }
    }

    private void Start()
    {
        cactusImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cactus").GetComponent<Image>();
        costCactusText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cactus").transform.Find("ItemText").GetComponent<Text>();
        soldOutCactusText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cactus").transform.Find("SoldOut").GetComponent<Text>();
        
        ArmchairImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Armchair").GetComponent<Image>();
        costArmchairText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Armchair").transform.Find("ItemText").GetComponent<Text>();
        soldOutArmchairText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Armchair").transform.Find("SoldOut").GetComponent<Text>();
        
        BookImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Book").GetComponent<Image>();
        costBookText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Book").transform.Find("ItemText").GetComponent<Text>();
        soldOutBookText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Book").transform.Find("SoldOut").GetComponent<Text>();
        
        CupImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cup").GetComponent<Image>();
        costCupText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cup").transform.Find("ItemText").GetComponent<Text>();
        soldOutCupText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cup").transform.Find("SoldOut").GetComponent<Text>();
        
        GrassImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Grass").GetComponent<Image>();
        costGrassText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Grass").transform.Find("ItemText").GetComponent<Text>();
        soldOutGrassText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Grass").transform.Find("SoldOut").GetComponent<Text>();
        
        TreeImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Tree").GetComponent<Image>();
        costTreeText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Tree").transform.Find("ItemText").GetComponent<Text>();
        soldOutTreeText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Tree").transform.Find("SoldOut").GetComponent<Text>();
        
        FurnitureImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Furniture").GetComponent<Image>();
        costFurnitureText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Furniture").transform.Find("ItemText").GetComponent<Text>();
        soldOutFurnitureText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Furniture").transform.Find("SoldOut").GetComponent<Text>();
        
        Picture1Img = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture1").GetComponent<Image>();
        costPicture1Text = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture1").transform.Find("ItemText").GetComponent<Text>();
        soldOutPicture1Text = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture1").transform.Find("SoldOut").GetComponent<Text>();
        
        Picture2Img = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture2").GetComponent<Image>();
        costPicture2Text = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture2").transform.Find("ItemText").GetComponent<Text>();
        soldOutPicture2Text = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture2").transform.Find("SoldOut").GetComponent<Text>();
        
        moneyCtrl = GetComponent<MoneyCtrl>();
    }
}
