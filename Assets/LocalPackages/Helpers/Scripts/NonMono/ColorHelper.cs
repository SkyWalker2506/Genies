using UnityEngine;

namespace Helpers
{
    public class ColorHelper
    {
        public static Color GetRandomColor()
        {
            return new Color(Random.value, Random.value, Random.value);
        }
    }
}
