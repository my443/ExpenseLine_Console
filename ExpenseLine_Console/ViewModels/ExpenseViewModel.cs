namespace ExpenseLine_Console.ViewModels
{
    public class ExpenseViewModel : BaseViewModel
    {
        private bool UserCanApprove { get; set; }
        private bool UserCanProcess { get; set; }

        public ExpenseViewModel() {
            UserCanApprove = false;
            UserCanProcess = false;
        }

        public bool GetCanApprove()
        {
            return UserCanApprove;
        }

        public void SetCanApprove(bool status)
        {
            UserCanApprove= status;
        }

        public bool GetCanProcess()
        {
            return UserCanProcess;
        }

        public void SetCanProcess(bool status)
        {
            UserCanProcess= status;
        }
    }
}
