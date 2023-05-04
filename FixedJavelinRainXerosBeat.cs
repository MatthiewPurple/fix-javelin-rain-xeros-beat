using MelonLoader;
using HarmonyLib;
using Il2Cpp;
using fix_javelin_rain_xeros_beat;
using Il2Cppnewdata_H;
using Il2Cppresult2_H;

[assembly: MelonInfo(typeof(FixedJavelinRainXerosBeat), "Fixed Javelin Rain and Xeros Beat", "1.0.0", "Matthiew Purple")]
[assembly: MelonGame("アトラス", "smt3hd")]

namespace fix_javelin_rain_xeros_beat;
public class FixedJavelinRainXerosBeat : MelonMod
{
    [HarmonyPatch(typeof(datSkillName), nameof(datSkillName.Get))]
    private class Patch
    {
        public static void Prefix(ref int id)
        {
            if (id == 133) id = 143;
            else if (id == 143) id = 133;
        }
    }

    [HarmonyPatch(typeof(datSkillHelp_msg), nameof(datSkillHelp_msg.Get))]
    private class Patch2
    {
        public static void Prefix(ref int id)
        {
            if (id == 133) id = 143;
            else if (id == 143) id = 133;
        }
    }

    public override void OnInitializeMelon()
    {
        datNormalSkill_t tmpNormalSkill = datNormalSkill.tbl[133];
        datNormalSkill.tbl[133] = datNormalSkill.tbl[143];
        datNormalSkill.tbl[143] = tmpNormalSkill;

        datSkill_t tmpSkill = datSkill.tbl[133];
        datSkill.tbl[133] = datSkill.tbl[143];
        datSkill.tbl[143] = tmpSkill;

        fclHeartsSkill_t tmpHeartsSkill = tblHearts.fclHeartsTbl[20].Skill[2];
        tblHearts.fclHeartsTbl[20].Skill[2] = tblHearts.fclHeartsTbl[15].Skill[2];
        tblHearts.fclHeartsTbl[15].Skill[2] = tmpHeartsSkill;
    }
}
