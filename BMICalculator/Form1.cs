using System;
using System.Drawing;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        private float finalBMI;

        public TextBox enterDatatoBox { get; set; }
        public string outputString { get; set; }
        public float heightValue { get; set; }
        public float weightValue { get; set; }
        public bool decimalExists { get; set; }
      

        public BMICalculator()
        {
            InitializeComponent();
            RadioImperial.Checked = true;
        }

        private void WeightDataMouseDown(object sender, MouseEventArgs e)
        {
            enterDatatoBox = WeightBox;
            WeightBox.Clear();

            outputString = "";
        }

        private void HeightDataMouseDown(object sender, MouseEventArgs e)
        {
            enterDatatoBox = HeightBox;
            HeightBox.Clear();
            outputString = "";
        }

        private void UnitChose(object sender, EventArgs e)
        {
            if (RadioImperial.Checked)
            {
                HeightUnits.Text = "inch";
                WeightUnits.Text = "p";
            }
            else if (RadioMetric.Checked)
            {
                HeightUnits.Text = "m";
                WeightUnits.Text = "kg";
            }
        }

        private void KeyboardButtonClick(object sender, EventArgs e)
        {
            try
            {
                Button TheButton = sender as Button;
                var tag = TheButton.Tag.ToString();

                int numericValue = 0;
                bool numericResult = int.TryParse(tag, out numericValue);
                if (numericResult)
                {
                    if (outputString == "0")
                    {
                        outputString = tag;
                    }
                    else
                    {
                        outputString += tag;
                    }
                    enterDatatoBox.Text = outputString;
                }
                else
                {
                    switch (tag)
                    {
                        case "calculator":
                            try
                            {
                                heightValue = float.Parse(HeightBox.Text);
                                weightValue = float.Parse(WeightBox.Text);

                                if (RadioImperial.Checked)
                                {
                                    finalBMI = weightValue * 703 / (heightValue * heightValue);

                                }
                                else if (RadioMetric.Checked)
                                {
                                    finalBMI = weightValue / (heightValue * heightValue);
                                    
                                }
                                ProgressBar.Value = (int)finalBMI;
                                if (finalBMI < 18.5)
                                {

                                    ProgressBar.BackColor = Color.Yellow;
                                    ResultBox.Text = $"{finalBMI:f2}  You are Underweight!";
                                }
                                else if (finalBMI >= 18.5 && finalBMI <= 24.9)
                                {
                                    ProgressBar.BackColor = Color.Green;
                                    ResultBox.Text = $"{finalBMI:f2}  You are Normal!";
                                }
                                else if (finalBMI >= 25 && finalBMI <= 29.9)
                                {
                                    ProgressBar.BackColor = Color.Orange;
                                    ResultBox.Text = $"{finalBMI:f2}  You are Overweight!";
                                }
                                else if (finalBMI >= 30)
                                {
                                    ProgressBar.BackColor = Color.Red;
                                    ResultBox.Text = $"{finalBMI:f2}  You are Obese!";
                                }
                                

                            }
                            catch
                            {
                                ClearButton();
                                ResultBox.Text = "Error Enter!!!";
                            }
                            break;
                        case "delete":
                            var lastChar = outputString.Substring(outputString.Length - 1);
                            if (lastChar == ".")
                            {
                                decimalExists = false;
                            }
                            outputString = outputString.Remove(outputString.Length - 1);
                            if (outputString.Length == 0)
                            {
                                outputString = "0";
                            }
                            enterDatatoBox.Text = outputString;
                            break;
                        case "clear":
                            ClearButton();
                            break;
                        case "decimal":
                            if (!decimalExists)
                            {
                                outputString += ".";
                                decimalExists = true;
                            }
                            break;
                    }
                }
            }     
            catch (Exception ButtonError)
            {
                ResultBox.Text = "";
            }
        }

        private void ClearButton()
        {
            WeightBox.Clear();
            HeightBox.Clear();
            ResultBox.Clear();
            outputString = "0";
            heightValue = 0.0f;
            weightValue = 0.0f;
            decimalExists = false;
        }

        
    }
}
