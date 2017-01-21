using UnityEngine;
using System.Collections;

public class TypeEnum : MonoBehaviour {
    enum OndeType {
		EAU,
		FEU,
		GLACE
	}

    OndeType ReverseTypeOnde(OndeType onde) {
        if (onde == OndeType.EAU)
            onde = OndeType.GLACE;
        else if (onde == OndeType.FEU)
            onde = OndeType.EAU;
        else if (onde == OndeType.GLACE)
            onde = OndeType.FEU;

        return onde;
    }
}