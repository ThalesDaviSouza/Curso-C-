namespace System {
    static class StringExtensionMethods {
        public static string Cut(this string thisObj, int value) {
            if (thisObj.Length <= value) {
                return thisObj;
            }

            string cut = thisObj.Substring(0, value);

            return $"{cut}...";
        }
    }
}
