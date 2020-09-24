
namespace FlightSimulatorApp
{
    interface IClient
    {
        void Connect(string ip, string port);
        bool IsConnected();

        void Write(string command);

        string Read();

        void SetReceiveTimeout(int t);
        void Disconnect();
    }
}
