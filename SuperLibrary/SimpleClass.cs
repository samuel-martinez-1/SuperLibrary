namespace SuperLibrary
{
    public class SimpleClass
    {
        public string GetSomeInfo(string name)
        {
            var uppercase = name.ToUpper();
            return $"hey {uppercase}!";
        }

    }
}