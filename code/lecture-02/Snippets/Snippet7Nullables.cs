using System;

namespace Snippets
{
    public class Snippet7Nullables
    {
        public static void SomeExpressionsInvolvingNullables()
        {
            Int32? aNullableInt = null;
            Int32? anotherNullableInt = 1 + aNullableInt; // null

            Int32? aNullableInt2 = 5;
            Int32? anotherNullableInt2 = 1 + aNullableInt2; // 6
            
            Int32 i = anotherNullableInt ?? 0; // 0L
            Int32 i2 = anotherNullableInt2 ?? 0; // 6L
           
            String aString = aNullableInt?.ToString(); // null
            String aString2 = aNullableInt2?.ToString(); // "6"
        }
    }
}