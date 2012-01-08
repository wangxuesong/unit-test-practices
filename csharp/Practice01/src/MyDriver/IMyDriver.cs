namespace MyDriver
{
    public interface IMyDriver
    {
        void Connect();
        void AddQuery(int queryId);
        void RemoveQuery(int queryId);
        void Close();
        MyData Receive();
    }
}