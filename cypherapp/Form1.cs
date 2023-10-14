using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace cypherapp
{
    public partial class Form1 : Form
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int BlockSize = 128;
        public Form1()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.BackColor = Color.FromArgb(40, 40, 40); // Dark background color

            // Styling for labels
            label1.ForeColor = Color.White;
            label1.Font = new Font("Arial", 16, FontStyle.Bold);

            label2.ForeColor = Color.White;
            label2.Font = new Font("Arial", 16, FontStyle.Bold);

            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;

            // Styling for buttons
            encbutton.BackColor = Color.FromArgb(65, 105, 225); // Royal Blue
            encbutton.ForeColor = Color.White;
            encbutton.Font = new Font("Arial", 12, FontStyle.Bold);

            decbutton.BackColor = Color.FromArgb(65, 105, 225);
            decbutton.ForeColor = Color.White;
            decbutton.Font = new Font("Arial", 12, FontStyle.Bold);

            // Styling for textboxes
            enctextbox.BackColor = Color.FromArgb(20, 20, 20); // Dark Gray
            enctextbox.ForeColor = Color.White;
            enctextbox.BorderStyle = BorderStyle.None;

            dectextbox.BackColor = Color.FromArgb(20, 20, 20);
            dectextbox.ForeColor = Color.White;
            dectextbox.BorderStyle = BorderStyle.None;
        }

        private void encbutton_Click(object sender, EventArgs e)
        {
            string mystr = this.enctext();
            if (mystr == "")
            {
                this.enctextbox.Text = "ERROR.. TEXT CANNOT BE EMPTY";
            } else
            {
                this.enctextbox.Text = mystr;
            }
        }

        private void decbutton_Click(object sender, EventArgs e)
        {
            string mystr = this.dectext();
            if (mystr == "")
            {
                this.enctextbox.Text = "ERROR.. CANNOT DECRYPT TEXT";
            }

            this.dectextbox.Text = mystr;
        }

        private String enctext()
        {
            if (this.enctextbox.Text == "")
            {
                return "";
            }

            byte[] bytes = Encoding.Unicode.GetBytes(this.enctextbox.Text);
            //Encrypt
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.BlockSize = BlockSize;
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes("thispass"));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }

                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        private String dectext()
        {
            if (this.dectextbox.Text == "")
            {
                return "";
            }

            //Decrypt
            byte[] bytes = Convert.FromBase64String(this.dectextbox.Text);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes("thispass"));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    this.dectextbox.Text = "";

                    return Encoding.Unicode.GetString(decryptedBytes);
                }
            }
        }
    }
}