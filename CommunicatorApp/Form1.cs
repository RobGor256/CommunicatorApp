using SuperSimpleTcp;
using System.Text;

namespace ServerApp
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if(client.IsConnected)
            {
                if(!string.IsNullOrEmpty(txtMsg.Text))
                {
                    client.Send("(" + txtUsername.Text + ")" + " : " + txtMsg.Text);
                    txtConsole.Text += $"{txtUsername.Text}: {txtMsg.Text}{Environment.NewLine}";
                    txtMsg.Text = string.Empty;
                }
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Username cannot be empty");
                }
                else
                {
                    client.Connect();
                    btnSend.Enabled = true;
                    btnConnect.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(txtServerIP.Text);

            //set events
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            btnSend.Enabled = false;
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtConsole.Text += $"Server disconnected.{Environment.NewLine}";
            });
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtConsole.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtConsole.Text += $"Server connected.{Environment.NewLine}";
            });
        }
    }
}