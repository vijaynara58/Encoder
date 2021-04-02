using System;
using System.Windows.Forms;
using System.IO;

namespace Encoder
{
    public partial class frmEncoder : Form
    {
        public frmEncoder()
        {
            InitializeComponent();
        }

        public cEncoderDecoder encodeDecode = new cEncoderDecoder();

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();

        }

        private void radCreateKey_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerateKey.Visible = true;
            btnKeySave.Visible = false;
        }

        private void radSaveKey_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerateKey.Visible = false;
            btnKeySave.Visible = true;
        }

        //Button to generate a new key
        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            rtxtKey.Clear();
            rtxtKey.Text = encodeDecode.generateNewKey();
            



        }
        private void frmEncoder_Load(object sender, EventArgs e)
        {
            encodeDecode.fillOriginal();
        }

        private bool btnEncodeWasClicked = false;
        public void btnEncode_Click(object sender, EventArgs e)
        {
            btnEncodeWasClicked = true;
            lblError.Text = "";
            if(rtxtKey.Text=="")
            {
                lblError.Text = "Empty Key";
            }
            else
            {
                string theKey = rtxtKey.Text;
                string theInput = rtxtResult.Text;

                bool veriOk = encodeDecode.verifKey(theKey);

                if(veriOk != true)
                {
                    lblError.Text = "Invalid Key";
                    return;
                }
                rtxtResult.Text = encodeDecode.Encoding(theKey, theInput);
            }
        }
        private void radOwnKey_CheckedChanged(object sender, EventArgs e)
        {
            rtxtKey.ReadOnly = false;
            openFileDialog1.Filter = "Text File|*.txt";
            openFileDialog1.Title = "Open Key";
            
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                   try
                    {
                        openFileDialog1.OpenFile();
                        StreamReader sr = System.IO.File.OpenText(openFileDialog1.FileName);
                        rtxtKey.Text = sr.ReadToEnd();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                 
                }

            
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            
            //if there is no key
            if(rtxtKey.Text == "")
            {
                lblError.Text = "Please use a key";
            }
            //if there is key
            else
            {
                //If there is no text for decoding
                if(rtxtResult.Text == "")
                {
                    lblError.Text = "Please enter some text to DECODE";
                }
                //If User has entered some text
                else
                {
                    //text to decode
                    string theText = rtxtResult.Text;
                    //Available key
                    string theKey = rtxtKey.Text;

                    bool verifOk = encodeDecode.verifKey(theKey);
                    //If the key is not verified
                    if(verifOk != true)
                    {
                        lblError.Text = "The key is Invalid!!";
                        return;
                    }
                    //If the key is verified.
                    else
                    {
                        //Decoding call
                        rtxtResult.Text = encodeDecode.Decoding(theKey, theText);
                    }

                }
            }

        }

        private void btnKeySave_Click(object sender, EventArgs e)
        {
            //Filter to save the file only in text file format
            saveFileDialog1.Filter = "Text File|*.txt";
            //Title of the dialog box
            saveFileDialog1.Title = "Save Key";
            
            if (rtxtKey.Text != "")
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    
                        using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                        using (StreamWriter sw = new StreamWriter(s))
                    { 
                        sw.Write(rtxtKey.Text);
                        MessageBox.Show("File Saved!");
                    }
                }
                   
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtResult.Text = "";
        }
    }
}
