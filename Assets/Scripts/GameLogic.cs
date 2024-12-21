using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
#region ����������

#region �������
    /// <summary>
    /// ���������� �������
    /// </summary>
    public int wheelCount;
    /// <summary>
    /// ����� ������� �������
    /// </summary>
    private int whellTotalCount = 0;
    /// <summary>
    /// ��������� ���� ��� ���������� �������
    /// </summary>
    public Text wheelCountText;
    /// <summary>
    /// ����� ����� �������
    /// </summary>
    public float wheatHarvestTimer;
    /// <summary>
    /// ������� ����� ����� �������
    /// </summary>
    private float currentWheelTimer = 0;
    /// <summary>
    /// ����������� ������� �����
    /// </summary>
    public Image wheatHarvestImage;
    /// <summary>
    /// ���������� ������� � 1 �����������
    /// </summary>
    public int wheelFromPeasant;
    /// <summary>
    /// ����������� ������� �������� �������
    /// </summary>
    public Image wheatEatingImage;
    /// <summary>
    /// ������ �������� �������
    /// </summary>
    public float eatWheatTimer;
    /// <summary>
    /// ������� ����� ������� �������� �������
    /// </summary>
    private float eatEatingTimerCurrentTime = 0;
    /// <summary>
    /// ���������� ������� ������� ������� ���� ���������� � ����
    /// </summary>
    public int wheatForOnePeasantandWarrior;
 #endregion

#region ���������
    /// <summary>
    /// ���������� ��������
    /// </summary>
    public int peasantCount;
    /// <summary>
    /// ��������� �����������
    /// </summary>
    public int peasantCost;
    /// <summary>
    /// ��������� ���� ����������� ���������� ��������
    /// </summary>
    public Text peasantCountText;
    /// <summary>
    /// ������ ���������� �����������
    /// </summary>
    public Button peasantAddButtonClick;
    /// <summary>
    /// ����������� ������� ���������� ��������
    /// </summary>
    public Image peasantAddImage;
    /// <summary>
    /// ����� ���������� �����������
    /// </summary>
    public float peasantTimer;
    /// <summary>
    /// ������� ����� ������� ���������� ��������
    /// </summary>
    private float peasantCurrentTime = 0;
    /// <summary>
    /// ��������� ������ �� ������
    /// </summary>
    private bool isPeasantAddButtonCliked;
#endregion

#region �����
    /// <summary>
    /// ���������� ������
    /// </summary>
    public int warriorCount;
    /// <summary>
    /// ����� ������ ������
    /// </summary>
    private int warriorTotalCount = 0;
    /// <summary>
    /// ��������� ����� �����
    /// </summary>
    public int warriortCost;
    /// <summary>
    /// ��������� ���� ��� ����������� ���������� ������
    /// </summary>
    public Text warriorCountText;
    /// <summary>
    /// ������ ���������� �����
    /// </summary>
    public Button warriorAddButtonClick;
    /// <summary>
    /// ����������� ������� ���������� �����
    /// </summary>
    public Image warriorAddImage;
    /// <summary>
    /// ����� ����������� �����
    /// </summary>
    public float warriorTimer;
    /// <summary>
    /// ������� ����� ���������� �����
    /// </summary>
    private float warriorCurrentTime = 0;
    /// <summary>
    /// ��������� ������ �� ������ ����������
    /// </summary>
    private bool isWarriorAddButtonCliked;
#endregion

#region ����������
    /// <summary>
    /// ��������� ���� ����������� ���������� �����������
    /// </summary>
    public Text rogueCountText;
    /// <summary>
    /// ���������� �����������
    /// </summary>
    private int rogueCount = 0;
    /// <summary>
    /// ����� ����� �����������
    /// </summary>
    public int rogueWave;
    /// <summary>
    /// ���������� ����������� �� �����. ������� ��� ����� * �� ���������� �� �����
    /// </summary>
    public int rogueAtWave;
    /// <summary>
    /// ����������� ������� ����� �����������
    /// </summary>
    public Image rogueWaveImage;
    /// <summary>
    /// ������ ������� �����������
    /// </summary>
    public float rogueTime;
    /// <summary>
    /// �������� ����� ������� ������� �����������
    /// </summary>
    private float rogueCurrentTime = 0;
#endregion

#region ���������� ����
    /// <summary>
    /// ����� ����
    /// </summary>
    public GameObject GameScreen;
    /// <summary>
    /// ����� ��������� ����
    /// </summary>
    public GameObject WinLoseScreen;
    /// <summary>
    /// ����� ����������� ������ ����� � �������� Win ��� Lose
    /// </summary>
    public Image winOrLoseImage;
    /// <summary>
    /// ������ ����������� ������ ����� � �������� Win
    /// </summary>
    public Sprite winSprite;
    /// <summary>
    /// ������ ����������� ������ ����� � �������� lose
    /// </summary>
    public Sprite loseSprite;
    /// <summary>
    /// ��������� ���� � ������������ ����������� ����
    /// </summary>
    public Text resultText;
    /// <summary>
    /// ����������� ������� ����
    /// </summary>
    private Image background;
    /// <summary>
    /// ������ ������ ��� ������� ����
    /// </summary>
    public Sprite winImage;
    /// <summary>
    /// ������ ��������� ��� ������� ����
    /// </summary>
    public Sprite loseImage;
#endregion

#region ��������� �����
    /// <summary>
    /// ��������� ��� ��������������� ���� ����������/�����/�������� �������/���������
    /// </summary>
    private AudioSource sounds;
    /// <summary>
    /// ����� ���� ����� �����������
    /// </summary>
    public AudioClip attackSound;
    /// <summary>
    /// ����� ���� ����� �������
    /// </summary>
    public AudioClip wheatSound;
    /// <summary>
    /// ����� ���� �������� �������
    /// </summary>
    public AudioClip eatSound;
    /// <summary>
    /// ����� ���� ���������� �����
    /// </summary>
    public AudioClip addWarrior;
    /// <summary>
    /// ����� ���� ���������� �����������
    /// </summary>
    public AudioClip addPeasant;
    #endregion
    #endregion

    #region ����� ����
    private void Start()
    {
        SetDefault();
        sounds = GetComponent<AudioSource>();
        background = GetComponent<Image>();
    }
    /// <summary>
    /// ������������� ����������� �������� � ��������� ����
    /// </summary>
    private void SetDefault()
    {
        wheelCountText.text = wheelCount.ToString();
        peasantCountText.text = peasantCount.ToString();
        warriorCountText.text = warriorCount.ToString();
        rogueCountText.text = rogueCount.ToString();
        Time.timeScale = 1;
    }
    #endregion

    void Update()
    {
        WinLoseChecker();
        IsActiveButtons();
        PlayWheatHarvestLogic();
        PlayEatHarvestLogic();
        PlayRogueLogic();
        if (isPeasantAddButtonCliked) AddPeasantLogic();
        if (isWarriorAddButtonCliked) AddWarriorLogic();

    }

    #region �������� ������ �� ������ � �� ����������� �� ����. ������� ���������
    /// <summary>
    /// ��������� �� ����������� �� ����
    /// </summary>
    private void WinLoseChecker()
    {
        if (warriorCount < 0 || wheelCount < 0 || rogueWave > 10)
        {
            Time.timeScale = 0;
            WinLoseScreen.SetActive(true);
            GameScreen.SetActive(false);
            resultText.text = $"������� ������� : {whellTotalCount}\n" +
                              $"�������� ������: {peasantCount}\n" +
                              $"������ ������: {warriorTotalCount}\n" +
                              $"�������� ����: {rogueWave - 1}";
            if (rogueWave > 10)
            {
                winOrLoseImage.sprite = winSprite;
                background.sprite = winImage;
            }
            else
            {
                winOrLoseImage.sprite = loseSprite;
                background.sprite = loseImage;
            }
        }
    }


    /// <summary>
    /// ��������� ������� �� ������� �� ����, � ���� �� ������� ��������� ������
    /// </summary>
    private void IsActiveButtons()
    {
        if (wheelCount < peasantCost)
            peasantAddButtonClick.interactable = false;
        else if (!isPeasantAddButtonCliked) peasantAddButtonClick.interactable = true;

        if (wheelCount < warriortCost)
            warriorAddButtonClick.interactable = false;
        else if (!isWarriorAddButtonCliked) warriorAddButtonClick.interactable = true;

    }
    #endregion

    #region ������ ������ ����� �������, �������� � � ����� ������
    /// <summary>
    /// ������������ ������ ����� �������.
    /// ������ � ���������� �� ���������� ������������
    /// </summary>
    private void PlayWheatHarvestLogic()

    {
        currentWheelTimer += Time.deltaTime;
        wheatHarvestImage.fillAmount = currentWheelTimer / wheatHarvestTimer;
        if (currentWheelTimer >= wheatHarvestTimer)
        {
            sounds.PlayOneShot(wheatSound);
            int addWheel = (peasantCount * wheelFromPeasant);
            wheelCount += addWheel;
            whellTotalCount += addWheel;
            wheelCountText.text = wheelCount.ToString();
            currentWheelTimer = 0;
        }
    }

    /// <summary>
    /// ������������ ������ �������� �������
    /// </summary>
    private void PlayEatHarvestLogic()
    {
        eatEatingTimerCurrentTime += Time.deltaTime;
        wheatEatingImage.fillAmount = eatEatingTimerCurrentTime / eatWheatTimer;
        if (eatEatingTimerCurrentTime >= eatWheatTimer)
        {
            sounds.PlayOneShot(eatSound);
            wheelCount -= (peasantCount + warriorCount) * wheatForOnePeasantandWarrior;
            wheelCountText.text = wheelCount.ToString();
            eatEatingTimerCurrentTime = 0;
        }
    }

    /// <summary>
    /// ����������� ���������� ����������� � ����������� �� �����. �������� ����� �� ������
    /// </summary>
    private void PlayRogueLogic()
    {
        if (rogueTime > rogueCurrentTime)
        {
            rogueCurrentTime += Time.deltaTime;
            rogueWaveImage.fillAmount = rogueCurrentTime / rogueTime;
        }
        else
        {
            rogueWave++;
            rogueCurrentTime = 0;
            if (rogueWave >= 0)
            {
                Attack();
                rogueCount = rogueWave * rogueAtWave;
                rogueCountText.text = rogueCount.ToString();
            }

        }
    }

    /// <summary>
    /// ����� ����� ����������� �� ������
    /// </summary>
    private void Attack()
    {
        sounds.PlayOneShot(attackSound);
        warriorCount -= rogueCount;
        warriorCountText.text = warriorCount.ToString();
    }
    #endregion

    #region ������
    /// <summary>
    /// ����������� ��� ������� �� ������ ����������� �����������
    /// </summary>
    public void AddWarrior()
    {
        warriorAddButtonClick.interactable = false;
        wheelCount -= warriortCost;
        wheelCountText.text = wheelCount.ToString();
        isWarriorAddButtonCliked = true;
    }

    /// <summary>
    /// ������ ���������� �����, ������ �������, �� ��������� ������� ���������� ����������� � ��������� ������
    /// </summary>
    private void AddWarriorLogic()
    {
        if (warriorCurrentTime >= warriorTimer)
        {
            sounds.PlayOneShot(addWarrior);
            warriorTotalCount++;
            warriorCount++;
            warriorCountText.text = warriorCount.ToString();
            warriorAddButtonClick.interactable = true;
            isWarriorAddButtonCliked = false;
            warriorCurrentTime = 0;
            warriorAddImage.fillAmount = 1;
        }
        else
        {
            warriorCurrentTime += Time.deltaTime;
            warriorAddImage.fillAmount = warriorCurrentTime / warriorTimer;
        }
    }

    /// <summary>
    /// ����������� ��� ������� �� ������ ����������� �����������
    /// </summary>
    public void AddPeasant()
    {
        peasantAddButtonClick.interactable = false;
        wheelCount -= peasantCost;
        wheelCountText.text = wheelCount.ToString();
        isPeasantAddButtonCliked = true;
    }

    /// <summary>
    /// ������ ���������� ����������, ������ �������, �� ��������� ������� ���������� ����������� � ��������� ������
    /// </summary>
    private void AddPeasantLogic()
    {
        if (peasantCurrentTime >= peasantTimer)
        {
            sounds.PlayOneShot(addPeasant);
            peasantCount ++;
            peasantCountText.text = peasantCount.ToString();
            peasantAddButtonClick.interactable = true;
            isPeasantAddButtonCliked = false;
            peasantCurrentTime = 0;
            peasantAddImage.fillAmount = 1;
        }
        else
        {
            peasantCurrentTime += Time.deltaTime;
            peasantAddImage.fillAmount = peasantCurrentTime / peasantTimer;
        }
    }
    #endregion
}
