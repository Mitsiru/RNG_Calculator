using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace 운빨계산기_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 확률 TextBox의 Validating 이벤트 핸들러 연결
            this.txtProbability.Validating += new System.ComponentModel.CancelEventHandler(this.txtProbability_Validating);

            // btnReset 설정
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // btnCalculate 설정
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
        }
        private void txtProbability_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && !string.IsNullOrEmpty(tb.Text))
            {
                if (double.TryParse(tb.Text, out double probValue))
                {
                    if (probValue < 0)
                    {
                        MessageBox.Show("확률은 양수만 입력 가능합니다.", "입력 오류");
                        tb.Text = string.Empty;
                    }
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            int trials = (int)nudTrials.Value;
            int actualSuccesses = (int)nudSuccesses.Value;
            double probabilityPercent;

            if (!double.TryParse(txtProbability.Text, out probabilityPercent))
            {
                MessageBox.Show("확률을 올바른 숫자로 입력해주세요.", "입력 오류");
                txtProbability.Focus();
                return;
            }

            if (probabilityPercent < 0 || probabilityPercent > 100)
            {
                MessageBox.Show("확률은 0에서 100 사이의 값이어야 합니다.", "입력 오류");
                return;
            }

            if (actualSuccesses > trials)
            {
                MessageBox.Show("성공 횟수는 실행 횟수보다 많을 수 없습니다.", "입력 오류");
                return;
            }

            double p_input = probabilityPercent / 100.0;
            string resultMessage = "";

            if (trials == 1 && actualSuccesses == 0)
            {
                // 소숫점 최대 10자리까지 가변 표기
                string probStr = probabilityPercent.ToString("0.##########");
                string upperStr = (100.0 - probabilityPercent).ToString("0.##########");

                if (probabilityPercent > 50)
                    resultMessage = $"당신의 행운은 \n하위 {probStr}%에 해당합니다.";
                else
                    resultMessage = $"당신의 행운은 \n상위 {upperStr}%에 해당합니다.";
            }
            else if (trials == 0)
            {
                resultMessage = "실행 횟수가 0이므로, \n결과를 판단할 수 없습니다.";
            }
            else
            {
                double expectedSuccesses = trials * p_input;
                if (actualSuccesses < expectedSuccesses)
                {
                    double lowerTailProbability = StatisticsHelper.BinomialCdf(actualSuccesses, trials, p_input);
                    string resStr = (lowerTailProbability * 100.0).ToString("0.##########");
                    resultMessage = $"당신의 행운은 \n하위 {resStr}%입니다.";
                }
                else if (actualSuccesses > expectedSuccesses)
                {
                    double upperTailProbability = 1.0 - StatisticsHelper.BinomialCdf(actualSuccesses - 1, trials, p_input);
                    string resStr = (upperTailProbability * 100.0).ToString("0.##########");
                    resultMessage = $"당신의 행운은 \n상위 {resStr}%입니다.";
                }
                else
                {
                    resultMessage = "당신의 성공 횟수는 기대치와 일치합니다. \n이는 평균적인 결과입니다.";
                }
            }
            lblResult.Text = resultMessage;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudTrials.Value = nudTrials.Minimum;
            nudSuccesses.Value = nudSuccesses.Minimum;
            txtProbability.Text = string.Empty;
            lblResult.Text = string.Empty;
            nudTrials.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSucessText_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}