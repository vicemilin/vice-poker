using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Poker.Core;
using Win.Poker.Core.Helpers;
using Win.Poker.Core.Models;
using Win.Poker.Helpers;

namespace Win.Poker
{
    public partial class FormDouble : Form
    {
        public decimal WinAmount { get; set; }
        private CardModel _currentCard;

        public FormDouble()
        {
            InitializeComponent();
            cardImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            CheckDouble(DoubleColor.Red);
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            CheckDouble(DoubleColor.Black);
        }

        private void FormDouble_Load(object sender, EventArgs e)
        {
            cardImage.Image = ImageHelper.Background;
            _currentCard = CardGenerator.GetRandomCard();
            lblWinAmount.Visible = true;
            lblWinAmount.Text = "Win: " + WinAmount;
        }

        private void CheckDouble(DoubleColor color)
        {
            btnBlack.Visible = false;
            btnRed.Visible = false;
            btnCollect.Visible = false;
            cardImage.Image = ImageHelper.GetCardImage(_currentCard);
            bool isWin = ResultHelper.IsDoubleWin(color, _currentCard.Color);
            if (isWin)
                WinAmount *= 2;
            else
                WinAmount = 0;

            if (!isWin)
                btnClose.Visible = true;
            else
            {
                TaskEx.Delay(1500).Wait();
                btnBlack.Visible = true;
                btnRed.Visible = true;
                btnCollect.Visible = true;
                _currentCard = CardGenerator.GetRandomCard();
                cardImage.Image = ImageHelper.Background;
            }

            lblWinAmount.Text = "Win: " + WinAmount;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
