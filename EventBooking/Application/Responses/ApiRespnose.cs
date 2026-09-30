using System.Net;

namespace Application.Responses;
 
public class ApiResponse<T>(HttpStatusCode statusCode, string message, T data)
{
    public HttpStatusCode StatusCode {get;set;} = statusCode;
    public string Message {get;set;} = message;
    public T? Data {get;set;} = data;
}