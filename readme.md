# Rent vs Own Simulation

An application that simulates owning, renting and being a landlord of a property.

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
|Rent|$1,584|
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
|PropertyTaxPercentage|0.42%|
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
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 1

* Starting cash of $61,959 ($57,980 owner down payment + $500 owner fixed closing costs + $3,479 owner variable closing costs)
* Security deposit of $1,584
* Invested  $60,375
* Investment of $60,777 grew by $403 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 1

* Down payment of $57,980
* Fixed closing costs of $500
* Variable closing costs of $3,479
* Total initial investment of $61,959
* Basis in home purchase $285,921
* Initial loan balance of $231,920
* Received rent of $1,584
* Loan payment of $1,141 ($320 principal / $821 interest)
* New loan balance of $231,600
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,422 leaving cash of ($158)
* Net taxable income of $162
* Allowed monthly depreciation of $703 + carry-over of $0
* Used depreciation of $162 resulting in adjusted taxable income of $0
* Carry over depreciation of $541
* Required personal loan of $158 creating a balance of $158
* Monthly expenses $1,422 + principle of $320 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $3

---

Owner in month # 2

* Loan payment of $1,141 ($321 principal / $820 interest)
* New loan balance of $231,279
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 2

* Investment of $61,182 grew by $405 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 2

* Received rent of $1,584
* Loan payment of $1,141 ($321 principal / $820 interest)
* New loan balance of $231,279
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,421 leaving cash of ($158)
* Net taxable income of $163
* Allowed monthly depreciation of $703 + carry-over of $541
* Used depreciation of $163 resulting in adjusted taxable income of $0
* Carry over depreciation of $1,081
* Required personal loan of $158 creating a balance of $317
* Monthly expenses $1,421 + principle of $321 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $4

---

Owner in month # 3

* Loan payment of $1,141 ($322 principal / $819 interest)
* New loan balance of $230,957
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 3

* Investment of $61,590 grew by $408 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 3

* Received rent of $1,584
* Loan payment of $1,141 ($322 principal / $819 interest)
* New loan balance of $230,957
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,420 leaving cash of ($158)
* Net taxable income of $164
* Allowed monthly depreciation of $703 + carry-over of $1,081
* Used depreciation of $164 resulting in adjusted taxable income of $0
* Carry over depreciation of $1,620
* Required personal loan of $158 creating a balance of $475
* Monthly expenses $1,420 + principle of $322 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $5

---

Owner in month # 4

* Loan payment of $1,141 ($323 principal / $818 interest)
* New loan balance of $230,634
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 4

* Investment of $62,001 grew by $411 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 4

* Received rent of $1,584
* Loan payment of $1,141 ($323 principal / $818 interest)
* New loan balance of $230,634
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,419 leaving cash of ($158)
* Net taxable income of $165
* Allowed monthly depreciation of $703 + carry-over of $1,620
* Used depreciation of $165 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,158
* Required personal loan of $158 creating a balance of $634
* Monthly expenses $1,419 + principle of $323 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $6

---

Owner in month # 5

* Loan payment of $1,141 ($324 principal / $817 interest)
* New loan balance of $230,310
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 5

* Investment of $62,414 grew by $413 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 5

* Received rent of $1,584
* Loan payment of $1,141 ($324 principal / $817 interest)
* New loan balance of $230,310
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,418 leaving cash of ($158)
* Net taxable income of $166
* Allowed monthly depreciation of $703 + carry-over of $2,158
* Used depreciation of $166 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,695
* Required personal loan of $158 creating a balance of $792
* Monthly expenses $1,418 + principle of $324 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $7

---

Owner in month # 6

* Loan payment of $1,141 ($325 principal / $816 interest)
* New loan balance of $229,985
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 6

* Investment of $62,830 grew by $416 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 6

* Received rent of $1,584
* Loan payment of $1,141 ($325 principal / $816 interest)
* New loan balance of $229,985
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,417 leaving cash of ($158)
* Net taxable income of $167
* Allowed monthly depreciation of $703 + carry-over of $2,695
* Used depreciation of $167 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,231
* Required personal loan of $158 creating a balance of $950
* Monthly expenses $1,417 + principle of $325 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $8

---

Owner in month # 7

* Loan payment of $1,141 ($326 principal / $815 interest)
* New loan balance of $229,659
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 7

* Investment of $63,249 grew by $419 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 7

* Received rent of $1,584
* Loan payment of $1,141 ($326 principal / $815 interest)
* New loan balance of $229,659
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,416 leaving cash of ($158)
* Net taxable income of $168
* Allowed monthly depreciation of $703 + carry-over of $3,231
* Used depreciation of $168 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,766
* Required personal loan of $158 creating a balance of $1,109
* Monthly expenses $1,416 + principle of $326 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $9

---

Owner in month # 8

* Loan payment of $1,141 ($328 principal / $813 interest)
* New loan balance of $229,331
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 8

* Investment of $63,671 grew by $422 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 8

* Received rent of $1,584
* Loan payment of $1,141 ($328 principal / $813 interest)
* New loan balance of $229,331
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,414 leaving cash of ($158)
* Net taxable income of $170
* Allowed monthly depreciation of $703 + carry-over of $3,766
* Used depreciation of $170 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,299
* Required personal loan of $158 creating a balance of $1,267
* Monthly expenses $1,414 + principle of $328 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $11

---

Owner in month # 9

* Loan payment of $1,141 ($329 principal / $812 interest)
* New loan balance of $229,002
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 9

* Investment of $64,095 grew by $424 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 9

* Received rent of $1,584
* Loan payment of $1,141 ($329 principal / $812 interest)
* New loan balance of $229,002
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,413 leaving cash of ($158)
* Net taxable income of $171
* Allowed monthly depreciation of $703 + carry-over of $4,299
* Used depreciation of $171 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,831
* Required personal loan of $158 creating a balance of $1,426
* Monthly expenses $1,413 + principle of $329 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $12

---

Owner in month # 10

* Loan payment of $1,141 ($330 principal / $811 interest)
* New loan balance of $228,672
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 10

* Investment of $64,523 grew by $427 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 10

* Received rent of $1,584
* Loan payment of $1,141 ($330 principal / $811 interest)
* New loan balance of $228,672
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,412 leaving cash of ($158)
* Net taxable income of $172
* Allowed monthly depreciation of $703 + carry-over of $4,831
* Used depreciation of $172 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,362
* Required personal loan of $158 creating a balance of $1,584
* Monthly expenses $1,412 + principle of $330 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $13

---

Owner in month # 11

* Loan payment of $1,141 ($331 principal / $810 interest)
* New loan balance of $228,341
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 11

* Investment of $64,953 grew by $430 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 11

* Received rent of $1,584
* Loan payment of $1,141 ($331 principal / $810 interest)
* New loan balance of $228,341
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,411 leaving cash of ($158)
* Net taxable income of $173
* Allowed monthly depreciation of $703 + carry-over of $5,362
* Used depreciation of $173 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,892
* Required personal loan of $158 creating a balance of $1,742
* Monthly expenses $1,411 + principle of $331 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $14

---

Owner in month # 12

* Loan payment of $1,141 ($332 principal / $809 interest)
* New loan balance of $228,009
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total expense this month $1,584

---

Renter in month # 12

* Investment of $65,386 grew by $433 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 12

* Received rent of $1,584
* Loan payment of $1,141 ($332 principal / $809 interest)
* New loan balance of $228,009
* Management fee of $158
* Spent $101 on property tax
* Spent $100 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,410 leaving cash of ($158)
* Net taxable income of $174
* Allowed monthly depreciation of $703 + carry-over of $5,892
* Used depreciation of $174 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,421
* Required personal loan of $158 creating a balance of $1,901
* Monthly expenses $1,410 + principle of $332 = $1,742 against rent of $1,584
* Negative cash flow of ($158)
* NPV cash flow of $15

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
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 13

* Investment of $65,822 grew by $436 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 13

* Received rent of $1,584
* Loan payment of $1,141 ($333 principal / $808 interest)
* New loan balance of $227,676
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,424 leaving cash of ($173)
* Net taxable income of $160
* Allowed monthly depreciation of $703 + carry-over of $6,421
* Used depreciation of $160 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,964
* Required personal loan of $173 creating a balance of $2,074
* Monthly expenses $1,424 + principle of $333 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($14)

---

Owner in month # 14

* Loan payment of $1,141 ($335 principal / $806 interest)
* New loan balance of $227,341
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 14

* Investment of $66,261 grew by $439 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 14

* Received rent of $1,584
* Loan payment of $1,141 ($335 principal / $806 interest)
* New loan balance of $227,341
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,422 leaving cash of ($173)
* Net taxable income of $162
* Allowed monthly depreciation of $703 + carry-over of $6,964
* Used depreciation of $162 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,505
* Required personal loan of $173 creating a balance of $2,248
* Monthly expenses $1,422 + principle of $335 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($12)

---

Owner in month # 15

* Loan payment of $1,141 ($336 principal / $805 interest)
* New loan balance of $227,005
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 15

* Investment of $66,702 grew by $442 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 15

* Received rent of $1,584
* Loan payment of $1,141 ($336 principal / $805 interest)
* New loan balance of $227,005
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,421 leaving cash of ($173)
* Net taxable income of $163
* Allowed monthly depreciation of $703 + carry-over of $7,505
* Used depreciation of $163 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,045
* Required personal loan of $173 creating a balance of $2,421
* Monthly expenses $1,421 + principle of $336 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($11)

---

Owner in month # 16

* Loan payment of $1,141 ($337 principal / $804 interest)
* New loan balance of $226,668
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 16

* Investment of $67,147 grew by $445 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 16

* Received rent of $1,584
* Loan payment of $1,141 ($337 principal / $804 interest)
* New loan balance of $226,668
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,420 leaving cash of ($173)
* Net taxable income of $164
* Allowed monthly depreciation of $703 + carry-over of $8,045
* Used depreciation of $164 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,584
* Required personal loan of $173 creating a balance of $2,594
* Monthly expenses $1,420 + principle of $337 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($10)

---

Owner in month # 17

* Loan payment of $1,141 ($338 principal / $803 interest)
* New loan balance of $226,330
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 17

* Investment of $67,595 grew by $448 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 17

* Received rent of $1,584
* Loan payment of $1,141 ($338 principal / $803 interest)
* New loan balance of $226,330
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,419 leaving cash of ($173)
* Net taxable income of $165
* Allowed monthly depreciation of $703 + carry-over of $8,584
* Used depreciation of $165 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,122
* Required personal loan of $173 creating a balance of $2,768
* Monthly expenses $1,419 + principle of $338 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($9)

---

Owner in month # 18

* Loan payment of $1,141 ($339 principal / $802 interest)
* New loan balance of $225,991
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 18

* Investment of $68,045 grew by $451 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 18

* Received rent of $1,584
* Loan payment of $1,141 ($339 principal / $802 interest)
* New loan balance of $225,991
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,418 leaving cash of ($173)
* Net taxable income of $166
* Allowed monthly depreciation of $703 + carry-over of $9,122
* Used depreciation of $166 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,659
* Required personal loan of $173 creating a balance of $2,941
* Monthly expenses $1,418 + principle of $339 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($8)

---

Owner in month # 19

* Loan payment of $1,141 ($341 principal / $800 interest)
* New loan balance of $225,650
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 19

* Investment of $68,499 grew by $454 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 19

* Received rent of $1,584
* Loan payment of $1,141 ($341 principal / $800 interest)
* New loan balance of $225,650
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,416 leaving cash of ($173)
* Net taxable income of $168
* Allowed monthly depreciation of $703 + carry-over of $9,659
* Used depreciation of $168 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,194
* Required personal loan of $173 creating a balance of $3,115
* Monthly expenses $1,416 + principle of $341 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($6)

---

Owner in month # 20

* Loan payment of $1,141 ($342 principal / $799 interest)
* New loan balance of $225,308
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 20

* Investment of $68,956 grew by $457 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 20

* Received rent of $1,584
* Loan payment of $1,141 ($342 principal / $799 interest)
* New loan balance of $225,308
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,415 leaving cash of ($173)
* Net taxable income of $169
* Allowed monthly depreciation of $703 + carry-over of $10,194
* Used depreciation of $169 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,728
* Required personal loan of $173 creating a balance of $3,288
* Monthly expenses $1,415 + principle of $342 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($5)

---

Owner in month # 21

* Loan payment of $1,141 ($343 principal / $798 interest)
* New loan balance of $224,965
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 21

* Investment of $69,415 grew by $460 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 21

* Received rent of $1,584
* Loan payment of $1,141 ($343 principal / $798 interest)
* New loan balance of $224,965
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,414 leaving cash of ($173)
* Net taxable income of $170
* Allowed monthly depreciation of $703 + carry-over of $10,728
* Used depreciation of $170 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,261
* Required personal loan of $173 creating a balance of $3,461
* Monthly expenses $1,414 + principle of $343 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($4)

---

Owner in month # 22

* Loan payment of $1,141 ($344 principal / $797 interest)
* New loan balance of $224,621
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 22

* Investment of $69,878 grew by $463 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 22

* Received rent of $1,584
* Loan payment of $1,141 ($344 principal / $797 interest)
* New loan balance of $224,621
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,413 leaving cash of ($173)
* Net taxable income of $171
* Allowed monthly depreciation of $703 + carry-over of $11,261
* Used depreciation of $171 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,793
* Required personal loan of $173 creating a balance of $3,635
* Monthly expenses $1,413 + principle of $344 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($3)

---

Owner in month # 23

* Loan payment of $1,141 ($345 principal / $796 interest)
* New loan balance of $224,276
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 23

* Investment of $70,344 grew by $466 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 23

* Received rent of $1,584
* Loan payment of $1,141 ($345 principal / $796 interest)
* New loan balance of $224,276
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,412 leaving cash of ($173)
* Net taxable income of $172
* Allowed monthly depreciation of $703 + carry-over of $11,793
* Used depreciation of $172 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,324
* Required personal loan of $173 creating a balance of $3,808
* Monthly expenses $1,412 + principle of $345 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of ($2)

---

Owner in month # 24

* Loan payment of $1,141 ($347 principal / $794 interest)
* New loan balance of $223,929
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total expense this month $1,599

---

Renter in month # 24

* Investment of $70,813 grew by $469 (0.67%)
* Spent $1,584 on rent
* Spent $15 on renters insurance

---

Landlord in month # 24

* Received rent of $1,584
* Loan payment of $1,141 ($347 principal / $794 interest)
* New loan balance of $223,929
* Management fee of $158
* Spent $105 on property tax
* Spent $102 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,410 leaving cash of ($173)
* Net taxable income of $174
* Allowed monthly depreciation of $703 + carry-over of $12,324
* Used depreciation of $174 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,853
* Required personal loan of $173 creating a balance of $3,982
* Monthly expenses $1,410 + principle of $347 = $1,757 against rent of $1,584
* Negative cash flow of ($173)
* NPV cash flow of $0

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
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 25

* Investment of $71,285 grew by $472 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 25

* Received rent of $1,584
* Loan payment of $1,141 ($348 principal / $793 interest)
* New loan balance of $223,581
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,424 leaving cash of ($188)
* Net taxable income of $160
* Allowed monthly depreciation of $703 + carry-over of $12,853
* Used depreciation of $160 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,396
* Required personal loan of $188 creating a balance of $4,170
* Monthly expenses $1,424 + principle of $348 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($29)

---

Owner in month # 26

* Loan payment of $1,141 ($349 principal / $792 interest)
* New loan balance of $223,232
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 26

* Investment of $71,760 grew by $475 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 26

* Received rent of $1,584
* Loan payment of $1,141 ($349 principal / $792 interest)
* New loan balance of $223,232
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,423 leaving cash of ($188)
* Net taxable income of $161
* Allowed monthly depreciation of $703 + carry-over of $13,396
* Used depreciation of $161 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,938
* Required personal loan of $188 creating a balance of $4,358
* Monthly expenses $1,423 + principle of $349 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($28)

---

Owner in month # 27

* Loan payment of $1,141 ($350 principal / $791 interest)
* New loan balance of $222,882
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 27

* Investment of $72,239 grew by $478 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 27

* Received rent of $1,584
* Loan payment of $1,141 ($350 principal / $791 interest)
* New loan balance of $222,882
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,422 leaving cash of ($188)
* Net taxable income of $162
* Allowed monthly depreciation of $703 + carry-over of $13,938
* Used depreciation of $162 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,479
* Required personal loan of $188 creating a balance of $4,547
* Monthly expenses $1,422 + principle of $350 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($27)

---

Owner in month # 28

* Loan payment of $1,141 ($352 principal / $789 interest)
* New loan balance of $222,530
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 28

* Investment of $72,720 grew by $482 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 28

* Received rent of $1,584
* Loan payment of $1,141 ($352 principal / $789 interest)
* New loan balance of $222,530
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,420 leaving cash of ($188)
* Net taxable income of $164
* Allowed monthly depreciation of $703 + carry-over of $14,479
* Used depreciation of $164 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,018
* Required personal loan of $188 creating a balance of $4,735
* Monthly expenses $1,420 + principle of $352 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($25)

---

Owner in month # 29

* Loan payment of $1,141 ($353 principal / $788 interest)
* New loan balance of $222,177
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 29

* Investment of $73,205 grew by $485 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 29

* Received rent of $1,584
* Loan payment of $1,141 ($353 principal / $788 interest)
* New loan balance of $222,177
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,419 leaving cash of ($188)
* Net taxable income of $165
* Allowed monthly depreciation of $703 + carry-over of $15,018
* Used depreciation of $165 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,556
* Required personal loan of $188 creating a balance of $4,924
* Monthly expenses $1,419 + principle of $353 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($24)

---

Owner in month # 30

* Loan payment of $1,141 ($354 principal / $787 interest)
* New loan balance of $221,823
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 30

* Investment of $73,693 grew by $488 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 30

* Received rent of $1,584
* Loan payment of $1,141 ($354 principal / $787 interest)
* New loan balance of $221,823
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,418 leaving cash of ($188)
* Net taxable income of $166
* Allowed monthly depreciation of $703 + carry-over of $15,556
* Used depreciation of $166 resulting in adjusted taxable income of $0
* Carry over depreciation of $16,093
* Required personal loan of $188 creating a balance of $5,112
* Monthly expenses $1,418 + principle of $354 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($23)

---

Owner in month # 31

* Loan payment of $1,141 ($355 principal / $786 interest)
* New loan balance of $221,468
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 31

* Investment of $74,184 grew by $491 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 31

* Received rent of $1,584
* Loan payment of $1,141 ($355 principal / $786 interest)
* New loan balance of $221,468
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,417 leaving cash of ($188)
* Net taxable income of $167
* Allowed monthly depreciation of $703 + carry-over of $16,093
* Used depreciation of $167 resulting in adjusted taxable income of $0
* Carry over depreciation of $16,629
* Required personal loan of $188 creating a balance of $5,301
* Monthly expenses $1,417 + principle of $355 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($22)

---

Owner in month # 32

* Loan payment of $1,141 ($357 principal / $784 interest)
* New loan balance of $221,111
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 32

* Investment of $74,679 grew by $495 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 32

* Received rent of $1,584
* Loan payment of $1,141 ($357 principal / $784 interest)
* New loan balance of $221,111
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,415 leaving cash of ($188)
* Net taxable income of $169
* Allowed monthly depreciation of $703 + carry-over of $16,629
* Used depreciation of $169 resulting in adjusted taxable income of $0
* Carry over depreciation of $17,163
* Required personal loan of $188 creating a balance of $5,489
* Monthly expenses $1,415 + principle of $357 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($20)

---

Owner in month # 33

* Loan payment of $1,141 ($358 principal / $783 interest)
* New loan balance of $220,753
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 33

* Investment of $75,177 grew by $498 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 33

* Received rent of $1,584
* Loan payment of $1,141 ($358 principal / $783 interest)
* New loan balance of $220,753
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,414 leaving cash of ($188)
* Net taxable income of $170
* Allowed monthly depreciation of $703 + carry-over of $17,163
* Used depreciation of $170 resulting in adjusted taxable income of $0
* Carry over depreciation of $17,696
* Required personal loan of $188 creating a balance of $5,678
* Monthly expenses $1,414 + principle of $358 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($19)

---

Owner in month # 34

* Loan payment of $1,141 ($359 principal / $782 interest)
* New loan balance of $220,394
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 34

* Investment of $75,678 grew by $501 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 34

* Received rent of $1,584
* Loan payment of $1,141 ($359 principal / $782 interest)
* New loan balance of $220,394
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,413 leaving cash of ($188)
* Net taxable income of $171
* Allowed monthly depreciation of $703 + carry-over of $17,696
* Used depreciation of $171 resulting in adjusted taxable income of $0
* Carry over depreciation of $18,228
* Required personal loan of $188 creating a balance of $5,866
* Monthly expenses $1,413 + principle of $359 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($18)

---

Owner in month # 35

* Loan payment of $1,141 ($360 principal / $781 interest)
* New loan balance of $220,034
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 35

* Investment of $76,182 grew by $505 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 35

* Received rent of $1,584
* Loan payment of $1,141 ($360 principal / $781 interest)
* New loan balance of $220,034
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,412 leaving cash of ($188)
* Net taxable income of $172
* Allowed monthly depreciation of $703 + carry-over of $18,228
* Used depreciation of $172 resulting in adjusted taxable income of $0
* Carry over depreciation of $18,759
* Required personal loan of $188 creating a balance of $6,054
* Monthly expenses $1,412 + principle of $360 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($17)

---

Owner in month # 36

* Loan payment of $1,141 ($362 principal / $779 interest)
* New loan balance of $219,672
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total expense this month $1,614

---

Renter in month # 36

* Investment of $76,690 grew by $508 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 36

* Received rent of $1,584
* Loan payment of $1,141 ($362 principal / $779 interest)
* New loan balance of $219,672
* Management fee of $158
* Spent $109 on property tax
* Spent $104 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $1,410 leaving cash of ($188)
* Net taxable income of $174
* Allowed monthly depreciation of $703 + carry-over of $18,759
* Used depreciation of $174 resulting in adjusted taxable income of $0
* Carry over depreciation of $19,288
* Required personal loan of $188 creating a balance of $6,243
* Monthly expenses $1,410 + principle of $362 = $1,772 against rent of $1,584
* Negative cash flow of ($188)
* NPV cash flow of ($15)

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
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 37

* Investment of $77,202 grew by $511 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 37

* Received rent of $1,584
* Loan payment of $1,141 ($363 principal / $778 interest)
* New loan balance of $219,309
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,425 leaving cash of ($204)
* Net taxable income of $159
* Allowed monthly depreciation of $703 + carry-over of $19,288
* Used depreciation of $159 resulting in adjusted taxable income of $0
* Carry over depreciation of $19,832
* Required personal loan of $204 creating a balance of $6,446
* Monthly expenses $1,425 + principle of $363 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($44)

---

Owner in month # 38

* Loan payment of $1,141 ($364 principal / $777 interest)
* New loan balance of $218,945
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 38

* Investment of $77,716 grew by $515 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 38

* Received rent of $1,584
* Loan payment of $1,141 ($364 principal / $777 interest)
* New loan balance of $218,945
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,424 leaving cash of ($204)
* Net taxable income of $160
* Allowed monthly depreciation of $703 + carry-over of $19,832
* Used depreciation of $160 resulting in adjusted taxable income of $0
* Carry over depreciation of $20,375
* Required personal loan of $204 creating a balance of $6,650
* Monthly expenses $1,424 + principle of $364 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($43)

---

Owner in month # 39

* Loan payment of $1,141 ($366 principal / $775 interest)
* New loan balance of $218,579
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 39

* Investment of $78,234 grew by $518 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 39

* Received rent of $1,584
* Loan payment of $1,141 ($366 principal / $775 interest)
* New loan balance of $218,579
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,422 leaving cash of ($204)
* Net taxable income of $162
* Allowed monthly depreciation of $703 + carry-over of $20,375
* Used depreciation of $162 resulting in adjusted taxable income of $0
* Carry over depreciation of $20,916
* Required personal loan of $204 creating a balance of $6,853
* Monthly expenses $1,422 + principle of $366 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($41)

---

Owner in month # 40

* Loan payment of $1,141 ($367 principal / $774 interest)
* New loan balance of $218,212
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 40

* Investment of $78,756 grew by $522 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 40

* Received rent of $1,584
* Loan payment of $1,141 ($367 principal / $774 interest)
* New loan balance of $218,212
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,421 leaving cash of ($204)
* Net taxable income of $163
* Allowed monthly depreciation of $703 + carry-over of $20,916
* Used depreciation of $163 resulting in adjusted taxable income of $0
* Carry over depreciation of $21,456
* Required personal loan of $204 creating a balance of $7,057
* Monthly expenses $1,421 + principle of $367 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($40)

---

Owner in month # 41

* Loan payment of $1,141 ($368 principal / $773 interest)
* New loan balance of $217,844
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 41

* Investment of $79,281 grew by $525 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 41

* Received rent of $1,584
* Loan payment of $1,141 ($368 principal / $773 interest)
* New loan balance of $217,844
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,420 leaving cash of ($204)
* Net taxable income of $164
* Allowed monthly depreciation of $703 + carry-over of $21,456
* Used depreciation of $164 resulting in adjusted taxable income of $0
* Carry over depreciation of $21,995
* Required personal loan of $204 creating a balance of $7,260
* Monthly expenses $1,420 + principle of $368 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($39)

---

Owner in month # 42

* Loan payment of $1,141 ($369 principal / $772 interest)
* New loan balance of $217,475
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 42

* Investment of $79,810 grew by $529 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 42

* Received rent of $1,584
* Loan payment of $1,141 ($369 principal / $772 interest)
* New loan balance of $217,475
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,419 leaving cash of ($204)
* Net taxable income of $165
* Allowed monthly depreciation of $703 + carry-over of $21,995
* Used depreciation of $165 resulting in adjusted taxable income of $0
* Carry over depreciation of $22,533
* Required personal loan of $204 creating a balance of $7,464
* Monthly expenses $1,419 + principle of $369 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($38)

---

Owner in month # 43

* Loan payment of $1,141 ($371 principal / $770 interest)
* New loan balance of $217,104
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 43

* Investment of $80,342 grew by $532 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 43

* Received rent of $1,584
* Loan payment of $1,141 ($371 principal / $770 interest)
* New loan balance of $217,104
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,417 leaving cash of ($204)
* Net taxable income of $167
* Allowed monthly depreciation of $703 + carry-over of $22,533
* Used depreciation of $167 resulting in adjusted taxable income of $0
* Carry over depreciation of $23,069
* Required personal loan of $204 creating a balance of $7,668
* Monthly expenses $1,417 + principle of $371 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($36)

---

Owner in month # 44

* Loan payment of $1,141 ($372 principal / $769 interest)
* New loan balance of $216,732
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 44

* Investment of $80,877 grew by $536 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 44

* Received rent of $1,584
* Loan payment of $1,141 ($372 principal / $769 interest)
* New loan balance of $216,732
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,416 leaving cash of ($204)
* Net taxable income of $168
* Allowed monthly depreciation of $703 + carry-over of $23,069
* Used depreciation of $168 resulting in adjusted taxable income of $0
* Carry over depreciation of $23,604
* Required personal loan of $204 creating a balance of $7,871
* Monthly expenses $1,416 + principle of $372 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($35)

---

Owner in month # 45

* Loan payment of $1,141 ($373 principal / $768 interest)
* New loan balance of $216,359
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 45

* Investment of $81,416 grew by $539 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 45

* Received rent of $1,584
* Loan payment of $1,141 ($373 principal / $768 interest)
* New loan balance of $216,359
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,415 leaving cash of ($204)
* Net taxable income of $169
* Allowed monthly depreciation of $703 + carry-over of $23,604
* Used depreciation of $169 resulting in adjusted taxable income of $0
* Carry over depreciation of $24,138
* Required personal loan of $204 creating a balance of $8,075
* Monthly expenses $1,415 + principle of $373 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($34)

---

Owner in month # 46

* Loan payment of $1,141 ($375 principal / $766 interest)
* New loan balance of $215,984
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 46

* Investment of $81,959 grew by $543 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 46

* Received rent of $1,584
* Loan payment of $1,141 ($375 principal / $766 interest)
* New loan balance of $215,984
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,413 leaving cash of ($204)
* Net taxable income of $171
* Allowed monthly depreciation of $703 + carry-over of $24,138
* Used depreciation of $171 resulting in adjusted taxable income of $0
* Carry over depreciation of $24,670
* Required personal loan of $204 creating a balance of $8,278
* Monthly expenses $1,413 + principle of $375 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($32)

---

Owner in month # 47

* Loan payment of $1,141 ($376 principal / $765 interest)
* New loan balance of $215,608
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 47

* Investment of $82,506 grew by $546 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 47

* Received rent of $1,584
* Loan payment of $1,141 ($376 principal / $765 interest)
* New loan balance of $215,608
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,412 leaving cash of ($204)
* Net taxable income of $172
* Allowed monthly depreciation of $703 + carry-over of $24,670
* Used depreciation of $172 resulting in adjusted taxable income of $0
* Carry over depreciation of $25,201
* Required personal loan of $204 creating a balance of $8,482
* Monthly expenses $1,412 + principle of $376 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($31)

---

Owner in month # 48

* Loan payment of $1,141 ($377 principal / $764 interest)
* New loan balance of $215,231
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total expense this month $1,629

---

Renter in month # 48

* Investment of $83,056 grew by $550 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 48

* Received rent of $1,584
* Loan payment of $1,141 ($377 principal / $764 interest)
* New loan balance of $215,231
* Management fee of $158
* Spent $113 on property tax
* Spent $106 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $1,411 leaving cash of ($204)
* Net taxable income of $173
* Allowed monthly depreciation of $703 + carry-over of $25,201
* Used depreciation of $173 resulting in adjusted taxable income of $0
* Carry over depreciation of $25,731
* Required personal loan of $204 creating a balance of $8,685
* Monthly expenses $1,411 + principle of $377 = $1,788 against rent of $1,584
* Negative cash flow of ($204)
* NPV cash flow of ($30)

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
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 49

* Investment of $83,609 grew by $554 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 49

* Received rent of $1,584
* Loan payment of $1,141 ($379 principal / $762 interest)
* New loan balance of $214,852
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,425 leaving cash of ($220)
* Net taxable income of $159
* Allowed monthly depreciation of $703 + carry-over of $25,731
* Used depreciation of $159 resulting in adjusted taxable income of $0
* Carry over depreciation of $26,275
* Required personal loan of $220 creating a balance of $8,905
* Monthly expenses $1,425 + principle of $379 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($60)

---

Owner in month # 50

* Loan payment of $1,141 ($380 principal / $761 interest)
* New loan balance of $214,472
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 50

* Investment of $84,167 grew by $557 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 50

* Received rent of $1,584
* Loan payment of $1,141 ($380 principal / $761 interest)
* New loan balance of $214,472
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,424 leaving cash of ($220)
* Net taxable income of $160
* Allowed monthly depreciation of $703 + carry-over of $26,275
* Used depreciation of $160 resulting in adjusted taxable income of $0
* Carry over depreciation of $26,818
* Required personal loan of $220 creating a balance of $9,124
* Monthly expenses $1,424 + principle of $380 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($59)

---

Owner in month # 51

* Loan payment of $1,141 ($381 principal / $760 interest)
* New loan balance of $214,091
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 51

* Investment of $84,728 grew by $561 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 51

* Received rent of $1,584
* Loan payment of $1,141 ($381 principal / $760 interest)
* New loan balance of $214,091
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,423 leaving cash of ($220)
* Net taxable income of $161
* Allowed monthly depreciation of $703 + carry-over of $26,818
* Used depreciation of $161 resulting in adjusted taxable income of $0
* Carry over depreciation of $27,360
* Required personal loan of $220 creating a balance of $9,344
* Monthly expenses $1,423 + principle of $381 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($58)

---

Owner in month # 52

* Loan payment of $1,141 ($383 principal / $758 interest)
* New loan balance of $213,708
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 52

* Investment of $85,293 grew by $565 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 52

* Received rent of $1,584
* Loan payment of $1,141 ($383 principal / $758 interest)
* New loan balance of $213,708
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,421 leaving cash of ($220)
* Net taxable income of $163
* Allowed monthly depreciation of $703 + carry-over of $27,360
* Used depreciation of $163 resulting in adjusted taxable income of $0
* Carry over depreciation of $27,900
* Required personal loan of $220 creating a balance of $9,564
* Monthly expenses $1,421 + principle of $383 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($56)

---

Owner in month # 53

* Loan payment of $1,141 ($384 principal / $757 interest)
* New loan balance of $213,324
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 53

* Investment of $85,861 grew by $569 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 53

* Received rent of $1,584
* Loan payment of $1,141 ($384 principal / $757 interest)
* New loan balance of $213,324
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,420 leaving cash of ($220)
* Net taxable income of $164
* Allowed monthly depreciation of $703 + carry-over of $27,900
* Used depreciation of $164 resulting in adjusted taxable income of $0
* Carry over depreciation of $28,439
* Required personal loan of $220 creating a balance of $9,783
* Monthly expenses $1,420 + principle of $384 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($55)

---

Owner in month # 54

* Loan payment of $1,141 ($385 principal / $756 interest)
* New loan balance of $212,939
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 54

* Investment of $86,434 grew by $572 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 54

* Received rent of $1,584
* Loan payment of $1,141 ($385 principal / $756 interest)
* New loan balance of $212,939
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,419 leaving cash of ($220)
* Net taxable income of $165
* Allowed monthly depreciation of $703 + carry-over of $28,439
* Used depreciation of $165 resulting in adjusted taxable income of $0
* Carry over depreciation of $28,977
* Required personal loan of $220 creating a balance of $10,003
* Monthly expenses $1,419 + principle of $385 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($54)

---

Owner in month # 55

* Loan payment of $1,141 ($387 principal / $754 interest)
* New loan balance of $212,552
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 55

* Investment of $87,010 grew by $576 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 55

* Received rent of $1,584
* Loan payment of $1,141 ($387 principal / $754 interest)
* New loan balance of $212,552
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,417 leaving cash of ($220)
* Net taxable income of $167
* Allowed monthly depreciation of $703 + carry-over of $28,977
* Used depreciation of $167 resulting in adjusted taxable income of $0
* Carry over depreciation of $29,513
* Required personal loan of $220 creating a balance of $10,223
* Monthly expenses $1,417 + principle of $387 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($52)

---

Owner in month # 56

* Loan payment of $1,141 ($388 principal / $753 interest)
* New loan balance of $212,164
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 56

* Investment of $87,590 grew by $580 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 56

* Received rent of $1,584
* Loan payment of $1,141 ($388 principal / $753 interest)
* New loan balance of $212,164
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,416 leaving cash of ($220)
* Net taxable income of $168
* Allowed monthly depreciation of $703 + carry-over of $29,513
* Used depreciation of $168 resulting in adjusted taxable income of $0
* Carry over depreciation of $30,048
* Required personal loan of $220 creating a balance of $10,442
* Monthly expenses $1,416 + principle of $388 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($51)

---

Owner in month # 57

* Loan payment of $1,141 ($390 principal / $751 interest)
* New loan balance of $211,774
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 57

* Investment of $88,174 grew by $584 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 57

* Received rent of $1,584
* Loan payment of $1,141 ($390 principal / $751 interest)
* New loan balance of $211,774
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,414 leaving cash of ($220)
* Net taxable income of $170
* Allowed monthly depreciation of $703 + carry-over of $30,048
* Used depreciation of $170 resulting in adjusted taxable income of $0
* Carry over depreciation of $30,581
* Required personal loan of $220 creating a balance of $10,662
* Monthly expenses $1,414 + principle of $390 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($49)

---

Owner in month # 58

* Loan payment of $1,141 ($391 principal / $750 interest)
* New loan balance of $211,383
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 58

* Investment of $88,762 grew by $588 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 58

* Received rent of $1,584
* Loan payment of $1,141 ($391 principal / $750 interest)
* New loan balance of $211,383
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,413 leaving cash of ($220)
* Net taxable income of $171
* Allowed monthly depreciation of $703 + carry-over of $30,581
* Used depreciation of $171 resulting in adjusted taxable income of $0
* Carry over depreciation of $31,113
* Required personal loan of $220 creating a balance of $10,882
* Monthly expenses $1,413 + principle of $391 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($48)

---

Owner in month # 59

* Loan payment of $1,141 ($392 principal / $749 interest)
* New loan balance of $210,991
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 59

* Investment of $89,353 grew by $592 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 59

* Received rent of $1,584
* Loan payment of $1,141 ($392 principal / $749 interest)
* New loan balance of $210,991
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,412 leaving cash of ($220)
* Net taxable income of $172
* Allowed monthly depreciation of $703 + carry-over of $31,113
* Used depreciation of $172 resulting in adjusted taxable income of $0
* Carry over depreciation of $31,644
* Required personal loan of $220 creating a balance of $11,101
* Monthly expenses $1,412 + principle of $392 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($47)

---

Owner in month # 60

* Loan payment of $1,141 ($394 principal / $747 interest)
* New loan balance of $210,597
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total expense this month $1,645

---

Renter in month # 60

* Investment of $89,949 grew by $596 (0.67%)
* Spent $1,584 on rent
* Spent $16 on renters insurance

---

Landlord in month # 60

* Received rent of $1,584
* Loan payment of $1,141 ($394 principal / $747 interest)
* New loan balance of $210,597
* Management fee of $158
* Spent $117 on property tax
* Spent $108 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $1,410 leaving cash of ($220)
* Net taxable income of $174
* Allowed monthly depreciation of $703 + carry-over of $31,644
* Used depreciation of $174 resulting in adjusted taxable income of $0
* Carry over depreciation of $32,173
* Required personal loan of $220 creating a balance of $11,321
* Monthly expenses $1,410 + principle of $394 = $1,804 against rent of $1,584
* Negative cash flow of ($220)
* NPV cash flow of ($45)

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
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 61

* Investment of $90,549 grew by $600 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 61

* Received rent of $1,584
* Loan payment of $1,141 ($395 principal / $746 interest)
* New loan balance of $210,202
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,427 leaving cash of ($238)
* Net taxable income of $157
* Allowed monthly depreciation of $703 + carry-over of $32,173
* Used depreciation of $157 resulting in adjusted taxable income of $0
* Carry over depreciation of $32,719
* Required personal loan of $238 creating a balance of $11,559
* Monthly expenses $1,427 + principle of $395 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($81)

---

Owner in month # 62

* Loan payment of $1,141 ($397 principal / $744 interest)
* New loan balance of $209,805
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 62

* Investment of $91,152 grew by $604 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 62

* Received rent of $1,584
* Loan payment of $1,141 ($397 principal / $744 interest)
* New loan balance of $209,805
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,425 leaving cash of ($238)
* Net taxable income of $159
* Allowed monthly depreciation of $703 + carry-over of $32,719
* Used depreciation of $159 resulting in adjusted taxable income of $0
* Carry over depreciation of $33,263
* Required personal loan of $238 creating a balance of $11,796
* Monthly expenses $1,425 + principle of $397 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($79)

---

Owner in month # 63

* Loan payment of $1,141 ($398 principal / $743 interest)
* New loan balance of $209,407
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 63

* Investment of $91,760 grew by $608 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 63

* Received rent of $1,584
* Loan payment of $1,141 ($398 principal / $743 interest)
* New loan balance of $209,407
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,424 leaving cash of ($238)
* Net taxable income of $160
* Allowed monthly depreciation of $703 + carry-over of $33,263
* Used depreciation of $160 resulting in adjusted taxable income of $0
* Carry over depreciation of $33,806
* Required personal loan of $238 creating a balance of $12,034
* Monthly expenses $1,424 + principle of $398 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($78)

---

Owner in month # 64

* Loan payment of $1,141 ($399 principal / $742 interest)
* New loan balance of $209,008
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 64

* Investment of $92,372 grew by $612 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 64

* Received rent of $1,584
* Loan payment of $1,141 ($399 principal / $742 interest)
* New loan balance of $209,008
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,423 leaving cash of ($238)
* Net taxable income of $161
* Allowed monthly depreciation of $703 + carry-over of $33,806
* Used depreciation of $161 resulting in adjusted taxable income of $0
* Carry over depreciation of $34,348
* Required personal loan of $238 creating a balance of $12,272
* Monthly expenses $1,423 + principle of $399 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($77)

---

Owner in month # 65

* Loan payment of $1,141 ($401 principal / $740 interest)
* New loan balance of $208,607
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 65

* Investment of $92,988 grew by $616 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 65

* Received rent of $1,584
* Loan payment of $1,141 ($401 principal / $740 interest)
* New loan balance of $208,607
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,421 leaving cash of ($238)
* Net taxable income of $163
* Allowed monthly depreciation of $703 + carry-over of $34,348
* Used depreciation of $163 resulting in adjusted taxable income of $0
* Carry over depreciation of $34,888
* Required personal loan of $238 creating a balance of $12,510
* Monthly expenses $1,421 + principle of $401 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($75)

---

Owner in month # 66

* Loan payment of $1,141 ($402 principal / $739 interest)
* New loan balance of $208,205
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 66

* Investment of $93,608 grew by $620 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 66

* Received rent of $1,584
* Loan payment of $1,141 ($402 principal / $739 interest)
* New loan balance of $208,205
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,420 leaving cash of ($238)
* Net taxable income of $164
* Allowed monthly depreciation of $703 + carry-over of $34,888
* Used depreciation of $164 resulting in adjusted taxable income of $0
* Carry over depreciation of $35,427
* Required personal loan of $238 creating a balance of $12,748
* Monthly expenses $1,420 + principle of $402 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($74)

---

Owner in month # 67

* Loan payment of $1,141 ($404 principal / $737 interest)
* New loan balance of $207,801
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 67

* Investment of $94,232 grew by $624 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 67

* Received rent of $1,584
* Loan payment of $1,141 ($404 principal / $737 interest)
* New loan balance of $207,801
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,418 leaving cash of ($238)
* Net taxable income of $166
* Allowed monthly depreciation of $703 + carry-over of $35,427
* Used depreciation of $166 resulting in adjusted taxable income of $0
* Carry over depreciation of $35,964
* Required personal loan of $238 creating a balance of $12,985
* Monthly expenses $1,418 + principle of $404 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($72)

---

Owner in month # 68

* Loan payment of $1,141 ($405 principal / $736 interest)
* New loan balance of $207,396
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 68

* Investment of $94,860 grew by $628 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 68

* Received rent of $1,584
* Loan payment of $1,141 ($405 principal / $736 interest)
* New loan balance of $207,396
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,417 leaving cash of ($238)
* Net taxable income of $167
* Allowed monthly depreciation of $703 + carry-over of $35,964
* Used depreciation of $167 resulting in adjusted taxable income of $0
* Carry over depreciation of $36,500
* Required personal loan of $238 creating a balance of $13,223
* Monthly expenses $1,417 + principle of $405 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($71)

---

Owner in month # 69

* Loan payment of $1,141 ($406 principal / $735 interest)
* New loan balance of $206,990
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 69

* Investment of $95,492 grew by $632 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 69

* Received rent of $1,584
* Loan payment of $1,141 ($406 principal / $735 interest)
* New loan balance of $206,990
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,416 leaving cash of ($238)
* Net taxable income of $168
* Allowed monthly depreciation of $703 + carry-over of $36,500
* Used depreciation of $168 resulting in adjusted taxable income of $0
* Carry over depreciation of $37,035
* Required personal loan of $238 creating a balance of $13,461
* Monthly expenses $1,416 + principle of $406 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($70)

---

Owner in month # 70

* Loan payment of $1,141 ($408 principal / $733 interest)
* New loan balance of $206,582
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 70

* Investment of $96,129 grew by $637 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 70

* Received rent of $1,584
* Loan payment of $1,141 ($408 principal / $733 interest)
* New loan balance of $206,582
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,414 leaving cash of ($238)
* Net taxable income of $170
* Allowed monthly depreciation of $703 + carry-over of $37,035
* Used depreciation of $170 resulting in adjusted taxable income of $0
* Carry over depreciation of $37,568
* Required personal loan of $238 creating a balance of $13,699
* Monthly expenses $1,414 + principle of $408 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($68)

---

Owner in month # 71

* Loan payment of $1,141 ($409 principal / $732 interest)
* New loan balance of $206,173
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 71

* Investment of $96,770 grew by $641 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 71

* Received rent of $1,584
* Loan payment of $1,141 ($409 principal / $732 interest)
* New loan balance of $206,173
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,413 leaving cash of ($238)
* Net taxable income of $171
* Allowed monthly depreciation of $703 + carry-over of $37,568
* Used depreciation of $171 resulting in adjusted taxable income of $0
* Carry over depreciation of $38,100
* Required personal loan of $238 creating a balance of $13,937
* Monthly expenses $1,413 + principle of $409 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($67)

---

Owner in month # 72

* Loan payment of $1,141 ($411 principal / $730 interest)
* New loan balance of $205,762
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total expense this month $1,663

---

Renter in month # 72

* Investment of $97,415 grew by $645 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 72

* Received rent of $1,584
* Loan payment of $1,141 ($411 principal / $730 interest)
* New loan balance of $205,762
* Management fee of $158
* Spent $122 on property tax
* Spent $110 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $1,411 leaving cash of ($238)
* Net taxable income of $173
* Allowed monthly depreciation of $703 + carry-over of $38,100
* Used depreciation of $173 resulting in adjusted taxable income of $0
* Carry over depreciation of $38,630
* Required personal loan of $238 creating a balance of $14,174
* Monthly expenses $1,411 + principle of $411 = $1,822 against rent of $1,584
* Negative cash flow of ($238)
* NPV cash flow of ($65)

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
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 73

* Investment of $98,064 grew by $649 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 73

* Received rent of $1,584
* Loan payment of $1,141 ($412 principal / $729 interest)
* New loan balance of $205,350
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,426 leaving cash of ($254)
* Net taxable income of $158
* Allowed monthly depreciation of $703 + carry-over of $38,630
* Used depreciation of $158 resulting in adjusted taxable income of $0
* Carry over depreciation of $39,175
* Required personal loan of $254 creating a balance of $14,428
* Monthly expenses $1,426 + principle of $412 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($96)

---

Owner in month # 74

* Loan payment of $1,141 ($414 principal / $727 interest)
* New loan balance of $204,936
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 74

* Investment of $98,718 grew by $654 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 74

* Received rent of $1,584
* Loan payment of $1,141 ($414 principal / $727 interest)
* New loan balance of $204,936
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,424 leaving cash of ($254)
* Net taxable income of $160
* Allowed monthly depreciation of $703 + carry-over of $39,175
* Used depreciation of $160 resulting in adjusted taxable income of $0
* Carry over depreciation of $39,718
* Required personal loan of $254 creating a balance of $14,682
* Monthly expenses $1,424 + principle of $414 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($94)

---

Owner in month # 75

* Loan payment of $1,141 ($415 principal / $726 interest)
* New loan balance of $204,521
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 75

* Investment of $99,376 grew by $658 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 75

* Received rent of $1,584
* Loan payment of $1,141 ($415 principal / $726 interest)
* New loan balance of $204,521
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,423 leaving cash of ($254)
* Net taxable income of $161
* Allowed monthly depreciation of $703 + carry-over of $39,718
* Used depreciation of $161 resulting in adjusted taxable income of $0
* Carry over depreciation of $40,260
* Required personal loan of $254 creating a balance of $14,936
* Monthly expenses $1,423 + principle of $415 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($93)

---

Owner in month # 76

* Loan payment of $1,141 ($417 principal / $724 interest)
* New loan balance of $204,104
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 76

* Investment of $100,039 grew by $663 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 76

* Received rent of $1,584
* Loan payment of $1,141 ($417 principal / $724 interest)
* New loan balance of $204,104
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,421 leaving cash of ($254)
* Net taxable income of $163
* Allowed monthly depreciation of $703 + carry-over of $40,260
* Used depreciation of $163 resulting in adjusted taxable income of $0
* Carry over depreciation of $40,800
* Required personal loan of $254 creating a balance of $15,190
* Monthly expenses $1,421 + principle of $417 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($91)

---

Owner in month # 77

* Loan payment of $1,141 ($418 principal / $723 interest)
* New loan balance of $203,686
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 77

* Investment of $100,706 grew by $667 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 77

* Received rent of $1,584
* Loan payment of $1,141 ($418 principal / $723 interest)
* New loan balance of $203,686
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,420 leaving cash of ($254)
* Net taxable income of $164
* Allowed monthly depreciation of $703 + carry-over of $40,800
* Used depreciation of $164 resulting in adjusted taxable income of $0
* Carry over depreciation of $41,339
* Required personal loan of $254 creating a balance of $15,444
* Monthly expenses $1,420 + principle of $418 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($90)

---

Owner in month # 78

* Loan payment of $1,141 ($420 principal / $721 interest)
* New loan balance of $203,266
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 78

* Investment of $101,377 grew by $671 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 78

* Received rent of $1,584
* Loan payment of $1,141 ($420 principal / $721 interest)
* New loan balance of $203,266
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,418 leaving cash of ($254)
* Net taxable income of $166
* Allowed monthly depreciation of $703 + carry-over of $41,339
* Used depreciation of $166 resulting in adjusted taxable income of $0
* Carry over depreciation of $41,876
* Required personal loan of $254 creating a balance of $15,698
* Monthly expenses $1,418 + principle of $420 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($88)

---

Owner in month # 79

* Loan payment of $1,141 ($421 principal / $720 interest)
* New loan balance of $202,845
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 79

* Investment of $102,053 grew by $676 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 79

* Received rent of $1,584
* Loan payment of $1,141 ($421 principal / $720 interest)
* New loan balance of $202,845
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,417 leaving cash of ($254)
* Net taxable income of $167
* Allowed monthly depreciation of $703 + carry-over of $41,876
* Used depreciation of $167 resulting in adjusted taxable income of $0
* Carry over depreciation of $42,412
* Required personal loan of $254 creating a balance of $15,952
* Monthly expenses $1,417 + principle of $421 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($87)

---

Owner in month # 80

* Loan payment of $1,141 ($423 principal / $718 interest)
* New loan balance of $202,422
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 80

* Investment of $102,733 grew by $680 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 80

* Received rent of $1,584
* Loan payment of $1,141 ($423 principal / $718 interest)
* New loan balance of $202,422
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,415 leaving cash of ($254)
* Net taxable income of $169
* Allowed monthly depreciation of $703 + carry-over of $42,412
* Used depreciation of $169 resulting in adjusted taxable income of $0
* Carry over depreciation of $42,946
* Required personal loan of $254 creating a balance of $16,206
* Monthly expenses $1,415 + principle of $423 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($85)

---

Owner in month # 81

* Loan payment of $1,141 ($424 principal / $717 interest)
* New loan balance of $201,998
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 81

* Investment of $103,418 grew by $685 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 81

* Received rent of $1,584
* Loan payment of $1,141 ($424 principal / $717 interest)
* New loan balance of $201,998
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,414 leaving cash of ($254)
* Net taxable income of $170
* Allowed monthly depreciation of $703 + carry-over of $42,946
* Used depreciation of $170 resulting in adjusted taxable income of $0
* Carry over depreciation of $43,479
* Required personal loan of $254 creating a balance of $16,460
* Monthly expenses $1,414 + principle of $424 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($84)

---

Owner in month # 82

* Loan payment of $1,141 ($426 principal / $715 interest)
* New loan balance of $201,572
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 82

* Investment of $104,108 grew by $689 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 82

* Received rent of $1,584
* Loan payment of $1,141 ($426 principal / $715 interest)
* New loan balance of $201,572
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,412 leaving cash of ($254)
* Net taxable income of $172
* Allowed monthly depreciation of $703 + carry-over of $43,479
* Used depreciation of $172 resulting in adjusted taxable income of $0
* Carry over depreciation of $44,010
* Required personal loan of $254 creating a balance of $16,715
* Monthly expenses $1,412 + principle of $426 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($82)

---

Owner in month # 83

* Loan payment of $1,141 ($427 principal / $714 interest)
* New loan balance of $201,145
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 83

* Investment of $104,802 grew by $694 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 83

* Received rent of $1,584
* Loan payment of $1,141 ($427 principal / $714 interest)
* New loan balance of $201,145
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,411 leaving cash of ($254)
* Net taxable income of $173
* Allowed monthly depreciation of $703 + carry-over of $44,010
* Used depreciation of $173 resulting in adjusted taxable income of $0
* Carry over depreciation of $44,540
* Required personal loan of $254 creating a balance of $16,969
* Monthly expenses $1,411 + principle of $427 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($81)

---

Owner in month # 84

* Loan payment of $1,141 ($429 principal / $712 interest)
* New loan balance of $200,716
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total expense this month $1,680

---

Renter in month # 84

* Investment of $105,500 grew by $699 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 84

* Received rent of $1,584
* Loan payment of $1,141 ($429 principal / $712 interest)
* New loan balance of $200,716
* Management fee of $158
* Spent $126 on property tax
* Spent $113 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $1,409 leaving cash of ($254)
* Net taxable income of $175
* Allowed monthly depreciation of $703 + carry-over of $44,540
* Used depreciation of $175 resulting in adjusted taxable income of $0
* Carry over depreciation of $45,068
* Required personal loan of $254 creating a balance of $17,223
* Monthly expenses $1,409 + principle of $429 = $1,838 against rent of $1,584
* Negative cash flow of ($254)
* NPV cash flow of ($79)

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
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 85

* Investment of $106,204 grew by $703 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 85

* Received rent of $1,584
* Loan payment of $1,141 ($430 principal / $711 interest)
* New loan balance of $200,286
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,427 leaving cash of ($273)
* Net taxable income of $157
* Allowed monthly depreciation of $703 + carry-over of $45,068
* Used depreciation of $157 resulting in adjusted taxable income of $0
* Carry over depreciation of $45,614
* Required personal loan of $273 creating a balance of $17,496
* Monthly expenses $1,427 + principle of $430 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($117)

---

Owner in month # 86

* Loan payment of $1,141 ($432 principal / $709 interest)
* New loan balance of $199,854
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 86

* Investment of $106,912 grew by $708 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 86

* Received rent of $1,584
* Loan payment of $1,141 ($432 principal / $709 interest)
* New loan balance of $199,854
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,425 leaving cash of ($273)
* Net taxable income of $159
* Allowed monthly depreciation of $703 + carry-over of $45,614
* Used depreciation of $159 resulting in adjusted taxable income of $0
* Carry over depreciation of $46,158
* Required personal loan of $273 creating a balance of $17,769
* Monthly expenses $1,425 + principle of $432 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($115)

---

Owner in month # 87

* Loan payment of $1,141 ($433 principal / $708 interest)
* New loan balance of $199,421
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 87

* Investment of $107,624 grew by $713 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 87

* Received rent of $1,584
* Loan payment of $1,141 ($433 principal / $708 interest)
* New loan balance of $199,421
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,424 leaving cash of ($273)
* Net taxable income of $160
* Allowed monthly depreciation of $703 + carry-over of $46,158
* Used depreciation of $160 resulting in adjusted taxable income of $0
* Carry over depreciation of $46,701
* Required personal loan of $273 creating a balance of $18,042
* Monthly expenses $1,424 + principle of $433 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($114)

---

Owner in month # 88

* Loan payment of $1,141 ($435 principal / $706 interest)
* New loan balance of $198,986
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 88

* Investment of $108,342 grew by $718 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 88

* Received rent of $1,584
* Loan payment of $1,141 ($435 principal / $706 interest)
* New loan balance of $198,986
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,422 leaving cash of ($273)
* Net taxable income of $162
* Allowed monthly depreciation of $703 + carry-over of $46,701
* Used depreciation of $162 resulting in adjusted taxable income of $0
* Carry over depreciation of $47,242
* Required personal loan of $273 creating a balance of $18,316
* Monthly expenses $1,422 + principle of $435 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($112)

---

Owner in month # 89

* Loan payment of $1,141 ($436 principal / $705 interest)
* New loan balance of $198,550
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 89

* Investment of $109,064 grew by $722 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 89

* Received rent of $1,584
* Loan payment of $1,141 ($436 principal / $705 interest)
* New loan balance of $198,550
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,421 leaving cash of ($273)
* Net taxable income of $163
* Allowed monthly depreciation of $703 + carry-over of $47,242
* Used depreciation of $163 resulting in adjusted taxable income of $0
* Carry over depreciation of $47,782
* Required personal loan of $273 creating a balance of $18,589
* Monthly expenses $1,421 + principle of $436 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($111)

---

Owner in month # 90

* Loan payment of $1,141 ($438 principal / $703 interest)
* New loan balance of $198,112
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 90

* Investment of $109,791 grew by $727 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 90

* Received rent of $1,584
* Loan payment of $1,141 ($438 principal / $703 interest)
* New loan balance of $198,112
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,419 leaving cash of ($273)
* Net taxable income of $165
* Allowed monthly depreciation of $703 + carry-over of $47,782
* Used depreciation of $165 resulting in adjusted taxable income of $0
* Carry over depreciation of $48,320
* Required personal loan of $273 creating a balance of $18,862
* Monthly expenses $1,419 + principle of $438 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($109)

---

Owner in month # 91

* Loan payment of $1,141 ($439 principal / $702 interest)
* New loan balance of $197,673
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 91

* Investment of $110,523 grew by $732 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 91

* Received rent of $1,584
* Loan payment of $1,141 ($439 principal / $702 interest)
* New loan balance of $197,673
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,418 leaving cash of ($273)
* Net taxable income of $166
* Allowed monthly depreciation of $703 + carry-over of $48,320
* Used depreciation of $166 resulting in adjusted taxable income of $0
* Carry over depreciation of $48,857
* Required personal loan of $273 creating a balance of $19,135
* Monthly expenses $1,418 + principle of $439 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($108)

---

Owner in month # 92

* Loan payment of $1,141 ($441 principal / $700 interest)
* New loan balance of $197,232
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 92

* Investment of $111,260 grew by $737 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 92

* Received rent of $1,584
* Loan payment of $1,141 ($441 principal / $700 interest)
* New loan balance of $197,232
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,416 leaving cash of ($273)
* Net taxable income of $168
* Allowed monthly depreciation of $703 + carry-over of $48,857
* Used depreciation of $168 resulting in adjusted taxable income of $0
* Carry over depreciation of $49,392
* Required personal loan of $273 creating a balance of $19,409
* Monthly expenses $1,416 + principle of $441 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($106)

---

Owner in month # 93

* Loan payment of $1,141 ($442 principal / $699 interest)
* New loan balance of $196,790
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 93

* Investment of $112,002 grew by $742 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 93

* Received rent of $1,584
* Loan payment of $1,141 ($442 principal / $699 interest)
* New loan balance of $196,790
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,415 leaving cash of ($273)
* Net taxable income of $169
* Allowed monthly depreciation of $703 + carry-over of $49,392
* Used depreciation of $169 resulting in adjusted taxable income of $0
* Carry over depreciation of $49,926
* Required personal loan of $273 creating a balance of $19,682
* Monthly expenses $1,415 + principle of $442 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($105)

---

Owner in month # 94

* Loan payment of $1,141 ($444 principal / $697 interest)
* New loan balance of $196,346
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 94

* Investment of $112,748 grew by $747 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 94

* Received rent of $1,584
* Loan payment of $1,141 ($444 principal / $697 interest)
* New loan balance of $196,346
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,413 leaving cash of ($273)
* Net taxable income of $171
* Allowed monthly depreciation of $703 + carry-over of $49,926
* Used depreciation of $171 resulting in adjusted taxable income of $0
* Carry over depreciation of $50,458
* Required personal loan of $273 creating a balance of $19,955
* Monthly expenses $1,413 + principle of $444 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($103)

---

Owner in month # 95

* Loan payment of $1,141 ($446 principal / $695 interest)
* New loan balance of $195,900
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 95

* Investment of $113,500 grew by $752 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 95

* Received rent of $1,584
* Loan payment of $1,141 ($446 principal / $695 interest)
* New loan balance of $195,900
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,411 leaving cash of ($273)
* Net taxable income of $173
* Allowed monthly depreciation of $703 + carry-over of $50,458
* Used depreciation of $173 resulting in adjusted taxable income of $0
* Carry over depreciation of $50,988
* Required personal loan of $273 creating a balance of $20,228
* Monthly expenses $1,411 + principle of $446 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($101)

---

Owner in month # 96

* Loan payment of $1,141 ($447 principal / $694 interest)
* New loan balance of $195,453
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total expense this month $1,699

---

Renter in month # 96

* Investment of $114,257 grew by $757 (0.67%)
* Spent $1,584 on rent
* Spent $17 on renters insurance

---

Landlord in month # 96

* Received rent of $1,584
* Loan payment of $1,141 ($447 principal / $694 interest)
* New loan balance of $195,453
* Management fee of $158
* Spent $131 on property tax
* Spent $115 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $1,410 leaving cash of ($273)
* Net taxable income of $174
* Allowed monthly depreciation of $703 + carry-over of $50,988
* Used depreciation of $174 resulting in adjusted taxable income of $0
* Carry over depreciation of $51,517
* Required personal loan of $273 creating a balance of $20,502
* Monthly expenses $1,410 + principle of $447 = $1,857 against rent of $1,584
* Negative cash flow of ($273)
* NPV cash flow of ($100)

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
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,717

---

Renter in month # 97

* Investment of $115,018 grew by $762 (0.67%)
* Spent $1,584 on rent
* Spent $18 on renters insurance

---

Landlord in month # 97

* Received rent of $1,584
* Loan payment of $1,141 ($449 principal / $692 interest)
* New loan balance of $195,004
* Management fee of $158
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,427 leaving cash of ($292)
* Net taxable income of $157
* Allowed monthly depreciation of $703 + carry-over of $51,517
* Used depreciation of $157 resulting in adjusted taxable income of $0
* Carry over depreciation of $52,063
* Required personal loan of $292 creating a balance of $20,793
* Monthly expenses $1,427 + principle of $449 = $1,876 against rent of $1,584
* Negative cash flow of ($292)
* NPV cash flow of ($134)

---

Owner in month # 98

* Loan payment of $1,141 ($450 principal / $691 interest)
* New loan balance of $194,554
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,717

---

Renter in month # 98

* Investment of $115,785 grew by $767 (0.67%)
* Spent $1,584 on rent
* Spent $18 on renters insurance

---

Landlord in month # 98

* Received rent of $1,584
* Loan payment of $1,141 ($450 principal / $691 interest)
* New loan balance of $194,554
* Management fee of $158
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,426 leaving cash of ($292)
* Net taxable income of $158
* Allowed monthly depreciation of $703 + carry-over of $52,063
* Used depreciation of $158 resulting in adjusted taxable income of $0
* Carry over depreciation of $52,608
* Required personal loan of $292 creating a balance of $21,085
* Monthly expenses $1,426 + principle of $450 = $1,876 against rent of $1,584
* Negative cash flow of ($292)
* NPV cash flow of ($133)

---

Owner in month # 99

* Loan payment of $1,141 ($452 principal / $689 interest)
* New loan balance of $194,102
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,717

---

Renter in month # 99

* Investment of $116,557 grew by $772 (0.67%)
* Spent $1,584 on rent
* Spent $18 on renters insurance

---

Landlord in month # 99

* Received rent of $1,584
* Loan payment of $1,141 ($452 principal / $689 interest)
* New loan balance of $194,102
* Management fee of $158
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,424 leaving cash of ($292)
* Net taxable income of $160
* Allowed monthly depreciation of $703 + carry-over of $52,608
* Used depreciation of $160 resulting in adjusted taxable income of $0
* Carry over depreciation of $53,151
* Required personal loan of $292 creating a balance of $21,376
* Monthly expenses $1,424 + principle of $452 = $1,876 against rent of $1,584
* Negative cash flow of ($292)
* NPV cash flow of ($131)

---

Owner in month # 100

* Loan payment of $1,141 ($454 principal / $687 interest)
* New loan balance of $193,648
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,717

---

Renter in month # 100

* Investment of $117,334 grew by $777 (0.67%)
* Spent $1,584 on rent
* Spent $18 on renters insurance

---

Landlord in month # 100

* Received rent of $1,584
* Loan payment of $1,141 ($454 principal / $687 interest)
* New loan balance of $193,648
* Management fee of $158
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,422 leaving cash of ($292)
* Net taxable income of $162
* Allowed monthly depreciation of $703 + carry-over of $53,151
* Used depreciation of $162 resulting in adjusted taxable income of $0
* Carry over depreciation of $53,692
* Required personal loan of $292 creating a balance of $21,668
* Monthly expenses $1,422 + principle of $454 = $1,876 against rent of $1,584
* Negative cash flow of ($292)
* NPV cash flow of ($129)

---

Owner in month # 101

* Loan payment of $1,141 ($455 principal / $686 interest)
* New loan balance of $193,193
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,717

---

Renter in month # 101

* Investment of $118,116 grew by $782 (0.67%)
* Spent $1,584 on rent
* Spent $18 on renters insurance

---

Landlord in month # 101

* Received rent of $1,584
* Loan payment of $1,141 ($455 principal / $686 interest)
* New loan balance of $193,193
* Management fee of $158
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,421 leaving cash of ($292)
* Net taxable income of $163
* Allowed monthly depreciation of $703 + carry-over of $53,692
* Used depreciation of $163 resulting in adjusted taxable income of $0
* Carry over depreciation of $54,232
* Required personal loan of $292 creating a balance of $21,959
* Monthly expenses $1,421 + principle of $455 = $1,876 against rent of $1,584
* Negative cash flow of ($292)
* NPV cash flow of ($128)

---

Owner in month # 102

* Loan payment of $1,141 ($457 principal / $684 interest)
* New loan balance of $192,736
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,717

---

Renter in month # 102

* Investment of $118,904 grew by $787 (0.67%)
* Spent $1,584 on rent
* Spent $18 on renters insurance

---

Landlord in month # 102

* Received rent of $1,584
* Loan payment of $1,141 ($457 principal / $684 interest)
* New loan balance of $192,736
* Management fee of $158
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,419 leaving cash of ($292)
* Net taxable income of $165
* Allowed monthly depreciation of $703 + carry-over of $54,232
* Used depreciation of $165 resulting in adjusted taxable income of $0
* Carry over depreciation of $54,770
* Required personal loan of $292 creating a balance of $22,251
* Monthly expenses $1,419 + principle of $457 = $1,876 against rent of $1,584
* Negative cash flow of ($292)
* NPV cash flow of ($126)

---

Owner in month # 103

* Loan payment of $1,141 ($458 principal / $683 interest)
* New loan balance of $192,278
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,717

---

Renter in month # 103

* Investment of $119,697 grew by $793 (0.67%)
* Spent $1,584 on rent
* Spent $18 on renters insurance

---

Landlord in month # 103

* Received rent of $1,584
* Loan payment of $1,141 ($458 principal / $683 interest)
* New loan balance of $192,278
* Management fee of $158
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,418 leaving cash of ($292)
* Net taxable income of $166
* Allowed monthly depreciation of $703 + carry-over of $54,770
* Used depreciation of $166 resulting in adjusted taxable income of $0
* Carry over depreciation of $55,307
* Required personal loan of $292 creating a balance of $22,543
* Monthly expenses $1,418 + principle of $458 = $1,876 against rent of $1,584
* Negative cash flow of ($292)
* NPV cash flow of ($125)

---

Owner in month # 104

* Loan payment of $1,141 ($460 principal / $681 interest)
* New loan balance of $191,818
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total expense this month $1,717
* Sold home for $387,685
* Fixed sales costs of $1,000 and commission of $23,261
* Paid off loan balance of $191,818
* Home sale proceeds of $171,606

---

Renter in month # 104

* Investment of $120,494 grew by $798 (0.67%)
* Spent $1,584 on rent
* Spent $18 on renters insurance
* Capital gains of $60,120 on initial investment of $60,375
* Capital gains tax of $9,018
* Cashed out investment of $120,494
* Returned security deposit of $1,584
* Cash on hand of $113,060
* Total spent $166,422

---

Landlord in month # 104

* Received rent of $1,584
* Loan payment of $1,141 ($460 principal / $681 interest)
* New loan balance of $191,818
* Management fee of $158
* Spent $136 on property tax
* Spent $117 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $1,416 leaving cash of ($292)
* Net taxable income of $168
* Allowed monthly depreciation of $703 + carry-over of $55,307
* Used depreciation of $168 resulting in adjusted taxable income of $0
* Carry over depreciation of $55,842
* Required personal loan of $292 creating a balance of $22,834
* Monthly expenses $1,416 + principle of $460 = $1,876 against rent of $1,584
* Negative cash flow of ($292)
* NPV cash flow of ($123)
* Sold home for $387,685
* Fixed sales costs of $1,000 and commission of $23,261 leaving proceeds of $363,424
* Total gain from sale of $77,503
* Paid depreciation recapture taxes of $4,145 on $17,270
* Paid capital gains taxes of $9,035 on $60,233
* Paid off loan balance of $191,818
* Closed out personal loan of $22,834
* Net home sale proceeds of $135,592
* Total cash on hand of $135,592
* Adjusted NPV cash flow of $135,469 accounting for sale proceeds of $135,592
* Net present value of $2,588
* Internal rate of return of 8.47%

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
|Rent|$1,584|
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
|PropertyTaxPercentage|0.42%|
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

Owner spent $171,097 (average of $1,645 / month) and has net worth of $171,606 on initial investment of $61,959

---

Renter spent $166,422 (average of $1,600 / month) and has net worth of $113,060 on initial investment of $60,375 + security deposit of $1,584

---

Landlord received total rent of $164,736 (average of $1,584 / month), total expenses of $184,909 (average of $1,778 / month), and has net worth of $135,592 on initial investment of $61,959
Net present value of $2,588
Internal rate of return of 8.47%
