using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimations : MonoBehaviour
{
    [SerializeField]
    GameObject NewSkillVFX, NewSkillUI, NewSkillIcon;

    [SerializeField]    
    Animator NewSkillBackground;

    bool canUnlockSkill;

    void Start()
    {
        canUnlockSkill = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && canUnlockSkill)
        {
            NewSkillVFX.SetActive(true); NewSkillUI.SetActive(true); NewSkillIcon.SetActive(true);
            NewSkillBackground.SetBool("SkillUnlock 0", true);
            Invoke("DisableVFX", 5f);
            canUnlockSkill = false;
        }
    }

    private void DisableVFX()
    {
        NewSkillVFX.SetActive(false); NewSkillUI.SetActive(false); NewSkillIcon.SetActive(false);
        canUnlockSkill = true;
        NewSkillBackground.SetBool("SkillUnlock 0", false);
    }
}
