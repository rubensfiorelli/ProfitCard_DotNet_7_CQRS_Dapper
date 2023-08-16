using ProfitCard.Application.Output.Output.Results.Interfaces;

namespace ProfitCard.Application.Output.Output.Results
{
    public class Result : IResultBase
    {
        //private List<Notification> _notifications;

        public Result(short resultCode, string message, bool isOk, object data)
        {
            ResultCode = resultCode;
            Message = message;
            IsOk = isOk;
            Data = data;
            //_notifications = new List<Notification>();
        }

        public int ResultCode { get; private set; }
        public string Message { get; private set; }
        public bool IsOk { get; private set; }
        public object Data { get; private set; }
        //public IReadOnlyCollection<Notification> Notifications => _notifications;


        //public void SetNotifications(List<Notification> notifications)
        //{
        //    _notifications = notifications;
        //}

        public void SetData(object data)
        {
            Data = data;
        }
    }
}
