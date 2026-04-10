using System;

namespace 운빨계산기_v2 //namespace == 프로젝트명
{
    public static class StatisticsHelper
    {
        /// <summary>
        /// 이항 분포의 누적 분포 함수 P(X <= k_actual) 계산
        /// </summary>
        public static double BinomialCdf(int k_actual, int n_trials, double p_success)
        {
            if (p_success < 0 || p_success > 1)
                throw new ArgumentOutOfRangeException(nameof(p_success), "확률은 0 ~ 100 사이여야 합니다.");
            if (n_trials < 0)
                throw new ArgumentOutOfRangeException(nameof(n_trials), "실행 횟수는 음수일 수 없습니다.");

            if (k_actual < 0) return 0.0;

            // 성공 확률이 0일 때의 처리
            if (p_success == 0.0)
                return (k_actual >= 0) ? 1.0 : 0.0;

            // 성공 확률이 1일 때의 처리
            if (p_success == 1.0)
                return (k_actual >= n_trials) ? 1.0 : 0.0;

            if (k_actual >= n_trials) return 1.0;

            double cdf = 0.0;
            // P(X=0) 계산: (1-p)^n
            double currentTerm = Math.Pow(1.0 - p_success, n_trials);

            if (0 <= k_actual)
            {
                cdf += currentTerm;
            }

            // P(X=i)를 P(X=i-1)로부터 반복적으로 계산하여 cdf에 더함
            for (int i = 1; i <= k_actual; i++)
            {
                if (currentTerm == 0) break;
                // 이항계수 성질을 이용한 점화식 계산 (효율적임)
                currentTerm *= (p_success / (1.0 - p_success)) * (n_trials - i + 1) / i;
                cdf += currentTerm;
            }

            return Math.Min(cdf, 1.0); // 부동소수점 오차 방지용
        }
    }
}