using SuperSimpleTcp;
using System.Text;

namespace ServerApp
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        SimpleTcpServer server;
        private void BtnRun_Click(object sender, EventArgs e)
        {
            server.Start();
            txtConsole.Text += $"Starting the server...{Environment.NewLine}";
            btnRun.Enabled = false;
            btnSend.Enabled = true;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            server = new SimpleTcpServer(txtServerIP.Text);

            //set events
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtConsole.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
            
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtConsole.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                lstConnectedClients.Items.Remove(e.IpPort);
            });
            
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtConsole.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                lstConnectedClients.Items.Add(e.IpPort);
            });
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(server.IsListening)
            {
                if(!string.IsNullOrEmpty(txtMsg.Text)&&lstConnectedClients.SelectedItem!=null)
                {
                    server.Send(lstConnectedClients.SelectedItem.ToString(),txtMsg.Text);
                    txtConsole.Text += $"Server: {txtMsg.Text}{Environment.NewLine}";
                    txtMsg.Text = String.Empty;
                }
            }
        }
    }
}