﻿// Copyright © 2013 Open Octopus Ltd.
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
// 
// Website: http://www.opencbs.com
// Contact: contact@opencbs.com

using System.Collections.Generic;
using OpenCBS.Common;
using OpenCBS.DataContract;
using OpenCBS.Interface.Presenter;

namespace OpenCBS.Interface.View
{
    public interface ILoanProductView : IView<ILoanProductPresenterCallbacks>
    {
        void Run();
        void Stop();
        void ShowPaymentFrequencyPolicies(IList<string> policies);
        void ShowSchedulePolicies(IList<string> policies);
        void ShowYearPolicies(IList<string> policies);
        void ShowDateShiftPolicies(IList<string> policies);
        void ShowRoundingPolicies(IList<string> policies);
        void ShowCurrencies(Dictionary<int, string> currencies);
        void ShowLateFeePolicies(IList<string> policies);
        void ShowNotification(Notification notification);

        int Id { get; set; }
        string LoanProductName { get; set; }
        string Code { get; set; }
        AvailableFor AvailableFor { get; set; }
        string PaymentFrequencyPolicy { get; set; }
        string SchedulePolicy { get; set; }
        string YearPolicy { get; set; }
        string DateShiftPolicy { get; set; }
        string RoundingPolicy { get; set; }

        decimal? AmountMin { get; set; }
        decimal? AmountMax { get; set; }
        decimal? InterestRateMin { get; set; }
        decimal? InterestRateMax { get; set; }
        int? MaturityMin { get; set; }
        int? MaturityMax { get; set; }
        int? GracePeriodMin { get; set; }
        int? GracePeriodMax { get; set; }
        bool ChargeInterestDuringGracePeriod { get; set; }

        decimal? LateFeeAmountRateMin { get; set; }
        decimal? LateFeeAmountRateMax { get; set; }
        decimal? LateFeeOlbRateMin { get; set; }
        decimal? LateFeeOlbRateMax { get; set; }
        decimal? LateFeeLatePrincipalRateMin { get; set; }
        decimal? LateFeeLatePrincipalRateMax { get; set; }
        decimal? LateFeeLateInterestRateMin { get; set; }
        decimal? LateFeeLateInterestRateMax { get; set; }
        int? LateFeeGracePeriod { get; set; }
        string LateFeePolicy { get; set; }

        IList<EntryFeeDto> EntryFees { get; set; }
        bool CanRemoveEntryFee { get; set; }
        int? SelectedEntryFeeId { get; }
    }
}