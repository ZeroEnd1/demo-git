namespace StyleIssues.CA1507
{
    public static class MyClass
    {
        public static string MyMethod(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            return "test" + str;
        }
    }
}
