using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButterflyBoss : MonoBehaviour
{
    public Transform leftSpawner;
    public Transform rightSpawner;
    public Transform botLeftSpawner;
    public Transform botRightSpawner;
    public Transform leftBallSpawner;
    public Transform rightBallSpawner;

    public GameObject leftSpike;
    public GameObject rightSpike;
    public GameObject leftBall;
    public GameObject rightBall;
    public bool waited;
    public bool bossDead = false;

    public GameObject locked;
    public GameObject unlockableRoad;

    float xx;
    float yy;
    Vector2 speed;
    float t = 0;

    public Image bossHPSlider;
    public Image behindHPSlider;

    public float HP = 20;
    public int atkDmg1;
    public int atkDmg2;
    public GameObject boss;
    public Animator anim;
    public float newHP;
    public float startingHP;
    public GameObject destruction;

    // Use this for initialization
    void Start()
    {
        locked.SetActive(true);
        anim = GetComponent<Animator>();
        newHP = HP;
        waited = true;
        startingHP = HP;
    }

    // Update is called once per frame
    void Update()
    {
        SpikeAttack();

        if (newHP != HP)
        {
            anim.SetBool("TakenDmg", true);
            newHP = HP;
            bossHPSlider.fillAmount = (newHP / startingHP);
        }
        else
        {
            anim.SetBool("TakenDmg", false);
        }


        xx = Mathf.Sin(t) / 25;
        yy = (((Mathf.Sin(t)) * (Mathf.Cos(t)))) / 25;
        t = t + 0.01f;

        if (HP <= 0)
        {
            destruction.SetActive(true);
            //speed = new Vector2(transform.position.x, transform.position.y);
            StartCoroutine(Wait());
            Destroy(behindHPSlider);
        }
        //BossHealthSystem();

        BossDead();
    }

    private void FixedUpdate()
    {
        speed = new Vector2(xx, yy);
        transform.Translate(speed);
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Destroy(boss);
        destruction.SetActive(false);
        bossDead = true;
    }

    public void SpikeAttack()
    {
        if (waited == true)
        {
            Instantiate(leftSpike, leftSpawner);
            Instantiate(leftSpike, botLeftSpawner);
            Instantiate(leftSpike, rightSpawner);
            Instantiate(leftSpike, botRightSpawner);
            waited = false;
            StartCoroutine(AttackSpikeDelay());

        }

    }

    public IEnumerator AttackSpikeDelay()
    {
        yield return new WaitForSeconds(1);
        waited = true;
    }

    public void BossDead()
    {
        if (HP <= 0)
        {
            locked.SetActive(false);
            unlockableRoad.SetActive(true);
        }
    }
  //  public void BossHealthSystem()
  //  {
  //      if((HP/startingHP) != (newHP / startingHP))
      //  {
  //          bossHPSlider.fillAmount = (newHP / startingHP);
    //    }
   // }
}


 

