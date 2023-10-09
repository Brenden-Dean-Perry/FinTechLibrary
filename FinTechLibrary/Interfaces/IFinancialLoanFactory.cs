﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTechLibrary
{
    public interface IFinancialLoanFactory
    {
        FinancialLoan CreateObject(LoanPaymentType paymentType);

    }
}
