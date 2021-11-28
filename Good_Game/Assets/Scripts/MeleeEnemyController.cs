using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeleeEnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    public static bool isAlive;
    public int maxHealth = 100;
    public static int currentEnemyHealth;
    public MeleeHealthBar enemyHealthBar;

    Transform target;
    NavMeshAgent agent;
	private CharacterController controller;
    Animator enemyAnimator; 
	private bool hasAnimator;

    // Start is called before the first frame update
    void Start()
    {
        target = MeleePlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();

		controller = GetComponent<CharacterController>();
		hasAnimator = TryGetComponent(out enemyAnimator);

        currentEnemyHealth = maxHealth;
        isAlive = true;
        enemyHealthBar.SetNewMaxHealth(currentEnemyHealth);
        // Debug.Log("MeleeEnemyController.start()");
        // Debug.Log("target: " + target);
        // Debug.Log("agent: " + agent);
        // enemyAnimator.Play("Jump1");

        // slow
        // GameObject.FindGameObjectWithTag("tagName");
    }

    // Update is called once per frame
    void Update()
    {
        float distance  = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius) {
            // Debug.Log("update() target: " + target);
            // Debug.Log("update()  agent: " + agent);
            // Debug.Log("meleeEnemyController.update() if() target: " + target);
            // Debug.Log("MeleeEnemyController.update() if ()");

            agent.SetDestination(target.position);
            // Debug.Log("target position: " + target.position);
            FaceTarget();

            if (distance <= agent.stoppingDistance) {
                // attack the target
                // face the target
                // Debug.Log("enemy-player distance: " + distance);
                FaceTarget();
                // enemyAnimator.Play("Attack");
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
		Debug.Log("meleeEnemyController.onCollision() with: " + collision.gameObject.tag);
		// Debug.Log(collision.gameObject.tag);
			// Debug.Log("collision with untagged");
        if (collision.gameObject.tag == "Player")
        // if (collision.gameObject.tag == "Untagged" || collision.gameObject.tag == "Damage_10")
        {
			Debug.Log("collision with mySword");
			int damage = 26;
			OpponentTakeDamage(damage);
        }
        if (collision.gameObject.tag == "mySword") {
			Debug.Log("collision with mySword");
			OpponentHealth.OpponentTakeDamage(34);
		}
        if (collision.gameObject.tag == "getHealth") {
			Debug.Log("if(true) => getting max health");
			currentEnemyHealth = maxHealth;
        	enemyHealthBar.SetNewHealth(currentEnemyHealth);
		}
    }

    public void OpponentTakeDamage(int damage)
    {
        Debug.Log("EnemyMeleeController.OpponentTakeDamage() " + damage);
        enemyAnimator.Play("TakeDamage");
        currentEnemyHealth -= damage;
        enemyHealthBar.SetNewHealth(currentEnemyHealth);
        if (currentEnemyHealth <= 0)
        {
            isAlive = false;
			// pause_menu.Pause();
       	 	// meleeAnimator.SetTrigger("Die");
       	 	enemyAnimator.Play("Die");
        }
        // Debug.Log("(meleeController) TakeDamage() " + currentHealth);
        // meleeAnimator.SetTrigger("takeDamage");
    }

    void FaceTarget () {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected () {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
