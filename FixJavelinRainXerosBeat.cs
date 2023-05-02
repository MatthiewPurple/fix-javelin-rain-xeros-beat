using MelonLoader;
using HarmonyLib;
using Il2Cpp;
using fix_javelin_rain_xeros_beat;
using Il2Cppnewdata_H;
using Il2Cppnewbattle_H;
using System.ComponentModel;
using Il2Cppeffect_H;

[assembly: MelonInfo(typeof(FixJavelinRainXerosBeat), "Fixed Javelin Rain and Xeros Beat", "1.0.0", "Matthiew Purple")]
[assembly: MelonGame("アトラス", "smt3hd")]

namespace fix_javelin_rain_xeros_beat;
public class FixJavelinRainXerosBeat : MelonMod
{
    [HarmonyPatch(typeof(cmpDrawStatus), nameof(cmpDrawStatus.cmpDrawSkill))]
    private class Patch0
    {
        public static void Postfix()
        {
            int x = 0;
            dds3GlobalWork.DDS3_GBWK.unitwork[0].skill[x++] = 147;
            dds3GlobalWork.DDS3_GBWK.unitwork[0].skill[x++] = 144;
            dds3GlobalWork.DDS3_GBWK.unitwork[0].skill[x++] = 143;
            dds3GlobalWork.DDS3_GBWK.unitwork[0].skill[x++] = 133;

            int y = 0;

            y = 147;
            MelonLogger.Msg($"-------------------------------------------");
            MelonLogger.Msg($"FREIKUGEL");
            MelonLogger.Msg($"animetype: {datNormalSkillVisual.tbl[y].animetype}");
            MelonLogger.Msg($"bedno: {datNormalSkillVisual.tbl[y].bedno}");
            MelonLogger.Msg($"hatudo: {datNormalSkillVisual.tbl[y].hatudo}");
            MelonLogger.Msg($"motion: {datNormalSkillVisual.tbl[y].motion}");

            y = 144;
            MelonLogger.Msg("");
            MelonLogger.Msg($"ONI KAGURA");
            MelonLogger.Msg($"animetype: {datNormalSkillVisual.tbl[y].animetype}");
            MelonLogger.Msg($"bedno: {datNormalSkillVisual.tbl[y].bedno}");
            MelonLogger.Msg($"hatudo: {datNormalSkillVisual.tbl[y].hatudo}");
            MelonLogger.Msg($"motion: {datNormalSkillVisual.tbl[y].motion}");

            y = 143;
            MelonLogger.Msg("");
            MelonLogger.Msg($"JAVELIN RAIN");
            MelonLogger.Msg($"animetype: {datNormalSkillVisual.tbl[y].animetype}");
            MelonLogger.Msg($"bedno: {datNormalSkillVisual.tbl[y].bedno}");
            MelonLogger.Msg($"hatudo: {datNormalSkillVisual.tbl[y].hatudo}");
            MelonLogger.Msg($"motion: {datNormalSkillVisual.tbl[y].motion}");

            y = 133;
            MelonLogger.Msg("");
            MelonLogger.Msg($"XEROS BEAT");
            MelonLogger.Msg($"animetype: {datNormalSkillVisual.tbl[y].animetype}");
            MelonLogger.Msg($"bedno: {datNormalSkillVisual.tbl[y].bedno}");
            MelonLogger.Msg($"hatudo: {datNormalSkillVisual.tbl[y].hatudo}");
            MelonLogger.Msg($"motion: {datNormalSkillVisual.tbl[y].motion}");
        }
    }

    public override void OnInitializeMelon()
    {
        datNormalSkillVisual.tbl[133].motion = 17;
        datNormalSkillVisual.tbl[143].motion = 15;
    }

    /* À chercher :
     * 
     * effBattle.effBTLCreate
     * effBattle.effBTLCutCreate
     * effBattle.effBTLPartCreate
     */
}
