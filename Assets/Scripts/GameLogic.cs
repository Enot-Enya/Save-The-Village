using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
#region Переменные

#region Пшеница
    /// <summary>
    /// Количество пшеницы
    /// </summary>
    public int wheelCount;
    /// <summary>
    /// Всего собрано пшеницы
    /// </summary>
    private int whellTotalCount = 0;
    /// <summary>
    /// Текстовое поля для количества пшеницы
    /// </summary>
    public Text wheelCountText;
    /// <summary>
    /// Время сбора пшеницы
    /// </summary>
    public float wheatHarvestTimer;
    /// <summary>
    /// Текущее время сбора пшеницы
    /// </summary>
    private float currentWheelTimer = 0;
    /// <summary>
    /// Изображение таймера сбора
    /// </summary>
    public Image wheatHarvestImage;
    /// <summary>
    /// Количество пшеницы с 1 крестьянина
    /// </summary>
    public int wheelFromPeasant;
    /// <summary>
    /// Изображение таймера поедания пшеницы
    /// </summary>
    public Image wheatEatingImage;
    /// <summary>
    /// Таймер поедания пшеницы
    /// </summary>
    public float eatWheatTimer;
    /// <summary>
    /// Текущее время таймера поедания пшеницы
    /// </summary>
    private float eatEatingTimerCurrentTime = 0;
    /// <summary>
    /// Количество пшеницы которое сьедает один крестьянин и воин
    /// </summary>
    public int wheatForOnePeasantandWarrior;
 #endregion

#region Крестьяне
    /// <summary>
    /// Количество крестьян
    /// </summary>
    public int peasantCount;
    /// <summary>
    /// Стоимость крестьянина
    /// </summary>
    public int peasantCost;
    /// <summary>
    /// Текстовое поле отображения количества крестьян
    /// </summary>
    public Text peasantCountText;
    /// <summary>
    /// Кнопка добавления крестьянина
    /// </summary>
    public Button peasantAddButtonClick;
    /// <summary>
    /// Изображения таймера добавления крестьян
    /// </summary>
    public Image peasantAddImage;
    /// <summary>
    /// Время добавления крестьянина
    /// </summary>
    public float peasantTimer;
    /// <summary>
    /// Текущее время таймера добавления крестьян
    /// </summary>
    private float peasantCurrentTime = 0;
    /// <summary>
    /// Проверяет нажата ли кнопка
    /// </summary>
    private bool isPeasantAddButtonCliked;
#endregion

#region Войны
    /// <summary>
    /// Количество войнов
    /// </summary>
    public int warriorCount;
    /// <summary>
    /// Всего нанято войнов
    /// </summary>
    private int warriorTotalCount = 0;
    /// <summary>
    /// Стоимость найма война
    /// </summary>
    public int warriortCost;
    /// <summary>
    /// Текстовое поле для отображения количество войнов
    /// </summary>
    public Text warriorCountText;
    /// <summary>
    /// Кнопка добавления война
    /// </summary>
    public Button warriorAddButtonClick;
    /// <summary>
    /// Изображение таймера добавления война
    /// </summary>
    public Image warriorAddImage;
    /// <summary>
    /// Время длобавления война
    /// </summary>
    public float warriorTimer;
    /// <summary>
    /// Текущее время добавления война
    /// </summary>
    private float warriorCurrentTime = 0;
    /// <summary>
    /// Проверяет нажата ли кнопка добавления
    /// </summary>
    private bool isWarriorAddButtonCliked;
#endregion

#region Разбойники
    /// <summary>
    /// Текстовое поле отображения количества разбойников
    /// </summary>
    public Text rogueCountText;
    /// <summary>
    /// Количество разбойников
    /// </summary>
    private int rogueCount = 0;
    /// <summary>
    /// Номер волны разбойников
    /// </summary>
    public int rogueWave;
    /// <summary>
    /// Количество разбойников за волну. Считает как волна * на количество за волну
    /// </summary>
    public int rogueAtWave;
    /// <summary>
    /// Изображение таймера волны разбойников
    /// </summary>
    public Image rogueWaveImage;
    /// <summary>
    /// Таймер прихода разбойников
    /// </summary>
    public float rogueTime;
    /// <summary>
    /// Текущеее время таймера прихода разбойников
    /// </summary>
    private float rogueCurrentTime = 0;
#endregion

#region Результаты игры
    /// <summary>
    /// Экран игры
    /// </summary>
    public GameObject GameScreen;
    /// <summary>
    /// Экран окончания игры
    /// </summary>
    public GameObject WinLoseScreen;
    /// <summary>
    /// Экран отображения сверху листа с надписью Win или Lose
    /// </summary>
    public Image winOrLoseImage;
    /// <summary>
    /// Спрайт отображения сверху листа с надписью Win
    /// </summary>
    public Sprite winSprite;
    /// <summary>
    /// Спрайт отображения сверху листа с надписью lose
    /// </summary>
    public Sprite loseSprite;
    /// <summary>
    /// Текстовое поле с отображением результатов игры
    /// </summary>
    public Text resultText;
    /// <summary>
    /// Изображение заднего фона
    /// </summary>
    private Image background;
    /// <summary>
    /// Спрайт победы для заднего фона
    /// </summary>
    public Sprite winImage;
    /// <summary>
    /// Спрайт поражения для заднего фона
    /// </summary>
    public Sprite loseImage;
#endregion

#region Настройка аудио
    /// <summary>
    /// АудиоСурс для воспроизведения звук добавления/сбора/поедания пшеницы/нападения
    /// </summary>
    private AudioSource sounds;
    /// <summary>
    /// Аудио клип атаки разбойников
    /// </summary>
    public AudioClip attackSound;
    /// <summary>
    /// Аудио клип сбора пшеницы
    /// </summary>
    public AudioClip wheatSound;
    /// <summary>
    /// Аудио клип поедания пшеницы
    /// </summary>
    public AudioClip eatSound;
    /// <summary>
    /// Аудио клип добавления война
    /// </summary>
    public AudioClip addWarrior;
    /// <summary>
    /// Аудио клип добавления крестьянина
    /// </summary>
    public AudioClip addPeasant;
    #endregion
    #endregion

    #region Старт Игры
    private void Start()
    {
        SetDefault();
        sounds = GetComponent<AudioSource>();
        background = GetComponent<Image>();
    }
    /// <summary>
    /// Устанавливает стандартные значения в текстовые поля
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

    #region Проверки нажата ли кнопка и не закончилась ли игра. Работаю постоянно
    /// <summary>
    /// Проверяет не закончилась ли игра
    /// </summary>
    private void WinLoseChecker()
    {
        if (warriorCount < 0 || wheelCount < 0 || rogueWave > 10)
        {
            Time.timeScale = 0;
            WinLoseScreen.SetActive(true);
            GameScreen.SetActive(false);
            resultText.text = $"Пшеницы собрано : {whellTotalCount}\n" +
                              $"Крестьян нанято: {peasantCount}\n" +
                              $"Войнов нанято: {warriorTotalCount}\n" +
                              $"Пережили волн: {rogueWave - 1}";
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
    /// Проверяет хватает ли пшеницы на найм, и если не хватает отключает кнопки
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

    #region Логика работа сбора пшеницы, поедания её и атаки войнов
    /// <summary>
    /// Обрабатывает логику сбора пшеницы.
    /// Таймер и добавление от количества крестьянинов
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
    /// Обрабатывает логику поедания пшеницы
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
    /// Уволичивает количество разбойников в зависимости от волны. Вызывает атаку на войнов
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
    /// Метод Атаки разбойников на войнов
    /// </summary>
    private void Attack()
    {
        sounds.PlayOneShot(attackSound);
        warriorCount -= rogueCount;
        warriorCountText.text = warriorCount.ToString();
    }
    #endregion

    #region Кнопки
    /// <summary>
    /// Срабатывает при нажатии на кнопку долбавления крестьянина
    /// </summary>
    public void AddWarrior()
    {
        warriorAddButtonClick.interactable = false;
        wheelCount -= warriortCost;
        wheelCountText.text = wheelCount.ToString();
        isWarriorAddButtonCliked = true;
    }

    /// <summary>
    /// Логика добавления война, отсчет таймера, по окончанию таймера добавление крестьянина и включение кнопки
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
    /// Срабатывает при нажатии на кнопку долбавления крестьянина
    /// </summary>
    public void AddPeasant()
    {
        peasantAddButtonClick.interactable = false;
        wheelCount -= peasantCost;
        wheelCountText.text = wheelCount.ToString();
        isPeasantAddButtonCliked = true;
    }

    /// <summary>
    /// Логика добавления крестьнина, отсчет таймера, по окончанию таймера добавление крестьянина и включение кнопки
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
