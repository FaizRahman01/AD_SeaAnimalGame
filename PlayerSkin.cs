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
        public void SetMainSkin(string skin1)
        {
            skinName = skin1;
            
        }
        public string GetMainSkin()
        {
            return skinName;
        }
    }

    class PlayerSkin2 : PlayerSkin
    {
        public void SetSecondSkin(string skin2)
        {
            skinName = skin2;
        }
        public string GetSecondSkin()
        {
            return skinName;
        }
    }

    class PlayerSkin3 : PlayerSkin
    {
        public void SetThirdSkin(string skin3)
        {
            skinName = skin3;
        }
        public string GetThirdSkin()
        {
            return skinName;
        }
    }
}
