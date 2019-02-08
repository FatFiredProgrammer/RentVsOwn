# Rent vs Own Simulation

An application that simulates owning, renting and being a landlord of a property.

## TODO

Include moving costs. 
Perhaps allow renter to move periodically during simulation.

## Notes to /u/friendly_hendie

I shared an XLSX spreadsheet [here](https://github.com/johnweeder/RentVsOwn/blob/master/RentVsOwn.xlsx).
I tried to change my code to output a spreadsheet so you could just it.
I tested my code as best I could by comparing mine to yours for similar runs until I got everything to match up.
Except for the issues below.

Renter NPV -$198,269 vs owner NPV of -$134,136. This is a clear victory, in this case, for own over rent.
Even lowering the rent to equal the owner's monthly payment doesn't help.

At $2,300 rent, the landlord has an NPV of -$38,185 at an 8% discount rate. At 2% IRR.
However, we've basically chosen relatively conservative options here which work against the landlord.


Problems with the spreadsheet.

* When comparing rentals, NPV/IRR is only meaningful in a relative sense. 
I.e. it only let's you decide which is better/worse - renting or owning.
It says nothing about the true economic value.
A person _must_ either rent or own - you must have a place to live.
The NPV here is not truly a cash flow showing revenue from an asset. 
Rather, it is accumulating the net value of the costs associated with owning or renting.
See scholarly paper referenced below.
* Your spreadsheet, the landlord does not appear to account for the security deposit being held.
* Your spreadsheet, the monthly discount rate for NPV is calculated as "rate / 12".
It should be "(1+rate)^(1/12)-1"
* Your spreadsheet,  does not appear to account for the loan balance in the final cash flow.
* Your spreadsheet, property tax and mortgage interest deduction are not relevant landlord assuming they rent more than 14 days per year.
These are already deductible expenses in any case.
One can't take an _additional_ "tax savings" because these expenses are _already_ offsetting rental income.
I.e. you're not _saving_ on tax, you're simply not paying tax which would otherwise have been due.
Since your spreadsheet is not paying tax to begin with, this essentially gives you a **tax deduction twice**! 
* Your spreadsheet, tax savings via depreciation are a "non-cash" expense are should _not_ be included in NPV.
See link below.
* To the extent you have a loss or unused depreciation, a loss can only be used to offset other passive income (in most reasonable cases).
Assuming all your properties are similar, you can't use a rob Peter to pay Paul approach here to boost your cash flow. 
In essence, that is just transferring value from another property.
* Your fixed closing costs for both purchase and sale are way out of line with respect to Omaha.
I understand other areas of the country are different.
Buyers fees are 1/2 title insurance, 1/2 of closing fee, some doc fees, termite and an appraisal. 
Plus a percentage fee for loan origination (1 or 2%).
Sellers closing costs here are 1/2 title insurance, 1/2 of closing fee and some documentation fees - plus a 6% commission.

Changes made to my simulation:

* Removed operating loan concept. It was wrong as an idea and implemented wrong.
* CSV and markdown reports
* Monthly and yearly reports.
* Landlord security deposit held/returned
* Vacancy holdback 
* 1031 exchange
* Added support for mortgage/propert tax deductions

# Links

This code available on [github](https://github.com/johnweeder/RentVsOwn).

See [Rent vs Own NPV](https://fbe.unimelb.edu.au/__data/assets/pdf_file/0011/1497953/2011MayLiER_NPV_submission.pdf)
for a discussion of how to use values.

See [this](https://iqcalculators.com/calculate-real-estate-roi) for discussion of how to evaluate
ROI from a landlord perspective.

[TurboTax](https://turbotax.intuit.com/tax-tips/home-ownership/buying-a-second-home-tax-tips-for-homeowners/L5Mzc5URo)
provided rules for tax deductibilty of expenses.


# Simulation Parameters

|Parameter|Value|Notes|
| :--- | ---: | :--- |
|Name of  Simulation|Default Simulation||
|Years|8.7|Number of years the simulation runs. Default is 8.7; the national average for home ownership.|
|Months|104|Number of months the simulation runs.|
|Home Purchase Amount|$289,900|Home purchase amount. Default is $289,900.|
|Home Appreciation Percentage Per Year|3.70%|Home appreciation per year. Default is 3.7% (historic average). If null, defaults to inflation rate.|
|Insurance Per Month|$150|Insurance costs per month. Default is $150.|
|Hoa Per Month|$0|HOA fees per month. Default is $100.|
|Home Maintenance Percentage Per Year|1.50%|Home maintenance percentage per year. Default is 1.5%.|
|Owner Interest Rate Per Year|4.25%|Home owner's mortgage interest rate. Default is 4.25%.|
|Owner Loan Years|30|Home owner's loan term. Default is 30 years.|
|Owner Down Payment Percentage|20.00%|Home owner down payment percentage. Default is 20%.|
|Owner Down Payment|$57,980|Home owner down payment. Calculated.|
|Owner Loan Amount|$231,920|Home owner loan amount. Calculated.|
|Owner Monthly Payment|$1,141|Home owner monthly payment. Calculated.|
|Owner Allow Tax Deductions|Yes|Allow home owner to deduct mortgage interest and property tax. Default is false.|
|Landlord Interest Rate Per Year|4.75%|Landlord's mortgage interest rate. Default is 4.75%. If null, use home owner's value.|
|Landlord Loan Years|20|Landlord's loan term. Default is 20 years. If null, use home owner's value.|
|Landlord Down Payment Percentage|25.00%|Landlord down payment percentage. Default is 25%. If null, use home owner's value.|
|Landlord Down Payment|$72,475|Landlord down payment. Calculated.|
|Landlord Loan Amount|$217,425|Landlord loan amount. Calculated.|
|Landlord Monthly Payment|$1,405|Landlord monthly payment. Calculated.|
|Landlord Management Fee Percentage Per Month|10.00%|Landlord property management fee as a percentage of monthly rent. Default is 10%.|
|Landlord Vacancy Fee Percentage|5.00%|Landlord property fee charged to represent loss due to vacancies. Default is 5%.|
|Allow 1031  Exchange|Yes|Allow landlord to make a 1031 exchange at close of simulation. Default is false.|
|Rent Per Month|$2,300|Initial rent per month. Default is the home owners initial monthly expense.|
|Rent Security Deposit Months|1|Number of months of rent retained as security deposit. Default is 1.|
|Renters Insurance Per Month|$15|Renter's insurance cost per month. Default is $15.|
|Rent Change Per Year Percentage|3.00%|The percentage increase in rent each year. Default is 3%.|
|Buyer Fixed Costs|$1,500|Fixed closing costs like title insurance, inspection, appraisal, etc. Default is $1,500.|
|Buyer Variable Costs Percentage|1.50%|Variable closing costs such as loan origination. Default is 1.5%.|
|Seller Commission Percentage|6.00%|Commission percentage paid to sell a home. Default is 6% (Omaha).|
|Seller Fixed Costs|$1,000|Fixed costs to sell a home. Title insurance, doc fees, etc. Default is $1000.|
|Depreciation Years|27.50|Number of years to depreciate. Default is 27.5.|
|Depreciable Percentage|80.00%|Percentage of the home which is depreciable versus land. Default is 80%.|
|Capital Gains Rate Per Year|15.00%|Capital gains tax rate per year. Default is 15%.|
|Marginal Tax Rate Per Year|24.00%|Marginal tax rate per year. Default is 24%.|
|Property Tax Percentage Per Year|2.12%|Property tax percentage per year. Default is 2.12% (Omaha).|
|Discount Rate Per Year|8.00%|Assumed rate of return per year for investments and also the rate assumed in NPV calculations. Default is 8%.|
|Discount Rate Per Month|0.64%|Monthly discount rate.|
|Inflation Rate Per Year|2.80%|The inflation percentage per year. Default is 2.8%.|



# Sample Result

A sample excel file can be downloaded [here](https://github.com/johnweeder/RentVsOwn/blob/master/RentVsOwn.xlsx),
This file is also included in the project.
