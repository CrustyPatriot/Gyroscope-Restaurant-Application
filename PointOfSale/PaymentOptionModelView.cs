using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Contains the definitions and logic for the payment.
    /// </summary>
    public class PaymentOptionModelView: INotifyPropertyChanged
    {


        /// <summary>
        /// Propetychanged handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// gets the order
        /// </summary>
        public Order Order { get; set; }

        #region

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int onehundrednumber = 0;


        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int OneHundredNumber
        {
            get => onehundrednumber;
            set
            {
                if (onehundrednumber != value)
                {
                    onehundrednumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 100;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 100;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneHundredNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int fiftynumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int FiftyNumber
        {
            get => fiftynumber;
            set
            {
                if (fiftynumber != value)
                {
                    fiftynumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 50;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 50;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int twentynumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int TwentyNumber
        {
            get => twentynumber;
            set
            {
                if (twentynumber != value)
                {
                    twentynumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 20;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 20;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int tennumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int TenNumber
        {
            get => tennumber;
            set
            {
                if (tennumber != value)
                {
                    tennumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 10;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 10;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int fivenumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int FiveNumber
        {
            get => fivenumber;
            set
            {
                if (fivenumber != value)
                {
                    fivenumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 5;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 5;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int twonumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int TwoNumber
        {
            get => twonumber;
            set
            {
                if (twonumber != value)
                {
                    twonumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 2;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 2;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwoNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int onenumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int OneNumber
        {
            get => onenumber;
            set
            {
                if (onenumber != value)
                {
                    onenumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 1;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 1;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneNumber"));
                }
            }
        }
        #endregion

        #region

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int onecoinnumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int OneCoinNumber
        {
            get => onecoinnumber;
            set
            {
                if (onecoinnumber != value)
                {
                    onecoinnumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 1;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 1;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OneCoinNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int fiftycoinnumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int FiftyCoinNumber
        {
            get => fiftycoinnumber;
            set
            {
                if (fiftycoinnumber != value)
                {
                    fiftycoinnumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 0.50m;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 0.50m;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftyCoinNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int twentyfivecoinnumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int TwentyFiveCoinNumber
        {
            get => twentyfivecoinnumber;
            set
            {
                if (twentyfivecoinnumber != value)
                {
                    twentyfivecoinnumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 0.25m;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 0.25m;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentyFiveCoinNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int tencoinnumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int TenCoinNumber
        {
            get => tencoinnumber;
            set
            {
                if (tencoinnumber != value)
                {
                    tencoinnumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 0.10m;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 0.10m;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TenCoinNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int fivecoinnumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int FiveCoinNumber
        {
            get => fivecoinnumber;
            set
            {
                if (fivecoinnumber != value)
                {
                    fivecoinnumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 0.05m;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 0.05m;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiveCoinNumber"));
                }
            }
        }

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        private int onecentnumber = 0;

        /// <summary>
        /// Handles the customers cash given
        /// </summary>
        public int OneCentNumber
        {
            get => onecentnumber;
            set
            {
                if (onecentnumber != value)
                {
                    onecentnumber = value;
                    if (Plus == true)
                    {
                        amountdue = amountdue - 0.01m;

                        if (amountdue <= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue > 0 && temp != 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                        }
                    }
                    if (Minus == true)
                    {
                        amountdue = amountdue + 0.01m;
                        if (amountdue >= 0)
                        {
                            changedue -= amountdue;
                            temp -= amountdue;
                            amountdue = 0;
                            GetChangeAmount();
                        }
                        if (amountdue <= 0 && temp <= 0)
                        {
                            changedue = 0;
                            amountdue -= temp;
                            temp = 0;
                            GetChangeAmount();
                        }
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("onecentnumber"));
                }
            }
        }
        #endregion

        #region

        /// <summary>
        /// gets the change amount
        /// </summary>
        public void GetChangeAmount()
        {
            ResetChange();
            decimal amountleft = ChangeDue;
            if (amountleft >= 100)
            {
                while (Hundreds != 0 && amountleft >= 100)
                {
                    HundredChange++;
                    amountleft -= 100;
                }
            }
            if (amountleft >= 50)
            {
                while (Fifties != 0 && amountleft >= 100)
                {
                    FiftiesChange++;
                    amountleft -= 50;
                }
            }
            if (amountleft >= 20)
            {
                while (Twenties != 0 && amountleft >= 20)
                {
                    TwentiesChange++;
                    amountleft -= 20;
                }
            }
            if (amountleft >= 10)
            {
                while (Tens != 0 && amountleft >= 10)
                {
                    TensChange++;
                    amountleft -= 10;
                }
            }
            if (amountleft >= 5)
            {
                while (Fives != 0 && amountleft >= 5)
                {
                    FivesChange++;
                    amountleft -= 5;
                }
            }

            if (amountleft >= 2)
            {
                while (Twos != 0 && amountleft >= 2)
                {
                    TwosChange++;
                    amountleft -= 2;
                }
            }

            if (amountleft >= 1)
            {
                while (Ones != 0 && amountleft >= 1)
                {
                    OnesChange++;
                    amountleft -= 1;
                }
            }
            if (amountleft >= 1)
            {
                while (Dollars != 0 && amountleft >= 1)
                {
                    DollarsChange++;
                    amountleft -= 1;
                }
            }
            if (amountleft >= 0.5m)
            {
                while (HalfDollars != 0 && amountleft >= 0.5m)
                {
                    HalfDollarsChange++;
                    amountleft -= 0.5m;
                }
            }
            if (amountleft >= 0.25m)
            {
                while (Quarters != 0 && amountleft >= 0.25m)
                {
                    QuartersChange++;
                    amountleft -= 0.25m;
                }
            }
            if (amountleft >= 0.10m)
            {
                while (Dimes != 0 && amountleft >= 0.10m)
                {
                    DimesChange++;
                    amountleft -= 0.10m;
                }
            }
            if (amountleft >= 0.05m)
            {
                while (Nickels != 0 && amountleft >= 0.05m)
                {
                    NickelsChange++;
                    amountleft -= 0.05m;
                }
            }
            if (amountleft >= 0.01m)
            {
                while (Pennies != 0 && amountleft >= 0.01m)
                {
                    PenniesChange++;
                    amountleft -= 0.01m;
                }
            }
        }
        /// <summary>
        /// subtracts amount from cash drawer
        /// </summary>
        public void SubtractFromCashDrawer()
        {
            pennies -= pennieschange;
            nickels -= nickelschange;
            dimes -= dimeschange;
            quarters -= quarterschange;
            halfdollars -= halfdollarschange;
            dollars -= dollarschange;
            ones -= oneschange;
            twos -= twoschange;
            fives -= fiveschange;
            tens -= tenschange;
            twenties -= twentieschange;
            fifties -= fiftieschange;
            hundreds -= hundredchange;
        }

        /// <summary>
        /// Adds amount to cash drawer
        /// </summary>
        public void AddToCashDrawer()
        {
            pennies += onecentnumber;
            nickels += fivecoinnumber;
            dimes += tencoinnumber;
            quarters += twentyfivecoinnumber;
            halfdollars += fiftycoinnumber;
            dollars += onecoinnumber;
            ones += onenumber;
            twos += twonumber;
            fives += fivenumber;
            tens += tennumber;
            twenties += twentynumber;
            fifties += fiftynumber;
            hundreds += onehundrednumber;
        }

        /// <summary>
        /// resets the change 
        /// </summary>
        public void ResetChange()
        {
            HundredChange = 0;
            TwentiesChange = 0;
            TensChange = 0;
            FivesChange = 0;
            OnesChange = 0;
            DollarsChange = 0;
            QuartersChange = 0;
            DimesChange = 0;
            HalfDollarsChange = 0;
            NickelsChange = 0;
            PenniesChange = 0;
            FiftiesChange = 0;
            TwosChange = 0;
        }

        /// <summary>
        /// Private events for the change
        /// </summary>
        private int hundredchange = 0;
        private int twentieschange = 0;
        private int tenschange = 0;
        private int fiveschange = 0;
        private int oneschange = 0;
        private int dollarschange = 0;
        private int quarterschange = 0;
        private int dimeschange = 0;
        private int halfdollarschange = 0;
        private int nickelschange = 0;
        private int pennieschange = 0;
        private int fiftieschange = 0;
        private int twoschange = 0;

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int HundredChange
        {
            get { return hundredchange; }
            set
            {
                if (hundredchange != value)
                {
                    hundredchange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int FiftiesChange
        {
            get { return fiftieschange; }
            set
            {
                if (fiftieschange != value)
                {
                    fiftieschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int TwentiesChange
        {
            get { return twentieschange; }
            set
            {
                if (twentieschange != value)
                {
                    twentieschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int TensChange
        {
            get { return tenschange; }
            set
            {
                if (tenschange != value)
                {
                    tenschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int FivesChange
        {
            get { return fiveschange; }
            set
            {
                if (fiveschange != value)
                {
                    fiveschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int TwosChange
        {
            get { return twoschange; }
            set
            {
                if (twoschange != value)
                {
                    twoschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int OnesChange
        {
            get { return oneschange; }
            set
            {
                if (oneschange != value)
                {
                    oneschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int DollarsChange
        {
            get { return dollarschange; }
            set
            {
                if (dollarschange != value)
                {
                    dollarschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarsChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int QuartersChange
        {
            get { return quarterschange; }
            set
            {
                if (quarterschange != value)
                {
                    quarterschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int DimesChange
        {
            get { return dimeschange; }
            set
            {
                if (dimeschange != value)
                {
                    dimeschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int NickelsChange
        {
            get { return nickelschange; }
            set
            {
                if (nickelschange != value)
                {
                    nickelschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int PenniesChange
        {
            get { return pennieschange; }
            set
            {
                if (pennieschange != value)
                {
                    pennieschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesChange"));
                }

            }
        }

        /// <summary>
        /// Change payment amounts
        /// </summary>
        public int HalfDollarsChange
        {
            get { return halfdollarschange; }
            set
            {
                if (halfdollarschange != value)
                {
                    halfdollarschange = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsChange"));
                }

            }
        }

        /// <summary>
        /// private fields for the cashdrawer amounts
        /// </summary>
        private int pennies = CashDrawer.Pennies;
        private int nickels = CashDrawer.Nickels;
        private int dimes = CashDrawer.Dimes;
        private int halfdollars = CashDrawer.HalfDollars;
        private int dollars = CashDrawer.Dollars;
        private int ones = CashDrawer.Ones;
        private int twos = CashDrawer.Twos;
        private int fives = CashDrawer.Fives;
        private int tens = CashDrawer.Tens;
        private int twenties = CashDrawer.Twenties;
        private int fifties = CashDrawer.Fifties;
        private int hundreds = CashDrawer.Hundreds;
        private int quarters = CashDrawer.Quarters;

        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Pennies
        {
            get { return pennies; }
            set
            {
                if (pennies != value)
                {
                    pennies = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Nickels
        {
            get { return nickels; }
            set
            {
                if (nickels != value)
                {
                    nickels = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Dimes
        {
            get { return dimes; }
            set
            {
                if (dimes != value)
                {
                    dimes = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Quarters
        {
            get { return quarters; }
            set
            {
                if (quarters != value)
                {
                    quarters = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int HalfDollars
        {
            get { return halfdollars; }
            set
            {
                if (halfdollars != value)
                {
                    halfdollars = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Dollars
        {
            get { return dollars; }
            set
            {
                if (dollars != value)
                {
                    dollars = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Ones
        {
            get { return ones; }
            set
            {
                if (ones != value)
                {
                    ones = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Twos
        {
            get { return twos; }
            set
            {
                if (twos != value)
                {
                    twos = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Fives
        {
            get { return fives; }
            set
            {
                if (fives != value)
                {
                    fives = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Tens
        {
            get { return tens; }
            set
            {
                if (tens != value)
                {
                    tens = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Twenties
        {
            get { return twenties; }
            set
            {
                if (twenties != value)
                {
                    twenties = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Fifties
        {
            get { return fifties; }
            set
            {
                if (fifties != value)
                {
                    fifties = value;
                }
            }
        }
        /// <summary>
        /// cashdrawer amounts
        /// </summary>
        public int Hundreds
        {
            get { return hundreds; }
            set
            {
                if (hundreds != value)
                {
                    hundreds = value;
                }
            }
        }
        #endregion



        /// <summary>
        /// determines if we are adding money to payment
        /// </summary>
        public bool Plus { get; set; }


        /// <summary>
        /// determines if we are subtacting money to payment
        /// </summary>
        public bool Minus { get; set; }

        /// <summary>
        /// private field for the amount due
        /// </summary>
        private decimal amountdue;

        /// <summary>
        /// a property for the amount due
        /// </summary>
        public decimal AmountDue
        {
            get { return amountdue; }
            set
            {
                if (amountdue != value)
                {
                    amountdue = value;
                }
            }
        }

        /// <summary>
        /// temp to hold amount due
        /// </summary>
        private decimal temp;

        /// <summary>
        /// determines the change due
        /// </summary>
        private decimal changedue = 0;
        /// <summary>
        /// determines the change due
        /// </summary>
        public decimal ChangeDue
        {
            get { return changedue; }
            set
            {
                if (changedue != value)
                {
                    changedue = value;
                }
            }
        }

        /// <summary>
        /// gets the total of the order
        /// </summary>
        public decimal Total
        {
            get
            {
                return Order.Total;
            }
        }

        /// <summary>
        /// gets the cash
        /// </summary>
        public bool Cash { get; set; }

        /// <summary>
        /// gets the credit debit card payment
        /// </summary>
        public bool CreditDebitCard { get; set; }

        /// <summary>
        /// pritns the recipet
        /// </summary>
        public void Print()
        {
            RecieptPrinter.PrintLine("Order Number: " + Order.Number.ToString());
            RecieptPrinter.PrintLine("Date and Time: " + Order.PlacedAt.ToString());
            RecieptPrinter.PrintLine(" ");
            RecieptPrinter.PrintLine("Order: ");
            for (int i = 0; i < Order._order.Count; i++)
            {
                RecieptPrinter.PrintLine(Order._order[i].Name.ToString() + "   $" + Order._order[i].Price.ToString());
                RecieptPrinter.PrintLine(" ");
            }
            RecieptPrinter.PrintLine(" ");
            RecieptPrinter.PrintLine("SubTotal: " + string.Format("{0:C}", Order.Subtotal));
            RecieptPrinter.PrintLine("Tax: " + string.Format("{0:C}", Order.Tax));
            RecieptPrinter.PrintLine("Total: " + string.Format("{0:C}", Order.Total));
            if (Cash)
            {
                RecieptPrinter.PrintLine("Payment Type: Cash");
                RecieptPrinter.PrintLine("Change Owed: " + string.Format("{0:C}", ChangeDue));
            }
            if (CreditDebitCard)
            {
                RecieptPrinter.PrintLine("Payment Type: Debit/Credit");
                RecieptPrinter.PrintLine("Change Owed: 0");
            }
            RecieptPrinter.CutTape();
        }
    }
}
