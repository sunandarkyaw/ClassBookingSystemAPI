namespace Core.Entities.Models
{
    public class CodeMessage
    {
        public string code { get; set; }
        public string message { get; set; }
    }

    public class CodeMessageWithData<T> : CodeMessage
    {
        public T data { get; set; }
    }
}
