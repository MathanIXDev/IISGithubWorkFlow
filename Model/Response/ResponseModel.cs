using System.Net;

public class ResponseModel<T>
{
    public HttpStatusCode httpStatusCode { get; set; }

    public List<T>? ListResult { get; set; }

    public T? Result { get; set; }

    public string? ErrorMessage { get; set; }


}