namespace Ardiente_NumSystemConversion
{
    public partial class Form1 : Form
    {
        private bool binaryInTrue = false;
        private bool decimalInTrue = false;
        private bool hexaInTrue = false;
        private bool octaInTrue = false;

        private bool binaryOutTrue = false;
        private bool decimalOutTrue = false;
        private bool hexaOutTrue = false;
        private bool octaOutTrue = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void octaInButton_CheckedChanged(object sender, EventArgs e)
        {
            if (octaInButton.Checked)
            {
                octaInTrue = true;
                hexaInTrue = false;
                decimalInTrue = false;
                binaryInTrue = false;
            }
        }

        private void decimalInButton_CheckedChanged(object sender, EventArgs e)
        {
            if (decimalInButton.Checked)
            {
                octaInTrue = false;
                hexaInTrue = false;
                decimalInTrue = true;
                binaryInTrue = false;
            }
        }

        private void hexaInButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hexaInButton.Checked)
            {
                octaInTrue = false;
                hexaInTrue = true;
                decimalInTrue = false;
                binaryInTrue = false;
            }
        }

        private void binaryInButton_CheckedChanged(object sender, EventArgs e)
        {
            if (binaryInButton.Checked)
            {
                octaInTrue = false;
                hexaInTrue = false;
                decimalInTrue = false;
                binaryInTrue = true;
            }
        }

        private void decimalOutButton_CheckedChanged(object sender, EventArgs e)
        {
            if (decimalOutButton.Checked)
            {
                octaOutTrue = false;
                hexaOutTrue = false;
                decimalOutTrue = true;
                binaryOutTrue = false;
            }
        }

        private void binaryOutButton_CheckedChanged(object sender, EventArgs e)
        {
            if (binaryOutButton.Checked)
            {
                octaOutTrue = false;
                hexaOutTrue = false;
                decimalOutTrue = false;
                binaryOutTrue = true;
            }
        }

        private void hexaOutButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hexaOutButton.Checked)
            {
                octaOutTrue = false;
                hexaOutTrue = true;
                decimalOutTrue = false;
                binaryOutTrue = false;
            }
        }

        private void octaOutButton_CheckedChanged(object sender, EventArgs e)
        {
            if (octaOutButton.Checked)
            {
                octaOutTrue = true;
                hexaOutTrue = false;
                decimalOutTrue = false;
                binaryOutTrue = false;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string inputTextValue = inputText.Text;
            string result = "";

            if (binaryInTrue)
            {
                if (hexaOutTrue)
                {
                    result = BinaryToHexadecimal(inputTextValue);
                }
                else if (octaOutTrue)
                {
                    result = BinaryToOctal(inputTextValue);
                }
                else if (decimalOutTrue)
                {
                    result = BinaryToDecimal(inputTextValue);
                }
                else if (binaryOutTrue)
                {
                    result = inputTextValue;
                }
            }
            else if (hexaInTrue)
            {
                if (hexaOutTrue)
                {
                    result = inputTextValue;
                }
                else if (octaOutTrue)
                {
                    result = HexadecimalToOctal(inputTextValue);
                }
                else if (decimalOutTrue)
                {
                    result = HexadecimalToDecimal(inputTextValue);
                }
                else if (binaryOutTrue)
                {
                    result = HexadecimalToBinary(inputTextValue);
                }
            }
            else if (octaInTrue)
            {
                if (hexaOutTrue)
                {
                    result = OctalToHexadecimal(inputTextValue);
                }
                else if (octaOutTrue)
                {
                    result = inputTextValue;
                }
                else if (decimalOutTrue)
                {
                    result = OctalToDecimal(inputTextValue);
                }
                else if (binaryOutTrue)
                {
                    result = OctalToBinary(inputTextValue);
                }
            }
            else if (decimalInTrue)
            {
                if (hexaOutTrue)
                {
                    result = DecimaltoHexa(inputTextValue);
                }
                else if (octaOutTrue)
                {
                    result = DecimaltoOcta(inputTextValue);
                }
                else if (decimalOutTrue)
                {
                    result = inputTextValue;
                }
                else if (binaryOutTrue)
                {
                    result = DecimalToBinary(inputTextValue);
                }
            }
            else
            {
                result = "Conversion not supported.";
            }

            outputText.Text = result;
        }

        private string BinaryToHexadecimal(string binary)
        {
            try
            {
                return Convert.ToInt32(binary, 2).ToString("X");
            }
            catch (FormatException)
            {
                return "Invalid binary input!";
            }
        }
        private string BinaryToOctal(string binary)
        {
            try
            {
                return Convert.ToString(Convert.ToInt32(binary, 2), 8);
            }
            catch (FormatException)
            {
                return "Invalid binary input!";
            }
        }
        private string BinaryToDecimal(string binary)
        {
            try
            {
                return Convert.ToInt32(binary, 2).ToString();
            }
            catch (FormatException)
            {
                return "Invalid binary input!";
            }
        }

        private string DecimalToBinary(string decimalValue)
        {
            try
            {
                // Parse the input decimal string to an integer
                int decimalNumber = int.Parse(decimalValue);

                // Convert the decimal number to binary
                string binaryResult = Convert.ToString(decimalNumber, 2);

                return binaryResult;
            }
            catch (FormatException)
            {
                return "Invalid decimal input!";
            }
        }
        private string DecimaltoHexa(string decimalValue)
        {
            try
            {
                // Parse the input decimal string to an integer
                int decimalNumber = int.Parse(decimalValue);

                // Convert the decimal number to octal
                string octalResult = Convert.ToString(decimalNumber, 8);

                return octalResult;
            }
            catch (FormatException)
            {
                return "Invalid decimal input!";
            }
        }
        private string DecimaltoOcta(string decimalValue)
        {
            try
            {
                // Parse the input decimal string to an integer
                int decimalNumber = int.Parse(decimalValue);

                // Convert the decimal number to octal
                string octalResult = Convert.ToString(decimalNumber, 8);

                return octalResult;
            }
            catch (FormatException)
            {
                return "Invalid decimal input!";
            }
        }

        private string HexadecimalToDecimal(string hexaValue)
        {
            try
            {
                // Parse the input hexadecimal string to an integer
                int decimalNumber = Convert.ToInt32(hexaValue, 16);

                // Convert the decimal number to a string
                string decimalResult = decimalNumber.ToString();

                return decimalResult;
            }
            catch (FormatException)
            {
                return "Invalid hexadecimal input!";
            }
        }
        private string HexadecimalToBinary(string hexaValue)
        {
            try
            {
                // Parse the input hexadecimal string to an integer
                int decimalNumber = Convert.ToInt32(hexaValue, 16);

                // Convert the decimal number to binary
                string binaryResult = Convert.ToString(decimalNumber, 2);

                return binaryResult;
            }
            catch (FormatException)
            {
                return "Invalid hexadecimal input!";
            }
        }
        private string HexadecimalToOctal(string hexaValue)
        {
            try
            {
                // Parse the input hexadecimal string to an integer
                int decimalNumber = Convert.ToInt32(hexaValue, 16);

                // Convert the decimal number to octal
                string octalResult = Convert.ToString(decimalNumber, 8);

                return octalResult;
            }
            catch (FormatException)
            {
                return "Invalid hexadecimal input!";
            }
        }

        private string OctalToDecimal(string octaVal)
        {
            try
            {
                // Parse the input octal string to an integer
                int decimalNumber = Convert.ToInt32(octaVal, 8);

                // Convert the decimal number to a string
                string decimalResult = decimalNumber.ToString();

                return decimalResult;
            }
            catch (FormatException)
            {
                return "Invalid octal input!";
            }
        }
        private string OctalToBinary(string octaVal)
        {
            try
            {
                // Parse the input octal string to an integer
                int decimalNumber = Convert.ToInt32(octaVal, 8);

                // Convert the decimal number to binary
                string binaryResult = Convert.ToString(decimalNumber, 2);

                return binaryResult;
            }
            catch (FormatException)
            {
                return "Invalid octal input!";
            }
        }
        private string OctalToHexadecimal(string octaVal)
        {
            try
            {
                // Parse the input octal string to an integer
                int decimalNumber = Convert.ToInt32(octaVal, 8);

                // Convert the decimal number to hexadecimal
                string hexadecimalResult = decimalNumber.ToString("X");

                return hexadecimalResult;
            }
            catch (FormatException)
            {
                return "Invalid octal input!";
            }
        }









        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}