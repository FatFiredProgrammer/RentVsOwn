# Rent vs Own Simulation

An application that simulates owning, renting and being a landlord of a property.

https://fbe.unimelb.edu.au/__data/assets/pdf_file/0011/1497953/2011MayLiER_NPV_submission.pdf

incorrect monthly discount rate calc!
Not accouniting for loan balance
large difference in monthly vs yearly npv calculations because of partial year?

Used discount rate == to downpayment!
Owner: Fixed closing cost of 2 pmts and $5000 are way out of line.
1/2 title insurance + 1/2 appraisal + 1/2 termite + lender fee ($200) + settlement + doc + origination.

Monthly NPV discount rate (1+Rate)^(1/12)-1
Monthly IRR to annual: (1+IRR)^12 - 1
lose security deposit

Remove unused values in ISimulation

USe DAta/Reports to report averages.

compounded future value: =-C9*(1+0.08/12)^A113
Vacancy rate 5%
Renter move years!
1031 exchange
Personal loan interest

=D9/(1+$L$2/12)^A9

Moving costs every 3 years.
PV of NET CF =M11/(1+Home!$H$2/12)^Own!A11

Gross Income(including vacancy allowance) - Operating Expenses = EBITDA(Earnings before interest, taxes, depreciation and amortization)
EBITDA - Interest Expenses - Depreciation = EBTA
EBTA x Marginal Tax Rate =  Estimated Property Income Taxes
EBTA - Estimate Property Income Taxes = Net Income
Net Income + Depreciation - Mortgage Principal Payments = Net Cash Flow


## Sample Run


|Year|Expenses|Rent|Renters Insurance|Cash Flow|
| ---: | ---: | ---: | ---: | ---: |
|0|$0|$0|$0|($62,959)|
|1|$25,380|$25,200|$180|($25,380)|
|2|$26,645|$26,460|$185|($26,645)|
|3|$27,970|$27,780|$190|($27,970)|
|4|$29,367|$29,172|$195|($29,367)|
|5|$30,837|$30,636|$201|($30,837)|
|6|$32,379|$32,172|$207|($32,379)|
|7|$33,992|$33,780|$212|($33,992)|
|8|$35,690|$35,472|$218|($35,690)|
|9|$24,982|$24,832|$150|$89,489|
|Sum|$267,243|$265,504|$1,739||
|Average|$29,694|$29,500|$193||
|NPV||||($188,833)|
|IRR||||-25.66%|