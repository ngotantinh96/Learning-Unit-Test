namespace TestNinJa.Fundamentals
{
    public class CustomerController
    {
        public ActionResult GetCustomer(int id)
        {
            if (id == 0)
                return new NotFound();
            return new OK();
        }
    }

    public class OK : ActionResult
    {
    }

    public class NotFound : ActionResult
    {
    }

    public class ActionResult
    {
    }
}
