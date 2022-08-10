using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DELFI_WHM.NET.QuanLy
{
    public partial class frmKetnoican : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        public static string Access_Connection = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb";
        private TcpListener _tcplistener;
        private Thread _listenThread;
        private static Thread _threadConnect;
        private TcpClient _tcpClient;
        private TcpClient _myClient;
        string _bufferincmessage;
        private int _typeConnect;
        private SerialPort _serialPort;

        public frmKetnoican()
        {
            InitializeComponent();
        }

        public static DataTable Getdata_Access(string sql)
        {
            OleDbConnection cnn = new OleDbConnection(Access_Connection);
            cnn.Close();
            cnn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public static bool Excute_Access(string sql)
        {
            OleDbConnection cnn = new OleDbConnection(Access_Connection);
            cnn.Close();
            cnn.Open();
            OleDbCommand command = new OleDbCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
            return true;
        }

        private void btnstartcom_Click(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.tblConfigScale.Where(c => c.ID == 1).FirstOrDefault();
                txtcom1.Text = list.IPServer;
                txtparity.Text = list.Parity;
                txtstopbits.Text = list.StopBits.ToString();
                txtmaxspeed.Text = list.MaxSpeed.ToString();
                txtdatabits.Text = list.DataBits.ToString();
            }
            OpenPort();
            btnBatdau.Enabled = false;
        }

        /// <summary>
        /// Mở port cho cổng COM1
        /// </summary>
        private void OpenPort()
        {
            try
            {
                bool portExists = SerialPort.GetPortNames().Any(x => x == txtcom1.Text);
                if (portExists)
                {
                    //using (_serialPort =new SerialPort())
                    //{

                    //}
                    _serialPort = new SerialPort
                    {
                        RtsEnable = true,
                        DtrEnable = true,
                        PortName = txtcom1.Text,
                        BaudRate = int.Parse(txtmaxspeed.Text),
                        Parity = GetParity(txtparity.Text),
                        DataBits = int.Parse(txtdatabits.Text),
                        StopBits = GetStopBits(txtstopbits.Text),
                        ReadBufferSize = 10240,
                        WriteBufferSize = 10240,
                        ReadTimeout = 500,
                    };
                    _typeConnect = 3;
                    _serialPort.DataReceived += serialPort_DataReceived;
                    _serialPort.Open();
                    if (_serialPort.IsOpen)
                    {
                        SetStatus(2, lblStatus);
                    }
                    else
                    {
                        SetStatus(0, lblStatus);
                    }
                }
                else
                {
                    ClosePort();
                    lblStatus.Text = "COM note existed.";
                    lblStatus.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                ClosePort();
                MessageBox.Show(ex.Message);
            }
        }

        private Parity GetParity(string parity)
        {
            var parityFullName = Parity.None;
            switch (parity)
            {
                case ParityContant.NoneKey:
                    parityFullName = Parity.None;
                    break;
                case ParityContant.EvenKey:
                    parityFullName = Parity.Even;
                    break;
                case ParityContant.OddKey:
                    parityFullName = Parity.Odd;
                    break;
                case ParityContant.MarkKey:
                    parityFullName = Parity.Mark;
                    break;
                case ParityContant.SpaceKey:
                    parityFullName = Parity.Space;
                    break;
            }

            return parityFullName;
        }

        private StopBits GetStopBits(string stopBits)
        {
            var stopBitsFullName = StopBits.One;
            switch (stopBits)
            {
                case "1":
                    stopBitsFullName = StopBits.One;
                    break;
                case "1.5":
                    stopBitsFullName = StopBits.OnePointFive;
                    break;
                case "2":
                    stopBitsFullName = StopBits.Two;
                    break;
                default:
                    stopBitsFullName = StopBits.None;
                    break;
            }

            return stopBitsFullName;
        }

        void SetStatus(int _status, TextBox lbl)
        {
            this.Invoke(new EventHandler(delegate
            {
                if (_status == 0)
                {//Stop
                    lbl.Text = "Disconnected";
                    lbl.ForeColor = Color.Red;
                }
                else if (_status == 1)
                { //Waitting...
                    lbl.Text = "Waiting...";
                    lbl.ForeColor = Color.Yellow;
                }
                else if (_status == 2)
                { //Opening...
                    lbl.Text = "Connected";
                    lbl.ForeColor = Color.Lime;
                }
            }));
        }

        private void Receive(Socket handler, string msg)
        {
            Invoke(new EventHandler(delegate
            {
                ReceiveData(msg);
            }));
        }
        bool receiving = false;
        private void Receive(string msg)
        {
            Invoke(new EventHandler(delegate
            {
                ReceiveData(msg);
            }));
        }

        private void ReceiveData(string msg)
        {           
            txtResultCom1.AppendText(msg);
            receiving = true;
        }

        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = (SerialPort)sender;
            if (!serialPort.IsOpen || serialPort.BytesToRead <= 0) return;
            var array = new byte[serialPort.BytesToRead];
            serialPort.Read(array, 0, array.Length);
            _bufferincmessage = Encoding.ASCII.GetString(array);

            Receive(_bufferincmessage);
        }
        private void ClosePort()
        {
            if (_serialPort != null)
            {
                _serialPort.Close();
            }

            SetStatus(0, lblStatus);
        }

        private void btnstopcom_Click(object sender, EventArgs e)
        {
            _serialPort.Close();
            ClosePort();

        }

        int TrongLuongCan = 0;
        private void txtResultCom1_TextChanged(object sender, EventArgs e)
        {
            string[] tempArray = txtResultCom1.Lines;
            if (tempArray.Length >= 3)
            {
                for (int i = tempArray.Length - 1; i >= tempArray.Length - 3; i--)
                {
                    if (tempArray[i].Contains("kg"))
                    {
                        textBox1.Text = tempArray[i].Replace(" ", "").Replace("kg", "").Replace(".0", "");
                        try
                        {
                            TrongLuongCan = Convert.ToInt32(textBox1.Text);
                        }
                        catch { }
                        numericUpDown1.Value = TrongLuongCan;
                    }
                    else
                    {
                        numericUpDown1.Value = numericUpDown1.Value;
                    }
                }
            }            
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
            tblConfigScale cb = db.tblConfigScale.Where(c => c.ID == 18).FirstOrDefault();
            cb.MaxSpeed = Convert.ToInt32(numericUpDown1.Value);
            db.SaveChanges();
            }
        }

        private void frmKetnoican_Load(object sender, EventArgs e)
        {
            btnstartcom_Click(sender, e);
        }
    }
}
