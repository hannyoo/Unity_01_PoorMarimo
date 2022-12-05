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

    private Monster_C monster;

    void Start()
    {
        
        Object m_hpbar = Resources.Load("monster_HPbar");
        Instantiate(m_hpbar, transform);

        monster = this;
        
        monsterHpBarUI = GetComponentInChildren<MonsterHpBarUI>();
        
        // monsterHpBarUI = FindObjectOfType<MonsterHpBarUI>();
        // Monster_C에서 참조하는게 MonsterHpBarUI 하나뿐이라 Find오브젝트오브타입 함수를 쓴다.
        // 남발하면 쥿됨 

        monsterHpBarUI.SetTotalHP(HP);
        monsterHpBarUI.SetCurHP(HP);

        monsterHpBarUI.SetName(monsterName); ////

        monsterHpBarUI.transform.position += new Vector3(0,+hpPosition, 0);
    }

    private void Update()
    {
        this.transform.rotation = Quaternion.Euler(Camera.main.transform.rotation.x, Camera.main.transform.rotation.y - 180, Camera.main.transform.rotation.z);
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
