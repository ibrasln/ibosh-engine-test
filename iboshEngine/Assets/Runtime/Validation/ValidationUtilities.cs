using System.Collections;
using UnityEngine;

namespace IboshEngine.Validation
{
    public static class ValidationUtilities
    {
        /// <summary>
        /// Empty string debug check
        /// </summary>
        public static bool ValidateCheckEmptyString(Object thisObject, string fieldName, string stringToCheck)
        {
            if (stringToCheck == "")
            {
                Debug.Log(fieldName + " is empty and must contain a value in object " + thisObject.name.ToString());
                return true;
            }
            return false;
        }

        /// <summary>
        /// Null value debug check
        /// </summary>
        public static bool ValidateCheckNullValue(Object thisObject, string fieldName, Object objectToCheck)
        {
            if (objectToCheck == null)
            {
                Debug.Log(fieldName + " is null and must contain a value in object " + thisObject.name.ToString());
                return true;
            }
            return false;
        }

        /// <summary>
        /// List is empty or contains null value check - returns true if there is an error
        /// </summary>
        public static bool ValidateCheckEnumerableValues(Object thisObject, string fieldName, IEnumerable enumerableObjectToCheck)
        {
            bool error = false;
            int count = 0;

            if (enumerableObjectToCheck == null)
            {
                Debug.Log(fieldName + " is null in object " + thisObject.name.ToString());
                return true;
            }


            foreach (var item in enumerableObjectToCheck)
            {

                if (item == null)
                {
                    Debug.Log(fieldName + " has null values in object " + thisObject.name.ToString());
                    error = true;
                }
                else
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Debug.Log(fieldName + " has no values in object " + thisObject.name.ToString());
                error = true;
            }

            return error;
        }

        /// <summary>
        /// Positive value debug check. If zero is allowed set isZeroAllowed true. (for integers)
        /// </summary>
        public static bool ValidateCheckPositiveValue(Object thisObject, string fieldName, int valueToCheck, bool isZeroAllowed)
        {
            bool error = false;

            if (isZeroAllowed)
            {
                if (valueToCheck < 0)
                {
                    Debug.Log(fieldName + " must contain a positive value or zero in object " + thisObject.name.ToString());
                    error = true;
                }
            }
            else
            {
                if (valueToCheck <= 0)
                {
                    Debug.Log(fieldName + " must contain a positive value in object " + thisObject.name.ToString());
                    error = true;
                }
            }
            return error;
        }


        /// <summary>
        /// Positive value debug check. If zero is allowed set isZeroAllowed true. (for floats)
        /// </summary>
        public static bool ValidateCheckPositiveValue(Object thisObject, string fieldName, float valueToCheck, bool isZeroAllowed)
        {
            bool error = false;

            if (isZeroAllowed)
            {
                if (valueToCheck < 0)
                {
                    Debug.Log(fieldName + " must contain a positive value or zero in object " + thisObject.name.ToString());
                    error = true;
                }
            }
            else
            {
                if (valueToCheck <= 0)
                {
                    Debug.Log(fieldName + " must contain a positive value in object " + thisObject.name.ToString());
                    error = true;
                }
            }
            return error;
        }

        /// <summary>
        /// Positive range debug check - set isZeroAllowed true if the min and max range values can both be zero. Return true if there is an error
        /// </summary>
        public static bool ValidateCheckPositiveRange(Object thisObject, string fieldNameMinimum, float valueToCheckMinimum, string fieldNameMaximum, float valueToCheckMaximum, bool isZeroAllowed)
        {
            bool error = false;

            if (valueToCheckMinimum > valueToCheckMaximum)
            {
                Debug.Log(fieldNameMinimum + " must be less than or equal to " + fieldNameMaximum + " in object " + thisObject.name.ToString());
                error = true;
            }

            if (ValidateCheckPositiveValue(thisObject, fieldNameMinimum, valueToCheckMinimum, isZeroAllowed)) error = true;
            if (ValidateCheckPositiveValue(thisObject, fieldNameMaximum, valueToCheckMaximum, isZeroAllowed)) error = true;

            return error;
        }

        /// <summary>
        /// Positive range debug check - set isZeroAllowed true if the min and max range values can both be zero. Return true if there is an error
        /// </summary>
        public static bool ValidateCheckPositiveRange(Object thisObject, string fieldNameMinimum, int valueToCheckMinimum, string fieldNameMaximum, int valueToCheckMaximum, bool isZeroAllowed)
        {
            bool error = false;

            if (valueToCheckMinimum > valueToCheckMaximum)
            {
                Debug.Log(fieldNameMinimum + " must be less than or equal to " + fieldNameMaximum + " in object " + thisObject.name.ToString());
                error = true;
            }

            if (ValidateCheckPositiveValue(thisObject, fieldNameMinimum, valueToCheckMinimum, isZeroAllowed)) error = true;
            if (ValidateCheckPositiveValue(thisObject, fieldNameMaximum, valueToCheckMaximum, isZeroAllowed)) error = true;

            return error;
        }
    }
}
