namespace TakeHome
{
    public static class Constants
    {
        public static class Controllers
        {
            public const string Feedback = "Feedback";
            public const string Home = "Home";

            public static class ActionNamesFeedback
            {
                public const string Feedback = "Feedback";
            }

            public static class ActionNamesHome
            {
                public const string About = "About";

                public const string Contact = "Contact";

                public const string Index = "Index";
            }
        }

        public static class Forms
        {
            public static class FeedBack
            {
                public static class Display
                {
                    public const string Comments = "Comments";
                    public const string Email = "Email";
                    public const string FirstName = "First Name";
                    public const string LastName = "Last Name";
                }

                public static class Errors
                {
                    public const string _andMax = " and max ";
                    public const string _charactersInLength = " characters in length";
                    public const string _requiredPrefix = "Please Provide '";
                    public const string _requiredSuffix = "'";
                    public const string _shouldBeMin = "' should be min ";
                    public const string LengthComments = "'" + Display.Comments + "' should have a max length of " + Validation.CommentsMaxLengthStr + " characters";
                    public const string LengthEmail = "'" + Display.Email + _shouldBeMin + Validation.EmailMinLengthStr + _andMax + Validation.EmailMaxLengthStr + _charactersInLength;
                    public const string LengthFirstName = "'" + Display.FirstName + _shouldBeMin + Validation.FirstNameMinLengthStr + _andMax + Validation.FirstNameMaxLengthStr + _charactersInLength;
                    public const string LengthLastName = "'" + Display.LastName + _shouldBeMin + Validation.LastNameMinLengthStr + _andMax + Validation.LastNameMaxLengthStr + _charactersInLength;
                    public const string RegexEmail = "Please provide valid '" + Display.Email + "'";
                    public const string RequiredEmail = _requiredPrefix + Display.Email + _requiredSuffix;
                    public const string RequiredFirstName = _requiredPrefix + Display.FirstName + _requiredSuffix;
                    public const string RequiredLastName = _requiredPrefix + Display.LastName + _requiredSuffix;
                }

                public static class Validation
                {
                    public const int CommentsMaxLengthInt = 200;
                    public const string CommentsMaxLengthStr = "200";
                    public const int EmailMaxLengthInt = 25;
                    public const string EmailMaxLengthStr = "25";
                    public const int EmailMinLengthInt = 3;
                    public const string EmailMinLengthStr = "3";
                    public const int FirstNameMaxLengthInt = 25;
                    public const string FirstNameMaxLengthStr = "25";
                    public const int FirstNameMinLengthInt = 1;
                    public const string FirstNameMinLengthStr = "1";
                    public const int LastNameMaxLengthInt = 25;
                    public const string LastNameMaxLengthStr = "25";
                    public const int LastNameMinLengthInt = 1;
                    public const string LastNameMinLengthStr = "1";
                }
            }

            public static class Validation
            {
                public const string Email = "^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
            }
        }

        public static class Titles
        {
            public const string Application = "Gregory's Submission";
        }

        public static class Views
        {
            public const string ThankYou = "ThankYou";
            public const string Feedback = "Feedback";

            public static class Titles
            {
                public const string About = "About";
                public const string Contact = "Contact";
                public const string Feedback = "Feedback";
                public const string HomePage = "Home Page";
            }
        }
    }
}