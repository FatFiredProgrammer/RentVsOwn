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
|RentChangePerYearPercentage|3.50%|
|Rent|$2,300|
|RentSecurityDepositMonths|1|
|RentersInsurancePerMonth|$15|
|LandlordInterestRate|4.75%|
|LandlordLoanYears|20|
|LandlordDownPaymentPercentage|25.00%|
|LandlordDownPayment|$72,475|
|LandlordLoanAmount|$217,425|
|LandlordHomeValue|$289,900|
|LandlordLoanBalance|$217,425|
|LandlordMonthlyPayment|$1,405|
|LandlordManagementFeePercentage|10.00%|
|DepreciationYears|27.50|
|DepreciablePercentage|80.00%|
|ClosingFixedCosts|$500|
|ClosingVariableCostsPercentage|1.50%|
|PropertyTaxPercentage|2.10%|
|InsurancePerMonth|$167|
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

Landlord in month # 1

* Down payment of $72,475
* Fixed closing costs of $500
* Variable closing costs of $3,261
* Total initial investment of $76,236
* Basis in home purchase $286,139
* Initial loan balance of $217,425
* Received rent of $2,300
* Loan payment of $1,405 ($544 principal / $861 interest)
* New loan balance of $216,881
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $2,007 leaving cash of ($251)
* Net taxable income of $293
* Allowed monthly depreciation of $703 + carry-over of $0
* Used depreciation of $293 resulting in adjusted taxable income of $0
* Carry over depreciation of $410
* Required personal loan of $251 creating a balance of $251
* Monthly expenses $2,007 + principle of $544 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $43

---

Owner in month # 1

* Down payment of $57,980
* Fixed closing costs of $500
* Variable closing costs of $3,479
* Total initial investment of $61,959
* Initial loan balance of $231,920
* Loan payment of $1,141 ($320 principal / $821 interest)
* New loan balance of $231,600
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 1

* Starting cash of $61,959 ($57,980 owner down payment + $500 owner fixed closing costs + $3,479 owner variable closing costs)
* Security deposit of $2,300
* Invested  $59,659
* Investment of $60,057 grew by $398 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 2

* Received rent of $2,300
* Loan payment of $1,405 ($547 principal / $858 interest)
* New loan balance of $216,334
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $2,004 leaving cash of ($251)
* Net taxable income of $296
* Allowed monthly depreciation of $703 + carry-over of $410
* Used depreciation of $296 resulting in adjusted taxable income of $0
* Carry over depreciation of $817
* Required personal loan of $251 creating a balance of $501
* Monthly expenses $2,004 + principle of $547 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $46

---

Owner in month # 2

* Loan payment of $1,141 ($321 principal / $820 interest)
* New loan balance of $231,279
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 2

* Investment of $60,457 grew by $400 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 3

* Received rent of $2,300
* Loan payment of $1,405 ($549 principal / $856 interest)
* New loan balance of $215,785
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $2,002 leaving cash of ($251)
* Net taxable income of $298
* Allowed monthly depreciation of $703 + carry-over of $817
* Used depreciation of $298 resulting in adjusted taxable income of $0
* Carry over depreciation of $1,222
* Required personal loan of $251 creating a balance of $752
* Monthly expenses $2,002 + principle of $549 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $48

---

Owner in month # 3

* Loan payment of $1,141 ($322 principal / $819 interest)
* New loan balance of $230,957
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 3

* Investment of $60,860 grew by $403 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 4

* Received rent of $2,300
* Loan payment of $1,405 ($551 principal / $854 interest)
* New loan balance of $215,234
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $2,000 leaving cash of ($251)
* Net taxable income of $300
* Allowed monthly depreciation of $703 + carry-over of $1,222
* Used depreciation of $300 resulting in adjusted taxable income of $0
* Carry over depreciation of $1,625
* Required personal loan of $251 creating a balance of $1,003
* Monthly expenses $2,000 + principle of $551 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $50

---

Owner in month # 4

* Loan payment of $1,141 ($323 principal / $818 interest)
* New loan balance of $230,634
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 4

* Investment of $61,266 grew by $406 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 5

* Received rent of $2,300
* Loan payment of $1,405 ($553 principal / $852 interest)
* New loan balance of $214,681
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,998 leaving cash of ($251)
* Net taxable income of $302
* Allowed monthly depreciation of $703 + carry-over of $1,625
* Used depreciation of $302 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,026
* Required personal loan of $251 creating a balance of $1,253
* Monthly expenses $1,998 + principle of $553 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $52

---

Owner in month # 5

* Loan payment of $1,141 ($324 principal / $817 interest)
* New loan balance of $230,310
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 5

* Investment of $61,674 grew by $408 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 6

* Received rent of $2,300
* Loan payment of $1,405 ($555 principal / $850 interest)
* New loan balance of $214,126
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,996 leaving cash of ($251)
* Net taxable income of $304
* Allowed monthly depreciation of $703 + carry-over of $2,026
* Used depreciation of $304 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,425
* Required personal loan of $251 creating a balance of $1,504
* Monthly expenses $1,996 + principle of $555 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $54

---

Owner in month # 6

* Loan payment of $1,141 ($325 principal / $816 interest)
* New loan balance of $229,985
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 6

* Investment of $62,085 grew by $411 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 7

* Received rent of $2,300
* Loan payment of $1,405 ($557 principal / $848 interest)
* New loan balance of $213,569
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,994 leaving cash of ($251)
* Net taxable income of $306
* Allowed monthly depreciation of $703 + carry-over of $2,425
* Used depreciation of $306 resulting in adjusted taxable income of $0
* Carry over depreciation of $2,822
* Required personal loan of $251 creating a balance of $1,755
* Monthly expenses $1,994 + principle of $557 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $56

---

Owner in month # 7

* Loan payment of $1,141 ($326 principal / $815 interest)
* New loan balance of $229,659
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 7

* Investment of $62,499 grew by $414 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 8

* Received rent of $2,300
* Loan payment of $1,405 ($560 principal / $845 interest)
* New loan balance of $213,009
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,991 leaving cash of ($251)
* Net taxable income of $309
* Allowed monthly depreciation of $703 + carry-over of $2,822
* Used depreciation of $309 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,216
* Required personal loan of $251 creating a balance of $2,005
* Monthly expenses $1,991 + principle of $560 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $59

---

Owner in month # 8

* Loan payment of $1,141 ($328 principal / $813 interest)
* New loan balance of $229,331
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 8

* Investment of $62,916 grew by $417 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 9

* Received rent of $2,300
* Loan payment of $1,405 ($562 principal / $843 interest)
* New loan balance of $212,447
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,989 leaving cash of ($251)
* Net taxable income of $311
* Allowed monthly depreciation of $703 + carry-over of $3,216
* Used depreciation of $311 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,608
* Required personal loan of $251 creating a balance of $2,256
* Monthly expenses $1,989 + principle of $562 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $61

---

Owner in month # 9

* Loan payment of $1,141 ($329 principal / $812 interest)
* New loan balance of $229,002
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 9

* Investment of $63,335 grew by $419 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 10

* Received rent of $2,300
* Loan payment of $1,405 ($564 principal / $841 interest)
* New loan balance of $211,883
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,987 leaving cash of ($251)
* Net taxable income of $313
* Allowed monthly depreciation of $703 + carry-over of $3,608
* Used depreciation of $313 resulting in adjusted taxable income of $0
* Carry over depreciation of $3,998
* Required personal loan of $251 creating a balance of $2,507
* Monthly expenses $1,987 + principle of $564 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $63

---

Owner in month # 10

* Loan payment of $1,141 ($330 principal / $811 interest)
* New loan balance of $228,672
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 10

* Investment of $63,758 grew by $422 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 11

* Received rent of $2,300
* Loan payment of $1,405 ($566 principal / $839 interest)
* New loan balance of $211,317
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,985 leaving cash of ($251)
* Net taxable income of $315
* Allowed monthly depreciation of $703 + carry-over of $3,998
* Used depreciation of $315 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,386
* Required personal loan of $251 creating a balance of $2,757
* Monthly expenses $1,985 + principle of $566 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $65

---

Owner in month # 11

* Loan payment of $1,141 ($331 principal / $810 interest)
* New loan balance of $228,341
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 11

* Investment of $64,183 grew by $425 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 12

* Received rent of $2,300
* Loan payment of $1,405 ($569 principal / $836 interest)
* New loan balance of $210,748
* Management fee of $230
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance
* Total monthly expenses of $1,982 leaving cash of ($251)
* Net taxable income of $318
* Allowed monthly depreciation of $703 + carry-over of $4,386
* Used depreciation of $318 resulting in adjusted taxable income of $0
* Carry over depreciation of $4,771
* Required personal loan of $251 creating a balance of $3,008
* Monthly expenses $1,982 + principle of $569 = $2,551 against rent of $2,300
* Negative cash flow of ($251)
* NPV cash flow of $68

---

Owner in month # 12

* Loan payment of $1,141 ($332 principal / $809 interest)
* New loan balance of $228,009
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $242 on home maintenance

---

Renter in month # 12

* Investment of $64,610 grew by $428 (0.67%)
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Year # 1

* Rent increased 3.50% to $2,380
* Owner Home value increased 3.70% to $300,626
* Landlord Home value increased 3.70% to $300,626
* Renters insurance increased 2.00% to $15.30
* Home owner's insurance increased 2.00% to $170.00
* HOA increased 2.00% to $0.00

---

Landlord in month # 13

* Received rent of $2,380
* Loan payment of $1,405 ($571 principal / $834 interest)
* New loan balance of $210,177
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $2,019 leaving cash of ($210)
* Net taxable income of $361
* Allowed monthly depreciation of $703 + carry-over of $4,771
* Used depreciation of $361 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,113
* Required personal loan of $210 creating a balance of $3,218
* Monthly expenses $2,019 + principle of $571 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $151

---

Owner in month # 13

* Loan payment of $1,141 ($333 principal / $808 interest)
* New loan balance of $227,676
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 13

* Investment of $65,041 grew by $431 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 14

* Received rent of $2,380
* Loan payment of $1,405 ($573 principal / $832 interest)
* New loan balance of $209,604
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $2,017 leaving cash of ($210)
* Net taxable income of $363
* Allowed monthly depreciation of $703 + carry-over of $5,113
* Used depreciation of $363 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,453
* Required personal loan of $210 creating a balance of $3,428
* Monthly expenses $2,017 + principle of $573 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $153

---

Owner in month # 14

* Loan payment of $1,141 ($335 principal / $806 interest)
* New loan balance of $227,341
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 14

* Investment of $65,475 grew by $434 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 15

* Received rent of $2,380
* Loan payment of $1,405 ($575 principal / $830 interest)
* New loan balance of $209,029
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $2,015 leaving cash of ($210)
* Net taxable income of $365
* Allowed monthly depreciation of $703 + carry-over of $5,453
* Used depreciation of $365 resulting in adjusted taxable income of $0
* Carry over depreciation of $5,791
* Required personal loan of $210 creating a balance of $3,638
* Monthly expenses $2,015 + principle of $575 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $155

---

Owner in month # 15

* Loan payment of $1,141 ($336 principal / $805 interest)
* New loan balance of $227,005
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 15

* Investment of $65,911 grew by $437 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 16

* Received rent of $2,380
* Loan payment of $1,405 ($578 principal / $827 interest)
* New loan balance of $208,451
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $2,012 leaving cash of ($210)
* Net taxable income of $368
* Allowed monthly depreciation of $703 + carry-over of $5,791
* Used depreciation of $368 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,126
* Required personal loan of $210 creating a balance of $3,848
* Monthly expenses $2,012 + principle of $578 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $158

---

Owner in month # 16

* Loan payment of $1,141 ($337 principal / $804 interest)
* New loan balance of $226,668
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 16

* Investment of $66,351 grew by $439 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 17

* Received rent of $2,380
* Loan payment of $1,405 ($580 principal / $825 interest)
* New loan balance of $207,871
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $2,010 leaving cash of ($210)
* Net taxable income of $370
* Allowed monthly depreciation of $703 + carry-over of $6,126
* Used depreciation of $370 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,459
* Required personal loan of $210 creating a balance of $4,058
* Monthly expenses $2,010 + principle of $580 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $160

---

Owner in month # 17

* Loan payment of $1,141 ($338 principal / $803 interest)
* New loan balance of $226,330
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 17

* Investment of $66,793 grew by $442 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 18

* Received rent of $2,380
* Loan payment of $1,405 ($582 principal / $823 interest)
* New loan balance of $207,289
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $2,008 leaving cash of ($210)
* Net taxable income of $372
* Allowed monthly depreciation of $703 + carry-over of $6,459
* Used depreciation of $372 resulting in adjusted taxable income of $0
* Carry over depreciation of $6,790
* Required personal loan of $210 creating a balance of $4,268
* Monthly expenses $2,008 + principle of $582 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $162

---

Owner in month # 18

* Loan payment of $1,141 ($339 principal / $802 interest)
* New loan balance of $225,991
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 18

* Investment of $67,238 grew by $445 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 19

* Received rent of $2,380
* Loan payment of $1,405 ($584 principal / $821 interest)
* New loan balance of $206,705
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $2,006 leaving cash of ($210)
* Net taxable income of $374
* Allowed monthly depreciation of $703 + carry-over of $6,790
* Used depreciation of $374 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,119
* Required personal loan of $210 creating a balance of $4,478
* Monthly expenses $2,006 + principle of $584 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $164

---

Owner in month # 19

* Loan payment of $1,141 ($341 principal / $800 interest)
* New loan balance of $225,650
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 19

* Investment of $67,687 grew by $448 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 20

* Received rent of $2,380
* Loan payment of $1,405 ($587 principal / $818 interest)
* New loan balance of $206,118
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $2,003 leaving cash of ($210)
* Net taxable income of $377
* Allowed monthly depreciation of $703 + carry-over of $7,119
* Used depreciation of $377 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,445
* Required personal loan of $210 creating a balance of $4,688
* Monthly expenses $2,003 + principle of $587 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $167

---

Owner in month # 20

* Loan payment of $1,141 ($342 principal / $799 interest)
* New loan balance of $225,308
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 20

* Investment of $68,138 grew by $451 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 21

* Received rent of $2,380
* Loan payment of $1,405 ($589 principal / $816 interest)
* New loan balance of $205,529
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $2,001 leaving cash of ($210)
* Net taxable income of $379
* Allowed monthly depreciation of $703 + carry-over of $7,445
* Used depreciation of $379 resulting in adjusted taxable income of $0
* Carry over depreciation of $7,769
* Required personal loan of $210 creating a balance of $4,898
* Monthly expenses $2,001 + principle of $589 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $169

---

Owner in month # 21

* Loan payment of $1,141 ($343 principal / $798 interest)
* New loan balance of $224,965
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 21

* Investment of $68,592 grew by $454 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 22

* Received rent of $2,380
* Loan payment of $1,405 ($591 principal / $814 interest)
* New loan balance of $204,938
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,999 leaving cash of ($210)
* Net taxable income of $381
* Allowed monthly depreciation of $703 + carry-over of $7,769
* Used depreciation of $381 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,091
* Required personal loan of $210 creating a balance of $5,108
* Monthly expenses $1,999 + principle of $591 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $171

---

Owner in month # 22

* Loan payment of $1,141 ($344 principal / $797 interest)
* New loan balance of $224,621
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 22

* Investment of $69,049 grew by $457 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 23

* Received rent of $2,380
* Loan payment of $1,405 ($594 principal / $811 interest)
* New loan balance of $204,344
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,996 leaving cash of ($210)
* Net taxable income of $384
* Allowed monthly depreciation of $703 + carry-over of $8,091
* Used depreciation of $384 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,410
* Required personal loan of $210 creating a balance of $5,318
* Monthly expenses $1,996 + principle of $594 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $174

---

Owner in month # 23

* Loan payment of $1,141 ($345 principal / $796 interest)
* New loan balance of $224,276
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 23

* Investment of $69,510 grew by $460 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 24

* Received rent of $2,380
* Loan payment of $1,405 ($596 principal / $809 interest)
* New loan balance of $203,748
* Management fee of $238
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance
* Total monthly expenses of $1,994 leaving cash of ($210)
* Net taxable income of $386
* Allowed monthly depreciation of $703 + carry-over of $8,410
* Used depreciation of $386 resulting in adjusted taxable income of $0
* Carry over depreciation of $8,727
* Required personal loan of $210 creating a balance of $5,528
* Monthly expenses $1,994 + principle of $596 = $2,590 against rent of $2,380
* Negative cash flow of ($210)
* NPV cash flow of $176

---

Owner in month # 24

* Loan payment of $1,141 ($347 principal / $794 interest)
* New loan balance of $223,929
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $251 on home maintenance

---

Renter in month # 24

* Investment of $69,973 grew by $463 (0.67%)
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Year # 2

* Rent increased 3.50% to $2,463
* Owner Home value increased 3.70% to $311,749
* Landlord Home value increased 3.70% to $311,749
* Renters insurance increased 2.00% to $15.61
* Home owner's insurance increased 2.00% to $173.40
* HOA increased 2.00% to $0.00

---

Landlord in month # 25

* Received rent of $2,463
* Loan payment of $1,405 ($598 principal / $807 interest)
* New loan balance of $203,150
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,033 leaving cash of ($168)
* Net taxable income of $430
* Allowed monthly depreciation of $703 + carry-over of $8,727
* Used depreciation of $430 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,000
* Required personal loan of $168 creating a balance of $5,696
* Monthly expenses $2,033 + principle of $598 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $263

---

Owner in month # 25

* Loan payment of $1,141 ($348 principal / $793 interest)
* New loan balance of $223,581
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 25

* Investment of $70,440 grew by $466 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 26

* Received rent of $2,463
* Loan payment of $1,405 ($601 principal / $804 interest)
* New loan balance of $202,549
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,030 leaving cash of ($168)
* Net taxable income of $433
* Allowed monthly depreciation of $703 + carry-over of $9,000
* Used depreciation of $433 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,270
* Required personal loan of $168 creating a balance of $5,863
* Monthly expenses $2,030 + principle of $601 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $266

---

Owner in month # 26

* Loan payment of $1,141 ($349 principal / $792 interest)
* New loan balance of $223,232
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 26

* Investment of $70,909 grew by $470 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 27

* Received rent of $2,463
* Loan payment of $1,405 ($603 principal / $802 interest)
* New loan balance of $201,946
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,028 leaving cash of ($168)
* Net taxable income of $435
* Allowed monthly depreciation of $703 + carry-over of $9,270
* Used depreciation of $435 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,538
* Required personal loan of $168 creating a balance of $6,031
* Monthly expenses $2,028 + principle of $603 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $268

---

Owner in month # 27

* Loan payment of $1,141 ($350 principal / $791 interest)
* New loan balance of $222,882
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 27

* Investment of $71,382 grew by $473 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 28

* Received rent of $2,463
* Loan payment of $1,405 ($606 principal / $799 interest)
* New loan balance of $201,340
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,025 leaving cash of ($168)
* Net taxable income of $438
* Allowed monthly depreciation of $703 + carry-over of $9,538
* Used depreciation of $438 resulting in adjusted taxable income of $0
* Carry over depreciation of $9,803
* Required personal loan of $168 creating a balance of $6,199
* Monthly expenses $2,025 + principle of $606 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $271

---

Owner in month # 28

* Loan payment of $1,141 ($352 principal / $789 interest)
* New loan balance of $222,530
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 28

* Investment of $71,858 grew by $476 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 29

* Received rent of $2,463
* Loan payment of $1,405 ($608 principal / $797 interest)
* New loan balance of $200,732
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,023 leaving cash of ($168)
* Net taxable income of $440
* Allowed monthly depreciation of $703 + carry-over of $9,803
* Used depreciation of $440 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,066
* Required personal loan of $168 creating a balance of $6,367
* Monthly expenses $2,023 + principle of $608 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $273

---

Owner in month # 29

* Loan payment of $1,141 ($353 principal / $788 interest)
* New loan balance of $222,177
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 29

* Investment of $72,337 grew by $479 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 30

* Received rent of $2,463
* Loan payment of $1,405 ($610 principal / $795 interest)
* New loan balance of $200,122
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,021 leaving cash of ($168)
* Net taxable income of $442
* Allowed monthly depreciation of $703 + carry-over of $10,066
* Used depreciation of $442 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,327
* Required personal loan of $168 creating a balance of $6,534
* Monthly expenses $2,021 + principle of $610 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $275

---

Owner in month # 30

* Loan payment of $1,141 ($354 principal / $787 interest)
* New loan balance of $221,823
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 30

* Investment of $72,819 grew by $482 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 31

* Received rent of $2,463
* Loan payment of $1,405 ($613 principal / $792 interest)
* New loan balance of $199,509
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,018 leaving cash of ($168)
* Net taxable income of $445
* Allowed monthly depreciation of $703 + carry-over of $10,327
* Used depreciation of $445 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,585
* Required personal loan of $168 creating a balance of $6,702
* Monthly expenses $2,018 + principle of $613 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $278

---

Owner in month # 31

* Loan payment of $1,141 ($355 principal / $786 interest)
* New loan balance of $221,468
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 31

* Investment of $73,305 grew by $485 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 32

* Received rent of $2,463
* Loan payment of $1,405 ($615 principal / $790 interest)
* New loan balance of $198,894
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,016 leaving cash of ($168)
* Net taxable income of $447
* Allowed monthly depreciation of $703 + carry-over of $10,585
* Used depreciation of $447 resulting in adjusted taxable income of $0
* Carry over depreciation of $10,841
* Required personal loan of $168 creating a balance of $6,870
* Monthly expenses $2,016 + principle of $615 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $280

---

Owner in month # 32

* Loan payment of $1,141 ($357 principal / $784 interest)
* New loan balance of $221,111
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 32

* Investment of $73,793 grew by $489 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 33

* Received rent of $2,463
* Loan payment of $1,405 ($618 principal / $787 interest)
* New loan balance of $198,276
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,013 leaving cash of ($168)
* Net taxable income of $450
* Allowed monthly depreciation of $703 + carry-over of $10,841
* Used depreciation of $450 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,094
* Required personal loan of $168 creating a balance of $7,037
* Monthly expenses $2,013 + principle of $618 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $283

---

Owner in month # 33

* Loan payment of $1,141 ($358 principal / $783 interest)
* New loan balance of $220,753
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 33

* Investment of $74,285 grew by $492 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 34

* Received rent of $2,463
* Loan payment of $1,405 ($620 principal / $785 interest)
* New loan balance of $197,656
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,011 leaving cash of ($168)
* Net taxable income of $452
* Allowed monthly depreciation of $703 + carry-over of $11,094
* Used depreciation of $452 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,345
* Required personal loan of $168 creating a balance of $7,205
* Monthly expenses $2,011 + principle of $620 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $285

---

Owner in month # 34

* Loan payment of $1,141 ($359 principal / $782 interest)
* New loan balance of $220,394
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 34

* Investment of $74,780 grew by $495 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 35

* Received rent of $2,463
* Loan payment of $1,405 ($623 principal / $782 interest)
* New loan balance of $197,033
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,008 leaving cash of ($168)
* Net taxable income of $455
* Allowed monthly depreciation of $703 + carry-over of $11,345
* Used depreciation of $455 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,593
* Required personal loan of $168 creating a balance of $7,373
* Monthly expenses $2,008 + principle of $623 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $288

---

Owner in month # 35

* Loan payment of $1,141 ($360 principal / $781 interest)
* New loan balance of $220,034
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 35

* Investment of $75,279 grew by $499 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 36

* Received rent of $2,463
* Loan payment of $1,405 ($625 principal / $780 interest)
* New loan balance of $196,408
* Management fee of $246
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance
* Total monthly expenses of $2,006 leaving cash of ($168)
* Net taxable income of $457
* Allowed monthly depreciation of $703 + carry-over of $11,593
* Used depreciation of $457 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,839
* Required personal loan of $168 creating a balance of $7,540
* Monthly expenses $2,006 + principle of $625 = $2,631 against rent of $2,463
* Negative cash flow of ($168)
* NPV cash flow of $290

---

Owner in month # 36

* Loan payment of $1,141 ($362 principal / $779 interest)
* New loan balance of $219,672
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $260 on home maintenance

---

Renter in month # 36

* Investment of $75,781 grew by $502 (0.67%)
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Year # 3

* Rent increased 3.50% to $2,549
* Owner Home value increased 3.70% to $323,284
* Landlord Home value increased 3.70% to $323,284
* Renters insurance increased 2.00% to $15.92
* Home owner's insurance increased 2.00% to $176.87
* HOA increased 2.00% to $0.00

---

Landlord in month # 37

* Received rent of $2,549
* Loan payment of $1,405 ($628 principal / $777 interest)
* New loan balance of $195,780
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,044 leaving cash of ($123)
* Net taxable income of $505
* Allowed monthly depreciation of $703 + carry-over of $11,839
* Used depreciation of $505 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,037
* Required personal loan of $123 creating a balance of $7,663
* Monthly expenses $2,044 + principle of $628 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $382

---

Owner in month # 37

* Loan payment of $1,141 ($363 principal / $778 interest)
* New loan balance of $219,309
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 37

* Investment of $76,286 grew by $505 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 38

* Received rent of $2,549
* Loan payment of $1,405 ($630 principal / $775 interest)
* New loan balance of $195,150
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,042 leaving cash of ($123)
* Net taxable income of $507
* Allowed monthly depreciation of $703 + carry-over of $12,037
* Used depreciation of $507 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,233
* Required personal loan of $123 creating a balance of $7,786
* Monthly expenses $2,042 + principle of $630 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $384

---

Owner in month # 38

* Loan payment of $1,141 ($364 principal / $777 interest)
* New loan balance of $218,945
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 38

* Investment of $76,795 grew by $509 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 39

* Received rent of $2,549
* Loan payment of $1,405 ($633 principal / $772 interest)
* New loan balance of $194,517
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,039 leaving cash of ($123)
* Net taxable income of $510
* Allowed monthly depreciation of $703 + carry-over of $12,233
* Used depreciation of $510 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,426
* Required personal loan of $123 creating a balance of $7,909
* Monthly expenses $2,039 + principle of $633 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $387

---

Owner in month # 39

* Loan payment of $1,141 ($366 principal / $775 interest)
* New loan balance of $218,579
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 39

* Investment of $77,307 grew by $512 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 40

* Received rent of $2,549
* Loan payment of $1,405 ($635 principal / $770 interest)
* New loan balance of $193,882
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,037 leaving cash of ($123)
* Net taxable income of $512
* Allowed monthly depreciation of $703 + carry-over of $12,426
* Used depreciation of $512 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,617
* Required personal loan of $123 creating a balance of $8,032
* Monthly expenses $2,037 + principle of $635 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $389

---

Owner in month # 40

* Loan payment of $1,141 ($367 principal / $774 interest)
* New loan balance of $218,212
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 40

* Investment of $77,822 grew by $515 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 41

* Received rent of $2,549
* Loan payment of $1,405 ($638 principal / $767 interest)
* New loan balance of $193,244
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,034 leaving cash of ($123)
* Net taxable income of $515
* Allowed monthly depreciation of $703 + carry-over of $12,617
* Used depreciation of $515 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,805
* Required personal loan of $123 creating a balance of $8,154
* Monthly expenses $2,034 + principle of $638 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $392

---

Owner in month # 41

* Loan payment of $1,141 ($368 principal / $773 interest)
* New loan balance of $217,844
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 41

* Investment of $78,341 grew by $519 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 42

* Received rent of $2,549
* Loan payment of $1,405 ($640 principal / $765 interest)
* New loan balance of $192,604
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,032 leaving cash of ($123)
* Net taxable income of $517
* Allowed monthly depreciation of $703 + carry-over of $12,805
* Used depreciation of $517 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,991
* Required personal loan of $123 creating a balance of $8,277
* Monthly expenses $2,032 + principle of $640 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $394

---

Owner in month # 42

* Loan payment of $1,141 ($369 principal / $772 interest)
* New loan balance of $217,475
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 42

* Investment of $78,863 grew by $522 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 43

* Received rent of $2,549
* Loan payment of $1,405 ($643 principal / $762 interest)
* New loan balance of $191,961
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,029 leaving cash of ($123)
* Net taxable income of $520
* Allowed monthly depreciation of $703 + carry-over of $12,991
* Used depreciation of $520 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,174
* Required personal loan of $123 creating a balance of $8,400
* Monthly expenses $2,029 + principle of $643 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $397

---

Owner in month # 43

* Loan payment of $1,141 ($371 principal / $770 interest)
* New loan balance of $217,104
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 43

* Investment of $79,389 grew by $526 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 44

* Received rent of $2,549
* Loan payment of $1,405 ($645 principal / $760 interest)
* New loan balance of $191,316
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,027 leaving cash of ($123)
* Net taxable income of $522
* Allowed monthly depreciation of $703 + carry-over of $13,174
* Used depreciation of $522 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,355
* Required personal loan of $123 creating a balance of $8,523
* Monthly expenses $2,027 + principle of $645 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $399

---

Owner in month # 44

* Loan payment of $1,141 ($372 principal / $769 interest)
* New loan balance of $216,732
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 44

* Investment of $79,918 grew by $529 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 45

* Received rent of $2,549
* Loan payment of $1,405 ($648 principal / $757 interest)
* New loan balance of $190,668
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,024 leaving cash of ($123)
* Net taxable income of $525
* Allowed monthly depreciation of $703 + carry-over of $13,355
* Used depreciation of $525 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,533
* Required personal loan of $123 creating a balance of $8,645
* Monthly expenses $2,024 + principle of $648 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $402

---

Owner in month # 45

* Loan payment of $1,141 ($373 principal / $768 interest)
* New loan balance of $216,359
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 45

* Investment of $80,451 grew by $533 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 46

* Received rent of $2,549
* Loan payment of $1,405 ($650 principal / $755 interest)
* New loan balance of $190,018
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,022 leaving cash of ($123)
* Net taxable income of $527
* Allowed monthly depreciation of $703 + carry-over of $13,533
* Used depreciation of $527 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,709
* Required personal loan of $123 creating a balance of $8,768
* Monthly expenses $2,022 + principle of $650 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $404

---

Owner in month # 46

* Loan payment of $1,141 ($375 principal / $766 interest)
* New loan balance of $215,984
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 46

* Investment of $80,987 grew by $536 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 47

* Received rent of $2,549
* Loan payment of $1,405 ($653 principal / $752 interest)
* New loan balance of $189,365
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,019 leaving cash of ($123)
* Net taxable income of $530
* Allowed monthly depreciation of $703 + carry-over of $13,709
* Used depreciation of $530 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,882
* Required personal loan of $123 creating a balance of $8,891
* Monthly expenses $2,019 + principle of $653 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $407

---

Owner in month # 47

* Loan payment of $1,141 ($376 principal / $765 interest)
* New loan balance of $215,608
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 47

* Investment of $81,527 grew by $540 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 48

* Received rent of $2,549
* Loan payment of $1,405 ($655 principal / $750 interest)
* New loan balance of $188,710
* Management fee of $255
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance
* Total monthly expenses of $2,017 leaving cash of ($123)
* Net taxable income of $532
* Allowed monthly depreciation of $703 + carry-over of $13,882
* Used depreciation of $532 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,053
* Required personal loan of $123 creating a balance of $9,014
* Monthly expenses $2,017 + principle of $655 = $2,672 against rent of $2,549
* Negative cash flow of ($123)
* NPV cash flow of $409

---

Owner in month # 48

* Loan payment of $1,141 ($377 principal / $764 interest)
* New loan balance of $215,231
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $269 on home maintenance

---

Renter in month # 48

* Investment of $82,071 grew by $544 (0.67%)
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Year # 4

* Rent increased 3.50% to $2,638
* Owner Home value increased 3.70% to $335,246
* Landlord Home value increased 3.70% to $335,246
* Renters insurance increased 2.00% to $16.24
* Home owner's insurance increased 2.00% to $180.41
* HOA increased 2.00% to $0.00

---

Landlord in month # 49

* Received rent of $2,638
* Loan payment of $1,405 ($658 principal / $747 interest)
* New loan balance of $188,052
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,057 leaving cash of ($77)
* Net taxable income of $581
* Allowed monthly depreciation of $703 + carry-over of $14,053
* Used depreciation of $581 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,175
* Required personal loan of $77 creating a balance of $9,091
* Monthly expenses $2,057 + principle of $658 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $504

---

Owner in month # 49

* Loan payment of $1,141 ($379 principal / $762 interest)
* New loan balance of $214,852
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 49

* Investment of $82,618 grew by $547 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 50

* Received rent of $2,638
* Loan payment of $1,405 ($661 principal / $744 interest)
* New loan balance of $187,391
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,054 leaving cash of ($77)
* Net taxable income of $584
* Allowed monthly depreciation of $703 + carry-over of $14,175
* Used depreciation of $584 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,294
* Required personal loan of $77 creating a balance of $9,168
* Monthly expenses $2,054 + principle of $661 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $507

---

Owner in month # 50

* Loan payment of $1,141 ($380 principal / $761 interest)
* New loan balance of $214,472
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 50

* Investment of $83,169 grew by $551 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 51

* Received rent of $2,638
* Loan payment of $1,405 ($663 principal / $742 interest)
* New loan balance of $186,728
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,052 leaving cash of ($77)
* Net taxable income of $586
* Allowed monthly depreciation of $703 + carry-over of $14,294
* Used depreciation of $586 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,411
* Required personal loan of $77 creating a balance of $9,245
* Monthly expenses $2,052 + principle of $663 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $509

---

Owner in month # 51

* Loan payment of $1,141 ($381 principal / $760 interest)
* New loan balance of $214,091
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 51

* Investment of $83,723 grew by $554 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 52

* Received rent of $2,638
* Loan payment of $1,405 ($666 principal / $739 interest)
* New loan balance of $186,062
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,049 leaving cash of ($77)
* Net taxable income of $589
* Allowed monthly depreciation of $703 + carry-over of $14,411
* Used depreciation of $589 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,525
* Required personal loan of $77 creating a balance of $9,323
* Monthly expenses $2,049 + principle of $666 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $512

---

Owner in month # 52

* Loan payment of $1,141 ($383 principal / $758 interest)
* New loan balance of $213,708
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 52

* Investment of $84,281 grew by $558 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 53

* Received rent of $2,638
* Loan payment of $1,405 ($669 principal / $736 interest)
* New loan balance of $185,393
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,046 leaving cash of ($77)
* Net taxable income of $592
* Allowed monthly depreciation of $703 + carry-over of $14,525
* Used depreciation of $592 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,636
* Required personal loan of $77 creating a balance of $9,400
* Monthly expenses $2,046 + principle of $669 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $515

---

Owner in month # 53

* Loan payment of $1,141 ($384 principal / $757 interest)
* New loan balance of $213,324
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 53

* Investment of $84,843 grew by $562 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 54

* Received rent of $2,638
* Loan payment of $1,405 ($671 principal / $734 interest)
* New loan balance of $184,722
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,044 leaving cash of ($77)
* Net taxable income of $594
* Allowed monthly depreciation of $703 + carry-over of $14,636
* Used depreciation of $594 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,745
* Required personal loan of $77 creating a balance of $9,477
* Monthly expenses $2,044 + principle of $671 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $517

---

Owner in month # 54

* Loan payment of $1,141 ($385 principal / $756 interest)
* New loan balance of $212,939
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 54

* Investment of $85,409 grew by $566 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 55

* Received rent of $2,638
* Loan payment of $1,405 ($674 principal / $731 interest)
* New loan balance of $184,048
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,041 leaving cash of ($77)
* Net taxable income of $597
* Allowed monthly depreciation of $703 + carry-over of $14,745
* Used depreciation of $597 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,851
* Required personal loan of $77 creating a balance of $9,554
* Monthly expenses $2,041 + principle of $674 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $520

---

Owner in month # 55

* Loan payment of $1,141 ($387 principal / $754 interest)
* New loan balance of $212,552
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 55

* Investment of $85,978 grew by $569 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 56

* Received rent of $2,638
* Loan payment of $1,405 ($676 principal / $729 interest)
* New loan balance of $183,372
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,039 leaving cash of ($77)
* Net taxable income of $599
* Allowed monthly depreciation of $703 + carry-over of $14,851
* Used depreciation of $599 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,955
* Required personal loan of $77 creating a balance of $9,631
* Monthly expenses $2,039 + principle of $676 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $522

---

Owner in month # 56

* Loan payment of $1,141 ($388 principal / $753 interest)
* New loan balance of $212,164
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 56

* Investment of $86,551 grew by $573 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 57

* Received rent of $2,638
* Loan payment of $1,405 ($679 principal / $726 interest)
* New loan balance of $182,693
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,036 leaving cash of ($77)
* Net taxable income of $602
* Allowed monthly depreciation of $703 + carry-over of $14,955
* Used depreciation of $602 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,056
* Required personal loan of $77 creating a balance of $9,709
* Monthly expenses $2,036 + principle of $679 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $525

---

Owner in month # 57

* Loan payment of $1,141 ($390 principal / $751 interest)
* New loan balance of $211,774
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 57

* Investment of $87,128 grew by $577 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 58

* Received rent of $2,638
* Loan payment of $1,405 ($682 principal / $723 interest)
* New loan balance of $182,011
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,033 leaving cash of ($77)
* Net taxable income of $605
* Allowed monthly depreciation of $703 + carry-over of $15,056
* Used depreciation of $605 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,154
* Required personal loan of $77 creating a balance of $9,786
* Monthly expenses $2,033 + principle of $682 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $528

---

Owner in month # 58

* Loan payment of $1,141 ($391 principal / $750 interest)
* New loan balance of $211,383
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 58

* Investment of $87,709 grew by $581 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 59

* Received rent of $2,638
* Loan payment of $1,405 ($685 principal / $720 interest)
* New loan balance of $181,326
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,030 leaving cash of ($77)
* Net taxable income of $608
* Allowed monthly depreciation of $703 + carry-over of $15,154
* Used depreciation of $608 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,249
* Required personal loan of $77 creating a balance of $9,863
* Monthly expenses $2,030 + principle of $685 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $531

---

Owner in month # 59

* Loan payment of $1,141 ($392 principal / $749 interest)
* New loan balance of $210,991
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 59

* Investment of $88,294 grew by $585 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 60

* Received rent of $2,638
* Loan payment of $1,405 ($687 principal / $718 interest)
* New loan balance of $180,639
* Management fee of $264
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance
* Total monthly expenses of $2,028 leaving cash of ($77)
* Net taxable income of $610
* Allowed monthly depreciation of $703 + carry-over of $15,249
* Used depreciation of $610 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,342
* Required personal loan of $77 creating a balance of $9,940
* Monthly expenses $2,028 + principle of $687 = $2,715 against rent of $2,638
* Negative cash flow of ($77)
* NPV cash flow of $533

---

Owner in month # 60

* Loan payment of $1,141 ($394 principal / $747 interest)
* New loan balance of $210,597
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $279 on home maintenance

---

Renter in month # 60

* Investment of $88,882 grew by $589 (0.67%)
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Year # 5

* Rent increased 3.50% to $2,730
* Owner Home value increased 3.70% to $347,650
* Landlord Home value increased 3.70% to $347,650
* Renters insurance increased 2.00% to $16.56
* Home owner's insurance increased 2.00% to $184.02
* HOA increased 2.00% to $0.00

---

Landlord in month # 61

* Received rent of $2,730
* Loan payment of $1,405 ($690 principal / $715 interest)
* New loan balance of $179,949
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,070 leaving cash of ($30)
* Net taxable income of $660
* Allowed monthly depreciation of $703 + carry-over of $15,342
* Used depreciation of $660 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,385
* Required personal loan of $30 creating a balance of $9,970
* Monthly expenses $2,070 + principle of $690 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $630

---

Owner in month # 61

* Loan payment of $1,141 ($395 principal / $746 interest)
* New loan balance of $210,202
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 61

* Investment of $89,475 grew by $593 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 62

* Received rent of $2,730
* Loan payment of $1,405 ($693 principal / $712 interest)
* New loan balance of $179,256
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,067 leaving cash of ($30)
* Net taxable income of $663
* Allowed monthly depreciation of $703 + carry-over of $15,385
* Used depreciation of $663 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,425
* Required personal loan of $30 creating a balance of $10,000
* Monthly expenses $2,067 + principle of $693 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $633

---

Owner in month # 62

* Loan payment of $1,141 ($397 principal / $744 interest)
* New loan balance of $209,805
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 62

* Investment of $90,072 grew by $597 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 63

* Received rent of $2,730
* Loan payment of $1,405 ($695 principal / $710 interest)
* New loan balance of $178,561
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,065 leaving cash of ($30)
* Net taxable income of $665
* Allowed monthly depreciation of $703 + carry-over of $15,425
* Used depreciation of $665 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,463
* Required personal loan of $30 creating a balance of $10,030
* Monthly expenses $2,065 + principle of $695 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $635

---

Owner in month # 63

* Loan payment of $1,141 ($398 principal / $743 interest)
* New loan balance of $209,407
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 63

* Investment of $90,672 grew by $600 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 64

* Received rent of $2,730
* Loan payment of $1,405 ($698 principal / $707 interest)
* New loan balance of $177,863
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,062 leaving cash of ($30)
* Net taxable income of $668
* Allowed monthly depreciation of $703 + carry-over of $15,463
* Used depreciation of $668 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,498
* Required personal loan of $30 creating a balance of $10,060
* Monthly expenses $2,062 + principle of $698 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $638

---

Owner in month # 64

* Loan payment of $1,141 ($399 principal / $742 interest)
* New loan balance of $209,008
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 64

* Investment of $91,276 grew by $604 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 65

* Received rent of $2,730
* Loan payment of $1,405 ($701 principal / $704 interest)
* New loan balance of $177,162
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,059 leaving cash of ($30)
* Net taxable income of $671
* Allowed monthly depreciation of $703 + carry-over of $15,498
* Used depreciation of $671 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,530
* Required personal loan of $30 creating a balance of $10,090
* Monthly expenses $2,059 + principle of $701 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $641

---

Owner in month # 65

* Loan payment of $1,141 ($401 principal / $740 interest)
* New loan balance of $208,607
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 65

* Investment of $91,885 grew by $609 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 66

* Received rent of $2,730
* Loan payment of $1,405 ($704 principal / $701 interest)
* New loan balance of $176,458
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,056 leaving cash of ($30)
* Net taxable income of $674
* Allowed monthly depreciation of $703 + carry-over of $15,530
* Used depreciation of $674 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,559
* Required personal loan of $30 creating a balance of $10,120
* Monthly expenses $2,056 + principle of $704 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $644

---

Owner in month # 66

* Loan payment of $1,141 ($402 principal / $739 interest)
* New loan balance of $208,205
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 66

* Investment of $92,498 grew by $613 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 67

* Received rent of $2,730
* Loan payment of $1,405 ($707 principal / $698 interest)
* New loan balance of $175,751
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,053 leaving cash of ($30)
* Net taxable income of $677
* Allowed monthly depreciation of $703 + carry-over of $15,559
* Used depreciation of $677 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,585
* Required personal loan of $30 creating a balance of $10,150
* Monthly expenses $2,053 + principle of $707 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $647

---

Owner in month # 67

* Loan payment of $1,141 ($404 principal / $737 interest)
* New loan balance of $207,801
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 67

* Investment of $93,114 grew by $617 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 68

* Received rent of $2,730
* Loan payment of $1,405 ($709 principal / $696 interest)
* New loan balance of $175,042
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,051 leaving cash of ($30)
* Net taxable income of $679
* Allowed monthly depreciation of $703 + carry-over of $15,585
* Used depreciation of $679 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,609
* Required personal loan of $30 creating a balance of $10,180
* Monthly expenses $2,051 + principle of $709 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $649

---

Owner in month # 68

* Loan payment of $1,141 ($405 principal / $736 interest)
* New loan balance of $207,396
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 68

* Investment of $93,735 grew by $621 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 69

* Received rent of $2,730
* Loan payment of $1,405 ($712 principal / $693 interest)
* New loan balance of $174,330
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,048 leaving cash of ($30)
* Net taxable income of $682
* Allowed monthly depreciation of $703 + carry-over of $15,609
* Used depreciation of $682 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,630
* Required personal loan of $30 creating a balance of $10,210
* Monthly expenses $2,048 + principle of $712 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $652

---

Owner in month # 69

* Loan payment of $1,141 ($406 principal / $735 interest)
* New loan balance of $206,990
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 69

* Investment of $94,360 grew by $625 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 70

* Received rent of $2,730
* Loan payment of $1,405 ($715 principal / $690 interest)
* New loan balance of $173,615
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,045 leaving cash of ($30)
* Net taxable income of $685
* Allowed monthly depreciation of $703 + carry-over of $15,630
* Used depreciation of $685 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,648
* Required personal loan of $30 creating a balance of $10,240
* Monthly expenses $2,045 + principle of $715 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $655

---

Owner in month # 70

* Loan payment of $1,141 ($408 principal / $733 interest)
* New loan balance of $206,582
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 70

* Investment of $94,989 grew by $629 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 71

* Received rent of $2,730
* Loan payment of $1,405 ($718 principal / $687 interest)
* New loan balance of $172,897
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,042 leaving cash of ($30)
* Net taxable income of $688
* Allowed monthly depreciation of $703 + carry-over of $15,648
* Used depreciation of $688 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,663
* Required personal loan of $30 creating a balance of $10,270
* Monthly expenses $2,042 + principle of $718 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $658

---

Owner in month # 71

* Loan payment of $1,141 ($409 principal / $732 interest)
* New loan balance of $206,173
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 71

* Investment of $95,622 grew by $633 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 72

* Received rent of $2,730
* Loan payment of $1,405 ($721 principal / $684 interest)
* New loan balance of $172,176
* Management fee of $273
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance
* Total monthly expenses of $2,039 leaving cash of ($30)
* Net taxable income of $691
* Allowed monthly depreciation of $703 + carry-over of $15,663
* Used depreciation of $691 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,675
* Required personal loan of $30 creating a balance of $10,300
* Monthly expenses $2,039 + principle of $721 = $2,760 against rent of $2,730
* Negative cash flow of ($30)
* NPV cash flow of $661

---

Owner in month # 72

* Loan payment of $1,141 ($411 principal / $730 interest)
* New loan balance of $205,762
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $290 on home maintenance

---

Renter in month # 72

* Investment of $96,260 grew by $637 (0.67%)
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Year # 6

* Rent increased 3.50% to $2,826
* Owner Home value increased 3.70% to $360,513
* Landlord Home value increased 3.70% to $360,513
* Renters insurance increased 2.00% to $16.89
* Home owner's insurance increased 2.00% to $187.70
* HOA increased 2.00% to $0.00

---

Landlord in month # 73

* Received rent of $2,826
* Loan payment of $1,405 ($723 principal / $682 interest)
* New loan balance of $171,453
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,083 leaving cash of $20
* Net taxable income of $743
* Allowed monthly depreciation of $703 + carry-over of $15,675
* Used depreciation of $743 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,635
* Paid back $20 of personal loan leaving a balance of $10,281 and cash of $0
* NPV cash flow of $762

---

Owner in month # 73

* Loan payment of $1,141 ($412 principal / $729 interest)
* New loan balance of $205,350
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 73

* Investment of $96,901 grew by $642 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 74

* Received rent of $2,826
* Loan payment of $1,405 ($726 principal / $679 interest)
* New loan balance of $170,727
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,080 leaving cash of $20
* Net taxable income of $746
* Allowed monthly depreciation of $703 + carry-over of $15,635
* Used depreciation of $746 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,592
* Paid back $20 of personal loan leaving a balance of $10,261 and cash of $0
* NPV cash flow of $765

---

Owner in month # 74

* Loan payment of $1,141 ($414 principal / $727 interest)
* New loan balance of $204,936
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 74

* Investment of $97,547 grew by $646 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 75

* Received rent of $2,826
* Loan payment of $1,405 ($729 principal / $676 interest)
* New loan balance of $169,998
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,077 leaving cash of $20
* Net taxable income of $749
* Allowed monthly depreciation of $703 + carry-over of $15,592
* Used depreciation of $749 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,546
* Paid back $20 of personal loan leaving a balance of $10,241 and cash of $0
* NPV cash flow of $768

---

Owner in month # 75

* Loan payment of $1,141 ($415 principal / $726 interest)
* New loan balance of $204,521
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 75

* Investment of $98,198 grew by $650 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 76

* Received rent of $2,826
* Loan payment of $1,405 ($732 principal / $673 interest)
* New loan balance of $169,266
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,074 leaving cash of $20
* Net taxable income of $752
* Allowed monthly depreciation of $703 + carry-over of $15,546
* Used depreciation of $752 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,497
* Paid back $20 of personal loan leaving a balance of $10,222 and cash of $0
* NPV cash flow of $771

---

Owner in month # 76

* Loan payment of $1,141 ($417 principal / $724 interest)
* New loan balance of $204,104
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 76

* Investment of $98,852 grew by $655 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 77

* Received rent of $2,826
* Loan payment of $1,405 ($735 principal / $670 interest)
* New loan balance of $168,531
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,071 leaving cash of $20
* Net taxable income of $755
* Allowed monthly depreciation of $703 + carry-over of $15,497
* Used depreciation of $755 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,445
* Paid back $20 of personal loan leaving a balance of $10,202 and cash of $0
* NPV cash flow of $774

---

Owner in month # 77

* Loan payment of $1,141 ($418 principal / $723 interest)
* New loan balance of $203,686
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 77

* Investment of $99,511 grew by $659 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 78

* Received rent of $2,826
* Loan payment of $1,405 ($738 principal / $667 interest)
* New loan balance of $167,793
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,068 leaving cash of $20
* Net taxable income of $758
* Allowed monthly depreciation of $703 + carry-over of $15,445
* Used depreciation of $758 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,390
* Paid back $20 of personal loan leaving a balance of $10,182 and cash of $0
* NPV cash flow of $777

---

Owner in month # 78

* Loan payment of $1,141 ($420 principal / $721 interest)
* New loan balance of $203,266
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 78

* Investment of $100,175 grew by $663 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 79

* Received rent of $2,826
* Loan payment of $1,405 ($741 principal / $664 interest)
* New loan balance of $167,052
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,065 leaving cash of $20
* Net taxable income of $761
* Allowed monthly depreciation of $703 + carry-over of $15,390
* Used depreciation of $761 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,332
* Paid back $20 of personal loan leaving a balance of $10,163 and cash of $0
* NPV cash flow of $780

---

Owner in month # 79

* Loan payment of $1,141 ($421 principal / $720 interest)
* New loan balance of $202,845
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 79

* Investment of $100,843 grew by $668 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 80

* Received rent of $2,826
* Loan payment of $1,405 ($744 principal / $661 interest)
* New loan balance of $166,308
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,062 leaving cash of $20
* Net taxable income of $764
* Allowed monthly depreciation of $703 + carry-over of $15,332
* Used depreciation of $764 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,271
* Paid back $20 of personal loan leaving a balance of $10,143 and cash of $0
* NPV cash flow of $783

---

Owner in month # 80

* Loan payment of $1,141 ($423 principal / $718 interest)
* New loan balance of $202,422
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 80

* Investment of $101,515 grew by $672 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 81

* Received rent of $2,826
* Loan payment of $1,405 ($747 principal / $658 interest)
* New loan balance of $165,561
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,059 leaving cash of $20
* Net taxable income of $767
* Allowed monthly depreciation of $703 + carry-over of $15,271
* Used depreciation of $767 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,207
* Paid back $20 of personal loan leaving a balance of $10,123 and cash of $0
* NPV cash flow of $786

---

Owner in month # 81

* Loan payment of $1,141 ($424 principal / $717 interest)
* New loan balance of $201,998
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 81

* Investment of $102,192 grew by $677 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 82

* Received rent of $2,826
* Loan payment of $1,405 ($750 principal / $655 interest)
* New loan balance of $164,811
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,056 leaving cash of $20
* Net taxable income of $770
* Allowed monthly depreciation of $703 + carry-over of $15,207
* Used depreciation of $770 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,140
* Paid back $20 of personal loan leaving a balance of $10,103 and cash of $0
* NPV cash flow of $789

---

Owner in month # 82

* Loan payment of $1,141 ($426 principal / $715 interest)
* New loan balance of $201,572
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 82

* Investment of $102,873 grew by $681 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 83

* Received rent of $2,826
* Loan payment of $1,405 ($753 principal / $652 interest)
* New loan balance of $164,058
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,053 leaving cash of $20
* Net taxable income of $773
* Allowed monthly depreciation of $703 + carry-over of $15,140
* Used depreciation of $773 resulting in adjusted taxable income of $0
* Carry over depreciation of $15,070
* Paid back $20 of personal loan leaving a balance of $10,084 and cash of $0
* NPV cash flow of $792

---

Owner in month # 83

* Loan payment of $1,141 ($427 principal / $714 interest)
* New loan balance of $201,145
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 83

* Investment of $103,559 grew by $686 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 84

* Received rent of $2,826
* Loan payment of $1,405 ($756 principal / $649 interest)
* New loan balance of $163,302
* Management fee of $283
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance
* Total monthly expenses of $2,050 leaving cash of $20
* Net taxable income of $776
* Allowed monthly depreciation of $703 + carry-over of $15,070
* Used depreciation of $776 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,997
* Paid back $20 of personal loan leaving a balance of $10,064 and cash of $0
* NPV cash flow of $795

---

Owner in month # 84

* Loan payment of $1,141 ($429 principal / $712 interest)
* New loan balance of $200,716
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $300 on home maintenance

---

Renter in month # 84

* Investment of $104,249 grew by $690 (0.67%)
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Year # 7

* Rent increased 3.50% to $2,925
* Owner Home value increased 3.70% to $373,852
* Landlord Home value increased 3.70% to $373,852
* Renters insurance increased 2.00% to $17.23
* Home owner's insurance increased 2.00% to $191.45
* HOA increased 2.00% to $0.00

---

Landlord in month # 85

* Received rent of $2,925
* Loan payment of $1,405 ($759 principal / $646 interest)
* New loan balance of $162,543
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,096 leaving cash of $70
* Net taxable income of $829
* Allowed monthly depreciation of $703 + carry-over of $14,997
* Used depreciation of $829 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,871
* Paid back $70 of personal loan leaving a balance of $9,994 and cash of $0
* NPV cash flow of $899

---

Owner in month # 85

* Loan payment of $1,141 ($430 principal / $711 interest)
* New loan balance of $200,286
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 85

* Investment of $104,944 grew by $695 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 86

* Received rent of $2,925
* Loan payment of $1,405 ($762 principal / $643 interest)
* New loan balance of $161,781
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,093 leaving cash of $70
* Net taxable income of $832
* Allowed monthly depreciation of $703 + carry-over of $14,871
* Used depreciation of $832 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,742
* Paid back $70 of personal loan leaving a balance of $9,924 and cash of $0
* NPV cash flow of $902

---

Owner in month # 86

* Loan payment of $1,141 ($432 principal / $709 interest)
* New loan balance of $199,854
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 86

* Investment of $105,644 grew by $700 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 87

* Received rent of $2,925
* Loan payment of $1,405 ($765 principal / $640 interest)
* New loan balance of $161,016
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,090 leaving cash of $70
* Net taxable income of $835
* Allowed monthly depreciation of $703 + carry-over of $14,742
* Used depreciation of $835 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,610
* Paid back $70 of personal loan leaving a balance of $9,854 and cash of $0
* NPV cash flow of $905

---

Owner in month # 87

* Loan payment of $1,141 ($433 principal / $708 interest)
* New loan balance of $199,421
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 87

* Investment of $106,348 grew by $704 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 88

* Received rent of $2,925
* Loan payment of $1,405 ($768 principal / $637 interest)
* New loan balance of $160,248
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,087 leaving cash of $70
* Net taxable income of $838
* Allowed monthly depreciation of $703 + carry-over of $14,610
* Used depreciation of $838 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,475
* Paid back $70 of personal loan leaving a balance of $9,784 and cash of $0
* NPV cash flow of $908

---

Owner in month # 88

* Loan payment of $1,141 ($435 principal / $706 interest)
* New loan balance of $198,986
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 88

* Investment of $107,057 grew by $709 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 89

* Received rent of $2,925
* Loan payment of $1,405 ($771 principal / $634 interest)
* New loan balance of $159,477
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,084 leaving cash of $70
* Net taxable income of $841
* Allowed monthly depreciation of $703 + carry-over of $14,475
* Used depreciation of $841 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,337
* Paid back $70 of personal loan leaving a balance of $9,714 and cash of $0
* NPV cash flow of $911

---

Owner in month # 89

* Loan payment of $1,141 ($436 principal / $705 interest)
* New loan balance of $198,550
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 89

* Investment of $107,771 grew by $714 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 90

* Received rent of $2,925
* Loan payment of $1,405 ($774 principal / $631 interest)
* New loan balance of $158,703
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,081 leaving cash of $70
* Net taxable income of $844
* Allowed monthly depreciation of $703 + carry-over of $14,337
* Used depreciation of $844 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,196
* Paid back $70 of personal loan leaving a balance of $9,644 and cash of $0
* NPV cash flow of $914

---

Owner in month # 90

* Loan payment of $1,141 ($438 principal / $703 interest)
* New loan balance of $198,112
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 90

* Investment of $108,489 grew by $718 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 91

* Received rent of $2,925
* Loan payment of $1,405 ($777 principal / $628 interest)
* New loan balance of $157,926
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,078 leaving cash of $70
* Net taxable income of $847
* Allowed monthly depreciation of $703 + carry-over of $14,196
* Used depreciation of $847 resulting in adjusted taxable income of $0
* Carry over depreciation of $14,052
* Paid back $70 of personal loan leaving a balance of $9,574 and cash of $0
* NPV cash flow of $917

---

Owner in month # 91

* Loan payment of $1,141 ($439 principal / $702 interest)
* New loan balance of $197,673
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 91

* Investment of $109,213 grew by $723 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 92

* Received rent of $2,925
* Loan payment of $1,405 ($780 principal / $625 interest)
* New loan balance of $157,146
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,075 leaving cash of $70
* Net taxable income of $850
* Allowed monthly depreciation of $703 + carry-over of $14,052
* Used depreciation of $850 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,905
* Paid back $70 of personal loan leaving a balance of $9,504 and cash of $0
* NPV cash flow of $920

---

Owner in month # 92

* Loan payment of $1,141 ($441 principal / $700 interest)
* New loan balance of $197,232
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 92

* Investment of $109,941 grew by $728 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 93

* Received rent of $2,925
* Loan payment of $1,405 ($783 principal / $622 interest)
* New loan balance of $156,363
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,072 leaving cash of $70
* Net taxable income of $853
* Allowed monthly depreciation of $703 + carry-over of $13,905
* Used depreciation of $853 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,755
* Paid back $70 of personal loan leaving a balance of $9,434 and cash of $0
* NPV cash flow of $923

---

Owner in month # 93

* Loan payment of $1,141 ($442 principal / $699 interest)
* New loan balance of $196,790
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 93

* Investment of $110,674 grew by $733 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 94

* Received rent of $2,925
* Loan payment of $1,405 ($786 principal / $619 interest)
* New loan balance of $155,577
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,069 leaving cash of $70
* Net taxable income of $856
* Allowed monthly depreciation of $703 + carry-over of $13,755
* Used depreciation of $856 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,602
* Paid back $70 of personal loan leaving a balance of $9,364 and cash of $0
* NPV cash flow of $926

---

Owner in month # 94

* Loan payment of $1,141 ($444 principal / $697 interest)
* New loan balance of $196,346
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 94

* Investment of $111,411 grew by $738 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 95

* Received rent of $2,925
* Loan payment of $1,405 ($789 principal / $616 interest)
* New loan balance of $154,788
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,066 leaving cash of $70
* Net taxable income of $859
* Allowed monthly depreciation of $703 + carry-over of $13,602
* Used depreciation of $859 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,446
* Paid back $70 of personal loan leaving a balance of $9,293 and cash of $0
* NPV cash flow of $929

---

Owner in month # 95

* Loan payment of $1,141 ($446 principal / $695 interest)
* New loan balance of $195,900
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 95

* Investment of $112,154 grew by $743 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 96

* Received rent of $2,925
* Loan payment of $1,405 ($792 principal / $613 interest)
* New loan balance of $153,996
* Management fee of $293
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance
* Total monthly expenses of $2,063 leaving cash of $70
* Net taxable income of $862
* Allowed monthly depreciation of $703 + carry-over of $13,446
* Used depreciation of $862 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,287
* Paid back $70 of personal loan leaving a balance of $9,223 and cash of $0
* NPV cash flow of $932

---

Owner in month # 96

* Loan payment of $1,141 ($447 principal / $694 interest)
* New loan balance of $195,453
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $312 on home maintenance

---

Renter in month # 96

* Investment of $112,902 grew by $748 (0.67%)
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Year # 8

* Rent increased 3.50% to $3,027
* Owner Home value increased 3.70% to $387,685
* Landlord Home value increased 3.70% to $387,685
* Renters insurance increased 2.00% to $17.57
* Home owner's insurance increased 2.00% to $195.28
* HOA increased 2.00% to $0.00

---

Landlord in month # 97

* Received rent of $3,027
* Loan payment of $1,405 ($795 principal / $610 interest)
* New loan balance of $153,201
* Management fee of $303
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $2,109 leaving cash of $123
* Net taxable income of $918
* Allowed monthly depreciation of $703 + carry-over of $13,287
* Used depreciation of $918 resulting in adjusted taxable income of $0
* Carry over depreciation of $13,072
* Paid back $123 of personal loan leaving a balance of $9,100 and cash of $0
* NPV cash flow of $1,041

---

Owner in month # 97

* Loan payment of $1,141 ($449 principal / $692 interest)
* New loan balance of $195,004
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance

---

Renter in month # 97

* Investment of $113,654 grew by $753 (0.67%)
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 98

* Received rent of $3,027
* Loan payment of $1,405 ($799 principal / $606 interest)
* New loan balance of $152,402
* Management fee of $303
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $2,105 leaving cash of $123
* Net taxable income of $922
* Allowed monthly depreciation of $703 + carry-over of $13,072
* Used depreciation of $922 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,853
* Paid back $123 of personal loan leaving a balance of $8,977 and cash of $0
* NPV cash flow of $1,045

---

Owner in month # 98

* Loan payment of $1,141 ($450 principal / $691 interest)
* New loan balance of $194,554
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance

---

Renter in month # 98

* Investment of $114,412 grew by $758 (0.67%)
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 99

* Received rent of $3,027
* Loan payment of $1,405 ($802 principal / $603 interest)
* New loan balance of $151,600
* Management fee of $303
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $2,102 leaving cash of $123
* Net taxable income of $925
* Allowed monthly depreciation of $703 + carry-over of $12,853
* Used depreciation of $925 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,631
* Paid back $123 of personal loan leaving a balance of $8,854 and cash of $0
* NPV cash flow of $1,048

---

Owner in month # 99

* Loan payment of $1,141 ($452 principal / $689 interest)
* New loan balance of $194,102
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance

---

Renter in month # 99

* Investment of $115,175 grew by $763 (0.67%)
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 100

* Received rent of $3,027
* Loan payment of $1,405 ($805 principal / $600 interest)
* New loan balance of $150,795
* Management fee of $303
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $2,099 leaving cash of $123
* Net taxable income of $928
* Allowed monthly depreciation of $703 + carry-over of $12,631
* Used depreciation of $928 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,406
* Paid back $123 of personal loan leaving a balance of $8,731 and cash of $0
* NPV cash flow of $1,051

---

Owner in month # 100

* Loan payment of $1,141 ($454 principal / $687 interest)
* New loan balance of $193,648
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance

---

Renter in month # 100

* Investment of $115,943 grew by $768 (0.67%)
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 101

* Received rent of $3,027
* Loan payment of $1,405 ($808 principal / $597 interest)
* New loan balance of $149,987
* Management fee of $303
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $2,096 leaving cash of $123
* Net taxable income of $931
* Allowed monthly depreciation of $703 + carry-over of $12,406
* Used depreciation of $931 resulting in adjusted taxable income of $0
* Carry over depreciation of $12,178
* Paid back $123 of personal loan leaving a balance of $8,608 and cash of $0
* NPV cash flow of $1,054

---

Owner in month # 101

* Loan payment of $1,141 ($455 principal / $686 interest)
* New loan balance of $193,193
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance

---

Renter in month # 101

* Investment of $116,716 grew by $773 (0.67%)
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 102

* Received rent of $3,027
* Loan payment of $1,405 ($811 principal / $594 interest)
* New loan balance of $149,176
* Management fee of $303
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $2,093 leaving cash of $123
* Net taxable income of $934
* Allowed monthly depreciation of $703 + carry-over of $12,178
* Used depreciation of $934 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,947
* Paid back $123 of personal loan leaving a balance of $8,485 and cash of $0
* NPV cash flow of $1,057

---

Owner in month # 102

* Loan payment of $1,141 ($457 principal / $684 interest)
* New loan balance of $192,736
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance

---

Renter in month # 102

* Investment of $117,494 grew by $778 (0.67%)
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 103

* Received rent of $3,027
* Loan payment of $1,405 ($815 principal / $590 interest)
* New loan balance of $148,361
* Management fee of $303
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $2,089 leaving cash of $123
* Net taxable income of $938
* Allowed monthly depreciation of $703 + carry-over of $11,947
* Used depreciation of $938 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,712
* Paid back $123 of personal loan leaving a balance of $8,362 and cash of $0
* NPV cash flow of $1,061

---

Owner in month # 103

* Loan payment of $1,141 ($458 principal / $683 interest)
* New loan balance of $192,278
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance

---

Renter in month # 103

* Investment of $118,277 grew by $783 (0.67%)
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 104

* Received rent of $3,027
* Loan payment of $1,405 ($818 principal / $587 interest)
* New loan balance of $147,543
* Management fee of $303
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance
* Total monthly expenses of $2,086 leaving cash of $123
* Net taxable income of $941
* Allowed monthly depreciation of $703 + carry-over of $11,712
* Used depreciation of $941 resulting in adjusted taxable income of $0
* Carry over depreciation of $11,474
* Paid back $123 of personal loan leaving a balance of $8,239 and cash of $0
* NPV cash flow of $1,064
* Sold home for $387,685
* Fixed sales costs of $1,000 and commission of $23,261 leaving proceeds of $363,424
* Total gain from sale of $77,285
* Paid depreciation recapture taxes of $14,793 on $61,638
* Paid capital gains taxes of $2,347 on $15,647
* Paid off loan balance of $147,543
* Closed out personal loan of $8,239
* Net home sale proceeds of $190,502
* Total cash on hand of $190,502
* Adjusted NPV cash flow of $191,566 accounting for sale proceeds of $190,502
* Net present value of $53,061
* Internal rate of return of 14.89%

---

Owner in month # 104

* Loan payment of $1,141 ($460 principal / $681 interest)
* New loan balance of $191,818
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $323 on home maintenance
* Sold home for $387,685
* Fixed sales costs of $1,000 and commission of $23,261
* Paid off loan balance of $191,818
* Home sale proceeds of $171,606

---

Renter in month # 104

* Investment of $119,066 grew by $789 (0.67%)
* Spent $3,027 on rent
* Spent $18 on renters insurance
* Capital gains of $59,407 on initial investment of $59,659
* Capital gains tax of $8,911
* Cashed out investment of $119,066
* Returned security deposit of $2,300
* Cash on hand of $112,455
* Total spent $275,634

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
|RentChangePerYearPercentage|3.50%|
|Rent|$3,027|
|RentSecurityDepositMonths|1|
|RentersInsurancePerMonth|$18|
|LandlordInterestRate|4.75%|
|LandlordLoanYears|20|
|LandlordDownPaymentPercentage|25.00%|
|LandlordDownPayment|$72,475|
|LandlordLoanAmount|$217,425|
|LandlordHomeValue|$0|
|LandlordLoanBalance|$0|
|LandlordMonthlyPayment|$1,405|
|LandlordManagementFeePercentage|10.00%|
|DepreciationYears|27.50|
|DepreciablePercentage|80.00%|
|ClosingFixedCosts|$500|
|ClosingVariableCostsPercentage|1.50%|
|PropertyTaxPercentage|2.10%|
|InsurancePerMonth|$195|
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

Landlord received total rent of $273,948 (average of $2,634 / month), total expenses of $253,706 (average of $2,439 / month), and has net worth of $190,502 on initial investment of $76,236
Net present value of $53,061
Internal rate of return of 14.89%

---

Owner spent $227,336 (average of $2,186 / month) and has net worth of $171,606 on initial investment of $61,959

---

Renter spent $275,634 (average of $2,650 / month) and has net worth of $112,455 on initial investment of $59,659
