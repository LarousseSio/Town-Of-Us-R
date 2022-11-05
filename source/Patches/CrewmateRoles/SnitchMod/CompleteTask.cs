using System.Linq;
using HarmonyLib;
using Reactor.Utilities;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.SnitchMod
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.CompleteTask))]
    public class CompleteTask
    {
        public static Sprite Sprite => TownOfUs.Arrow;

        public static void Postfix(PlayerControl __instance)
        {
            if (!__instance.Is(RoleEnum.告密者)) return;
            if (__instance.Data.IsDead) return;
            var taskinfos = __instance.Data.Tasks.ToArray();

            var tasksLeft = taskinfos.Count(x => !x.Complete);
            var role = Role.GetRole<Snitch>(__instance);
            var localRole = Role.GetRole(PlayerControl.LocalPlayer);
            switch (tasksLeft)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    if (tasksLeft == CustomGameOptions.SnitchTasksRemaining)
                    {
                        role.RegenTask();
                        if (PlayerControl.LocalPlayer.Is(RoleEnum.告密者))
                        {
                            Coroutines.Start(Utils.FlashCoroutine(role.Color));
                        }
                        else if ((PlayerControl.LocalPlayer.Data.IsImpostor() && (!PlayerControl.LocalPlayer.Is(RoleEnum.背叛者) || CustomGameOptions.SnitchSeesTraitor))
                            || ((PlayerControl.LocalPlayer.Is(RoleEnum.混沌) || PlayerControl.LocalPlayer.Is(RoleEnum.天启)
                            || PlayerControl.LocalPlayer.Is(RoleEnum.纵火狂) || PlayerControl.LocalPlayer.Is(RoleEnum.月下狼人)
                            || PlayerControl.LocalPlayer.Is(RoleEnum.瘟疫之源) || PlayerControl.LocalPlayer.Is(RoleEnum.万疫之神)) && CustomGameOptions.SnitchSeesNeutrals))
                        {
                            Coroutines.Start(Utils.FlashCoroutine(role.Color));
                            var gameObj = new GameObject();
                            var arrow = gameObj.AddComponent<ArrowBehaviour>();
                            gameObj.transform.parent = PlayerControl.LocalPlayer.gameObject.transform;
                            var renderer = gameObj.AddComponent<SpriteRenderer>();
                            renderer.sprite = Sprite;
                            arrow.image = renderer;
                            gameObj.layer = 5;
                            role.ImpArrows.Add(arrow);
                        }
                    }
                    break;

                case 0:
                    role.RegenTask();
                    if (PlayerControl.LocalPlayer.Is(RoleEnum.告密者))
                    {
                        Coroutines.Start(Utils.FlashCoroutine(Color.green));
                        var impostors = PlayerControl.AllPlayerControls.ToArray().Where(x => x.Data.IsImpostor());
                        var traitor = PlayerControl.AllPlayerControls.ToArray().Where(x => x.Is(RoleEnum.背叛者));
                        foreach (var imp in impostors)
                        {
                            if (!imp.Is(RoleEnum.背叛者) || CustomGameOptions.SnitchSeesTraitor)
                            {
                                var gameObj = new GameObject();
                                var arrow = gameObj.AddComponent<ArrowBehaviour>();
                                gameObj.transform.parent = PlayerControl.LocalPlayer.gameObject.transform;
                                var renderer = gameObj.AddComponent<SpriteRenderer>();
                                renderer.sprite = Sprite;
                                arrow.image = renderer;
                                gameObj.layer = 5;
                                role.SnitchArrows.Add(imp.PlayerId, arrow);
                            }
                        }
                    }
                    else if (PlayerControl.LocalPlayer.Data.IsImpostor() || ((PlayerControl.LocalPlayer.Is(RoleEnum.混沌) || PlayerControl.LocalPlayer.Is(RoleEnum.天启)
                            || PlayerControl.LocalPlayer.Is(RoleEnum.纵火狂) || PlayerControl.LocalPlayer.Is(RoleEnum.月下狼人)
                            || PlayerControl.LocalPlayer.Is(RoleEnum.瘟疫之源) || PlayerControl.LocalPlayer.Is(RoleEnum.万疫之神)) && CustomGameOptions.SnitchSeesNeutrals))
                    {
                        Coroutines.Start(Utils.FlashCoroutine(Color.green));
                    }

                    break;
            }
        }
    }
}