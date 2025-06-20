using UnityEngine;

public class DayNightCycleController : MonoBehaviour
{

    [SerializeField] private AnimationClip dayAnimation; 
    private Animator animator; 

    [SerializeField] private Gradient FogColor;
    private float current_animation_time;

    private void Awake()
    {
        animator = GetComponent<Animator>(); 

        RenderSettings.fog = true; 
        RenderSettings.fogDensity = 0.0035f;
        RenderSettings.fogColor = FogColor.Evaluate(0); 
    }

    // Update is called once per frame
    void Update()
    {
        current_animation_time = animator.GetCurrentAnimatorStateInfo(0).normalizedTime % 1; 
        RenderSettings.fogColor = FogColor.Evaluate(current_animation_time);
        
    }
}
