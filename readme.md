# Rent vs Own Simulation

An application that simulates owning, renting and being a landlord of a property.

https://fbe.unimelb.edu.au/__data/assets/pdf_file/0011/1497953/2011MayLiER_NPV_submission.pdf

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


|Default Simulator||
| --- | --: |
|Years|8.70|
|Months|104|
|HomePurchaseAmount|$289,900|
|OwnerInterestRate|4.25%|
|OwnerLoanYears|30|
|OwnerDownPaymentPercentage|20.00%|
|OwnerDownPayment|$57,980|
|OwnerLoanAmount|$231,920|
|OwnerHomeValue|$289,900|
|OwnerLoanBalance|$231,920|
|OwnerMonthlyPayment|$1,141|
|RentChangePerYearPercentage|0.00%|
|Rent|$2,100|
|RentSecurityDepositMonths|1|
|RentersInsurancePerMonth|$15|
|LandlordInterestRate|4.25%|
|LandlordLoanYears|30|
|LandlordDownPaymentPercentage|20.00%|
|LandlordDownPayment|$57,980|
|LandlordLoanAmount|$231,920|
|LandlordHomeValue|$289,900|
|LandlordLoanBalance|$231,920|
|LandlordMonthlyPayment|$1,141|
|LandlordManagementFeePercentage|10.00%|
|DepreciationYears|27.50|
|DepreciablePercentage|80.00%|
|ClosingFixedCosts|$500|
|ClosingVariableCostsPercentage|1.50%|
|PropertyTaxPercentage|0.84%|
|InsurancePerMonth|$100|
|HoaPerMonth|$0|
|HomeAppreciationPercentagePerYear|3.70%|
|HomeMaintenancePercentagePerYear|1.00%|
|SalesCommissionPercentage|6.00%|
|SalesFixedCosts|$1,000|
|DiscountRate|8.00%|
|CapitalGainsRate|15.00%|
|MarginalTaxRate|24.00%|
|InflationRate|2.00%|

---

Owner in month # 1

* Down payment of $57,980
* Fixed closing costs of $500
* Variable closing costs of $3,479
* Total initial investment of $61,959
* Initial loan balance of $231,920
* Loan payment of $1,141 ($320 principal / $821 interest)
* New loan balance of $231,600
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 1

* Starting cash of $61,959 ($57,980 owner down payment + $500 owner fixed closing costs + $3,479 owner variable closing costs)
* Security deposit of $2,100
* Invested  $59,859
* Investment of $60,258 grew by $399 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 1

* Down payment of $57,980
* Fixed closing costs of $500
* Variable closing costs of $3,479
* Total initial investment of $61,959
* Basis in home purchase $285,921
* Initial loan balance of $231,920
* Received rent of $2,100
* Loan payment of $1,141 ($320 principal / $821 interest)
* New loan balance of $231,600
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,576 leaving cash of $204
* Net taxable income of $524
* Allowed monthly depreciation of $703 + carry-over of $0
* Used depreciation of $524 resulting in adjusted taxable income of $0
* Carry over depreciation of $179
* Paid additional principal of $204 leaving balance of $231,396 and cash of $0
* NPV cash flow of $524

---

Owner in month # 2

* Loan payment of $1,141 ($321 principal / $820 interest)
* New loan balance of $231,279
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 2

* Investment of $60,660 grew by $402 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 2

* Received rent of $2,100
* Loan payment of $1,141 ($321 principal / $820 interest)
* New loan balance of $231,075
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,575 leaving cash of $204
* Net taxable income of $525
* Allowed monthly depreciation of $703 + carry-over of $179
* Used depreciation of $525 resulting in adjusted taxable income of $0
* Carry over depreciation of $357
* Paid additional principal of $204 leaving balance of $230,871 and cash of $0
* NPV cash flow of $525

---

Owner in month # 3

* Loan payment of $1,141 ($322 principal / $819 interest)
* New loan balance of $230,957
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 3

* Investment of $61,064 grew by $404 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 3

* Received rent of $2,100
* Loan payment of $1,141 ($323 principal / $818 interest)
* New loan balance of $230,548
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,573 leaving cash of $204
* Net taxable income of $527
* Allowed monthly depreciation of $703 + carry-over of $357
* Used depreciation of $527 resulting in adjusted taxable income of $0
* Carry over depreciation of $533
* Paid additional principal of $204 leaving balance of $230,344 and cash of $0
* NPV cash flow of $527

---

Owner in month # 4

* Loan payment of $1,141 ($323 principal / $818 interest)
* New loan balance of $230,634
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 4

* Investment of $61,471 grew by $407 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 4

* Received rent of $2,100
* Loan payment of $1,141 ($325 principal / $816 interest)
* New loan balance of $230,019
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,571 leaving cash of $204
* Net taxable income of $529
* Allowed monthly depreciation of $703 + carry-over of $533
* Used depreciation of $529 resulting in adjusted taxable income of $0
* Carry over depreciation of $707
* Paid additional principal of $204 leaving balance of $229,815 and cash of $0
* NPV cash flow of $529

---

Owner in month # 5

* Loan payment of $1,141 ($324 principal / $817 interest)
* New loan balance of $230,310
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 5

* Investment of $61,881 grew by $410 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 5

* Received rent of $2,100
* Loan payment of $1,141 ($327 principal / $814 interest)
* New loan balance of $229,488
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,569 leaving cash of $204
* Net taxable income of $531
* Allowed monthly depreciation of $703 + carry-over of $707
* Used depreciation of $531 resulting in adjusted taxable income of $0
* Carry over depreciation of $879
* Paid additional principal of $204 leaving balance of $229,284 and cash of $0
* NPV cash flow of $531

---

Owner in month # 6

* Loan payment of $1,141 ($325 principal / $816 interest)
* New loan balance of $229,985
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 6

* Investment of $62,293 grew by $413 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 6

* Received rent of $2,100
* Loan payment of $1,141 ($329 principal / $812 interest)
* New loan balance of $228,955
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,567 leaving cash of $204
* Net taxable income of $533
* Allowed monthly depreciation of $703 + carry-over of $879
* Used depreciation of $533 resulting in adjusted taxable income of $0
* Carry over depreciation of $1,049
* Paid additional principal of $204 leaving balance of $228,751 and cash of $0
* NPV cash flow of $533

---

Owner in month # 7

* Loan payment of $1,141 ($326 principal / $815 interest)
* New loan balance of $229,659
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 7

* Investment of $62,709 grew by $415 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 7

* Received rent of $2,100
* Loan payment of $1,141 ($331 principal / $810 interest)
* New loan balance of $228,420
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,565 leaving cash of $204
* Net taxable income of $535
* Allowed monthly depreciation of $703 + carry-over of $1,049
* Used depreciation of $535 resulting in adjusted taxable income of $0
* Carry over depreciation of $1,217
* Paid additional principal of $204 leaving balance of $228,216 and cash of $0
* NPV cash flow of $535

---

Owner in month # 8

* Loan payment of $1,141 ($328 principal / $813 interest)
* New loan balance of $229,331
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 8

* Investment of $63,127 grew by $418 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 8

* Received rent of $2,100
* Loan payment of $1,141 ($333 principal / $808 interest)
* New loan balance of $227,883
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,563 leaving cash of $204
* Net taxable income of $537
* Allowed monthly depreciation of $703 + carry-over of $1,217
* Used depreciation of $537 resulting in adjusted taxable income of $0
* Carry over depreciation of $1,383
* Paid additional principal of $204 leaving balance of $227,679 and cash of $0
* NPV cash flow of $537

---

Owner in month # 9

* Loan payment of $1,141 ($329 principal / $812 interest)
* New loan balance of $229,002
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 9

* Investment of $63,548 grew by $421 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 9

* Received rent of $2,100
* Loan payment of $1,141 ($335 principal / $806 interest)
* New loan balance of $227,344
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,561 leaving cash of $204
* Net taxable income of $539
* Allowed monthly depreciation of $703 + carry-over of $1,383
* Used depreciation of $539 resulting in adjusted taxable income of $0
* Carry over depreciation of $1,547
* Paid additional principal of $204 leaving balance of $227,140 and cash of $0
* NPV cash flow of $539

---

Owner in month # 10

* Loan payment of $1,141 ($330 principal / $811 interest)
* New loan balance of $228,672
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 10

* Investment of $63,971 grew by $424 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 10

* Received rent of $2,100
* Loan payment of $1,141 ($337 principal / $804 interest)
* New loan balance of $226,803
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,559 leaving cash of $204
* Net taxable income of $541
* Allowed monthly depreciation of $703 + carry-over of $1,547
* Used depreciation of $541 resulting in adjusted taxable income of $0
* Carry over depreciation of $1,709
* Paid additional principal of $204 leaving balance of $226,599 and cash of $0
* NPV cash flow of $541

---

Owner in month # 11

* Loan payment of $1,141 ($331 principal / $810 interest)
* New loan balance of $228,341
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 11

* Investment of $64,398 grew by $426 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 11

* Received rent of $2,100
* Loan payment of $1,141 ($338 principal / $803 interest)
* New loan balance of $226,261
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,558 leaving cash of $204
* Net taxable income of $542
* Allowed monthly depreciation of $703 + carry-over of $1,709
* Used depreciation of $542 resulting in adjusted taxable income of $0
* Carry over depreciation of $1,870
* Paid additional principal of $204 leaving balance of $226,057 and cash of $0
* NPV cash flow of $542

---

Owner in month # 12

* Loan payment of $1,141 ($332 principal / $809 interest)
* New loan balance of $228,009
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,686

---

Renter in month # 12

* Investment of $64,827 grew by $429 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 12

* Received rent of $2,100
* Loan payment of $1,141 ($340 principal / $801 interest)
* New loan balance of $225,717
* Management fee of $210
* Spent $203 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,556 leaving cash of $204
* Net taxable income of $544
* Allowed monthly depreciation of $703 + carry-over of $1,870
* Used depreciation of $544 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,029
* Paid additional principal of $204 leaving balance of $225,513 and cash of $0
* NPV cash flow of $544

---

Year # 1

* Owner Home value increased 3.70% to $300,626
* Landlord Home value increased 3.70% to $300,626
* Renters insurance increased 2.00% to $15.30
* Home owner's insurance increased 2.00% to $102.00
* HOA increased 2.00% to $0.00

---

Owner in month # 13

* Loan payment of $1,141 ($333 principal / $808 interest)
* New loan balance of $227,676
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 13

* Investment of $65,259 grew by $432 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 13

* Received rent of $2,100
* Loan payment of $1,141 ($342 principal / $799 interest)
* New loan balance of $225,171
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,572 leaving cash of $186
* Net taxable income of $528
* Allowed monthly depreciation of $703 + carry-over of $2,029
* Used depreciation of $528 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,204
* Paid additional principal of $186 leaving balance of $224,985 and cash of $0
* NPV cash flow of $528

---

Owner in month # 14

* Loan payment of $1,141 ($335 principal / $806 interest)
* New loan balance of $227,341
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 14

* Investment of $65,694 grew by $435 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 14

* Received rent of $2,100
* Loan payment of $1,141 ($344 principal / $797 interest)
* New loan balance of $224,641
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,570 leaving cash of $186
* Net taxable income of $530
* Allowed monthly depreciation of $703 + carry-over of $2,204
* Used depreciation of $530 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,377
* Paid additional principal of $186 leaving balance of $224,455 and cash of $0
* NPV cash flow of $530

---

Owner in month # 15

* Loan payment of $1,141 ($336 principal / $805 interest)
* New loan balance of $227,005
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 15

* Investment of $66,132 grew by $438 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 15

* Received rent of $2,100
* Loan payment of $1,141 ($346 principal / $795 interest)
* New loan balance of $224,109
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,568 leaving cash of $186
* Net taxable income of $532
* Allowed monthly depreciation of $703 + carry-over of $2,377
* Used depreciation of $532 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,548
* Paid additional principal of $186 leaving balance of $223,923 and cash of $0
* NPV cash flow of $532

---

Owner in month # 16

* Loan payment of $1,141 ($337 principal / $804 interest)
* New loan balance of $226,668
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 16

* Investment of $66,573 grew by $441 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 16

* Received rent of $2,100
* Loan payment of $1,141 ($348 principal / $793 interest)
* New loan balance of $223,575
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,566 leaving cash of $186
* Net taxable income of $534
* Allowed monthly depreciation of $703 + carry-over of $2,548
* Used depreciation of $534 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,717
* Paid additional principal of $186 leaving balance of $223,389 and cash of $0
* NPV cash flow of $534

---

Owner in month # 17

* Loan payment of $1,141 ($338 principal / $803 interest)
* New loan balance of $226,330
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 17

* Investment of $67,017 grew by $444 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 17

* Received rent of $2,100
* Loan payment of $1,141 ($350 principal / $791 interest)
* New loan balance of $223,039
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,564 leaving cash of $186
* Net taxable income of $536
* Allowed monthly depreciation of $703 + carry-over of $2,717
* Used depreciation of $536 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,884
* Paid additional principal of $186 leaving balance of $222,853 and cash of $0
* NPV cash flow of $536

---

Owner in month # 18

* Loan payment of $1,141 ($339 principal / $802 interest)
* New loan balance of $225,991
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 18

* Investment of $67,464 grew by $447 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 18

* Received rent of $2,100
* Loan payment of $1,141 ($352 principal / $789 interest)
* New loan balance of $222,501
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,562 leaving cash of $186
* Net taxable income of $538
* Allowed monthly depreciation of $703 + carry-over of $2,884
* Used depreciation of $538 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,049
* Paid additional principal of $186 leaving balance of $222,315 and cash of $0
* NPV cash flow of $538

---

Owner in month # 19

* Loan payment of $1,141 ($341 principal / $800 interest)
* New loan balance of $225,650
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 19

* Investment of $67,914 grew by $450 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 19

* Received rent of $2,100
* Loan payment of $1,141 ($354 principal / $787 interest)
* New loan balance of $221,961
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,560 leaving cash of $186
* Net taxable income of $540
* Allowed monthly depreciation of $703 + carry-over of $3,049
* Used depreciation of $540 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,212
* Paid additional principal of $186 leaving balance of $221,775 and cash of $0
* NPV cash flow of $540

---

Owner in month # 20

* Loan payment of $1,141 ($342 principal / $799 interest)
* New loan balance of $225,308
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 20

* Investment of $68,366 grew by $453 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 20

* Received rent of $2,100
* Loan payment of $1,141 ($356 principal / $785 interest)
* New loan balance of $221,419
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,558 leaving cash of $186
* Net taxable income of $542
* Allowed monthly depreciation of $703 + carry-over of $3,212
* Used depreciation of $542 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,373
* Paid additional principal of $186 leaving balance of $221,233 and cash of $0
* NPV cash flow of $542

---

Owner in month # 21

* Loan payment of $1,141 ($343 principal / $798 interest)
* New loan balance of $224,965
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 21

* Investment of $68,822 grew by $456 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 21

* Received rent of $2,100
* Loan payment of $1,141 ($357 principal / $784 interest)
* New loan balance of $220,876
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,557 leaving cash of $186
* Net taxable income of $543
* Allowed monthly depreciation of $703 + carry-over of $3,373
* Used depreciation of $543 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,533
* Paid additional principal of $186 leaving balance of $220,690 and cash of $0
* NPV cash flow of $543

---

Owner in month # 22

* Loan payment of $1,141 ($344 principal / $797 interest)
* New loan balance of $224,621
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 22

* Investment of $69,281 grew by $459 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 22

* Received rent of $2,100
* Loan payment of $1,141 ($359 principal / $782 interest)
* New loan balance of $220,331
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,555 leaving cash of $186
* Net taxable income of $545
* Allowed monthly depreciation of $703 + carry-over of $3,533
* Used depreciation of $545 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,691
* Paid additional principal of $186 leaving balance of $220,145 and cash of $0
* NPV cash flow of $545

---

Owner in month # 23

* Loan payment of $1,141 ($345 principal / $796 interest)
* New loan balance of $224,276
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 23

* Investment of $69,743 grew by $462 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 23

* Received rent of $2,100
* Loan payment of $1,141 ($361 principal / $780 interest)
* New loan balance of $219,784
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,553 leaving cash of $186
* Net taxable income of $547
* Allowed monthly depreciation of $703 + carry-over of $3,691
* Used depreciation of $547 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,847
* Paid additional principal of $186 leaving balance of $219,598 and cash of $0
* NPV cash flow of $547

---

Owner in month # 24

* Loan payment of $1,141 ($347 principal / $794 interest)
* New loan balance of $223,929
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,704

---

Renter in month # 24

* Investment of $70,208 grew by $465 (0.67%)
* Spent $2,100 on rent
* Spent $15 on renters insurance

---

Landlord in month # 24

* Received rent of $2,100
* Loan payment of $1,141 ($363 principal / $778 interest)
* New loan balance of $219,235
* Management fee of $210
* Spent $210 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,551 leaving cash of $186
* Net taxable income of $549
* Allowed monthly depreciation of $703 + carry-over of $3,847
* Used depreciation of $549 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,001
* Paid additional principal of $186 leaving balance of $219,049 and cash of $0
* NPV cash flow of $549

---

Year # 2

* Owner Home value increased 3.70% to $311,749
* Landlord Home value increased 3.70% to $311,749
* Renters insurance increased 2.00% to $15.61
* Home owner's insurance increased 2.00% to $104.04
* HOA increased 2.00% to $0.00

---

Owner in month # 25

* Loan payment of $1,141 ($348 principal / $793 interest)
* New loan balance of $223,581
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 25

* Investment of $70,676 grew by $468 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 25

* Received rent of $2,100
* Loan payment of $1,141 ($365 principal / $776 interest)
* New loan balance of $218,684
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,568 leaving cash of $167
* Net taxable income of $532
* Allowed monthly depreciation of $703 + carry-over of $4,001
* Used depreciation of $532 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,172
* Paid additional principal of $167 leaving balance of $218,517 and cash of $0
* NPV cash flow of $532

---

Owner in month # 26

* Loan payment of $1,141 ($349 principal / $792 interest)
* New loan balance of $223,232
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 26

* Investment of $71,147 grew by $471 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 26

* Received rent of $2,100
* Loan payment of $1,141 ($367 principal / $774 interest)
* New loan balance of $218,150
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,566 leaving cash of $167
* Net taxable income of $534
* Allowed monthly depreciation of $703 + carry-over of $4,172
* Used depreciation of $534 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,341
* Paid additional principal of $167 leaving balance of $217,983 and cash of $0
* NPV cash flow of $534

---

Owner in month # 27

* Loan payment of $1,141 ($350 principal / $791 interest)
* New loan balance of $222,882
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 27

* Investment of $71,621 grew by $474 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 27

* Received rent of $2,100
* Loan payment of $1,141 ($369 principal / $772 interest)
* New loan balance of $217,614
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,564 leaving cash of $167
* Net taxable income of $536
* Allowed monthly depreciation of $703 + carry-over of $4,341
* Used depreciation of $536 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,508
* Paid additional principal of $167 leaving balance of $217,447 and cash of $0
* NPV cash flow of $536

---

Owner in month # 28

* Loan payment of $1,141 ($352 principal / $789 interest)
* New loan balance of $222,530
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 28

* Investment of $72,099 grew by $477 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 28

* Received rent of $2,100
* Loan payment of $1,141 ($371 principal / $770 interest)
* New loan balance of $217,076
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,562 leaving cash of $167
* Net taxable income of $538
* Allowed monthly depreciation of $703 + carry-over of $4,508
* Used depreciation of $538 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,673
* Paid additional principal of $167 leaving balance of $216,909 and cash of $0
* NPV cash flow of $538

---

Owner in month # 29

* Loan payment of $1,141 ($353 principal / $788 interest)
* New loan balance of $222,177
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 29

* Investment of $72,579 grew by $481 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 29

* Received rent of $2,100
* Loan payment of $1,141 ($373 principal / $768 interest)
* New loan balance of $216,536
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,560 leaving cash of $167
* Net taxable income of $540
* Allowed monthly depreciation of $703 + carry-over of $4,673
* Used depreciation of $540 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,836
* Paid additional principal of $167 leaving balance of $216,369 and cash of $0
* NPV cash flow of $540

---

Owner in month # 30

* Loan payment of $1,141 ($354 principal / $787 interest)
* New loan balance of $221,823
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 30

* Investment of $73,063 grew by $484 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 30

* Received rent of $2,100
* Loan payment of $1,141 ($375 principal / $766 interest)
* New loan balance of $215,994
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,558 leaving cash of $167
* Net taxable income of $542
* Allowed monthly depreciation of $703 + carry-over of $4,836
* Used depreciation of $542 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,997
* Paid additional principal of $167 leaving balance of $215,827 and cash of $0
* NPV cash flow of $542

---

Owner in month # 31

* Loan payment of $1,141 ($355 principal / $786 interest)
* New loan balance of $221,468
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 31

* Investment of $73,550 grew by $487 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 31

* Received rent of $2,100
* Loan payment of $1,141 ($377 principal / $764 interest)
* New loan balance of $215,450
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,556 leaving cash of $167
* Net taxable income of $544
* Allowed monthly depreciation of $703 + carry-over of $4,997
* Used depreciation of $544 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,156
* Paid additional principal of $167 leaving balance of $215,283 and cash of $0
* NPV cash flow of $544

---

Owner in month # 32

* Loan payment of $1,141 ($357 principal / $784 interest)
* New loan balance of $221,111
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 32

* Investment of $74,041 grew by $490 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 32

* Received rent of $2,100
* Loan payment of $1,141 ($379 principal / $762 interest)
* New loan balance of $214,904
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,554 leaving cash of $167
* Net taxable income of $546
* Allowed monthly depreciation of $703 + carry-over of $5,156
* Used depreciation of $546 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,313
* Paid additional principal of $167 leaving balance of $214,737 and cash of $0
* NPV cash flow of $546

---

Owner in month # 33

* Loan payment of $1,141 ($358 principal / $783 interest)
* New loan balance of $220,753
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 33

* Investment of $74,534 grew by $494 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 33

* Received rent of $2,100
* Loan payment of $1,141 ($380 principal / $761 interest)
* New loan balance of $214,357
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,553 leaving cash of $167
* Net taxable income of $547
* Allowed monthly depreciation of $703 + carry-over of $5,313
* Used depreciation of $547 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,469
* Paid additional principal of $167 leaving balance of $214,190 and cash of $0
* NPV cash flow of $547

---

Owner in month # 34

* Loan payment of $1,141 ($359 principal / $782 interest)
* New loan balance of $220,394
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 34

* Investment of $75,031 grew by $497 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 34

* Received rent of $2,100
* Loan payment of $1,141 ($382 principal / $759 interest)
* New loan balance of $213,808
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,551 leaving cash of $167
* Net taxable income of $549
* Allowed monthly depreciation of $703 + carry-over of $5,469
* Used depreciation of $549 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,623
* Paid additional principal of $167 leaving balance of $213,641 and cash of $0
* NPV cash flow of $549

---

Owner in month # 35

* Loan payment of $1,141 ($360 principal / $781 interest)
* New loan balance of $220,034
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 35

* Investment of $75,531 grew by $500 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 35

* Received rent of $2,100
* Loan payment of $1,141 ($384 principal / $757 interest)
* New loan balance of $213,257
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,549 leaving cash of $167
* Net taxable income of $551
* Allowed monthly depreciation of $703 + carry-over of $5,623
* Used depreciation of $551 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,775
* Paid additional principal of $167 leaving balance of $213,090 and cash of $0
* NPV cash flow of $551

---

Owner in month # 36

* Loan payment of $1,141 ($362 principal / $779 interest)
* New loan balance of $219,672
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,723

---

Renter in month # 36

* Investment of $76,035 grew by $504 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 36

* Received rent of $2,100
* Loan payment of $1,141 ($386 principal / $755 interest)
* New loan balance of $212,704
* Management fee of $210
* Spent $218 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,547 leaving cash of $167
* Net taxable income of $553
* Allowed monthly depreciation of $703 + carry-over of $5,775
* Used depreciation of $553 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,925
* Paid additional principal of $167 leaving balance of $212,537 and cash of $0
* NPV cash flow of $553

---

Year # 3

* Owner Home value increased 3.70% to $323,284
* Landlord Home value increased 3.70% to $323,284
* Renters insurance increased 2.00% to $15.92
* Home owner's insurance increased 2.00% to $106.12
* HOA increased 2.00% to $0.00

---

Owner in month # 37

* Loan payment of $1,141 ($363 principal / $778 interest)
* New loan balance of $219,309
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 37

* Investment of $76,542 grew by $507 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 37

* Received rent of $2,100
* Loan payment of $1,141 ($388 principal / $753 interest)
* New loan balance of $212,149
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,564 leaving cash of $148
* Net taxable income of $536
* Allowed monthly depreciation of $703 + carry-over of $5,925
* Used depreciation of $536 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,092
* Paid additional principal of $148 leaving balance of $212,002 and cash of $0
* NPV cash flow of $536

---

Owner in month # 38

* Loan payment of $1,141 ($364 principal / $777 interest)
* New loan balance of $218,945
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 38

* Investment of $77,052 grew by $510 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 38

* Received rent of $2,100
* Loan payment of $1,141 ($390 principal / $751 interest)
* New loan balance of $211,612
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,562 leaving cash of $148
* Net taxable income of $538
* Allowed monthly depreciation of $703 + carry-over of $6,092
* Used depreciation of $538 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,257
* Paid additional principal of $148 leaving balance of $211,464 and cash of $0
* NPV cash flow of $538

---

Owner in month # 39

* Loan payment of $1,141 ($366 principal / $775 interest)
* New loan balance of $218,579
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 39

* Investment of $77,566 grew by $514 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 39

* Received rent of $2,100
* Loan payment of $1,141 ($392 principal / $749 interest)
* New loan balance of $211,072
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,560 leaving cash of $148
* Net taxable income of $540
* Allowed monthly depreciation of $703 + carry-over of $6,257
* Used depreciation of $540 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,420
* Paid additional principal of $148 leaving balance of $210,924 and cash of $0
* NPV cash flow of $540

---

Owner in month # 40

* Loan payment of $1,141 ($367 principal / $774 interest)
* New loan balance of $218,212
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 40

* Investment of $78,083 grew by $517 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 40

* Received rent of $2,100
* Loan payment of $1,141 ($394 principal / $747 interest)
* New loan balance of $210,530
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,558 leaving cash of $148
* Net taxable income of $542
* Allowed monthly depreciation of $703 + carry-over of $6,420
* Used depreciation of $542 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,581
* Paid additional principal of $148 leaving balance of $210,382 and cash of $0
* NPV cash flow of $542

---

Owner in month # 41

* Loan payment of $1,141 ($368 principal / $773 interest)
* New loan balance of $217,844
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 41

* Investment of $78,603 grew by $521 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 41

* Received rent of $2,100
* Loan payment of $1,141 ($396 principal / $745 interest)
* New loan balance of $209,986
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,556 leaving cash of $148
* Net taxable income of $544
* Allowed monthly depreciation of $703 + carry-over of $6,581
* Used depreciation of $544 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,740
* Paid additional principal of $148 leaving balance of $209,838 and cash of $0
* NPV cash flow of $544

---

Owner in month # 42

* Loan payment of $1,141 ($369 principal / $772 interest)
* New loan balance of $217,475
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 42

* Investment of $79,127 grew by $524 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 42

* Received rent of $2,100
* Loan payment of $1,141 ($398 principal / $743 interest)
* New loan balance of $209,440
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,554 leaving cash of $148
* Net taxable income of $546
* Allowed monthly depreciation of $703 + carry-over of $6,740
* Used depreciation of $546 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,897
* Paid additional principal of $148 leaving balance of $209,292 and cash of $0
* NPV cash flow of $546

---

Owner in month # 43

* Loan payment of $1,141 ($371 principal / $770 interest)
* New loan balance of $217,104
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 43

* Investment of $79,655 grew by $528 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 43

* Received rent of $2,100
* Loan payment of $1,141 ($400 principal / $741 interest)
* New loan balance of $208,892
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,552 leaving cash of $148
* Net taxable income of $548
* Allowed monthly depreciation of $703 + carry-over of $6,897
* Used depreciation of $548 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,052
* Paid additional principal of $148 leaving balance of $208,744 and cash of $0
* NPV cash flow of $548

---

Owner in month # 44

* Loan payment of $1,141 ($372 principal / $769 interest)
* New loan balance of $216,732
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 44

* Investment of $80,186 grew by $531 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 44

* Received rent of $2,100
* Loan payment of $1,141 ($402 principal / $739 interest)
* New loan balance of $208,342
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,550 leaving cash of $148
* Net taxable income of $550
* Allowed monthly depreciation of $703 + carry-over of $7,052
* Used depreciation of $550 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,205
* Paid additional principal of $148 leaving balance of $208,194 and cash of $0
* NPV cash flow of $550

---

Owner in month # 45

* Loan payment of $1,141 ($373 principal / $768 interest)
* New loan balance of $216,359
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 45

* Investment of $80,721 grew by $535 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 45

* Received rent of $2,100
* Loan payment of $1,141 ($404 principal / $737 interest)
* New loan balance of $207,790
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,548 leaving cash of $148
* Net taxable income of $552
* Allowed monthly depreciation of $703 + carry-over of $7,205
* Used depreciation of $552 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,356
* Paid additional principal of $148 leaving balance of $207,643 and cash of $0
* NPV cash flow of $552

---

Owner in month # 46

* Loan payment of $1,141 ($375 principal / $766 interest)
* New loan balance of $215,984
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 46

* Investment of $81,259 grew by $538 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 46

* Received rent of $2,100
* Loan payment of $1,141 ($406 principal / $735 interest)
* New loan balance of $207,237
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,546 leaving cash of $148
* Net taxable income of $554
* Allowed monthly depreciation of $703 + carry-over of $7,356
* Used depreciation of $554 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,505
* Paid additional principal of $148 leaving balance of $207,089 and cash of $0
* NPV cash flow of $554

---

Owner in month # 47

* Loan payment of $1,141 ($376 principal / $765 interest)
* New loan balance of $215,608
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 47

* Investment of $81,800 grew by $542 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 47

* Received rent of $2,100
* Loan payment of $1,141 ($408 principal / $733 interest)
* New loan balance of $206,681
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,544 leaving cash of $148
* Net taxable income of $556
* Allowed monthly depreciation of $703 + carry-over of $7,505
* Used depreciation of $556 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,652
* Paid additional principal of $148 leaving balance of $206,533 and cash of $0
* NPV cash flow of $556

---

Owner in month # 48

* Loan payment of $1,141 ($377 principal / $764 interest)
* New loan balance of $215,231
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,742

---

Renter in month # 48

* Investment of $82,346 grew by $545 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 48

* Received rent of $2,100
* Loan payment of $1,141 ($410 principal / $731 interest)
* New loan balance of $206,123
* Management fee of $210
* Spent $226 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,542 leaving cash of $148
* Net taxable income of $558
* Allowed monthly depreciation of $703 + carry-over of $7,652
* Used depreciation of $558 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,797
* Paid additional principal of $148 leaving balance of $205,975 and cash of $0
* NPV cash flow of $558

---

Year # 4

* Owner Home value increased 3.70% to $335,246
* Landlord Home value increased 3.70% to $335,246
* Renters insurance increased 2.00% to $16.24
* Home owner's insurance increased 2.00% to $108.24
* HOA increased 2.00% to $0.00

---

Owner in month # 49

* Loan payment of $1,141 ($379 principal / $762 interest)
* New loan balance of $214,852
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 49

* Investment of $82,895 grew by $549 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 49

* Received rent of $2,100
* Loan payment of $1,141 ($412 principal / $729 interest)
* New loan balance of $205,563
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,561 leaving cash of $127
* Net taxable income of $539
* Allowed monthly depreciation of $703 + carry-over of $7,797
* Used depreciation of $539 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,961
* Paid additional principal of $127 leaving balance of $205,436 and cash of $0
* NPV cash flow of $539

---

Owner in month # 50

* Loan payment of $1,141 ($380 principal / $761 interest)
* New loan balance of $214,472
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 50

* Investment of $83,447 grew by $553 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 50

* Received rent of $2,100
* Loan payment of $1,141 ($413 principal / $728 interest)
* New loan balance of $205,023
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,560 leaving cash of $127
* Net taxable income of $540
* Allowed monthly depreciation of $703 + carry-over of $7,961
* Used depreciation of $540 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,124
* Paid additional principal of $127 leaving balance of $204,896 and cash of $0
* NPV cash flow of $540

---

Owner in month # 51

* Loan payment of $1,141 ($381 principal / $760 interest)
* New loan balance of $214,091
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 51

* Investment of $84,004 grew by $556 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 51

* Received rent of $2,100
* Loan payment of $1,141 ($415 principal / $726 interest)
* New loan balance of $204,481
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,558 leaving cash of $127
* Net taxable income of $542
* Allowed monthly depreciation of $703 + carry-over of $8,124
* Used depreciation of $542 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,285
* Paid additional principal of $127 leaving balance of $204,355 and cash of $0
* NPV cash flow of $542

---

Owner in month # 52

* Loan payment of $1,141 ($383 principal / $758 interest)
* New loan balance of $213,708
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 52

* Investment of $84,564 grew by $560 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 52

* Received rent of $2,100
* Loan payment of $1,141 ($417 principal / $724 interest)
* New loan balance of $203,938
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,556 leaving cash of $127
* Net taxable income of $544
* Allowed monthly depreciation of $703 + carry-over of $8,285
* Used depreciation of $544 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,444
* Paid additional principal of $127 leaving balance of $203,811 and cash of $0
* NPV cash flow of $544

---

Owner in month # 53

* Loan payment of $1,141 ($384 principal / $757 interest)
* New loan balance of $213,324
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 53

* Investment of $85,127 grew by $564 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 53

* Received rent of $2,100
* Loan payment of $1,141 ($419 principal / $722 interest)
* New loan balance of $203,392
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,554 leaving cash of $127
* Net taxable income of $546
* Allowed monthly depreciation of $703 + carry-over of $8,444
* Used depreciation of $546 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,601
* Paid additional principal of $127 leaving balance of $203,265 and cash of $0
* NPV cash flow of $546

---

Owner in month # 54

* Loan payment of $1,141 ($385 principal / $756 interest)
* New loan balance of $212,939
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 54

* Investment of $85,695 grew by $568 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 54

* Received rent of $2,100
* Loan payment of $1,141 ($421 principal / $720 interest)
* New loan balance of $202,844
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,552 leaving cash of $127
* Net taxable income of $548
* Allowed monthly depreciation of $703 + carry-over of $8,601
* Used depreciation of $548 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,756
* Paid additional principal of $127 leaving balance of $202,717 and cash of $0
* NPV cash flow of $548

---

Owner in month # 55

* Loan payment of $1,141 ($387 principal / $754 interest)
* New loan balance of $212,552
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 55

* Investment of $86,266 grew by $571 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 55

* Received rent of $2,100
* Loan payment of $1,141 ($423 principal / $718 interest)
* New loan balance of $202,294
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,550 leaving cash of $127
* Net taxable income of $550
* Allowed monthly depreciation of $703 + carry-over of $8,756
* Used depreciation of $550 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,909
* Paid additional principal of $127 leaving balance of $202,168 and cash of $0
* NPV cash flow of $550

---

Owner in month # 56

* Loan payment of $1,141 ($388 principal / $753 interest)
* New loan balance of $212,164
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 56

* Investment of $86,841 grew by $575 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 56

* Received rent of $2,100
* Loan payment of $1,141 ($425 principal / $716 interest)
* New loan balance of $201,743
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,548 leaving cash of $127
* Net taxable income of $552
* Allowed monthly depreciation of $703 + carry-over of $8,909
* Used depreciation of $552 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,060
* Paid additional principal of $127 leaving balance of $201,616 and cash of $0
* NPV cash flow of $552

---

Owner in month # 57

* Loan payment of $1,141 ($390 principal / $751 interest)
* New loan balance of $211,774
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 57

* Investment of $87,420 grew by $579 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 57

* Received rent of $2,100
* Loan payment of $1,141 ($427 principal / $714 interest)
* New loan balance of $201,189
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,546 leaving cash of $127
* Net taxable income of $554
* Allowed monthly depreciation of $703 + carry-over of $9,060
* Used depreciation of $554 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,209
* Paid additional principal of $127 leaving balance of $201,062 and cash of $0
* NPV cash flow of $554

---

Owner in month # 58

* Loan payment of $1,141 ($391 principal / $750 interest)
* New loan balance of $211,383
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 58

* Investment of $88,003 grew by $583 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 58

* Received rent of $2,100
* Loan payment of $1,141 ($429 principal / $712 interest)
* New loan balance of $200,633
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,544 leaving cash of $127
* Net taxable income of $556
* Allowed monthly depreciation of $703 + carry-over of $9,209
* Used depreciation of $556 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,356
* Paid additional principal of $127 leaving balance of $200,506 and cash of $0
* NPV cash flow of $556

---

Owner in month # 59

* Loan payment of $1,141 ($392 principal / $749 interest)
* New loan balance of $210,991
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 59

* Investment of $88,590 grew by $587 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 59

* Received rent of $2,100
* Loan payment of $1,141 ($431 principal / $710 interest)
* New loan balance of $200,075
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,542 leaving cash of $127
* Net taxable income of $558
* Allowed monthly depreciation of $703 + carry-over of $9,356
* Used depreciation of $558 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,501
* Paid additional principal of $127 leaving balance of $199,949 and cash of $0
* NPV cash flow of $558

---

Owner in month # 60

* Loan payment of $1,141 ($394 principal / $747 interest)
* New loan balance of $210,597
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,763

---

Renter in month # 60

* Investment of $89,180 grew by $591 (0.67%)
* Spent $2,100 on rent
* Spent $16 on renters insurance

---

Landlord in month # 60

* Received rent of $2,100
* Loan payment of $1,141 ($433 principal / $708 interest)
* New loan balance of $199,516
* Management fee of $210
* Spent $235 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,540 leaving cash of $127
* Net taxable income of $560
* Allowed monthly depreciation of $703 + carry-over of $9,501
* Used depreciation of $560 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,644
* Paid additional principal of $127 leaving balance of $199,389 and cash of $0
* NPV cash flow of $560

---

Year # 5

* Owner Home value increased 3.70% to $347,650
* Landlord Home value increased 3.70% to $347,650
* Renters insurance increased 2.00% to $16.56
* Home owner's insurance increased 2.00% to $110.40
* HOA increased 2.00% to $0.00

---

Owner in month # 61

* Loan payment of $1,141 ($395 principal / $746 interest)
* New loan balance of $210,202
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 61

* Investment of $89,775 grew by $595 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 61

* Received rent of $2,100
* Loan payment of $1,141 ($435 principal / $706 interest)
* New loan balance of $198,954
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,559 leaving cash of $106
* Net taxable income of $541
* Allowed monthly depreciation of $703 + carry-over of $9,644
* Used depreciation of $541 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,806
* Paid additional principal of $106 leaving balance of $198,848 and cash of $0
* NPV cash flow of $541

---

Owner in month # 62

* Loan payment of $1,141 ($397 principal / $744 interest)
* New loan balance of $209,805
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 62

* Investment of $90,373 grew by $599 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 62

* Received rent of $2,100
* Loan payment of $1,141 ($437 principal / $704 interest)
* New loan balance of $198,411
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,557 leaving cash of $106
* Net taxable income of $543
* Allowed monthly depreciation of $703 + carry-over of $9,806
* Used depreciation of $543 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,966
* Paid additional principal of $106 leaving balance of $198,306 and cash of $0
* NPV cash flow of $543

---

Owner in month # 63

* Loan payment of $1,141 ($398 principal / $743 interest)
* New loan balance of $209,407
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 63

* Investment of $90,976 grew by $602 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 63

* Received rent of $2,100
* Loan payment of $1,141 ($439 principal / $702 interest)
* New loan balance of $197,867
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,555 leaving cash of $106
* Net taxable income of $545
* Allowed monthly depreciation of $703 + carry-over of $9,966
* Used depreciation of $545 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,124
* Paid additional principal of $106 leaving balance of $197,761 and cash of $0
* NPV cash flow of $545

---

Owner in month # 64

* Loan payment of $1,141 ($399 principal / $742 interest)
* New loan balance of $209,008
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 64

* Investment of $91,582 grew by $607 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 64

* Received rent of $2,100
* Loan payment of $1,141 ($441 principal / $700 interest)
* New loan balance of $197,320
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,553 leaving cash of $106
* Net taxable income of $547
* Allowed monthly depreciation of $703 + carry-over of $10,124
* Used depreciation of $547 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,280
* Paid additional principal of $106 leaving balance of $197,214 and cash of $0
* NPV cash flow of $547

---

Owner in month # 65

* Loan payment of $1,141 ($401 principal / $740 interest)
* New loan balance of $208,607
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 65

* Investment of $92,193 grew by $611 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 65

* Received rent of $2,100
* Loan payment of $1,141 ($443 principal / $698 interest)
* New loan balance of $196,771
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,551 leaving cash of $106
* Net taxable income of $549
* Allowed monthly depreciation of $703 + carry-over of $10,280
* Used depreciation of $549 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,434
* Paid additional principal of $106 leaving balance of $196,666 and cash of $0
* NPV cash flow of $549

---

Owner in month # 66

* Loan payment of $1,141 ($402 principal / $739 interest)
* New loan balance of $208,205
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 66

* Investment of $92,808 grew by $615 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 66

* Received rent of $2,100
* Loan payment of $1,141 ($444 principal / $697 interest)
* New loan balance of $196,222
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,550 leaving cash of $106
* Net taxable income of $550
* Allowed monthly depreciation of $703 + carry-over of $10,434
* Used depreciation of $550 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,587
* Paid additional principal of $106 leaving balance of $196,116 and cash of $0
* NPV cash flow of $550

---

Owner in month # 67

* Loan payment of $1,141 ($404 principal / $737 interest)
* New loan balance of $207,801
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 67

* Investment of $93,426 grew by $619 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 67

* Received rent of $2,100
* Loan payment of $1,141 ($446 principal / $695 interest)
* New loan balance of $195,670
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,548 leaving cash of $106
* Net taxable income of $552
* Allowed monthly depreciation of $703 + carry-over of $10,587
* Used depreciation of $552 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,738
* Paid additional principal of $106 leaving balance of $195,565 and cash of $0
* NPV cash flow of $552

---

Owner in month # 68

* Loan payment of $1,141 ($405 principal / $736 interest)
* New loan balance of $207,396
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 68

* Investment of $94,049 grew by $623 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 68

* Received rent of $2,100
* Loan payment of $1,141 ($448 principal / $693 interest)
* New loan balance of $195,117
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,546 leaving cash of $106
* Net taxable income of $554
* Allowed monthly depreciation of $703 + carry-over of $10,738
* Used depreciation of $554 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,887
* Paid additional principal of $106 leaving balance of $195,011 and cash of $0
* NPV cash flow of $554

---

Owner in month # 69

* Loan payment of $1,141 ($406 principal / $735 interest)
* New loan balance of $206,990
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 69

* Investment of $94,676 grew by $627 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 69

* Received rent of $2,100
* Loan payment of $1,141 ($450 principal / $691 interest)
* New loan balance of $194,561
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,544 leaving cash of $106
* Net taxable income of $556
* Allowed monthly depreciation of $703 + carry-over of $10,887
* Used depreciation of $556 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,034
* Paid additional principal of $106 leaving balance of $194,455 and cash of $0
* NPV cash flow of $556

---

Owner in month # 70

* Loan payment of $1,141 ($408 principal / $733 interest)
* New loan balance of $206,582
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 70

* Investment of $95,307 grew by $631 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 70

* Received rent of $2,100
* Loan payment of $1,141 ($452 principal / $689 interest)
* New loan balance of $194,003
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,542 leaving cash of $106
* Net taxable income of $558
* Allowed monthly depreciation of $703 + carry-over of $11,034
* Used depreciation of $558 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,179
* Paid additional principal of $106 leaving balance of $193,898 and cash of $0
* NPV cash flow of $558

---

Owner in month # 71

* Loan payment of $1,141 ($409 principal / $732 interest)
* New loan balance of $206,173
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 71

* Investment of $95,943 grew by $635 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 71

* Received rent of $2,100
* Loan payment of $1,141 ($454 principal / $687 interest)
* New loan balance of $193,444
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,540 leaving cash of $106
* Net taxable income of $560
* Allowed monthly depreciation of $703 + carry-over of $11,179
* Used depreciation of $560 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,322
* Paid additional principal of $106 leaving balance of $193,338 and cash of $0
* NPV cash flow of $560

---

Owner in month # 72

* Loan payment of $1,141 ($411 principal / $730 interest)
* New loan balance of $205,762
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,784

---

Renter in month # 72

* Investment of $96,582 grew by $640 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 72

* Received rent of $2,100
* Loan payment of $1,141 ($456 principal / $685 interest)
* New loan balance of $192,882
* Management fee of $210
* Spent $243 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,538 leaving cash of $106
* Net taxable income of $562
* Allowed monthly depreciation of $703 + carry-over of $11,322
* Used depreciation of $562 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,463
* Paid additional principal of $106 leaving balance of $192,777 and cash of $0
* NPV cash flow of $562

---

Year # 6

* Owner Home value increased 3.70% to $360,513
* Landlord Home value increased 3.70% to $360,513
* Renters insurance increased 2.00% to $16.89
* Home owner's insurance increased 2.00% to $112.61
* HOA increased 2.00% to $0.00

---

Owner in month # 73

* Loan payment of $1,141 ($412 principal / $729 interest)
* New loan balance of $205,350
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 73

* Investment of $97,226 grew by $644 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 73

* Received rent of $2,100
* Loan payment of $1,141 ($458 principal / $683 interest)
* New loan balance of $192,319
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,558 leaving cash of $84
* Net taxable income of $542
* Allowed monthly depreciation of $703 + carry-over of $11,463
* Used depreciation of $542 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,624
* Paid additional principal of $84 leaving balance of $192,234 and cash of $0
* NPV cash flow of $542

---

Owner in month # 74

* Loan payment of $1,141 ($414 principal / $727 interest)
* New loan balance of $204,936
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 74

* Investment of $97,874 grew by $648 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 74

* Received rent of $2,100
* Loan payment of $1,141 ($460 principal / $681 interest)
* New loan balance of $191,774
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,556 leaving cash of $84
* Net taxable income of $544
* Allowed monthly depreciation of $703 + carry-over of $11,624
* Used depreciation of $544 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,783
* Paid additional principal of $84 leaving balance of $191,690 and cash of $0
* NPV cash flow of $544

---

Owner in month # 75

* Loan payment of $1,141 ($415 principal / $726 interest)
* New loan balance of $204,521
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 75

* Investment of $98,527 grew by $653 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 75

* Received rent of $2,100
* Loan payment of $1,141 ($462 principal / $679 interest)
* New loan balance of $191,228
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,554 leaving cash of $84
* Net taxable income of $546
* Allowed monthly depreciation of $703 + carry-over of $11,783
* Used depreciation of $546 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,940
* Paid additional principal of $84 leaving balance of $191,143 and cash of $0
* NPV cash flow of $546

---

Owner in month # 76

* Loan payment of $1,141 ($417 principal / $724 interest)
* New loan balance of $204,104
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 76

* Investment of $99,184 grew by $657 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 76

* Received rent of $2,100
* Loan payment of $1,141 ($464 principal / $677 interest)
* New loan balance of $190,679
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,552 leaving cash of $84
* Net taxable income of $548
* Allowed monthly depreciation of $703 + carry-over of $11,940
* Used depreciation of $548 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,095
* Paid additional principal of $84 leaving balance of $190,595 and cash of $0
* NPV cash flow of $548

---

Owner in month # 77

* Loan payment of $1,141 ($418 principal / $723 interest)
* New loan balance of $203,686
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 77

* Investment of $99,845 grew by $661 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 77

* Received rent of $2,100
* Loan payment of $1,141 ($466 principal / $675 interest)
* New loan balance of $190,129
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,550 leaving cash of $84
* Net taxable income of $550
* Allowed monthly depreciation of $703 + carry-over of $12,095
* Used depreciation of $550 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,248
* Paid additional principal of $84 leaving balance of $190,045 and cash of $0
* NPV cash flow of $550

---

Owner in month # 78

* Loan payment of $1,141 ($420 principal / $721 interest)
* New loan balance of $203,266
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 78

* Investment of $100,511 grew by $666 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 78

* Received rent of $2,100
* Loan payment of $1,141 ($468 principal / $673 interest)
* New loan balance of $189,577
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,548 leaving cash of $84
* Net taxable income of $552
* Allowed monthly depreciation of $703 + carry-over of $12,248
* Used depreciation of $552 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,399
* Paid additional principal of $84 leaving balance of $189,492 and cash of $0
* NPV cash flow of $552

---

Owner in month # 79

* Loan payment of $1,141 ($421 principal / $720 interest)
* New loan balance of $202,845
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 79

* Investment of $101,181 grew by $670 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 79

* Received rent of $2,100
* Loan payment of $1,141 ($470 principal / $671 interest)
* New loan balance of $189,022
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,546 leaving cash of $84
* Net taxable income of $554
* Allowed monthly depreciation of $703 + carry-over of $12,399
* Used depreciation of $554 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,548
* Paid additional principal of $84 leaving balance of $188,938 and cash of $0
* NPV cash flow of $554

---

Owner in month # 80

* Loan payment of $1,141 ($423 principal / $718 interest)
* New loan balance of $202,422
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 80

* Investment of $101,855 grew by $675 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 80

* Received rent of $2,100
* Loan payment of $1,141 ($472 principal / $669 interest)
* New loan balance of $188,466
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,544 leaving cash of $84
* Net taxable income of $556
* Allowed monthly depreciation of $703 + carry-over of $12,548
* Used depreciation of $556 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,695
* Paid additional principal of $84 leaving balance of $188,381 and cash of $0
* NPV cash flow of $556

---

Owner in month # 81

* Loan payment of $1,141 ($424 principal / $717 interest)
* New loan balance of $201,998
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 81

* Investment of $102,534 grew by $679 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 81

* Received rent of $2,100
* Loan payment of $1,141 ($474 principal / $667 interest)
* New loan balance of $187,907
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,542 leaving cash of $84
* Net taxable income of $558
* Allowed monthly depreciation of $703 + carry-over of $12,695
* Used depreciation of $558 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,840
* Paid additional principal of $84 leaving balance of $187,823 and cash of $0
* NPV cash flow of $558

---

Owner in month # 82

* Loan payment of $1,141 ($426 principal / $715 interest)
* New loan balance of $201,572
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 82

* Investment of $103,218 grew by $684 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 82

* Received rent of $2,100
* Loan payment of $1,141 ($476 principal / $665 interest)
* New loan balance of $187,347
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,540 leaving cash of $84
* Net taxable income of $560
* Allowed monthly depreciation of $703 + carry-over of $12,840
* Used depreciation of $560 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,983
* Paid additional principal of $84 leaving balance of $187,263 and cash of $0
* NPV cash flow of $560

---

Owner in month # 83

* Loan payment of $1,141 ($427 principal / $714 interest)
* New loan balance of $201,145
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 83

* Investment of $103,906 grew by $688 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 83

* Received rent of $2,100
* Loan payment of $1,141 ($478 principal / $663 interest)
* New loan balance of $186,785
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,538 leaving cash of $84
* Net taxable income of $562
* Allowed monthly depreciation of $703 + carry-over of $12,983
* Used depreciation of $562 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,124
* Paid additional principal of $84 leaving balance of $186,700 and cash of $0
* NPV cash flow of $562

---

Owner in month # 84

* Loan payment of $1,141 ($429 principal / $712 interest)
* New loan balance of $200,716
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,806

---

Renter in month # 84

* Investment of $104,599 grew by $693 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 84

* Received rent of $2,100
* Loan payment of $1,141 ($480 principal / $661 interest)
* New loan balance of $186,220
* Management fee of $210
* Spent $252 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,536 leaving cash of $84
* Net taxable income of $564
* Allowed monthly depreciation of $703 + carry-over of $13,124
* Used depreciation of $564 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,263
* Paid additional principal of $84 leaving balance of $186,136 and cash of $0
* NPV cash flow of $564

---

Year # 7

* Owner Home value increased 3.70% to $373,852
* Landlord Home value increased 3.70% to $373,852
* Renters insurance increased 2.00% to $17.23
* Home owner's insurance increased 2.00% to $114.86
* HOA increased 2.00% to $0.00

---

Owner in month # 85

* Loan payment of $1,141 ($430 principal / $711 interest)
* New loan balance of $200,286
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 85

* Investment of $105,296 grew by $697 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 85

* Received rent of $2,100
* Loan payment of $1,141 ($482 principal / $659 interest)
* New loan balance of $185,654
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,558 leaving cash of $60
* Net taxable income of $542
* Allowed monthly depreciation of $703 + carry-over of $13,263
* Used depreciation of $542 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,424
* Paid additional principal of $60 leaving balance of $185,594 and cash of $0
* NPV cash flow of $542

---

Owner in month # 86

* Loan payment of $1,141 ($432 principal / $709 interest)
* New loan balance of $199,854
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 86

* Investment of $105,998 grew by $702 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 86

* Received rent of $2,100
* Loan payment of $1,141 ($484 principal / $657 interest)
* New loan balance of $185,110
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,556 leaving cash of $60
* Net taxable income of $544
* Allowed monthly depreciation of $703 + carry-over of $13,424
* Used depreciation of $544 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,583
* Paid additional principal of $60 leaving balance of $185,050 and cash of $0
* NPV cash flow of $544

---

Owner in month # 87

* Loan payment of $1,141 ($433 principal / $708 interest)
* New loan balance of $199,421
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 87

* Investment of $106,705 grew by $707 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 87

* Received rent of $2,100
* Loan payment of $1,141 ($486 principal / $655 interest)
* New loan balance of $184,564
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,554 leaving cash of $60
* Net taxable income of $546
* Allowed monthly depreciation of $703 + carry-over of $13,583
* Used depreciation of $546 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,740
* Paid additional principal of $60 leaving balance of $184,504 and cash of $0
* NPV cash flow of $546

---

Owner in month # 88

* Loan payment of $1,141 ($435 principal / $706 interest)
* New loan balance of $198,986
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 88

* Investment of $107,416 grew by $711 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 88

* Received rent of $2,100
* Loan payment of $1,141 ($488 principal / $653 interest)
* New loan balance of $184,016
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,552 leaving cash of $60
* Net taxable income of $548
* Allowed monthly depreciation of $703 + carry-over of $13,740
* Used depreciation of $548 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,895
* Paid additional principal of $60 leaving balance of $183,955 and cash of $0
* NPV cash flow of $548

---

Owner in month # 89

* Loan payment of $1,141 ($436 principal / $705 interest)
* New loan balance of $198,550
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 89

* Investment of $108,132 grew by $716 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 89

* Received rent of $2,100
* Loan payment of $1,141 ($489 principal / $652 interest)
* New loan balance of $183,466
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,551 leaving cash of $60
* Net taxable income of $549
* Allowed monthly depreciation of $703 + carry-over of $13,895
* Used depreciation of $549 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,049
* Paid additional principal of $60 leaving balance of $183,406 and cash of $0
* NPV cash flow of $549

---

Owner in month # 90

* Loan payment of $1,141 ($438 principal / $703 interest)
* New loan balance of $198,112
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 90

* Investment of $108,853 grew by $721 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 90

* Received rent of $2,100
* Loan payment of $1,141 ($491 principal / $650 interest)
* New loan balance of $182,915
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,549 leaving cash of $60
* Net taxable income of $551
* Allowed monthly depreciation of $703 + carry-over of $14,049
* Used depreciation of $551 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,201
* Paid additional principal of $60 leaving balance of $182,855 and cash of $0
* NPV cash flow of $551

---

Owner in month # 91

* Loan payment of $1,141 ($439 principal / $702 interest)
* New loan balance of $197,673
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 91

* Investment of $109,579 grew by $726 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 91

* Received rent of $2,100
* Loan payment of $1,141 ($493 principal / $648 interest)
* New loan balance of $182,362
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,547 leaving cash of $60
* Net taxable income of $553
* Allowed monthly depreciation of $703 + carry-over of $14,201
* Used depreciation of $553 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,351
* Paid additional principal of $60 leaving balance of $182,302 and cash of $0
* NPV cash flow of $553

---

Owner in month # 92

* Loan payment of $1,141 ($441 principal / $700 interest)
* New loan balance of $197,232
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 92

* Investment of $110,309 grew by $731 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 92

* Received rent of $2,100
* Loan payment of $1,141 ($495 principal / $646 interest)
* New loan balance of $181,807
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,545 leaving cash of $60
* Net taxable income of $555
* Allowed monthly depreciation of $703 + carry-over of $14,351
* Used depreciation of $555 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,499
* Paid additional principal of $60 leaving balance of $181,747 and cash of $0
* NPV cash flow of $555

---

Owner in month # 93

* Loan payment of $1,141 ($442 principal / $699 interest)
* New loan balance of $196,790
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 93

* Investment of $111,044 grew by $735 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 93

* Received rent of $2,100
* Loan payment of $1,141 ($497 principal / $644 interest)
* New loan balance of $181,250
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,543 leaving cash of $60
* Net taxable income of $557
* Allowed monthly depreciation of $703 + carry-over of $14,499
* Used depreciation of $557 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,645
* Paid additional principal of $60 leaving balance of $181,190 and cash of $0
* NPV cash flow of $557

---

Owner in month # 94

* Loan payment of $1,141 ($444 principal / $697 interest)
* New loan balance of $196,346
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 94

* Investment of $111,785 grew by $740 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 94

* Received rent of $2,100
* Loan payment of $1,141 ($499 principal / $642 interest)
* New loan balance of $180,691
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,541 leaving cash of $60
* Net taxable income of $559
* Allowed monthly depreciation of $703 + carry-over of $14,645
* Used depreciation of $559 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,789
* Paid additional principal of $60 leaving balance of $180,631 and cash of $0
* NPV cash flow of $559

---

Owner in month # 95

* Loan payment of $1,141 ($446 principal / $695 interest)
* New loan balance of $195,900
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 95

* Investment of $112,530 grew by $745 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 95

* Received rent of $2,100
* Loan payment of $1,141 ($501 principal / $640 interest)
* New loan balance of $180,130
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,539 leaving cash of $60
* Net taxable income of $561
* Allowed monthly depreciation of $703 + carry-over of $14,789
* Used depreciation of $561 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,931
* Paid additional principal of $60 leaving balance of $180,069 and cash of $0
* NPV cash flow of $561

---

Owner in month # 96

* Loan payment of $1,141 ($447 principal / $694 interest)
* New loan balance of $195,453
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,830

---

Renter in month # 96

* Investment of $113,280 grew by $750 (0.67%)
* Spent $2,100 on rent
* Spent $17 on renters insurance

---

Landlord in month # 96

* Received rent of $2,100
* Loan payment of $1,141 ($503 principal / $638 interest)
* New loan balance of $179,566
* Management fee of $210
* Spent $262 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,537 leaving cash of $60
* Net taxable income of $563
* Allowed monthly depreciation of $703 + carry-over of $14,931
* Used depreciation of $563 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,071
* Paid additional principal of $60 leaving balance of $179,506 and cash of $0
* NPV cash flow of $563

---

Year # 8

* Owner Home value increased 3.70% to $387,685
* Landlord Home value increased 3.70% to $387,685
* Renters insurance increased 2.00% to $17.57
* Home owner's insurance increased 2.00% to $117.16
* HOA increased 2.00% to $0.00

---

Owner in month # 97

* Loan payment of $1,141 ($449 principal / $692 interest)
* New loan balance of $195,004
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,852

---

Renter in month # 97

* Investment of $114,035 grew by $755 (0.67%)
* Spent $2,100 on rent
* Spent $18 on renters insurance

---

Landlord in month # 97

* Received rent of $2,100
* Loan payment of $1,141 ($505 principal / $636 interest)
* New loan balance of $179,001
* Management fee of $210
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,557 leaving cash of $38
* Net taxable income of $543
* Allowed monthly depreciation of $703 + carry-over of $15,071
* Used depreciation of $543 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,231
* Paid additional principal of $38 leaving balance of $178,963 and cash of $0
* NPV cash flow of $543

---

Owner in month # 98

* Loan payment of $1,141 ($450 principal / $691 interest)
* New loan balance of $194,554
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,852

---

Renter in month # 98

* Investment of $114,796 grew by $760 (0.67%)
* Spent $2,100 on rent
* Spent $18 on renters insurance

---

Landlord in month # 98

* Received rent of $2,100
* Loan payment of $1,141 ($507 principal / $634 interest)
* New loan balance of $178,456
* Management fee of $210
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,555 leaving cash of $38
* Net taxable income of $545
* Allowed monthly depreciation of $703 + carry-over of $15,231
* Used depreciation of $545 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,389
* Paid additional principal of $38 leaving balance of $178,419 and cash of $0
* NPV cash flow of $545

---

Owner in month # 99

* Loan payment of $1,141 ($452 principal / $689 interest)
* New loan balance of $194,102
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,852

---

Renter in month # 99

* Investment of $115,561 grew by $765 (0.67%)
* Spent $2,100 on rent
* Spent $18 on renters insurance

---

Landlord in month # 99

* Received rent of $2,100
* Loan payment of $1,141 ($509 principal / $632 interest)
* New loan balance of $177,910
* Management fee of $210
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,553 leaving cash of $38
* Net taxable income of $547
* Allowed monthly depreciation of $703 + carry-over of $15,389
* Used depreciation of $547 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,545
* Paid additional principal of $38 leaving balance of $177,872 and cash of $0
* NPV cash flow of $547

---

Owner in month # 100

* Loan payment of $1,141 ($454 principal / $687 interest)
* New loan balance of $193,648
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,852

---

Renter in month # 100

* Investment of $116,331 grew by $770 (0.67%)
* Spent $2,100 on rent
* Spent $18 on renters insurance

---

Landlord in month # 100

* Received rent of $2,100
* Loan payment of $1,141 ($511 principal / $630 interest)
* New loan balance of $177,361
* Management fee of $210
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,551 leaving cash of $38
* Net taxable income of $549
* Allowed monthly depreciation of $703 + carry-over of $15,545
* Used depreciation of $549 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,699
* Paid additional principal of $38 leaving balance of $177,323 and cash of $0
* NPV cash flow of $549

---

Owner in month # 101

* Loan payment of $1,141 ($455 principal / $686 interest)
* New loan balance of $193,193
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,852

---

Renter in month # 101

* Investment of $117,107 grew by $776 (0.67%)
* Spent $2,100 on rent
* Spent $18 on renters insurance

---

Landlord in month # 101

* Received rent of $2,100
* Loan payment of $1,141 ($513 principal / $628 interest)
* New loan balance of $176,810
* Management fee of $210
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,549 leaving cash of $38
* Net taxable income of $551
* Allowed monthly depreciation of $703 + carry-over of $15,699
* Used depreciation of $551 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,851
* Paid additional principal of $38 leaving balance of $176,772 and cash of $0
* NPV cash flow of $551

---

Owner in month # 102

* Loan payment of $1,141 ($457 principal / $684 interest)
* New loan balance of $192,736
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,852

---

Renter in month # 102

* Investment of $117,888 grew by $781 (0.67%)
* Spent $2,100 on rent
* Spent $18 on renters insurance

---

Landlord in month # 102

* Received rent of $2,100
* Loan payment of $1,141 ($515 principal / $626 interest)
* New loan balance of $176,257
* Management fee of $210
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,547 leaving cash of $38
* Net taxable income of $553
* Allowed monthly depreciation of $703 + carry-over of $15,851
* Used depreciation of $553 resulting in adjusted taxable income of $0
* Carry over depreciation of $16,001
* Paid additional principal of $38 leaving balance of $176,219 and cash of $0
* NPV cash flow of $553

---

Owner in month # 103

* Loan payment of $1,141 ($458 principal / $683 interest)
* New loan balance of $192,278
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,852

---

Renter in month # 103

* Investment of $118,674 grew by $786 (0.67%)
* Spent $2,100 on rent
* Spent $18 on renters insurance

---

Landlord in month # 103

* Received rent of $2,100
* Loan payment of $1,141 ($517 principal / $624 interest)
* New loan balance of $175,702
* Management fee of $210
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,545 leaving cash of $38
* Net taxable income of $555
* Allowed monthly depreciation of $703 + carry-over of $16,001
* Used depreciation of $555 resulting in adjusted taxable income of $0
* Carry over depreciation of $16,149
* Paid additional principal of $38 leaving balance of $175,664 and cash of $0
* NPV cash flow of $555

---

Owner in month # 104

* Loan payment of $1,141 ($460 principal / $681 interest)
* New loan balance of $191,818
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,852
* Sold home for $387,685
* Fixed sales costs of $1,000 and commission of $23,261
* Paid off loan balance of $191,818
* Home sale proceeds of $171,606

---

Renter in month # 104

* Investment of $119,465 grew by $791 (0.67%)
* Spent $2,100 on rent
* Spent $18 on renters insurance
* Capital gains of $59,606 on initial investment of $59,859
* Capital gains tax of $8,941
* Cashed out investment of $119,465
* Returned security deposit of $2,100
* Cash on hand of $112,624
* Total spent $220,086

---

Landlord in month # 104

* Received rent of $2,100
* Loan payment of $1,141 ($519 principal / $622 interest)
* New loan balance of $175,145
* Management fee of $210
* Spent $271 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,543 leaving cash of $38
* Net taxable income of $557
* Allowed monthly depreciation of $703 + carry-over of $16,149
* Used depreciation of $557 resulting in adjusted taxable income of $0
* Carry over depreciation of $16,295
* Paid additional principal of $38 leaving balance of $175,108 and cash of $0
* NPV cash flow of $557
* Sold home for $387,685
* Fixed sales costs of $1,000 and commission of $23,261 leaving proceeds of $363,424
* Total gain from sale of $77,503
* Paid depreciation recapture taxes of $13,636 on $56,817
* Paid capital gains taxes of $3,103 on $20,686
* Paid off loan balance of $175,108
* Net home sale proceeds of $171,577
* Total cash on hand of $171,577
* Adjusted NPV cash flow of $172,134 accounting for sale proceeds of $171,577
* Net present value of $64,795
* Internal rate of return of 18.77%

---

|Default Simulator||
| --- | --: |
|Years|8.70|
|Months|104|
|HomePurchaseAmount|$289,900|
|OwnerInterestRate|4.25%|
|OwnerLoanYears|30|
|OwnerDownPaymentPercentage|20.00%|
|OwnerDownPayment|$57,980|
|OwnerLoanAmount|$231,920|
|OwnerHomeValue|$0|
|OwnerLoanBalance|$0|
|OwnerMonthlyPayment|$1,141|
|RentChangePerYearPercentage|0.00%|
|Rent|$2,100|
|RentSecurityDepositMonths|1|
|RentersInsurancePerMonth|$18|
|LandlordInterestRate|4.25%|
|LandlordLoanYears|30|
|LandlordDownPaymentPercentage|20.00%|
|LandlordDownPayment|$57,980|
|LandlordLoanAmount|$231,920|
|LandlordHomeValue|$0|
|LandlordLoanBalance|$0|
|LandlordMonthlyPayment|$1,141|
|LandlordManagementFeePercentage|10.00%|
|DepreciationYears|27.50|
|DepreciablePercentage|80.00%|
|ClosingFixedCosts|$500|
|ClosingVariableCostsPercentage|1.50%|
|PropertyTaxPercentage|0.84%|
|InsurancePerMonth|$117|
|HoaPerMonth|$0|
|HomeAppreciationPercentagePerYear|3.70%|
|HomeMaintenancePercentagePerYear|1.00%|
|SalesCommissionPercentage|6.00%|
|SalesFixedCosts|$1,000|
|DiscountRate|8.00%|
|CapitalGainsRate|15.00%|
|MarginalTaxRate|24.00%|
|InflationRate|2.00%|

---

Owner spent $183,277 (average of $1,762 / month) and has net worth of $171,606 on initial investment of $61,959

---

Renter spent $220,086 (average of $2,116 / month) and has net worth of $112,624 on initial investment of $59,859 + security deposit of $2,100

---

Landlord received total rent of $218,400 (average of $2,100 / month), total expenses of $202,588 (average of $1,948 / month), and has net worth of $171,577 on initial investment of $61,959
Net present value of $64,795
Internal rate of return of 18.77%
