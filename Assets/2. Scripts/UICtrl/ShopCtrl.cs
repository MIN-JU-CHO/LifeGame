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
    public Image cactusImg;
    public Text costCactusText, soldOutCactusText;

    [HideInInspector]
    public Object armchair;
    private bool isArmchairSoldOut;
    public Image ArmchairImg;
    public Text costArmchairText, soldOutArmchairText;
    
    [HideInInspector]
    public Object book;
    private bool isBookSoldOut;
    public Image BookImg;
    public Text costBookText, soldOutBookText;
    
    [HideInInspector]
    public Object Cup;
    private bool isCupSoldOut;
    public Image CupImg;
    public Text costCupText, soldOutCupText;
    
    [HideInInspector]
    public Object Grass;
    private bool isGrassSoldOut;
    public Image GrassImg;
    public Text costGrassText, soldOutGrassText;
    
    [HideInInspector]
    public Object Tree;
    private bool isTreeSoldOut;
    public Image TreeImg;
    public Text costTreeText, soldOutTreeText;
    
    [HideInInspector]
    public Object Furniture;
    private bool isFurnitureSoldOut;
    public Image FurnitureImg;
    public Text costFurnitureText, soldOutFurnitureText;
    
    [HideInInspector]
    public Object Picture1;
    private bool isPicture1SoldOut;
    public Image Picture1Img;
    public Text costPicture1Text, soldOutPicture1Text;
    
    [HideInInspector]
    public Object Picture2;
    private bool isPicture2SoldOut;
    public Image Picture2Img;
    public Text costPicture2Text, soldOutPicture2Text;
    
    [HideInInspector]
    public Object Sofa;
    private bool isSofaSoldOut;
    public Image SofaImg;
    public Text costSofaText, soldOutSofaText;
    
    [HideInInspector]
    public Object Table;
    private bool isTableSoldOut;
    public Image TableImg;
    public Text costTableText, soldOutTableText;


    public enum Items
    {
        Cactus, Armchair, Book, Cup, Grass, Tree, Furniture, Picture1, Picture2, Sofa, Table
    }

    public void SetTypeAsCactus()
    {
        item = Items.Cactus;
    }
    public void SetTypeAsArmchair()
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
    public void SetTypeAsSofa()
    {
        item = Items.Sofa;
    }
    public void SetTypeAsTable()
    {
        item = Items.Table;
    }

    public void BuyItem()
    {
        if (!isShop)
        {
            return;
        }
        string costStr;
        switch (item)
        {
            case Items.Cactus:
                costStr = Regex.Replace(costCactusText.text, @"\D", "");

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
                costStr = Regex.Replace(costArmchairText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isArmchairSoldOut)
                {
                    armchair = Instantiate(Resources.Load("Armchair"));
                    DontDestroyOnLoad(armchair);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isArmchairSoldOut = true;
                    soldOutArmchairText.text = "SOLD OUT";
                    ArmchairImg.color = Color.gray;
                }
                break;
            case Items.Book:
                costStr = Regex.Replace(costBookText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isBookSoldOut)
                {
                    book = Instantiate(Resources.Load("Book3"));
                    DontDestroyOnLoad(book);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isBookSoldOut = true;
                    soldOutBookText.text = "SOLD OUT";
                    BookImg.color = Color.gray;
                }
                break;
            case Items.Cup:
                costStr = Regex.Replace(costCupText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isCupSoldOut)
                {
                    Cup = Instantiate(Resources.Load("Cup"));
                    DontDestroyOnLoad(Cup);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isCupSoldOut = true;
                    soldOutCupText.text = "SOLD OUT";
                    CupImg.color = Color.gray;
                }
                break;
            case Items.Grass:
                costStr = Regex.Replace(costGrassText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isGrassSoldOut)
                {
                    Grass = Instantiate(Resources.Load("Flower1"));
                    DontDestroyOnLoad(Grass);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isGrassSoldOut = true;
                    soldOutGrassText.text = "SOLD OUT";
                    GrassImg.color = Color.gray;
                }
                break;
            case Items.Tree:
                costStr = Regex.Replace(costTreeText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isTreeSoldOut)
                {
                    Tree = Instantiate(Resources.Load("Flower2"));
                    DontDestroyOnLoad(Tree);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isTreeSoldOut = true;
                    soldOutTreeText.text = "SOLD OUT";
                    TreeImg.color = Color.gray;
                }
                break;
            case Items.Furniture:
                costStr = Regex.Replace(costFurnitureText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isFurnitureSoldOut)
                {
                    Furniture = Instantiate(Resources.Load("Furniture"));
                    DontDestroyOnLoad(Furniture);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isFurnitureSoldOut = true;
                    soldOutFurnitureText.text = "SOLD OUT";
                    FurnitureImg.color = Color.gray;
                }
                break;
            case Items.Picture1:
                costStr = Regex.Replace(costPicture1Text.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isPicture1SoldOut)
                {
                    Picture1 = Instantiate(Resources.Load("Picture1"));
                    DontDestroyOnLoad(Picture1);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isPicture1SoldOut = true;
                    soldOutPicture1Text.text = "SOLD OUT";
                    Picture1Img.color = Color.gray;
                }
                break;
            case Items.Picture2:
                costStr = Regex.Replace(costPicture2Text.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isPicture2SoldOut)
                {
                    Picture2 = Instantiate(Resources.Load("Picture2"));
                    DontDestroyOnLoad(Picture2);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isPicture2SoldOut = true;
                    soldOutPicture2Text.text = "SOLD OUT";
                    Picture2Img.color = Color.gray;
                }
                break;
            case Items.Sofa:
                costStr = Regex.Replace(costSofaText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isSofaSoldOut)
                {
                    Sofa = Instantiate(Resources.Load("Sofa"));
                    DontDestroyOnLoad(Sofa);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isSofaSoldOut = true;
                    soldOutSofaText.text = "SOLD OUT";
                    SofaImg.color = Color.gray;
                }
                break;
            case Items.Table:
                costStr = Regex.Replace(costTableText.text, @"\D", "");

                // 현재 보유한 돈이 가격 이상일 때, 품절이 아닐 때
                if (moneyCtrl.GetMoney() >= int.Parse(costStr) && !isTableSoldOut)
                {
                    Table = Instantiate(Resources.Load("Table1"));
                    DontDestroyOnLoad(Table);
                    moneyCtrl.Purchase(int.Parse(costStr));
                    isTableSoldOut = true;
                    soldOutTableText.text = "SOLD OUT";
                    TableImg.color = Color.gray;
                }
                break;
        }
    }

    private void Start()
    {
        //cactusImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cactus").GetComponent<Image>();
        //costCactusText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cactus").transform.Find("ItemText").GetComponent<Text>();
        //soldOutCactusText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cactus").transform.Find("SoldOut").GetComponent<Text>();
        
        //ArmchairImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Armchair").GetComponent<Image>();
        //costArmchairText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Armchair").transform.Find("ItemText").GetComponent<Text>();
        //soldOutArmchairText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Armchair").transform.Find("SoldOut").GetComponent<Text>();
        
        //BookImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Book").GetComponent<Image>();
        //costBookText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Book").transform.Find("ItemText").GetComponent<Text>();
        //soldOutBookText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Book").transform.Find("SoldOut").GetComponent<Text>();
        
        //CupImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cup").GetComponent<Image>();
        //costCupText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cup").transform.Find("ItemText").GetComponent<Text>();
        //soldOutCupText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Cup").transform.Find("SoldOut").GetComponent<Text>();
        
        //GrassImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Grass").GetComponent<Image>();
        //costGrassText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Grass").transform.Find("ItemText").GetComponent<Text>();
        //soldOutGrassText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Grass").transform.Find("SoldOut").GetComponent<Text>();
        
        //TreeImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Tree").GetComponent<Image>();
        //costTreeText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Tree").transform.Find("ItemText").GetComponent<Text>();
        //soldOutTreeText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Tree").transform.Find("SoldOut").GetComponent<Text>();
        
        //FurnitureImg = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Furniture").GetComponent<Image>();
        //costFurnitureText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Furniture").transform.Find("ItemText").GetComponent<Text>();
        //soldOutFurnitureText = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Furniture").transform.Find("SoldOut").GetComponent<Text>();
        
        //Picture1Img = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture1").GetComponent<Image>();
        //costPicture1Text = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture1").transform.Find("ItemText").GetComponent<Text>();
        //soldOutPicture1Text = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture1").transform.Find("SoldOut").GetComponent<Text>();
        
        //Picture2Img = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture2").GetComponent<Image>();
        //costPicture2Text = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture2").transform.Find("ItemText").GetComponent<Text>();
        //soldOutPicture2Text = GameObject.Find("DefaultUI").transform.Find("ShopView").transform.Find("Picture2").transform.Find("SoldOut").GetComponent<Text>();
        
        moneyCtrl = GetComponent<MoneyCtrl>();
    }
}
