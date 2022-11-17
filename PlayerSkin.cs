using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_SeaAnimalGame
{
    class PlayerSkin
    {
        public string skinName;
        public int SpeedOfPlayer = 12;
    }

    class PlayerSkin1 : PlayerSkin
    {
        public string GetMainSkin()
        {
            skinName = "submarineleft";
            return skinName;
        }

    }
    class PlayerSkin2 : PlayerSkin
    {
        public string GetSecondSkin()
        {
            skinName = "submarine2left";
            return skinName;
        }

    }

    class PlayerSkin3 : PlayerSkin
    {
        public string GetThirdSkin()
        {
            skinName = "submarine3left";
            return skinName;
        }

    }
}
