using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marimo_C : MonoBehaviour
{
    public string playername;
   
    public float speed;
       
    public int HP;
    public int Atk;
    public int Dfn;
    public int Gold;

    public int jumpPower;

    //hp��
    hpBarUI hpBarUI;
    

   
    //////////// Move

    Animator anim;
    Rigidbody rigid;

    float hAxis;
    float vAxis;

    bool jDown;
    bool isJump = false;
    Vector3 moveVec;
    


    //////////// Move

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        GetInput();
        Move();
        Turn();
        Jump();
        
    }

    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw ("Vertical");
        jDown = Input.GetButton("Jump") ;

    }
    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        transform.position += moveVec * speed * Time.deltaTime;
        anim.SetBool("isWalk", moveVec != Vector3.zero);

    }

    void Turn()
    {
        transform.LookAt(transform.position + moveVec);
    }
    void Jump() 
    {
       if(jDown && !isJump)
        {
            //rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            anim.SetTrigger("doJump");
            isJump = true;

        }
       
    }

    ////////////

    private void Start()
    {
        GameManager.Instance = this;

        // ���� rigid= GetComponent<Rigidbody>();
        // ���� isJump = false;


        //hpBar prefabã�Ƽ� �ҷ�����
        Object hpBar = Resources.Load("Marimo_HPbar");
        Instantiate(hpBar, transform);//Ʈ������ ����ϳ�
        
        hpBarUI = GetComponentInChildren<hpBarUI>();

        hpBarUI.SetTotalHP(HP); //??
        hpBarUI.SetCurHP(HP);

        hpBarUI.SetName(playername);

    }


    //////////// �ø��� Collision 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        { isJump = false; }

        Monster_C monster = collision.gameObject.GetComponent<Monster_C>();
        if(monster)
        {
            hpBarUI.SetColor(Color.red);
            //monster.MonsterHpBarUI.text.SetColor(Color.red);//??
                   
        }

        
        ShopUI_C shopUI = collision.gameObject.GetComponent<ShopUI_C > ();
        if (shopUI)
        {
            shopUI.OpenShop();

        }

    }

    private void OnCollisionExit(Collision collision)
    {
        Monster_C monster = collision.gameObject.GetComponent<Monster_C>();
        if(monster)
        {
            hpBarUI.SetOgColor();
            hpBarUI.SetCurHP(HP);

            OnDamaged(monster.Atk);
            monster.onDamaged(this); 

                      
        }

        ShopUI_C shopUI = collision.gameObject.GetComponent<ShopUI_C>();
        if (shopUI)
        {
            shopUI.CloseShop();

        }

    }



    public void OnDamaged(int damage)
    {
        HP -= damage;

        if(HP<=0)
        {
            HP = 0;
            Die();

        }
    }

    void Die()
    { Destroy(gameObject); }

 //////////// Move
   




}
