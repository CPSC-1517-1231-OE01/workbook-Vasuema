namespace Utils
{
    public static class Utilities
    {
        public static bool IsZeroOrNegative(int value)
        {
            //simple technique -> return the expression
            //return value <= 0; //true || false

            //explicit technique -> declare all parts
            //bool result;
            //if (value <= 0)
            //{
            //    result = true;
            //}
            //else
            //{
            //    result = false;
            //}
            //return result;

            //simple but explicit -> conditional / ternary operator
            //bool result;
            //result = value <= 0 ? true : false;
            //return result;
            //or
            return value <= 0 ? true : false;
                // if (         ) true     else    false
        }

        public static bool IsPositive(int value) => value > 0;

        /// <summary>
        /// determines if the entered date is in the future
        /// </summary>
        /// <param name="value"></param>
        /// <returns>true/false</returns>
        public static bool IsInFuture(DateOnly value) => value > DateOnly.FromDateTime(DateTime.Now);
    }
}