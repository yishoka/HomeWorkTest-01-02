using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    /// <summary>
    /// 定義欄位
    /// </summary>
    #region 定義基礎數值
    [Header("史萊姆的血量"), Tooltip("史萊姆的血量")]
    public int SHP;
    [Header("史萊姆的攻擊力"), Tooltip("史萊姆的攻擊力")]
    public int SATK;
    [Header("史萊姆的恢復力"), Tooltip("史萊姆的恢復力")]
    public int SHEAL;
    [Header("史萊姆輸出結果")]
    public Text SResult;
    [Header("對象怪物"), Tooltip("對象怪物")]
    public Bat Bat1;
    #endregion

    //遊戲開始時輸入欄位值
    public void Start()
    {
        SHP = 100;
        SATK = 10;
        SHEAL = 30;
    }

    /// <summary>
    /// 史萊姆攻擊-呼叫蝙蝠受傷方法
    /// </summary>
    public void SAttack()
    {
        Bat1.BHurt(SATK);
    }

    /// <summary>
    /// 史萊姆受傷-接受BATK
    /// </summary>
    /// <param name="EnemyATK">敵人的攻擊力</param>
    public void SHurt(int EnemyATK)
    {
        SHP -= EnemyATK;
        SResult.text = gameObject.name + "收到傷害" + EnemyATK + "\n" + gameObject.name + "剩餘血量：" + SHP;
    }

    /// <summary>
    /// 史萊姆補血
    /// </summary>
    public void SHealling()
    {
        SHP += SHEAL;
        SResult.text = gameObject.name + "恢復血量" + SHEAL + "\n" + gameObject.name + "剩餘血量：" + SHP;
    }
}
