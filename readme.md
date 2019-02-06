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

# Simulation Parameters

|Parameter|Value|Notes|
| :--- | ---: | :--- |
|Name of  Simulation|Default Simulation||
|Years|8.7|Number of years the simulation runs. Default is 8.7; the national average for home ownership.|
|Months|104|Number of months the simulation runs.|
|Home Purchase Amount|$289,900|Home purchase amount. Default is $289,900.|
|Home Appreciation Percentage Per Year|2.80%|Home appreciation per year. Default is 3.7% (historic average).|
|Insurance Per Month|$150|Insurance costs per month. Default is $150.|
|Hoa Per Month|$0|HOA fees per month. Default is $100.|
|Home Maintenance Percentage Per Year|1.50%|Home maintenance percentage per year. Default is 1.5%.|
|Owner Interest Rate Per Year|4.25%|Home owner's mortgage interest rate. Default is 4.25%.|
|Owner Loan Years|30|Home owner's loan term. Default is 30 years.|
|Owner Down Payment Percentage|20.00%|Home owner down payment percentage. Default is 20%.|
|Owner Down Payment|$57,980|Home owner down payment. Calculated.|
|Owner Loan Amount|$231,920|Home owner loan amount. Calculated.|
|Owner Monthly Payment|$1,141|Home owner monthly payment. Calculated.|
|Landlord Interest Rate|4.75%|Landlord's mortgage interest rate. Default is 4.75%. If null, use home owner's value.|
|Landlord Loan Years|20|Landlord's loan term. Default is 20 years. If null, use home owner's value.|
|Landlord Down Payment Percentage|25.00%|Landlord down payment percentage. Default is 25%. If null, use home owner's value.|
|Landlord Down Payment|$72,475|Landlord down payment. Calculated.|
|Landlord Loan Amount|$217,425|Landlord loan amount. Calculated.|
|Landlord Monthly Payment|$1,405|Landlord monthly payment. Calculated.|
|Landlord Management Fee Percentage Per Month|10.00%|Landlord property management fee as a percentage of monthly rent. Default is 10%.|
|Rent Per Month|$2,165|Initial rent per month. Defaults is the home owners initial monthly expense.|
|Rent Security Deposit Months|1|Number of months of rent retained as security deposit. Defaults is 1.|
|Renters Insurance Per Month|$15|Renter's insurance cost per month. Default is $15.|
|Rent Change Per Year Percentage|3.00%|The percentage increase in rent each year. Default is 3%.|
|Buyer Fixed Costs|$1,500|Fixed closing costs like title insurance, inspection, appraisal, etc. Defaults is $1,500.|
|Buyer Variable Costs Percentage|1.50%|Variable closing costs such as loan origination. Defaults is 1.5%.|
|Seller Commission Percentage|6.00%|Commission percentage paid to sell a home. Default is 6% (Omaha).|
|Seller Fixed Costs|$1,000|Fixed costs to sell a home. Title insurance, doc fees, etc. Default is $1000.|
|Depreciation Years|27.50|Number of years to depreciate. Default is 27.5.|
|Depreciable Percentage|80.00%|Percentage of the home which is depreciable versus land. Defaults is 80%.|
|Capital Gains Rate Per Year|15.00%|Capital gains tax rate per year. Default is 15%.|
|Marginal Tax Rate Per Year|24.00%|Marginal tax rate per year. Default is 24%.|
|Property Tax Percentage Per Year|2.12%|Property tax percentage per year. Default is 2.12% (Omaha).|
|Discount Rate Per Year|8.00%|Assumed rate of return per year for investments and also the rate assumed in NPV calculations. Defaults is 8%.|
|Discount Rate Per Month|0.64%|Monthly discount rate.|
|Inflation Rate Per Year|2.80%|The inflation percentage per year. Defaults is 2.8%.|


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