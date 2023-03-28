using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetTools;
using System.Net;
namespace Lab1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = $"{oct1.Text}.{oct2.Text}.{oct3.Text}.{oct4.Text}";
                ValidIp(ipAddress, int.Parse(cidr.Text));
                Subnetting();

            }
            catch (IPException ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            oct1.Clear();
            oct2.Clear();
            oct3.Clear();
            oct4.Clear();
            cidr.Clear();
            subnetNum.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class IPException : Exception
        {
            public IPException(string msg) : base(msg) { }
        }

        private void ValidIp(string IP, int cidr)
        {
            string[] ipPart = IP.Split('.');
            int[] ipOct = new int[4];
            for(int i = 0; i < ipPart.Length; i++)
            {
                ipOct[i] = int.Parse(ipPart[i]);
            }
            foreach(int i in ipOct)
            {
                if(i < 0 || i > 255)
                {
                    throw new IPException("Invalid IP Address");
                }
            }
            if(cidr < 0 || cidr > 32)
            {
                throw new IPException("Invalid CIDR");
            }
            string ipFull = IP + '/' +FormatCIDR(cidr);
            var range = IPAddressRange.Parse(ipFull);
<<<<<<< HEAD
            bool test = range.Contains(IPAddress.Parse(IP));
            if (!range.Contains(IPAddress.Parse(IP)))
=======

            bool test = range.Contains(IPAddress.Parse(IP));

            if (range.Contains(IPAddress.Parse(IP)))
>>>>>>> a321b8ff2936decce3905c6ebb87e157d5326e42
            {
                throw new IPException("Invalid CIDR");
            }
        }

        private void Subnetting()
        {
            uint subnetCount = uint.Parse(subnetNum.Text);
            uint[] ipByte = new uint[4] { uint.Parse(oct1.Text), uint.Parse(oct2.Text), uint.Parse(oct3.Text), uint.Parse(oct4.Text) };

            uint bitsNeeded = (uint)Math.Ceiling(Math.Log(subnetCount, 2));
            uint[] subnetMask = new uint[4];
            uint newsub = 32 - bitsNeeded;
            for (uint i = 0; i < 4; i++)
            {
                if (newsub >= 8)
                {
                    subnetMask[i] = 255;
                    newsub -= 8;
                }
                else if (newsub > 0)
                {
                    subnetMask[i] = (255 - ((uint)Math.Pow(2, 8 - bitsNeeded) - 1));
                    newsub = 0;
                }
                else
                {
                    subnetMask[i] = 0;
                }
            }

            uint[] debug = subnetMask;
            debug = ipByte;

            uint subnetAddressuint = (ipByte[0] << 24) + (ipByte[1] << 16) + (ipByte[2] << 8) + ipByte[3];
            uint subnetMaskuint = (subnetMask[0] << 24) + (subnetMask[1] << 16) + (subnetMask[2] << 8) + subnetMask[3];
            subnetAddressuint &= subnetMaskuint;

            DataTable dt = new DataTable();
            dt.Columns.Add("Subnet", typeof(uint));
            dt.Columns.Add("Network Address", typeof(string));
            dt.Columns.Add("First Address", typeof(string));
            dt.Columns.Add("Last Address", typeof(string));
            dt.Columns.Add("Broadcast", typeof(string));


            uint[] subnetAddresses = new uint[subnetCount];
            for (uint i = 0; i < subnetCount; i++)
            {
                subnetAddresses[i] = subnetAddressuint + i * (uint)Math.Pow(2, 8 - bitsNeeded);

                // Calculate the first, last, and broadcast IP addresses for each subnet
                uint firstAddress = subnetAddresses[i] + 1;
                uint lastAddress = subnetAddresses[i] + (uint)Math.Pow(2, 8 - bitsNeeded) - 2;
                uint broadcastAddress = subnetAddresses[i] + (uint)Math.Pow(2, 8 - bitsNeeded) - 1;
                dt.Rows.Add(i + 1, FormatIP(subnetAddresses[i]), FormatIP(firstAddress), FormatIP(lastAddress), FormatIP(broadcastAddress));
            }

            dataGridView1.DataSource = dt;
        }


        private string FormatCIDR(int cidr)
        {
            cidr = -1 ^ ((1 << (32 - cidr)) - 1);
            return $"{(cidr >> 24) & 0xFF}.{(cidr >> 16) & 0xFF}.{(cidr >> 8) & 0xFF}.{cidr & 0xFF}";
        }

        private string FormatIP(uint IP)
        {
            return $"{(IP >> 24) & 0xFF}.{(IP >> 16) & 0xFF}.{(IP >> 8) & 0xFF}.{IP & 0xFF}";

        }
    }
}
