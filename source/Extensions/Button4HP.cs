using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using HarmonyLib;
using Newtonsoft.Json.Linq;
using Twitch;
using UnityEngine;
using UnityEngine.UI;

namespace HanPi.Modules
{

    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
    public class ModUpdaterButton
    {
        private static void Prefix(MainMenuManager __instance)
        {
            var template = GameObject.Find("ExitGameButton");

            /*
            // 憨批QQ群
            var button憨批QQ群 = UnityEngine.Object.Instantiate(template, null);
            button憨批QQ群.transform.localPosition = new Vector3(button憨批QQ群.transform.localPosition.x, button憨批QQ群.transform.localPosition.y, button憨批QQ群.transform.localPosition.z + 1.2f);

            var text憨批QQ群 = button憨批QQ群.transform.GetChild(0).GetComponent<TMPro.TMP_Text>();
            __instance.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) => {
                text憨批QQ群.SetText("联系汉化组");
            })));

            PassiveButton passiveButton憨批QQ群 = button憨批QQ群.GetComponent<PassiveButton>();
            SpriteRenderer buttonSprite憨批QQ群 = button憨批QQ群.GetComponent<SpriteRenderer>();

            passiveButton憨批QQ群.OnClick = new Button.ButtonClickedEvent();
            passiveButton憨批QQ群.OnClick.AddListener((System.Action)(() => Application.OpenURL("https://jq.qq.com/?_wv=1027&k=3wPXhLE1")));

            Color 憨批QQ群Color = new Color32(255, 255, 0, byte.MaxValue);
            buttonSprite憨批QQ群.color = text憨批QQ群.color = 憨批QQ群Color;
            passiveButton憨批QQ群.OnMouseOut.AddListener((System.Action)delegate
            {
                buttonSprite憨批QQ群.color = text憨批QQ群.color = 憨批QQ群Color;
            });

            // 汉化组
            var button四个憨批官网 = UnityEngine.Object.Instantiate(template, null);
            button四个憨批官网.transform.localPosition = new Vector3(button四个憨批官网.transform.localPosition.x, button四个憨批官网.transform.localPosition.y , button四个憨批官网.transform.localPosition.z + 1.8f);

            var text四个憨批官网 = button四个憨批官网.transform.GetChild(0).GetComponent<TMPro.TMP_Text>();
            __instance.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) => {
                text四个憨批官网.SetText("汉化组官网");
            })));

            PassiveButton passiveButton四个憨批官网 = button四个憨批官网.GetComponent<PassiveButton>();
            SpriteRenderer buttonSprite四个憨批官网 = button四个憨批官网.GetComponent<SpriteRenderer>();

            passiveButton四个憨批官网.OnClick = new Button.ButtonClickedEvent();
            passiveButton四个憨批官网.OnClick.AddListener((System.Action)(() => Application.OpenURL("https://amonguscn.club")));

            Color 四个憨批官网Color = new Color32(255, 0, 0, byte.MaxValue);
            buttonSprite四个憨批官网.color = text四个憨批官网.color = 四个憨批官网Color;
            passiveButton四个憨批官网.OnMouseOut.AddListener((System.Action)delegate
            {
                buttonSprite四个憨批官网.color = text四个憨批官网.color = 四个憨批官网Color;
            });
            */
            //右按钮
            //联系汉化组
            var 憨批QQ群Button = UnityEngine.Object.Instantiate(template, null);
            憨批QQ群Button.transform.localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)) + new Vector3(-0.6f, 0.4f, 0);

            PassiveButton passive憨批QQ群Button = 憨批QQ群Button.GetComponent<PassiveButton>();
            passive憨批QQ群Button.OnClick = new Button.ButtonClickedEvent();
            passive憨批QQ群Button.OnClick.AddListener((UnityEngine.Events.UnityAction)(() => Application.OpenURL("https://jq.qq.com/?_wv=1027&k=3wPXhLE1")));

            var 憨批QQ群Text = 憨批QQ群Button.transform.GetChild(0).GetComponent<TMPro.TMP_Text>();
            __instance.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) =>
            {
                憨批QQ群Text.SetText("联系汉化组");
            })));

            SpriteRenderer buttonSprite憨批QQ群 = 憨批QQ群Button.GetComponent<SpriteRenderer>();
            Color 憨批QQ群Color = new Color32(255, 255, 0, byte.MaxValue);
            buttonSprite憨批QQ群.color = 憨批QQ群Text.color = 憨批QQ群Color;
            passive憨批QQ群Button.OnMouseOut.AddListener((System.Action)delegate
            {
                buttonSprite憨批QQ群.color = 憨批QQ群Text.color = 憨批QQ群Color;
            });

            //四个憨批官网
            var 四个憨批官网Button = UnityEngine.Object.Instantiate(template, null);
            四个憨批官网Button.transform.localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)) + new Vector3(-0.6f, 1.0f, 0);

            PassiveButton passive四个憨批官网Button = 四个憨批官网Button.GetComponent<PassiveButton>();
            passive四个憨批官网Button.OnClick = new Button.ButtonClickedEvent();
            passive四个憨批官网Button.OnClick.AddListener((UnityEngine.Events.UnityAction)(() => Application.OpenURL("https://amonguscn.club")));

            var 四个憨批官网Text = 四个憨批官网Button.transform.GetChild(0).GetComponent<TMPro.TMP_Text>();
            __instance.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) =>
            {
                四个憨批官网Text.SetText("汉化组官网");
            })));

            SpriteRenderer buttonSprite四个憨批官网 = 四个憨批官网Button.GetComponent<SpriteRenderer>();
            Color 四个憨批官网Color = new Color32(255, 0, 0, byte.MaxValue);
            buttonSprite四个憨批官网.color = 四个憨批官网Text.color = 四个憨批官网Color;
            passive四个憨批官网Button.OnMouseOut.AddListener((System.Action)delegate
            {
                buttonSprite四个憨批官网.color = 四个憨批官网Text.color = 四个憨批官网Color;
            });
        }
    }
}
