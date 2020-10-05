using Microsoft.Win32;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Win.Poker.Helpers;
using Win.Poker.Core.Models;
using Win.Poker.Core.Helpers;

namespace Win.Poker
{
	public partial class MainForm : Form
	{
        public decimal CreditAmount { get; private set; }
        private readonly HandModel _hand = new HandModel();
        private decimal _bet = 1;

		public MainForm()
		{
			InitializeComponent();
			ImageHelper.LoadCardImages();
            //Set picture boxes to stretch mode for automatic image resize
            cardImage0.SizeMode = PictureBoxSizeMode.StretchImage;
            cardImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            cardImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            cardImage3.SizeMode = PictureBoxSizeMode.StretchImage;
            cardImage4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        #region Events
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoadCreditInfo();
            DrawHand();
        }

        private void btnDeal_Click(object sender, System.EventArgs e)
        {
            _hand.Deal();
            DrawHand();
        }


        private void cardImage0_Click(object sender, System.EventArgs e)
        {
            _hand.Hold(0);
            DrawHand();
        }

        private void cardImage1_Click(object sender, System.EventArgs e)
        {
            _hand.Hold(1);
            DrawHand();
        }

        private void cardImage2_Click(object sender, System.EventArgs e)
        {
            _hand.Hold(2);
            DrawHand();
        }

        private void cardImage3_Click(object sender, System.EventArgs e)
        {
            _hand.Hold(3);
            DrawHand();
        }

        private void cardImage4_Click(object sender, System.EventArgs e)
        {
            _hand.Hold(4);
            DrawHand();
        }

        private void MainForm_Leave(object sender, System.EventArgs e)
        {
            this.Focus();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCreditInfo();
        }
        #endregion

        private void LoadCreditInfo()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            var creditEntry = key.GetValue("POKER_CREDIT");
            if (creditEntry == null)
            {
                CreditAmount = 100.0m;
                key.SetValue("POKER_CREDIT", CreditAmount);
            }
            else
                CreditAmount = decimal.Parse(creditEntry.ToString());
        }

        private void SaveCreditInfo()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.SetValue("POKER_CREDIT", CreditAmount);
        }

        private void DrawHand()
        {
            #region Draw Cards
            cardImage0.Image = ImageHelper.GetCardImage(_hand.State.CurrentCards[0]);
            cardImage1.Image = ImageHelper.GetCardImage(_hand.State.CurrentCards[1]);
            cardImage2.Image = ImageHelper.GetCardImage(_hand.State.CurrentCards[2]);
            cardImage3.Image = ImageHelper.GetCardImage(_hand.State.CurrentCards[3]);
            cardImage4.Image = ImageHelper.GetCardImage(_hand.State.CurrentCards[4]);
            #endregion

            #region Draw Holds
            if(_hand.State.FirstDeal && !_hand.State.SecondDeal)
            {
                lblHold0.Visible = _hand.State.HeldCards[0];
                lblHold1.Visible = _hand.State.HeldCards[1];
                lblHold2.Visible = _hand.State.HeldCards[2];
                lblHold3.Visible = _hand.State.HeldCards[3];
                lblHold4.Visible = _hand.State.HeldCards[4];
            }
            else
            {
                lblHold0.Visible = false;
                lblHold1.Visible = false;
                lblHold2.Visible = false;
                lblHold3.Visible = false;
                lblHold4.Visible = false;
            }
            #endregion

            lblCredit.Text = "Credit: " + CreditAmount.ToString();

            #region Result
            lblWinAmount.Visible = false;
            lblWinType.Visible = false;
            if (_hand.State.FirstDeal)
            {
                var result = _hand.GetResult();
                if(result != Core.HandResult.None)
                {
                    lblWinAmount.Visible = true;
                    lblWinType.Visible = true;
                    lblWinAmount.Text = "Win: " + (_bet * (decimal)result).ToString();
                    lblWinType.Text = ResultHelper.GetResultName(result);
                }
            }
            #endregion
        }
    }
}
