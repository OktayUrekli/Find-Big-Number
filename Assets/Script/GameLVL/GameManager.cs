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

    public int kacýncý_oyun,oyun_sayacý;
    int UstDeger, AltDeger,BuyukDeger,butonDegeri;

    int toplamPuan, artýsDegeri;
    int dogruAdet, yanlýsAdet;

    private AudioSource sesKaynagisi;
    [SerializeField]
    private AudioClip dogruSes,YanlýsSes,baslangýcSes,bitisSes;

    private void Awake()
    {
        timerManager =Object.FindObjectOfType<TimerManager>();
        dairelerManager =Object.FindObjectOfType<DairelerManager>();
        tfManager= Object.FindObjectOfType<TrueFalseManager>();
        sesKaynagisi=GetComponent<AudioSource>();
    }

    private void Start()
    {
        kacýncý_oyun = 0;
        oyun_sayacý = 0;
        puanText.text = "0";
        toplamPuan = 0;
        dogruAdet= 0;
        yanlýsAdet = 0;
    }

    public void oyunaBasla()
    {
        sesKaynagisi.PlayOneShot(baslangýcSes);
        timerManager.SureyiBaslat();
        kacýncýOyun();
    }

    public void kacýncýOyun()
    {
        if (oyun_sayacý < 5)
        {
            kacýncý_oyun = 1;
            artýsDegeri = 25;
        }
        else if (oyun_sayacý>=5 && oyun_sayacý<10)
        {
            kacýncý_oyun = 2;
            artýsDegeri = 50;
        }
        else if (oyun_sayacý>=10&& oyun_sayacý<15)
        {
            kacýncý_oyun = 3;
            artýsDegeri = 75;
        }
        else if (oyun_sayacý >=15&& oyun_sayacý<20)
        {
            kacýncý_oyun = 4;
            artýsDegeri = 100;
        }
        else if (oyun_sayacý >= 20 && oyun_sayacý < 25)
        {
            kacýncý_oyun = 5;
            artýsDegeri = 125;
        }
        else
        {
            kacýncý_oyun = Random.Range(1, 6);
            artýsDegeri = 150;
        }

        switch (kacýncý_oyun)
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
            dairelerManager.DaireScaleAc(oyun_sayacý%5);
            sesKaynagisi.PlayOneShot(dogruSes);
            oyun_sayacý++;
            toplamPuan += artýsDegeri;
            puanText.text = toplamPuan.ToString();
            dogruAdet++;
            kacýncýOyun();
        }
        else
        {
            
            tfManager.IconAc(false);
            HatayaGoreSayacýAzalt();
            sesKaynagisi.PlayOneShot(YanlýsSes);
            yanlýsAdet++;
            kacýncýOyun();
        }
        
    }

    void HatayaGoreSayacýAzalt()
    {
        oyun_sayacý -= (oyun_sayacý % 5 + 5);
        if (oyun_sayacý<0)
        {
            oyun_sayacý = 0;
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
        sonucManager.SonuclarýYaz(dogruAdet, yanlýsAdet, toplamPuan);
    }
}
