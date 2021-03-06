namespace Entity.ResponseMessage
{
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
        private string CurrentDirectory { get; set; }
        private string FileName { get; set; }
        private string FilePath { get; set; }
        public string ToLog(string status, string message)
        {
            return Logger(status, message);
        }
        public string Logger(string status, string message)
        {
            FileName = "Logs.txt";
            CurrentDirectory = Directory.GetCurrentDirectory();
            FilePath = CurrentDirectory + "/" + FileName;
            return Log(status, message);
        }
        public string Log(string status, string message)
        {
            using (System.IO.StreamWriter writer = System.IO.File.AppendText(FilePath))
            {
                writer.Write("\r\nLog Entry : ");
                writer.WriteLine("{0} {1}", DateTime.Now.ToString("R"), DateTime.Now.ToLongTimeString());
                writer.WriteLine("  : {0}", status == null ? "Error" + " || " + message.ToString() : status.ToString() + " || " + message.ToString());
                writer.WriteLine("---------------------------------------------------------------------------------------------");
                return status == null ? "Error" + " || " + message.ToString() : status.ToString() + " || " + message.ToString();
            }
        }
    }
}
