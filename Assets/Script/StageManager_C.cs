using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager_C : MonoBehaviour
{
   

    void Start()
    {
        MonsterGen();
    }

  


        public void MonsterGen()
        {
            GameObject monster = Resources.Load<GameObject>("Slime 1");

            //Instantiate(monster, new Vector3(22, 0,-15), Quaternion.identity);
            // 한개 이 로테이션 값에 생성

            for (int i = 0; i < 10; i++)
            {

                float randomX = Random.Range(-70, 70.0f);
                float randomZ = Random.Range(-85, 80.0f);

                Instantiate(monster, new Vector3(40 + randomX, 3, 100 + randomZ), monster.transform.rotation);
            }
        }
    }
