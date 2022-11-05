using System.Collections.Generic;
using System.Linq;
using Object = UnityEngine.Object;

namespace TownOfUs.Roles
{
    public class Mystic : Role
    {
        public Dictionary<byte, ArrowBehaviour> BodyArrows = new Dictionary<byte, ArrowBehaviour>();
        public Mystic(PlayerControl player) : base(player)
        {
            Name = "灵媒";
            ImpostorText = () => "死亡的闪烁";
            TaskText = () => "知道什么时候有人被击杀";
            Color = Patches.Colors.Mystic;
            RoleType = RoleEnum.灵媒;
            AddToRoleHistory(RoleType);
        }

        public void DestroyArrow(byte targetPlayerId)
        {
            var arrow = BodyArrows.FirstOrDefault(x => x.Key == targetPlayerId);
            if (arrow.Value != null)
                Object.Destroy(arrow.Value);
            if (arrow.Value.gameObject != null)
                Object.Destroy(arrow.Value.gameObject);
            BodyArrows.Remove(arrow.Key);
        }
    }
}