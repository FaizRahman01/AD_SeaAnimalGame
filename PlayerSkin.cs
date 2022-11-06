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
        public void MainSkin ()
        {
            skinName = "submarineleft";
        }
    }

    class PlayerSkin2 : PlayerSkin
    {
        public void SecondSkin ()
        {
            skinName = "submarine2left";
        }
    }

    class PlayerSkin3 : PlayerSkin
    {
        public void ThirdSkin()
        {
            skinName = "submarine3left";
        }
    }
}
