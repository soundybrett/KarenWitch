using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* HOWTO make a new level - Brett 12/10/2020

1. Create new Scene in Scenes folder, eg. Level3
2. Delete main Camera. There is a camera in the Player prefab.
3. Drag Canvas prefab into Heirarchy list.
4. Drag Player prefab into H.list
5. With Player selected, drag Canvas in H.list to Ui variable in Player script Inspector.
- score will not update & gems will not disappear if this is not done.
6. Add Grid prefab & change level graphics using Tile Palette
7. Add Gem prefab & duplicate & move in scene window within reach of player.
8. Add Enemy prefab & duplicate & move in Scene window.
- for up & down, change Enemy(script) Target Pos X to same as Transform position X
9. Add EndFlag prefab. If Final Level check tick box in EndFlag script variable
- change Next Scene name variable to next scene name, eg Level4.
10 Add new level to File|Build Settings by dragging Level from Scenes folder into Build settings.

*/