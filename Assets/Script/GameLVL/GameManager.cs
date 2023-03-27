using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text ustText, altText,puanText;

    [SerializeField]
    private GameObject pausePaneli;

    [SerializeField]
    private GameObject SonucPaneli;

    TimerManager timerManager;
    DairelerManager dairelerManager;
    TrueFalseManager tfManager;
    SonucManager sonucManager;  

    public int kac�nc�_oyun,oyun_sayac�;
    int UstDeger, AltDeger,BuyukDeger,butonDegeri;

    int toplamPuan, art�sDegeri;
    int dogruAdet, yanl�sAdet;

    private AudioSource sesKaynagisi;
    [SerializeField]
    private AudioClip dogruSes,Yanl�sSes,baslang�cSes,bitisSes;

    private void Awake()
    {
        timerManager =Object.FindObjectOfType<TimerManager>();
        dairelerManager =Object.FindObjectOfType<DairelerManager>();
        tfManager= Object.FindObjectOfType<TrueFalseManager>();
        sesKaynagisi=GetComponent<AudioSource>();
    }

    private void Start()
    {
        kac�nc�_oyun = 0;
        oyun_sayac� = 0;
        puanText.text = "0";
        toplamPuan = 0;
        dogruAdet= 0;
        yanl�sAdet = 0;
    }

    public void oyunaBasla()
    {
        sesKaynagisi.PlayOneShot(baslang�cSes);
        timerManager.SureyiBaslat();
        kac�nc�Oyun();
    }

    public void kac�nc�Oyun()
    {
        if (oyun_sayac� < 5)
        {
            kac�nc�_oyun = 1;
            art�sDegeri = 25;
        }
        else if (oyun_sayac�>=5 && oyun_sayac�<10)
        {
            kac�nc�_oyun = 2;
            art�sDegeri = 50;
        }
        else if (oyun_sayac�>=10&& oyun_sayac�<15)
        {
            kac�nc�_oyun = 3;
            art�sDegeri = 75;
        }
        else if (oyun_sayac� >=15&& oyun_sayac�<20)
        {
            kac�nc�_oyun = 4;
            art�sDegeri = 100;
        }
        else if (oyun_sayac� >= 20 && oyun_sayac� < 25)
        {
            kac�nc�_oyun = 5;
            art�sDegeri = 125;
        }
        else
        {
            kac�nc�_oyun = Random.Range(1, 6);
            art�sDegeri = 150;
        }

        switch (kac�nc�_oyun)
        {
            case 1:BirinciFonks();
                break;
            case 2:
                IkinciFonks();
                break;
            case 3:
                UcuncuFonks();
                break;
            case 4:
                DorduncuFonks();
                break;
            case 5:
                BesinciFonks();
                break;
            default:
                break;
        }
    }


    void BirinciFonks()
    {
        int randSayi = Random.Range(1, 50);

        if (randSayi<=25)
        {
            UstDeger=Random.Range(2, 50);
            AltDeger=UstDeger+Random.Range(1, 15);
        }
        else
        {
            UstDeger = Random.Range(2, 50);
            AltDeger = Mathf.Abs(UstDeger - Random.Range(0, 15));
        }


        if (UstDeger>AltDeger)
        {
            BuyukDeger = UstDeger;
        }
        else if (AltDeger>UstDeger)
        {
            BuyukDeger = AltDeger;
        }
        else
        {
            BirinciFonks();
            return;
        }

        ustText.text=UstDeger.ToString();
        altText.text = AltDeger.ToString();
    }

    void IkinciFonks()
    {
        int s1=Random.Range(1, 10);
        int s2=Random.Range(1, 20);
        int s3 = Random.Range(1, 10);
        int s4 = Random.Range(1, 20);

        UstDeger = s1 + s2;
        AltDeger = s3 + s4;

        if (UstDeger>AltDeger)
        {
            BuyukDeger = UstDeger;
        }
        else if(UstDeger < AltDeger)
        {
            BuyukDeger= AltDeger;
        }
        else
        {
            IkinciFonks();
            return;
        }

        ustText.text = s1 + "+" + s2;
        altText.text = s3 + "+" + s4;
    }

    void UcuncuFonks()
    {
        int s1 = Random.Range(11, 30);
        int s2 = Random.Range(1, 11);
        int s3 = Random.Range(11, 40);
        int s4 = Random.Range(1, 11);

        UstDeger = s1 - s2;
        AltDeger = s3 - s4;

        if (UstDeger > AltDeger)
        {
            BuyukDeger = UstDeger;
        }
        else if (UstDeger < AltDeger)
        {
            BuyukDeger = AltDeger;
        }
        else
        {
            UcuncuFonks();
            return;
        }

        ustText.text = s1 + "-" + s2;
        altText.text = s3 + "-" + s4;
    }

    void DorduncuFonks()
    {
        int s1 = Random.Range(1, 10);
        int s2 = Random.Range(1, 10);
        int s3 = Random.Range(1, 10);
        int s4 = Random.Range(1, 10);

        UstDeger = s1 * s2;
        AltDeger = s3 * s4;

        if (UstDeger > AltDeger)
        {
            BuyukDeger = UstDeger;
        }
        else if (UstDeger < AltDeger)
        {
            BuyukDeger = AltDeger;
        }
        else
        {
            DorduncuFonks();
            return;
        }

        ustText.text = s1 + "x" + s2;
        altText.text = s3 + "x" + s4;
    }

    void BesinciFonks()
    {
        int bolen1 = Random.Range(2, 10);
        UstDeger = Random.Range(2, 10);
        int bolunen1 = bolen1 * UstDeger;

        int bolen2 = Random.Range(2, 10);
        AltDeger = Random.Range(2, 10);
        int bolunen2 = bolen2 * AltDeger;

        if (UstDeger > AltDeger)
        {
            BuyukDeger = UstDeger;
        }
        else if (UstDeger < AltDeger)
        {
            BuyukDeger = AltDeger;
        }
        else
        {
            BesinciFonks();
            return;
        }

        ustText.text = bolunen1 + " / " + bolen1;
        altText.text = bolunen2 + " / " + bolen2;
    }

    public void butonDegeriniBelirle(string butonAdi)
    {
        if (butonAdi=="ustButon")
        {
            butonDegeri = UstDeger;
        }
        else if (butonAdi == "altButon")
        {
            butonDegeri=AltDeger;   
        }

        if (butonDegeri==BuyukDeger)
        {
            
            tfManager.IconAc(true);
            dairelerManager.DaireScaleAc(oyun_sayac�%5);
            sesKaynagisi.PlayOneShot(dogruSes);
            oyun_sayac�++;
            toplamPuan += art�sDegeri;
            puanText.text = toplamPuan.ToString();
            dogruAdet++;
            kac�nc�Oyun();
        }
        else
        {
            
            tfManager.IconAc(false);
            HatayaGoreSayac�Azalt();
            sesKaynagisi.PlayOneShot(Yanl�sSes);
            yanl�sAdet++;
            kac�nc�Oyun();
        }
        
    }

    void HatayaGoreSayac�Azalt()
    {
        oyun_sayac� -= (oyun_sayac� % 5 + 5);
        if (oyun_sayac�<0)
        {
            oyun_sayac� = 0;
        }

        dairelerManager.DaireleriKapat();
    }

    public void PausePaneliAc()
    {
        pausePaneli.gameObject.SetActive(true);
    }

    public void oyunbitti()
    {
        sesKaynagisi.PlayOneShot(bitisSes);
        SonucPaneli.SetActive(true);
        sonucManager = Object.FindObjectOfType<SonucManager>();
        sonucManager.Sonuclar�Yaz(dogruAdet, yanl�sAdet, toplamPuan);
    }
}
