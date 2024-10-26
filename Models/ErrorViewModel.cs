namespace todo_list_asp_mvc.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        //(S)CUM MASTAH !!!
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
