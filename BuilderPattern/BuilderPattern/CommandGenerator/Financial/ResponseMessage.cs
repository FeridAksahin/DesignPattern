namespace BuilderPattern.CommandGenerator.Financial
{
    public class ResponseMessage
    {
        private ResponseGenerator _responser;
        private RequestCommand _request;

        public ResponseMessage(RequestCommand request)
        {
            _request = request;
        }

        public string SendResponseMessage()
        {
            _responser = new ResponseGenerator();
            try
            {
                var getReponseMessage = _responser.GetResponse(_request);
                return getReponseMessage;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
