using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_C : MonoBehaviour
{
    public string monsterName;
    public int HP;
    public int Atk;

    public int Gold;

    MonsterHpBarUI monsterHpBarUI;

    public float hpPosition;


    void Start()
    {
        
        Object m_hpbar = Resources.Load("monster_HPbar");
        Instantiate(m_hpbar, transform);

        monsterHpBarUI = GetComponentInChildren<MonsterHpBarUI>();
        
        // monsterHpBarUI = FindObjectOfType<MonsterHpBarUI>();
        // Monster_C���� �����ϴ°� MonsterHpBarUI �ϳ����̶� Find������Ʈ����Ÿ�� �Լ��� ����.
        // �����ϸ� �M�� 

        monsterHpBarUI.SetTotalHP(HP);
        monsterHpBarUI.SetCurHP(HP);

        monsterHpBarUI.SetName(monsterName); ////

        monsterHpBarUI.transform.position += new Vector3(0,+hpPosition, 0);
    }

    public void onDamaged(Marimo_C marimo)
    {
        HP -= marimo.Atk;

        monsterHpBarUI.SetCurHP(HP);

        if(HP <=0)
        {
            HP= 0;

            Die();

        }
    
    }

    void Die()
    { Destroy(gameObject); }




}
