namespace LearningUnitTest.Fundamentals
{
    public class Reservation
    {
        public User Madeby { get; set; }

        public bool CanBeCanceledBy(User user)
        {
            if (user.IsAdmin)
                return true;

            if (Madeby == user)
                return true;
            return false;
        }
    }
}
