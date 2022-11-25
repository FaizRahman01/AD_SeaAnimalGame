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

        public GamePage GamePage
        {
            get => default;
            set
            {
            }
        }
    }

    class PlayerSkin1 : PlayerSkin
    {
        public string GetMainSkin()
        {
            //use the properties image name if user choose Spekter in SkinOptionPage
            skinName = "submarineleft";
            return skinName;
        }

    }
    class PlayerSkin2 : PlayerSkin
    {
        public string GetSecondSkin()
        {
            //use the properties image name if user choose Fantom in SkinOptionPage
            skinName = "submarine2left";
            return skinName;
        }

    }

    class PlayerSkin3 : PlayerSkin
    {
        public string GetThirdSkin()
        {
            //use the properties image name if user choose Veindal in SkinOptionPage
            skinName = "submarine3left";
            return skinName;
        }

    }
}
