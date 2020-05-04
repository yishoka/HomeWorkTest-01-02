using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
    /// <summary>
    /// 定義欄位
    /// </summary>
    #region 定義基礎數值
    [Header("蝙蝠的血量"),Tooltip("蝙蝠的血量")]
    public int BHP;
    [Header("蝙蝠的攻擊力"),Tooltip("蝙蝠的攻擊力")]
    public int BATK;
    [Header("蝙蝠的恢復力"),Tooltip("蝙蝠的恢復力")]
    public int BHEAL;
    [Header("蝙蝠輸出結果")]
    public Text BResult;
    [Header("對象怪物"),Tooltip("對象怪物")]
    public Slime Slime1;
    #endregion

    //遊戲開始時輸入欄位值
    public void Start()
    {
        BHP = 300;
        BATK = 20;
        BHEAL = 10;
    }

    /// <summary>
    /// 蝙蝠攻擊-呼叫史萊姆受傷方法
    /// </summary>
    public void BAttack()
    {
        Slime1.SHurt(BATK);
    }

    /// <summary>
    /// 蝙蝠受傷-接受史萊姆ATK
    /// </summary>
    /// <param name="EnemyATK">敵人的攻擊力</param>
    public void BHurt(int EnemyATK)
    {
        BHP -= EnemyATK;
        BResult.text = gameObject.name + "收到傷害" + EnemyATK + "\n" + gameObject.name + "剩餘血量：" + BHP; 
    }

    /// <summary>
    /// 蝙蝠補血
    /// </summary>
    public void BHealling()
    {
        BHP += BHEAL;
        BResult.text = gameObject.name + "恢復血量" + BHEAL + "\n" + gameObject.name + "剩餘血量：" + BHP;
    }
}
