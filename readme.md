# Rent vs Own Simulation

An application that simulates owning, renting and being a landlord of a property.

## Sample Run

|Default Simulator||
| --- | --: |
|Years|8.70|
|Months|104|
|HomePurchaseAmount|$289,900|
|HomeValue|$289,900|
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
|HoaPerMonth|$100|
|HomeAppreciationPercentagePerYear|3.70%|
|HomeMaintenancePercentagePerYear|1.50%|
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
* Initial loan balance of $217,425
* Received rent of $2,300
* Loan payment of $1,405 ($544 principal / $861 interest)
* New loan balance of $216,881
* Management fee of $230
* Loan payment of $1,405 ($547 principal / $858 interest)
* New loan balance of $216,334
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,227
* Net income of $1,439
* Allowed monthly depreciation of $703 + carry-over of $0
* Taxable income of $1,439 ($1,439 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,439 leaving balance of $214,895

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
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 1

* Security deposit of $2,300
* Invested  $288,100
* Investment grew by $1,921
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 2

* Received rent of $2,300
* Loan payment of $1,405 ($554 principal / $851 interest)
* New loan balance of $214,341
* Management fee of $230
* Loan payment of $1,405 ($557 principal / $848 interest)
* New loan balance of $213,784
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,217
* Net income of $1,449
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $746 ($2,185 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,449 leaving balance of $212,335

---

Owner in month # 2

* Loan payment of $1,141 ($321 principal / $820 interest)
* New loan balance of $231,279
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 2

* Investment grew by $1,933
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 3

* Received rent of $2,300
* Loan payment of $1,405 ($565 principal / $840 interest)
* New loan balance of $211,770
* Management fee of $230
* Loan payment of $1,405 ($567 principal / $838 interest)
* New loan balance of $211,203
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,206
* Net income of $1,460
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $757 ($2,942 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,460 leaving balance of $209,743

---

Owner in month # 3

* Loan payment of $1,141 ($322 principal / $819 interest)
* New loan balance of $230,957
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 3

* Investment grew by $1,946
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 4

* Received rent of $2,300
* Loan payment of $1,405 ($575 principal / $830 interest)
* New loan balance of $209,168
* Management fee of $230
* Loan payment of $1,405 ($577 principal / $828 interest)
* New loan balance of $208,591
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,196
* Net income of $1,470
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $767 ($3,710 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,470 leaving balance of $207,121

---

Owner in month # 4

* Loan payment of $1,141 ($323 principal / $818 interest)
* New loan balance of $230,634
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 4

* Investment grew by $1,959
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 5

* Received rent of $2,300
* Loan payment of $1,405 ($585 principal / $820 interest)
* New loan balance of $206,536
* Management fee of $230
* Loan payment of $1,405 ($587 principal / $818 interest)
* New loan balance of $205,949
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,186
* Net income of $1,480
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $777 ($4,487 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,480 leaving balance of $204,469

---

Owner in month # 5

* Loan payment of $1,141 ($324 principal / $817 interest)
* New loan balance of $230,310
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 5

* Investment grew by $1,972
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 6

* Received rent of $2,300
* Loan payment of $1,405 ($596 principal / $809 interest)
* New loan balance of $203,873
* Management fee of $230
* Loan payment of $1,405 ($598 principal / $807 interest)
* New loan balance of $203,275
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,175
* Net income of $1,491
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $788 ($5,275 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,491 leaving balance of $201,784

---

Owner in month # 6

* Loan payment of $1,141 ($325 principal / $816 interest)
* New loan balance of $229,985
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 6

* Investment grew by $1,986
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 7

* Received rent of $2,300
* Loan payment of $1,405 ($606 principal / $799 interest)
* New loan balance of $201,178
* Management fee of $230
* Loan payment of $1,405 ($609 principal / $796 interest)
* New loan balance of $200,569
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,165
* Net income of $1,501
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $798 ($6,073 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,501 leaving balance of $199,068

---

Owner in month # 7

* Loan payment of $1,141 ($326 principal / $815 interest)
* New loan balance of $229,659
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 7

* Investment grew by $1,999
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 8

* Received rent of $2,300
* Loan payment of $1,405 ($617 principal / $788 interest)
* New loan balance of $198,451
* Management fee of $230
* Loan payment of $1,405 ($619 principal / $786 interest)
* New loan balance of $197,832
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,154
* Net income of $1,512
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $809 ($6,882 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,512 leaving balance of $196,320

---

Owner in month # 8

* Loan payment of $1,141 ($328 principal / $813 interest)
* New loan balance of $229,331
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 8

* Investment grew by $2,012
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 9

* Received rent of $2,300
* Loan payment of $1,405 ($628 principal / $777 interest)
* New loan balance of $195,692
* Management fee of $230
* Loan payment of $1,405 ($630 principal / $775 interest)
* New loan balance of $195,062
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,143
* Net income of $1,523
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $820 ($7,703 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,523 leaving balance of $193,539

---

Owner in month # 9

* Loan payment of $1,141 ($329 principal / $812 interest)
* New loan balance of $229,002
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 9

* Investment grew by $2,026
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 10

* Received rent of $2,300
* Loan payment of $1,405 ($639 principal / $766 interest)
* New loan balance of $192,900
* Management fee of $230
* Loan payment of $1,405 ($641 principal / $764 interest)
* New loan balance of $192,259
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,132
* Net income of $1,534
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $831 ($8,534 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,534 leaving balance of $190,725

---

Owner in month # 10

* Loan payment of $1,141 ($330 principal / $811 interest)
* New loan balance of $228,672
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 10

* Investment grew by $2,039
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 11

* Received rent of $2,300
* Loan payment of $1,405 ($650 principal / $755 interest)
* New loan balance of $190,075
* Management fee of $230
* Loan payment of $1,405 ($653 principal / $752 interest)
* New loan balance of $189,422
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,121
* Net income of $1,545
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $842 ($9,376 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,545 leaving balance of $187,877

---

Owner in month # 11

* Loan payment of $1,141 ($331 principal / $810 interest)
* New loan balance of $228,341
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 11

* Investment grew by $2,053
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Landlord in month # 12

* Received rent of $2,300
* Loan payment of $1,405 ($661 principal / $744 interest)
* New loan balance of $187,216
* Management fee of $230
* Loan payment of $1,405 ($664 principal / $741 interest)
* New loan balance of $186,552
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance
* Total monthly expenses of $2,110
* Net income of $1,556
* Allowed monthly depreciation of $703 + carry-over of $703
* Taxable income of $853 ($10,229 YTD)
* $703 of depreciation carried over
* Paid additional principal of $1,556 leaving balance of $184,996

---

Owner in month # 12

* Loan payment of $1,141 ($332 principal / $809 interest)
* New loan balance of $228,009
* Spent $507 on property tax
* Spent $167 on insurance
* Spent $100 on HOA
* Spent $362 on home maintenance

---

Renter in month # 12

* Investment grew by $2,066
* Spent $2,300 on rent
* Spent $15 on renters insurance

---

Year # 1
Rent increased 3.50% to $2,380
Home value increased 3.70% to $300,626
Renters insurance increased 2.00% to $15.30
Home owner's insurance increased 2.00% to $170.00
HOA increased 2.00% to $102.00

---

Landlord in month # 13

* Received rent of $2,380
* Loan payment of $1,405 ($673 principal / $732 interest)
* New loan balance of $184,323
* Management fee of $238
* Loan payment of $1,405 ($675 principal / $730 interest)
* New loan balance of $183,648
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Paid last year's taxes of $2,455
* Total monthly expenses of $4,599
* Net income of $1,648
* Allowed monthly depreciation of $729 + carry-over of $703
* Taxable income of $945 ($945 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,648 leaving balance of $182,000

---

Owner in month # 13

* Loan payment of $1,141 ($333 principal / $808 interest)
* New loan balance of $227,676
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 13

* Investment grew by $2,080
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 14

* Received rent of $2,380
* Loan payment of $1,405 ($685 principal / $720 interest)
* New loan balance of $181,315
* Management fee of $238
* Loan payment of $1,405 ($687 principal / $718 interest)
* New loan balance of $180,628
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,132
* Net income of $1,660
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $931 ($1,876 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,660 leaving balance of $178,968

---

Owner in month # 14

* Loan payment of $1,141 ($335 principal / $806 interest)
* New loan balance of $227,341
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 14

* Investment grew by $2,094
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 15

* Received rent of $2,380
* Loan payment of $1,405 ($697 principal / $708 interest)
* New loan balance of $178,271
* Management fee of $238
* Loan payment of $1,405 ($699 principal / $706 interest)
* New loan balance of $177,572
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,120
* Net income of $1,672
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $943 ($2,820 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,672 leaving balance of $175,900

---

Owner in month # 15

* Loan payment of $1,141 ($336 principal / $805 interest)
* New loan balance of $227,005
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 15

* Investment grew by $2,108
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 16

* Received rent of $2,380
* Loan payment of $1,405 ($709 principal / $696 interest)
* New loan balance of $175,191
* Management fee of $238
* Loan payment of $1,405 ($712 principal / $693 interest)
* New loan balance of $174,479
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,108
* Net income of $1,684
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $955 ($3,775 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,684 leaving balance of $172,795

---

Owner in month # 16

* Loan payment of $1,141 ($337 principal / $804 interest)
* New loan balance of $226,668
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 16

* Investment grew by $2,122
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 17

* Received rent of $2,380
* Loan payment of $1,405 ($721 principal / $684 interest)
* New loan balance of $172,074
* Management fee of $238
* Loan payment of $1,405 ($724 principal / $681 interest)
* New loan balance of $171,350
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,096
* Net income of $1,696
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $967 ($4,742 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,696 leaving balance of $169,654

---

Owner in month # 17

* Loan payment of $1,141 ($338 principal / $803 interest)
* New loan balance of $226,330
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 17

* Investment grew by $2,136
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 18

* Received rent of $2,380
* Loan payment of $1,405 ($733 principal / $672 interest)
* New loan balance of $168,921
* Management fee of $238
* Loan payment of $1,405 ($736 principal / $669 interest)
* New loan balance of $168,185
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,084
* Net income of $1,708
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $979 ($5,721 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,708 leaving balance of $166,477

---

Owner in month # 18

* Loan payment of $1,141 ($339 principal / $802 interest)
* New loan balance of $225,991
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 18

* Investment grew by $2,150
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 19

* Received rent of $2,380
* Loan payment of $1,405 ($746 principal / $659 interest)
* New loan balance of $165,731
* Management fee of $238
* Loan payment of $1,405 ($749 principal / $656 interest)
* New loan balance of $164,982
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,071
* Net income of $1,721
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $992 ($6,713 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,721 leaving balance of $163,261

---

Owner in month # 19

* Loan payment of $1,141 ($341 principal / $800 interest)
* New loan balance of $225,650
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 19

* Investment grew by $2,165
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 20

* Received rent of $2,380
* Loan payment of $1,405 ($759 principal / $646 interest)
* New loan balance of $162,502
* Management fee of $238
* Loan payment of $1,405 ($762 principal / $643 interest)
* New loan balance of $161,740
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,058
* Net income of $1,734
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $1,005 ($7,719 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,734 leaving balance of $160,006

---

Owner in month # 20

* Loan payment of $1,141 ($342 principal / $799 interest)
* New loan balance of $225,308
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 20

* Investment grew by $2,179
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 21

* Received rent of $2,380
* Loan payment of $1,405 ($772 principal / $633 interest)
* New loan balance of $159,234
* Management fee of $238
* Loan payment of $1,405 ($775 principal / $630 interest)
* New loan balance of $158,459
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,045
* Net income of $1,747
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $1,018 ($8,737 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,747 leaving balance of $156,712

---

Owner in month # 21

* Loan payment of $1,141 ($343 principal / $798 interest)
* New loan balance of $224,965
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 21

* Investment grew by $2,194
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 22

* Received rent of $2,380
* Loan payment of $1,405 ($785 principal / $620 interest)
* New loan balance of $155,927
* Management fee of $238
* Loan payment of $1,405 ($788 principal / $617 interest)
* New loan balance of $155,139
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,032
* Net income of $1,760
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $1,031 ($9,768 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,760 leaving balance of $153,379

---

Owner in month # 22

* Loan payment of $1,141 ($344 principal / $797 interest)
* New loan balance of $224,621
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 22

* Investment grew by $2,208
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 23

* Received rent of $2,380
* Loan payment of $1,405 ($798 principal / $607 interest)
* New loan balance of $152,581
* Management fee of $238
* Loan payment of $1,405 ($801 principal / $604 interest)
* New loan balance of $151,780
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,019
* Net income of $1,773
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $1,044 ($10,812 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,773 leaving balance of $150,007

---

Owner in month # 23

* Loan payment of $1,141 ($345 principal / $796 interest)
* New loan balance of $224,276
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 23

* Investment grew by $2,223
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Landlord in month # 24

* Received rent of $2,380
* Loan payment of $1,405 ($811 principal / $594 interest)
* New loan balance of $149,196
* Management fee of $238
* Loan payment of $1,405 ($814 principal / $591 interest)
* New loan balance of $148,382
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance
* Total monthly expenses of $2,006
* Net income of $1,786
* Allowed monthly depreciation of $729 + carry-over of $729
* Taxable income of $1,057 ($11,870 YTD)
* $729 of depreciation carried over
* Paid additional principal of $1,786 leaving balance of $146,596

---

Owner in month # 24

* Loan payment of $1,141 ($347 principal / $794 interest)
* New loan balance of $223,929
* Spent $526 on property tax
* Spent $170 on insurance
* Spent $102 on HOA
* Spent $376 on home maintenance

---

Renter in month # 24

* Investment grew by $2,238
* Spent $2,380 on rent
* Spent $15 on renters insurance

---

Year # 2
Rent increased 3.50% to $2,463
Home value increased 3.70% to $311,749
Renters insurance increased 2.00% to $15.61
Home owner's insurance increased 2.00% to $173.40
HOA increased 2.00% to $104.04

---

Landlord in month # 25

* Received rent of $2,463
* Loan payment of $1,405 ($825 principal / $580 interest)
* New loan balance of $145,771
* Management fee of $246
* Loan payment of $1,405 ($828 principal / $577 interest)
* New loan balance of $144,943
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Paid last year's taxes of $2,849
* Total monthly expenses of $4,888
* Net income of $1,883
* Allowed monthly depreciation of $756 + carry-over of $729
* Taxable income of $1,154 ($1,154 YTD)
* $756 of depreciation carried over
* Paid additional principal of $1,883 leaving balance of $143,060

---

Owner in month # 25

* Loan payment of $1,141 ($348 principal / $793 interest)
* New loan balance of $223,581
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 25

* Investment grew by $2,253
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 26

* Received rent of $2,463
* Loan payment of $1,405 ($839 principal / $566 interest)
* New loan balance of $142,221
* Management fee of $246
* Loan payment of $1,405 ($842 principal / $563 interest)
* New loan balance of $141,379
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $2,026
* Net income of $1,897
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,141 ($2,295 YTD)
* $756 of depreciation carried over
* Paid additional principal of $1,897 leaving balance of $139,482

---

Owner in month # 26

* Loan payment of $1,141 ($349 principal / $792 interest)
* New loan balance of $223,232
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 26

* Investment grew by $2,268
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 27

* Received rent of $2,463
* Loan payment of $1,405 ($853 principal / $552 interest)
* New loan balance of $138,629
* Management fee of $246
* Loan payment of $1,405 ($856 principal / $549 interest)
* New loan balance of $137,773
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $2,012
* Net income of $1,911
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,155 ($3,451 YTD)
* $756 of depreciation carried over
* Paid additional principal of $1,911 leaving balance of $135,862

---

Owner in month # 27

* Loan payment of $1,141 ($350 principal / $791 interest)
* New loan balance of $222,882
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 27

* Investment grew by $2,283
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 28

* Received rent of $2,463
* Loan payment of $1,405 ($867 principal / $538 interest)
* New loan balance of $134,995
* Management fee of $246
* Loan payment of $1,405 ($871 principal / $534 interest)
* New loan balance of $134,124
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $1,998
* Net income of $1,925
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,169 ($4,620 YTD)
* $756 of depreciation carried over
* Paid additional principal of $1,925 leaving balance of $132,199

---

Owner in month # 28

* Loan payment of $1,141 ($352 principal / $789 interest)
* New loan balance of $222,530
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 28

* Investment grew by $2,298
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 29

* Received rent of $2,463
* Loan payment of $1,405 ($882 principal / $523 interest)
* New loan balance of $131,317
* Management fee of $246
* Loan payment of $1,405 ($885 principal / $520 interest)
* New loan balance of $130,432
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $1,983
* Net income of $1,940
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,184 ($5,804 YTD)
* $756 of depreciation carried over
* Paid additional principal of $1,940 leaving balance of $128,492

---

Owner in month # 29

* Loan payment of $1,141 ($353 principal / $788 interest)
* New loan balance of $222,177
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 29

* Investment grew by $2,313
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 30

* Received rent of $2,463
* Loan payment of $1,405 ($896 principal / $509 interest)
* New loan balance of $127,596
* Management fee of $246
* Loan payment of $1,405 ($900 principal / $505 interest)
* New loan balance of $126,696
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $1,969
* Net income of $1,954
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,198 ($7,002 YTD)
* $756 of depreciation carried over
* Paid additional principal of $1,954 leaving balance of $124,742

---

Owner in month # 30

* Loan payment of $1,141 ($354 principal / $787 interest)
* New loan balance of $221,823
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 30

* Investment grew by $2,329
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 31

* Received rent of $2,463
* Loan payment of $1,405 ($911 principal / $494 interest)
* New loan balance of $123,831
* Management fee of $246
* Loan payment of $1,405 ($915 principal / $490 interest)
* New loan balance of $122,916
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $1,954
* Net income of $1,969
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,213 ($8,216 YTD)
* $756 of depreciation carried over
* Paid additional principal of $1,969 leaving balance of $120,947

---

Owner in month # 31

* Loan payment of $1,141 ($355 principal / $786 interest)
* New loan balance of $221,468
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 31

* Investment grew by $2,344
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 32

* Received rent of $2,463
* Loan payment of $1,405 ($926 principal / $479 interest)
* New loan balance of $120,021
* Management fee of $246
* Loan payment of $1,405 ($930 principal / $475 interest)
* New loan balance of $119,091
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $1,939
* Net income of $1,984
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,228 ($9,444 YTD)
* $756 of depreciation carried over
* Paid additional principal of $1,984 leaving balance of $117,107

---

Owner in month # 32

* Loan payment of $1,141 ($357 principal / $784 interest)
* New loan balance of $221,111
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 32

* Investment grew by $2,360
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 33

* Received rent of $2,463
* Loan payment of $1,405 ($941 principal / $464 interest)
* New loan balance of $116,166
* Management fee of $246
* Loan payment of $1,405 ($945 principal / $460 interest)
* New loan balance of $115,221
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $1,924
* Net income of $1,999
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,243 ($10,687 YTD)
* $756 of depreciation carried over
* Paid additional principal of $1,999 leaving balance of $113,222

---

Owner in month # 33

* Loan payment of $1,141 ($358 principal / $783 interest)
* New loan balance of $220,753
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 33

* Investment grew by $2,376
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 34

* Received rent of $2,463
* Loan payment of $1,405 ($957 principal / $448 interest)
* New loan balance of $112,265
* Management fee of $246
* Loan payment of $1,405 ($961 principal / $444 interest)
* New loan balance of $111,304
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $1,908
* Net income of $2,015
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,259 ($11,946 YTD)
* $756 of depreciation carried over
* Paid additional principal of $2,015 leaving balance of $109,289

---

Owner in month # 34

* Loan payment of $1,141 ($359 principal / $782 interest)
* New loan balance of $220,394
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 34

* Investment grew by $2,392
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 35

* Received rent of $2,463
* Loan payment of $1,405 ($972 principal / $433 interest)
* New loan balance of $108,317
* Management fee of $246
* Loan payment of $1,405 ($976 principal / $429 interest)
* New loan balance of $107,341
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $1,893
* Net income of $2,030
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,274 ($13,221 YTD)
* $756 of depreciation carried over
* Paid additional principal of $2,030 leaving balance of $105,311

---

Owner in month # 35

* Loan payment of $1,141 ($360 principal / $781 interest)
* New loan balance of $220,034
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 35

* Investment grew by $2,408
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Landlord in month # 36

* Received rent of $2,463
* Loan payment of $1,405 ($988 principal / $417 interest)
* New loan balance of $104,323
* Management fee of $246
* Loan payment of $1,405 ($992 principal / $413 interest)
* New loan balance of $103,331
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance
* Total monthly expenses of $1,877
* Net income of $2,046
* Allowed monthly depreciation of $756 + carry-over of $756
* Taxable income of $1,290 ($14,511 YTD)
* $756 of depreciation carried over
* Paid additional principal of $2,046 leaving balance of $101,285

---

Owner in month # 36

* Loan payment of $1,141 ($362 principal / $779 interest)
* New loan balance of $219,672
* Spent $546 on property tax
* Spent $173 on insurance
* Spent $104 on HOA
* Spent $390 on home maintenance

---

Renter in month # 36

* Investment grew by $2,424
* Spent $2,463 on rent
* Spent $16 on renters insurance

---

Year # 3
Rent increased 3.50% to $2,549
Home value increased 3.70% to $323,284
Renters insurance increased 2.00% to $15.92
Home owner's insurance increased 2.00% to $176.87
HOA increased 2.00% to $106.12

---

Landlord in month # 37

* Received rent of $2,549
* Loan payment of $1,405 ($1,004 principal / $401 interest)
* New loan balance of $100,281
* Management fee of $255
* Loan payment of $1,405 ($1,008 principal / $397 interest)
* New loan balance of $99,273
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Paid last year's taxes of $3,483
* Total monthly expenses of $5,391
* Net income of $2,148
* Allowed monthly depreciation of $784 + carry-over of $756
* Taxable income of $1,392 ($1,392 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,148 leaving balance of $97,125

---

Owner in month # 37

* Loan payment of $1,141 ($363 principal / $778 interest)
* New loan balance of $219,309
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 37

* Investment grew by $2,440
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 38

* Received rent of $2,549
* Loan payment of $1,405 ($1,021 principal / $384 interest)
* New loan balance of $96,104
* Management fee of $255
* Loan payment of $1,405 ($1,025 principal / $380 interest)
* New loan balance of $95,079
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,892
* Net income of $2,165
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,381 ($2,774 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,165 leaving balance of $92,914

---

Owner in month # 38

* Loan payment of $1,141 ($364 principal / $777 interest)
* New loan balance of $218,945
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 38

* Investment grew by $2,456
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 39

* Received rent of $2,549
* Loan payment of $1,405 ($1,037 principal / $368 interest)
* New loan balance of $91,877
* Management fee of $255
* Loan payment of $1,405 ($1,041 principal / $364 interest)
* New loan balance of $90,836
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,876
* Net income of $2,181
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,397 ($4,171 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,181 leaving balance of $88,655

---

Owner in month # 39

* Loan payment of $1,141 ($366 principal / $775 interest)
* New loan balance of $218,579
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 39

* Investment grew by $2,472
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 40

* Received rent of $2,549
* Loan payment of $1,405 ($1,054 principal / $351 interest)
* New loan balance of $87,601
* Management fee of $255
* Loan payment of $1,405 ($1,058 principal / $347 interest)
* New loan balance of $86,543
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,859
* Net income of $2,198
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,414 ($5,585 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,198 leaving balance of $84,345

---

Owner in month # 40

* Loan payment of $1,141 ($367 principal / $774 interest)
* New loan balance of $218,212
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 40

* Investment grew by $2,489
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 41

* Received rent of $2,549
* Loan payment of $1,405 ($1,071 principal / $334 interest)
* New loan balance of $83,274
* Management fee of $255
* Loan payment of $1,405 ($1,075 principal / $330 interest)
* New loan balance of $82,199
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,842
* Net income of $2,215
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,431 ($7,016 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,215 leaving balance of $79,984

---

Owner in month # 41

* Loan payment of $1,141 ($368 principal / $773 interest)
* New loan balance of $217,844
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 41

* Investment grew by $2,505
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 42

* Received rent of $2,549
* Loan payment of $1,405 ($1,088 principal / $317 interest)
* New loan balance of $78,896
* Management fee of $255
* Loan payment of $1,405 ($1,093 principal / $312 interest)
* New loan balance of $77,803
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,825
* Net income of $2,232
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,448 ($8,465 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,232 leaving balance of $75,571

---

Owner in month # 42

* Loan payment of $1,141 ($369 principal / $772 interest)
* New loan balance of $217,475
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 42

* Investment grew by $2,522
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 43

* Received rent of $2,549
* Loan payment of $1,405 ($1,106 principal / $299 interest)
* New loan balance of $74,465
* Management fee of $255
* Loan payment of $1,405 ($1,110 principal / $295 interest)
* New loan balance of $73,355
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,807
* Net income of $2,250
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,466 ($9,931 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,250 leaving balance of $71,105

---

Owner in month # 43

* Loan payment of $1,141 ($371 principal / $770 interest)
* New loan balance of $217,104
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 43

* Investment grew by $2,539
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 44

* Received rent of $2,549
* Loan payment of $1,405 ($1,124 principal / $281 interest)
* New loan balance of $69,981
* Management fee of $255
* Loan payment of $1,405 ($1,128 principal / $277 interest)
* New loan balance of $68,853
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,789
* Net income of $2,268
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,484 ($11,415 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,268 leaving balance of $66,585

---

Owner in month # 44

* Loan payment of $1,141 ($372 principal / $769 interest)
* New loan balance of $216,732
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 44

* Investment grew by $2,556
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 45

* Received rent of $2,549
* Loan payment of $1,405 ($1,141 principal / $264 interest)
* New loan balance of $65,444
* Management fee of $255
* Loan payment of $1,405 ($1,146 principal / $259 interest)
* New loan balance of $64,298
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,772
* Net income of $2,285
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,501 ($12,916 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,285 leaving balance of $62,013

---

Owner in month # 45

* Loan payment of $1,141 ($373 principal / $768 interest)
* New loan balance of $216,359
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 45

* Investment grew by $2,573
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 46

* Received rent of $2,549
* Loan payment of $1,405 ($1,160 principal / $245 interest)
* New loan balance of $60,853
* Management fee of $255
* Loan payment of $1,405 ($1,164 principal / $241 interest)
* New loan balance of $59,689
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,753
* Net income of $2,304
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,520 ($14,437 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,304 leaving balance of $57,385

---

Owner in month # 46

* Loan payment of $1,141 ($375 principal / $766 interest)
* New loan balance of $215,984
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 46

* Investment grew by $2,590
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 47

* Received rent of $2,549
* Loan payment of $1,405 ($1,178 principal / $227 interest)
* New loan balance of $56,207
* Management fee of $255
* Loan payment of $1,405 ($1,183 principal / $222 interest)
* New loan balance of $55,024
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,735
* Net income of $2,322
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,538 ($15,975 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,322 leaving balance of $52,702

---

Owner in month # 47

* Loan payment of $1,141 ($376 principal / $765 interest)
* New loan balance of $215,608
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 47

* Investment grew by $2,607
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Landlord in month # 48

* Received rent of $2,549
* Loan payment of $1,405 ($1,196 principal / $209 interest)
* New loan balance of $51,506
* Management fee of $255
* Loan payment of $1,405 ($1,201 principal / $204 interest)
* New loan balance of $50,305
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance
* Total monthly expenses of $1,717
* Net income of $2,340
* Allowed monthly depreciation of $784 + carry-over of $784
* Taxable income of $1,556 ($17,531 YTD)
* $784 of depreciation carried over
* Paid additional principal of $2,340 leaving balance of $47,965

---

Owner in month # 48

* Loan payment of $1,141 ($377 principal / $764 interest)
* New loan balance of $215,231
* Spent $566 on property tax
* Spent $177 on insurance
* Spent $106 on HOA
* Spent $404 on home maintenance

---

Renter in month # 48

* Investment grew by $2,625
* Spent $2,549 on rent
* Spent $16 on renters insurance

---

Year # 4
Rent increased 3.50% to $2,638
Home value increased 3.70% to $335,246
Renters insurance increased 2.00% to $16.24
Home owner's insurance increased 2.00% to $180.41
HOA increased 2.00% to $108.24

---

Landlord in month # 49

* Received rent of $2,638
* Loan payment of $1,405 ($1,215 principal / $190 interest)
* New loan balance of $46,750
* Management fee of $264
* Loan payment of $1,405 ($1,220 principal / $185 interest)
* New loan balance of $45,530
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Paid last year's taxes of $4,208
* Total monthly expenses of $5,956
* Net income of $2,448
* Allowed monthly depreciation of $813 + carry-over of $784
* Taxable income of $1,664 ($1,664 YTD)
* $813 of depreciation carried over
* Paid additional principal of $2,448 leaving balance of $43,082

---

Owner in month # 49

* Loan payment of $1,141 ($379 principal / $762 interest)
* New loan balance of $214,852
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 49

* Investment grew by $2,642
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 50

* Received rent of $2,638
* Loan payment of $1,405 ($1,234 principal / $171 interest)
* New loan balance of $41,848
* Management fee of $264
* Loan payment of $1,405 ($1,239 principal / $166 interest)
* New loan balance of $40,609
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,729
* Net income of $2,467
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,654 ($3,319 YTD)
* $813 of depreciation carried over
* Paid additional principal of $2,467 leaving balance of $38,142

---

Owner in month # 50

* Loan payment of $1,141 ($380 principal / $761 interest)
* New loan balance of $214,472
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 50

* Investment grew by $2,660
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 51

* Received rent of $2,638
* Loan payment of $1,405 ($1,254 principal / $151 interest)
* New loan balance of $36,888
* Management fee of $264
* Loan payment of $1,405 ($1,259 principal / $146 interest)
* New loan balance of $35,629
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,709
* Net income of $2,487
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,674 ($4,993 YTD)
* $813 of depreciation carried over
* Paid additional principal of $2,487 leaving balance of $33,142

---

Owner in month # 51

* Loan payment of $1,141 ($381 principal / $760 interest)
* New loan balance of $214,091
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 51

* Investment grew by $2,678
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 52

* Received rent of $2,638
* Loan payment of $1,405 ($1,274 principal / $131 interest)
* New loan balance of $31,868
* Management fee of $264
* Loan payment of $1,405 ($1,279 principal / $126 interest)
* New loan balance of $30,589
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,689
* Net income of $2,507
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,694 ($6,687 YTD)
* $813 of depreciation carried over
* Paid additional principal of $2,507 leaving balance of $28,082

---

Owner in month # 52

* Loan payment of $1,141 ($383 principal / $758 interest)
* New loan balance of $213,708
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 52

* Investment grew by $2,695
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 53

* Received rent of $2,638
* Loan payment of $1,405 ($1,294 principal / $111 interest)
* New loan balance of $26,788
* Management fee of $264
* Loan payment of $1,405 ($1,299 principal / $106 interest)
* New loan balance of $25,489
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,669
* Net income of $2,527
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,714 ($8,401 YTD)
* $813 of depreciation carried over
* Paid additional principal of $2,527 leaving balance of $22,962

---

Owner in month # 53

* Loan payment of $1,141 ($384 principal / $757 interest)
* New loan balance of $213,324
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 53

* Investment grew by $2,713
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 54

* Received rent of $2,638
* Loan payment of $1,405 ($1,314 principal / $91 interest)
* New loan balance of $21,648
* Management fee of $264
* Loan payment of $1,405 ($1,319 principal / $86 interest)
* New loan balance of $20,329
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,649
* Net income of $2,547
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,734 ($10,136 YTD)
* $813 of depreciation carried over
* Paid additional principal of $2,547 leaving balance of $17,782

---

Owner in month # 54

* Loan payment of $1,141 ($385 principal / $756 interest)
* New loan balance of $212,939
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 54

* Investment grew by $2,731
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 55

* Received rent of $2,638
* Loan payment of $1,405 ($1,335 principal / $70 interest)
* New loan balance of $16,447
* Management fee of $264
* Loan payment of $1,405 ($1,340 principal / $65 interest)
* New loan balance of $15,107
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,628
* Net income of $2,568
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,755 ($11,891 YTD)
* $813 of depreciation carried over
* Paid additional principal of $2,568 leaving balance of $12,539

---

Owner in month # 55

* Loan payment of $1,141 ($387 principal / $754 interest)
* New loan balance of $212,552
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 55

* Investment grew by $2,750
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 56

* Received rent of $2,638
* Loan payment of $1,405 ($1,355 principal / $50 interest)
* New loan balance of $11,184
* Management fee of $264
* Loan payment of $1,405 ($1,361 principal / $44 interest)
* New loan balance of $9,823
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,608
* Net income of $2,588
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,775 ($13,666 YTD)
* $813 of depreciation carried over
* Paid additional principal of $2,588 leaving balance of $7,235

---

Owner in month # 56

* Loan payment of $1,141 ($388 principal / $753 interest)
* New loan balance of $212,164
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 56

* Investment grew by $2,768
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 57

* Received rent of $2,638
* Loan payment of $1,405 ($1,376 principal / $29 interest)
* New loan balance of $5,859
* Management fee of $264
* Loan payment of $1,405 ($1,382 principal / $23 interest)
* New loan balance of $4,477
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,587
* Net income of $2,609
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,796 ($15,463 YTD)
* $813 of depreciation carried over
* Paid additional principal of $2,609 leaving balance of $1,868

---

Owner in month # 57

* Loan payment of $1,141 ($390 principal / $751 interest)
* New loan balance of $211,774
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 57

* Investment grew by $2,786
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 58

* Received rent of $2,638
* Loan payment of $1,405 ($1,398 principal / $7 interest)
* New loan balance of $470
* Management fee of $264
* Loan payment of $1,405 ($1,403 principal / $2 interest)
* New loan balance of ($933)
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,565
* Net income of $2,631
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,818 ($17,281 YTD)
* $813 of depreciation carried over
* Added net income of $2,631 to personal leaving balance of ($2,631)

---

Owner in month # 58

* Loan payment of $1,141 ($391 principal / $750 interest)
* New loan balance of $211,383
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 58

* Investment grew by $2,805
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 59

* Received rent of $2,638
* Loan payment of $1,405 ($1,409 principal / ($4) interest)
* New loan balance of ($2,342)
* Management fee of $264
* Loan payment of $1,405 ($1,414 principal / ($9) interest)
* New loan balance of ($3,756)
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,554
* Net income of $2,642
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,829 ($19,110 YTD)
* $813 of depreciation carried over
* Added net income of $2,642 to personal leaving balance of ($5,273)

---

Owner in month # 59

* Loan payment of $1,141 ($392 principal / $749 interest)
* New loan balance of $210,991
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 59

* Investment grew by $2,824
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Landlord in month # 60

* Received rent of $2,638
* Loan payment of $1,405 ($1,420 principal / ($15) interest)
* New loan balance of ($5,176)
* Management fee of $264
* Loan payment of $1,405 ($1,425 principal / ($20) interest)
* New loan balance of ($6,601)
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance
* Total monthly expenses of $1,543
* Net income of $2,653
* Allowed monthly depreciation of $813 + carry-over of $813
* Taxable income of $1,840 ($20,950 YTD)
* $813 of depreciation carried over
* Added net income of $2,653 to personal leaving balance of ($7,926)

---

Owner in month # 60

* Loan payment of $1,141 ($394 principal / $747 interest)
* New loan balance of $210,597
* Spent $587 on property tax
* Spent $180 on insurance
* Spent $108 on HOA
* Spent $419 on home maintenance

---

Renter in month # 60

* Investment grew by $2,843
* Spent $2,638 on rent
* Spent $16 on renters insurance

---

Year # 5
Rent increased 3.50% to $2,730
Home value increased 3.70% to $347,650
Renters insurance increased 2.00% to $16.56
Home owner's insurance increased 2.00% to $184.02
HOA increased 2.00% to $110.40

---

Landlord in month # 61

* Received rent of $2,730
* Loan payment of $1,405 ($1,431 principal / ($26) interest)
* New loan balance of ($8,032)
* Management fee of $273
* Loan payment of $1,405 ($1,437 principal / ($32) interest)
* New loan balance of ($9,469)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Paid last year's taxes of $5,028
* Total monthly expenses of $6,613
* Net income of $2,756
* Allowed monthly depreciation of $843 + carry-over of $813
* Taxable income of $1,943 ($1,943 YTD)
* $843 of depreciation carried over
* Added net income of $2,756 to personal leaving balance of ($10,682)

---

Owner in month # 61

* Loan payment of $1,141 ($395 principal / $746 interest)
* New loan balance of $210,202
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 61

* Investment grew by $2,862
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 62

* Received rent of $2,730
* Loan payment of $1,405 ($1,442 principal / ($37) interest)
* New loan balance of ($10,911)
* Management fee of $273
* Loan payment of $1,405 ($1,448 principal / ($43) interest)
* New loan balance of ($12,359)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,573
* Net income of $2,767
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $1,924 ($3,867 YTD)
* $843 of depreciation carried over
* Added net income of $2,767 to personal leaving balance of ($13,449)

---

Owner in month # 62

* Loan payment of $1,141 ($397 principal / $744 interest)
* New loan balance of $209,805
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 62

* Investment grew by $2,881
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 63

* Received rent of $2,730
* Loan payment of $1,405 ($1,454 principal / ($49) interest)
* New loan balance of ($13,813)
* Management fee of $273
* Loan payment of $1,405 ($1,460 principal / ($55) interest)
* New loan balance of ($15,273)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,561
* Net income of $2,779
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $1,936 ($5,804 YTD)
* $843 of depreciation carried over
* Added net income of $2,779 to personal leaving balance of ($16,228)

---

Owner in month # 63

* Loan payment of $1,141 ($398 principal / $743 interest)
* New loan balance of $209,407
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 63

* Investment grew by $2,900
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 64

* Received rent of $2,730
* Loan payment of $1,405 ($1,465 principal / ($60) interest)
* New loan balance of ($16,738)
* Management fee of $273
* Loan payment of $1,405 ($1,471 principal / ($66) interest)
* New loan balance of ($18,209)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,550
* Net income of $2,790
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $1,947 ($7,751 YTD)
* $843 of depreciation carried over
* Added net income of $2,790 to personal leaving balance of ($19,018)

---

Owner in month # 64

* Loan payment of $1,141 ($399 principal / $742 interest)
* New loan balance of $209,008
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 64

* Investment grew by $2,919
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 65

* Received rent of $2,730
* Loan payment of $1,405 ($1,477 principal / ($72) interest)
* New loan balance of ($19,686)
* Management fee of $273
* Loan payment of $1,405 ($1,483 principal / ($78) interest)
* New loan balance of ($21,169)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,538
* Net income of $2,802
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $1,959 ($9,710 YTD)
* $843 of depreciation carried over
* Added net income of $2,802 to personal leaving balance of ($21,820)

---

Owner in month # 65

* Loan payment of $1,141 ($401 principal / $740 interest)
* New loan balance of $208,607
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 65

* Investment grew by $2,939
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 66

* Received rent of $2,730
* Loan payment of $1,405 ($1,489 principal / ($84) interest)
* New loan balance of ($22,658)
* Management fee of $273
* Loan payment of $1,405 ($1,495 principal / ($90) interest)
* New loan balance of ($24,153)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,526
* Net income of $2,814
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $1,971 ($11,681 YTD)
* $843 of depreciation carried over
* Added net income of $2,814 to personal leaving balance of ($24,634)

---

Owner in month # 66

* Loan payment of $1,141 ($402 principal / $739 interest)
* New loan balance of $208,205
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 66

* Investment grew by $2,958
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 67

* Received rent of $2,730
* Loan payment of $1,405 ($1,501 principal / ($96) interest)
* New loan balance of ($25,654)
* Management fee of $273
* Loan payment of $1,405 ($1,507 principal / ($102) interest)
* New loan balance of ($27,161)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,514
* Net income of $2,826
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $1,983 ($13,665 YTD)
* $843 of depreciation carried over
* Added net income of $2,826 to personal leaving balance of ($27,460)

---

Owner in month # 67

* Loan payment of $1,141 ($404 principal / $737 interest)
* New loan balance of $207,801
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 67

* Investment grew by $2,978
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 68

* Received rent of $2,730
* Loan payment of $1,405 ($1,513 principal / ($108) interest)
* New loan balance of ($28,674)
* Management fee of $273
* Loan payment of $1,405 ($1,519 principal / ($114) interest)
* New loan balance of ($30,193)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,502
* Net income of $2,838
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $1,995 ($15,660 YTD)
* $843 of depreciation carried over
* Added net income of $2,838 to personal leaving balance of ($30,298)

---

Owner in month # 68

* Loan payment of $1,141 ($405 principal / $736 interest)
* New loan balance of $207,396
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 68

* Investment grew by $2,998
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 69

* Received rent of $2,730
* Loan payment of $1,405 ($1,525 principal / ($120) interest)
* New loan balance of ($31,718)
* Management fee of $273
* Loan payment of $1,405 ($1,531 principal / ($126) interest)
* New loan balance of ($33,249)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,490
* Net income of $2,850
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $2,007 ($17,667 YTD)
* $843 of depreciation carried over
* Added net income of $2,850 to personal leaving balance of ($33,148)

---

Owner in month # 69

* Loan payment of $1,141 ($406 principal / $735 interest)
* New loan balance of $206,990
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 69

* Investment grew by $3,018
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 70

* Received rent of $2,730
* Loan payment of $1,405 ($1,537 principal / ($132) interest)
* New loan balance of ($34,786)
* Management fee of $273
* Loan payment of $1,405 ($1,543 principal / ($138) interest)
* New loan balance of ($36,329)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,478
* Net income of $2,862
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $2,019 ($19,686 YTD)
* $843 of depreciation carried over
* Added net income of $2,862 to personal leaving balance of ($36,010)

---

Owner in month # 70

* Loan payment of $1,141 ($408 principal / $733 interest)
* New loan balance of $206,582
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 70

* Investment grew by $3,038
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 71

* Received rent of $2,730
* Loan payment of $1,405 ($1,549 principal / ($144) interest)
* New loan balance of ($37,878)
* Management fee of $273
* Loan payment of $1,405 ($1,555 principal / ($150) interest)
* New loan balance of ($39,433)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,466
* Net income of $2,874
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $2,031 ($21,717 YTD)
* $843 of depreciation carried over
* Added net income of $2,874 to personal leaving balance of ($38,884)

---

Owner in month # 71

* Loan payment of $1,141 ($409 principal / $732 interest)
* New loan balance of $206,173
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 71

* Investment grew by $3,058
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Landlord in month # 72

* Received rent of $2,730
* Loan payment of $1,405 ($1,561 principal / ($156) interest)
* New loan balance of ($40,994)
* Management fee of $273
* Loan payment of $1,405 ($1,567 principal / ($162) interest)
* New loan balance of ($42,561)
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance
* Total monthly expenses of $1,454
* Net income of $2,886
* Allowed monthly depreciation of $843 + carry-over of $843
* Taxable income of $2,043 ($23,761 YTD)
* $843 of depreciation carried over
* Added net income of $2,886 to personal leaving balance of ($41,770)

---

Owner in month # 72

* Loan payment of $1,141 ($411 principal / $730 interest)
* New loan balance of $205,762
* Spent $608 on property tax
* Spent $184 on insurance
* Spent $110 on HOA
* Spent $435 on home maintenance

---

Renter in month # 72

* Investment grew by $3,078
* Spent $2,730 on rent
* Spent $17 on renters insurance

---

Year # 6
Rent increased 3.50% to $2,826
Home value increased 3.70% to $360,513
Renters insurance increased 2.00% to $16.89
Home owner's insurance increased 2.00% to $187.70
HOA increased 2.00% to $112.61

---

Landlord in month # 73

* Received rent of $2,826
* Loan payment of $1,405 ($1,573 principal / ($168) interest)
* New loan balance of ($44,134)
* Management fee of $283
* Loan payment of $1,405 ($1,580 principal / ($175) interest)
* New loan balance of ($45,714)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Paid last year's taxes of $5,703
* Total monthly expenses of $7,199
* Net income of $2,994
* Allowed monthly depreciation of $874 + carry-over of $843
* Taxable income of $2,151 ($2,151 YTD)
* $874 of depreciation carried over
* Added net income of $2,994 to personal leaving balance of ($44,764)

---

Owner in month # 73

* Loan payment of $1,141 ($412 principal / $729 interest)
* New loan balance of $205,350
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 73

* Investment grew by $3,099
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 74

* Received rent of $2,826
* Loan payment of $1,405 ($1,586 principal / ($181) interest)
* New loan balance of ($47,300)
* Management fee of $283
* Loan payment of $1,405 ($1,592 principal / ($187) interest)
* New loan balance of ($48,892)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,484
* Net income of $3,007
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,133 ($4,284 YTD)
* $874 of depreciation carried over
* Added net income of $3,007 to personal leaving balance of ($47,771)

---

Owner in month # 74

* Loan payment of $1,141 ($414 principal / $727 interest)
* New loan balance of $204,936
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 74

* Investment grew by $3,120
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 75

* Received rent of $2,826
* Loan payment of $1,405 ($1,599 principal / ($194) interest)
* New loan balance of ($50,491)
* Management fee of $283
* Loan payment of $1,405 ($1,605 principal / ($200) interest)
* New loan balance of ($52,096)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,471
* Net income of $3,020
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,146 ($6,430 YTD)
* $874 of depreciation carried over
* Added net income of $3,020 to personal leaving balance of ($50,791)

---

Owner in month # 75

* Loan payment of $1,141 ($415 principal / $726 interest)
* New loan balance of $204,521
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 75

* Investment grew by $3,140
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 76

* Received rent of $2,826
* Loan payment of $1,405 ($1,611 principal / ($206) interest)
* New loan balance of ($53,707)
* Management fee of $283
* Loan payment of $1,405 ($1,618 principal / ($213) interest)
* New loan balance of ($55,325)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,459
* Net income of $3,032
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,158 ($8,588 YTD)
* $874 of depreciation carried over
* Added net income of $3,032 to personal leaving balance of ($53,823)

---

Owner in month # 76

* Loan payment of $1,141 ($417 principal / $724 interest)
* New loan balance of $204,104
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 76

* Investment grew by $3,161
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 77

* Received rent of $2,826
* Loan payment of $1,405 ($1,624 principal / ($219) interest)
* New loan balance of ($56,949)
* Management fee of $283
* Loan payment of $1,405 ($1,630 principal / ($225) interest)
* New loan balance of ($58,579)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,446
* Net income of $3,045
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,171 ($10,759 YTD)
* $874 of depreciation carried over
* Added net income of $3,045 to personal leaving balance of ($56,868)

---

Owner in month # 77

* Loan payment of $1,141 ($418 principal / $723 interest)
* New loan balance of $203,686
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 77

* Investment grew by $3,182
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 78

* Received rent of $2,826
* Loan payment of $1,405 ($1,637 principal / ($232) interest)
* New loan balance of ($60,216)
* Management fee of $283
* Loan payment of $1,405 ($1,643 principal / ($238) interest)
* New loan balance of ($61,859)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,433
* Net income of $3,058
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,184 ($12,943 YTD)
* $874 of depreciation carried over
* Added net income of $3,058 to personal leaving balance of ($59,926)

---

Owner in month # 78

* Loan payment of $1,141 ($420 principal / $721 interest)
* New loan balance of $203,266
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 78

* Investment grew by $3,204
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 79

* Received rent of $2,826
* Loan payment of $1,405 ($1,650 principal / ($245) interest)
* New loan balance of ($63,509)
* Management fee of $283
* Loan payment of $1,405 ($1,656 principal / ($251) interest)
* New loan balance of ($65,165)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,420
* Net income of $3,071
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,197 ($15,140 YTD)
* $874 of depreciation carried over
* Added net income of $3,071 to personal leaving balance of ($62,997)

---

Owner in month # 79

* Loan payment of $1,141 ($421 principal / $720 interest)
* New loan balance of $202,845
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 79

* Investment grew by $3,225
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 80

* Received rent of $2,826
* Loan payment of $1,405 ($1,663 principal / ($258) interest)
* New loan balance of ($66,828)
* Management fee of $283
* Loan payment of $1,405 ($1,670 principal / ($265) interest)
* New loan balance of ($68,498)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,407
* Net income of $3,084
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,210 ($17,350 YTD)
* $874 of depreciation carried over
* Added net income of $3,084 to personal leaving balance of ($66,081)

---

Owner in month # 80

* Loan payment of $1,141 ($423 principal / $718 interest)
* New loan balance of $202,422
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 80

* Investment grew by $3,247
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 81

* Received rent of $2,826
* Loan payment of $1,405 ($1,676 principal / ($271) interest)
* New loan balance of ($70,174)
* Management fee of $283
* Loan payment of $1,405 ($1,683 principal / ($278) interest)
* New loan balance of ($71,857)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,394
* Net income of $3,097
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,223 ($19,573 YTD)
* $874 of depreciation carried over
* Added net income of $3,097 to personal leaving balance of ($69,178)

---

Owner in month # 81

* Loan payment of $1,141 ($424 principal / $717 interest)
* New loan balance of $201,998
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 81

* Investment grew by $3,268
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 82

* Received rent of $2,826
* Loan payment of $1,405 ($1,689 principal / ($284) interest)
* New loan balance of ($73,546)
* Management fee of $283
* Loan payment of $1,405 ($1,696 principal / ($291) interest)
* New loan balance of ($75,242)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,381
* Net income of $3,110
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,236 ($21,809 YTD)
* $874 of depreciation carried over
* Added net income of $3,110 to personal leaving balance of ($72,288)

---

Owner in month # 82

* Loan payment of $1,141 ($426 principal / $715 interest)
* New loan balance of $201,572
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 82

* Investment grew by $3,290
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 83

* Received rent of $2,826
* Loan payment of $1,405 ($1,703 principal / ($298) interest)
* New loan balance of ($76,945)
* Management fee of $283
* Loan payment of $1,405 ($1,710 principal / ($305) interest)
* New loan balance of ($78,655)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,367
* Net income of $3,124
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,250 ($24,060 YTD)
* $874 of depreciation carried over
* Added net income of $3,124 to personal leaving balance of ($75,412)

---

Owner in month # 83

* Loan payment of $1,141 ($427 principal / $714 interest)
* New loan balance of $201,145
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 83

* Investment grew by $3,312
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Landlord in month # 84

* Received rent of $2,826
* Loan payment of $1,405 ($1,716 principal / ($311) interest)
* New loan balance of ($80,371)
* Management fee of $283
* Loan payment of $1,405 ($1,723 principal / ($318) interest)
* New loan balance of ($82,094)
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance
* Total monthly expenses of $1,354
* Net income of $3,137
* Allowed monthly depreciation of $874 + carry-over of $874
* Taxable income of $2,263 ($26,323 YTD)
* $874 of depreciation carried over
* Added net income of $3,137 to personal leaving balance of ($78,549)

---

Owner in month # 84

* Loan payment of $1,141 ($429 principal / $712 interest)
* New loan balance of $200,716
* Spent $631 on property tax
* Spent $188 on insurance
* Spent $113 on HOA
* Spent $451 on home maintenance

---

Renter in month # 84

* Investment grew by $3,334
* Spent $2,826 on rent
* Spent $17 on renters insurance

---

Year # 7
Rent increased 3.50% to $2,925
Home value increased 3.70% to $373,852
Renters insurance increased 2.00% to $17.23
Home owner's insurance increased 2.00% to $191.45
HOA increased 2.00% to $114.86

---

Landlord in month # 85

* Received rent of $2,925
* Loan payment of $1,405 ($1,730 principal / ($325) interest)
* New loan balance of ($83,824)
* Management fee of $293
* Loan payment of $1,405 ($1,737 principal / ($332) interest)
* New loan balance of ($85,561)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Paid last year's taxes of $6,317
* Total monthly expenses of $7,712
* Net income of $3,250
* Allowed monthly depreciation of $906 + carry-over of $874
* Taxable income of $2,376 ($2,376 YTD)
* $906 of depreciation carried over
* Added net income of $3,250 to personal leaving balance of ($81,799)

---

Owner in month # 85

* Loan payment of $1,141 ($430 principal / $711 interest)
* New loan balance of $200,286
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 85

* Investment grew by $3,356
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 86

* Received rent of $2,925
* Loan payment of $1,405 ($1,744 principal / ($339) interest)
* New loan balance of ($87,305)
* Management fee of $293
* Loan payment of $1,405 ($1,751 principal / ($346) interest)
* New loan balance of ($89,056)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,381
* Net income of $3,264
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,358 ($4,734 YTD)
* $906 of depreciation carried over
* Added net income of $3,264 to personal leaving balance of ($85,063)

---

Owner in month # 86

* Loan payment of $1,141 ($432 principal / $709 interest)
* New loan balance of $199,854
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 86

* Investment grew by $3,379
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 87

* Received rent of $2,925
* Loan payment of $1,405 ($1,758 principal / ($353) interest)
* New loan balance of ($90,814)
* Management fee of $293
* Loan payment of $1,405 ($1,764 principal / ($359) interest)
* New loan balance of ($92,578)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,367
* Net income of $3,278
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,372 ($7,105 YTD)
* $906 of depreciation carried over
* Added net income of $3,278 to personal leaving balance of ($88,341)

---

Owner in month # 87

* Loan payment of $1,141 ($433 principal / $708 interest)
* New loan balance of $199,421
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 87

* Investment grew by $3,401
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 88

* Received rent of $2,925
* Loan payment of $1,405 ($1,771 principal / ($366) interest)
* New loan balance of ($94,349)
* Management fee of $293
* Loan payment of $1,405 ($1,778 principal / ($373) interest)
* New loan balance of ($96,127)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,354
* Net income of $3,291
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,385 ($9,490 YTD)
* $906 of depreciation carried over
* Added net income of $3,291 to personal leaving balance of ($91,632)

---

Owner in month # 88

* Loan payment of $1,141 ($435 principal / $706 interest)
* New loan balance of $198,986
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 88

* Investment grew by $3,424
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 89

* Received rent of $2,925
* Loan payment of $1,405 ($1,786 principal / ($381) interest)
* New loan balance of ($97,913)
* Management fee of $293
* Loan payment of $1,405 ($1,793 principal / ($388) interest)
* New loan balance of ($99,706)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,339
* Net income of $3,306
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,400 ($11,890 YTD)
* $906 of depreciation carried over
* Added net income of $3,306 to personal leaving balance of ($94,938)

---

Owner in month # 89

* Loan payment of $1,141 ($436 principal / $705 interest)
* New loan balance of $198,550
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 89

* Investment grew by $3,447
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 90

* Received rent of $2,925
* Loan payment of $1,405 ($1,800 principal / ($395) interest)
* New loan balance of ($101,506)
* Management fee of $293
* Loan payment of $1,405 ($1,807 principal / ($402) interest)
* New loan balance of ($103,313)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,325
* Net income of $3,320
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,414 ($14,303 YTD)
* $906 of depreciation carried over
* Added net income of $3,320 to personal leaving balance of ($98,258)

---

Owner in month # 90

* Loan payment of $1,141 ($438 principal / $703 interest)
* New loan balance of $198,112
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 90

* Investment grew by $3,470
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 91

* Received rent of $2,925
* Loan payment of $1,405 ($1,814 principal / ($409) interest)
* New loan balance of ($105,127)
* Management fee of $293
* Loan payment of $1,405 ($1,821 principal / ($416) interest)
* New loan balance of ($106,948)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,311
* Net income of $3,334
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,428 ($16,731 YTD)
* $906 of depreciation carried over
* Added net income of $3,334 to personal leaving balance of ($101,592)

---

Owner in month # 91

* Loan payment of $1,141 ($439 principal / $702 interest)
* New loan balance of $197,673
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 91

* Investment grew by $3,493
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 92

* Received rent of $2,925
* Loan payment of $1,405 ($1,828 principal / ($423) interest)
* New loan balance of ($108,776)
* Management fee of $293
* Loan payment of $1,405 ($1,836 principal / ($431) interest)
* New loan balance of ($110,612)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,297
* Net income of $3,348
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,442 ($19,173 YTD)
* $906 of depreciation carried over
* Added net income of $3,348 to personal leaving balance of ($104,940)

---

Owner in month # 92

* Loan payment of $1,141 ($441 principal / $700 interest)
* New loan balance of $197,232
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 92

* Investment grew by $3,516
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 93

* Received rent of $2,925
* Loan payment of $1,405 ($1,843 principal / ($438) interest)
* New loan balance of ($112,455)
* Management fee of $293
* Loan payment of $1,405 ($1,850 principal / ($445) interest)
* New loan balance of ($114,305)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,282
* Net income of $3,363
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,457 ($21,630 YTD)
* $906 of depreciation carried over
* Added net income of $3,363 to personal leaving balance of ($108,303)

---

Owner in month # 93

* Loan payment of $1,141 ($442 principal / $699 interest)
* New loan balance of $196,790
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 93

* Investment grew by $3,539
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 94

* Received rent of $2,925
* Loan payment of $1,405 ($1,857 principal / ($452) interest)
* New loan balance of ($116,162)
* Management fee of $293
* Loan payment of $1,405 ($1,865 principal / ($460) interest)
* New loan balance of ($118,027)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,268
* Net income of $3,377
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,471 ($24,100 YTD)
* $906 of depreciation carried over
* Added net income of $3,377 to personal leaving balance of ($111,680)

---

Owner in month # 94

* Loan payment of $1,141 ($444 principal / $697 interest)
* New loan balance of $196,346
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 94

* Investment grew by $3,563
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 95

* Received rent of $2,925
* Loan payment of $1,405 ($1,872 principal / ($467) interest)
* New loan balance of ($119,899)
* Management fee of $293
* Loan payment of $1,405 ($1,880 principal / ($475) interest)
* New loan balance of ($121,779)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,253
* Net income of $3,392
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,486 ($26,586 YTD)
* $906 of depreciation carried over
* Added net income of $3,392 to personal leaving balance of ($115,072)

---

Owner in month # 95

* Loan payment of $1,141 ($446 principal / $695 interest)
* New loan balance of $195,900
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 95

* Investment grew by $3,587
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Landlord in month # 96

* Received rent of $2,925
* Loan payment of $1,405 ($1,887 principal / ($482) interest)
* New loan balance of ($123,666)
* Management fee of $293
* Loan payment of $1,405 ($1,895 principal / ($490) interest)
* New loan balance of ($125,561)
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance
* Total monthly expenses of $1,238
* Net income of $3,407
* Allowed monthly depreciation of $906 + carry-over of $906
* Taxable income of $2,501 ($29,087 YTD)
* $906 of depreciation carried over
* Added net income of $3,407 to personal leaving balance of ($118,479)

---

Owner in month # 96

* Loan payment of $1,141 ($447 principal / $694 interest)
* New loan balance of $195,453
* Spent $654 on property tax
* Spent $191 on insurance
* Spent $115 on HOA
* Spent $467 on home maintenance

---

Renter in month # 96

* Investment grew by $3,611
* Spent $2,925 on rent
* Spent $17 on renters insurance

---

Year # 8
Rent increased 3.50% to $3,027
Home value increased 3.70% to $387,685
Renters insurance increased 2.00% to $17.57
Home owner's insurance increased 2.00% to $195.28
HOA increased 2.00% to $117.16

---

Landlord in month # 97

* Received rent of $3,027
* Loan payment of $1,405 ($1,902 principal / ($497) interest)
* New loan balance of ($127,463)
* Management fee of $303
* Loan payment of $1,405 ($1,910 principal / ($505) interest)
* New loan balance of ($129,373)
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance
* Paid last year's taxes of $6,981
* Total monthly expenses of $8,262
* Net income of $3,524
* Allowed monthly depreciation of $940 + carry-over of $906
* Taxable income of $2,618 ($2,618 YTD)
* $940 of depreciation carried over
* Added net income of $3,524 to personal leaving balance of ($122,003)

---

Owner in month # 97

* Loan payment of $1,141 ($449 principal / $692 interest)
* New loan balance of $195,004
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance

---

Renter in month # 97

* Investment grew by $3,635
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 98

* Received rent of $3,027
* Loan payment of $1,405 ($1,917 principal / ($512) interest)
* New loan balance of ($131,290)
* Management fee of $303
* Loan payment of $1,405 ($1,925 principal / ($520) interest)
* New loan balance of ($133,215)
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance
* Total monthly expenses of $1,266
* Net income of $3,539
* Allowed monthly depreciation of $940 + carry-over of $940
* Taxable income of $2,599 ($5,217 YTD)
* $940 of depreciation carried over
* Added net income of $3,539 to personal leaving balance of ($125,542)

---

Owner in month # 98

* Loan payment of $1,141 ($450 principal / $691 interest)
* New loan balance of $194,554
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance

---

Renter in month # 98

* Investment grew by $3,659
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 99

* Received rent of $3,027
* Loan payment of $1,405 ($1,932 principal / ($527) interest)
* New loan balance of ($135,147)
* Management fee of $303
* Loan payment of $1,405 ($1,940 principal / ($535) interest)
* New loan balance of ($137,087)
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance
* Total monthly expenses of $1,251
* Net income of $3,554
* Allowed monthly depreciation of $940 + carry-over of $940
* Taxable income of $2,614 ($7,831 YTD)
* $940 of depreciation carried over
* Added net income of $3,554 to personal leaving balance of ($129,096)

---

Owner in month # 99

* Loan payment of $1,141 ($452 principal / $689 interest)
* New loan balance of $194,102
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance

---

Renter in month # 99

* Investment grew by $3,683
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 100

* Received rent of $3,027
* Loan payment of $1,405 ($1,948 principal / ($543) interest)
* New loan balance of ($139,035)
* Management fee of $303
* Loan payment of $1,405 ($1,955 principal / ($550) interest)
* New loan balance of ($140,990)
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance
* Total monthly expenses of $1,235
* Net income of $3,570
* Allowed monthly depreciation of $940 + carry-over of $940
* Taxable income of $2,630 ($10,461 YTD)
* $940 of depreciation carried over
* Added net income of $3,570 to personal leaving balance of ($132,666)

---

Owner in month # 100

* Loan payment of $1,141 ($454 principal / $687 interest)
* New loan balance of $193,648
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance

---

Renter in month # 100

* Investment grew by $3,708
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 101

* Received rent of $3,027
* Loan payment of $1,405 ($1,963 principal / ($558) interest)
* New loan balance of ($142,953)
* Management fee of $303
* Loan payment of $1,405 ($1,971 principal / ($566) interest)
* New loan balance of ($144,924)
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance
* Total monthly expenses of $1,220
* Net income of $3,585
* Allowed monthly depreciation of $940 + carry-over of $940
* Taxable income of $2,645 ($13,106 YTD)
* $940 of depreciation carried over
* Added net income of $3,585 to personal leaving balance of ($136,251)

---

Owner in month # 101

* Loan payment of $1,141 ($455 principal / $686 interest)
* New loan balance of $193,193
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance

---

Renter in month # 101

* Investment grew by $3,733
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 102

* Received rent of $3,027
* Loan payment of $1,405 ($1,979 principal / ($574) interest)
* New loan balance of ($146,903)
* Management fee of $303
* Loan payment of $1,405 ($1,986 principal / ($581) interest)
* New loan balance of ($148,889)
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance
* Total monthly expenses of $1,204
* Net income of $3,601
* Allowed monthly depreciation of $940 + carry-over of $940
* Taxable income of $2,661 ($15,767 YTD)
* $940 of depreciation carried over
* Added net income of $3,601 to personal leaving balance of ($139,852)

---

Owner in month # 102

* Loan payment of $1,141 ($457 principal / $684 interest)
* New loan balance of $192,736
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance

---

Renter in month # 102

* Investment grew by $3,758
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 103

* Received rent of $3,027
* Loan payment of $1,405 ($1,994 principal / ($589) interest)
* New loan balance of ($150,883)
* Management fee of $303
* Loan payment of $1,405 ($2,002 principal / ($597) interest)
* New loan balance of ($152,885)
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance
* Total monthly expenses of $1,189
* Net income of $3,616
* Allowed monthly depreciation of $940 + carry-over of $940
* Taxable income of $2,676 ($18,444 YTD)
* $940 of depreciation carried over
* Added net income of $3,616 to personal leaving balance of ($143,468)

---

Owner in month # 103

* Loan payment of $1,141 ($458 principal / $683 interest)
* New loan balance of $192,278
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance

---

Renter in month # 103

* Investment grew by $3,783
* Spent $3,027 on rent
* Spent $18 on renters insurance

---

Landlord in month # 104

* Received rent of $3,027
* Loan payment of $1,405 ($2,010 principal / ($605) interest)
* New loan balance of ($154,895)
* Management fee of $303
* Loan payment of $1,405 ($2,018 principal / ($613) interest)
* New loan balance of ($156,913)
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance
* Total monthly expenses of $1,173
* Net income of $3,632
* Allowed monthly depreciation of $940 + carry-over of $940
* Taxable income of $2,692 ($21,136 YTD)
* $940 of depreciation carried over
* Added net income of $3,632 to personal leaving balance of ($147,100)
* Sold home for $387,685
* Fixed sales costs of $1,000 and commission of $23,261
* Paid of loan balance of ($156,913)
* Paid depreciation recapture taxes of $20,031
* Paid capital gains taxes of $65,531
* Paid remaining yearly taxes of $5,073
* Closed out personal loan of ($147,100)
* Net home sale proceeds of $576,802
* Total cash on hand of $576,802
* Net present value of ($75,608)

---

Owner in month # 104

* Loan payment of $1,141 ($460 principal / $681 interest)
* New loan balance of $191,818
* Spent $678 on property tax
* Spent $195 on insurance
* Spent $117 on HOA
* Spent $485 on home maintenance
* Sold home for $387,685
* Fixed sales costs of $1,000 and commission of $23,261
* Paid of loan balance of $191,818
* Home sale proceeds of $171,606

---

Renter in month # 104

* Investment grew by $3,808
* Spent $3,027 on rent
* Spent $18 on renters insurance
* Capital gains of $286,883
* Capital gains tax of $43,032
* Cashed out investment of $574,983
* Returned security deposit of $2,300

---

|Default Simulator||
| --- | --: |
|Years|8.70|
|Months|104|
|HomePurchaseAmount|$289,900|
|HomeValue|$387,685|
|OwnerInterestRate|4.25%|
|OwnerLoanYears|30|
|OwnerDownPaymentPercentage|20.00%|
|OwnerDownPayment|$57,980|
|OwnerLoanAmount|$231,920|
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
|LandlordMonthlyPayment|$1,405|
|LandlordManagementFeePercentage|10.00%|
|DepreciationYears|27.50|
|DepreciablePercentage|80.00%|
|ClosingFixedCosts|$500|
|ClosingVariableCostsPercentage|1.50%|
|PropertyTaxPercentage|2.10%|
|InsurancePerMonth|$195|
|HoaPerMonth|$117|
|HomeAppreciationPercentagePerYear|3.70%|
|HomeMaintenancePercentagePerYear|1.50%|
|SalesCommissionPercentage|6.00%|
|SalesFixedCosts|$1,000|
|DiscountRate|8.00%|
|CapitalGainsRate|15.00%|
|MarginalTaxRate|24.00%|
|InflationRate|2.00%|

---

Landlord has total rent of $273,948 (average of $2,634 / month), total expenses of $328,820 (average of $3,162 / month), and has a net worth of $576,802 on an initial investment of $76,236
Net present value of ($75,608)

---

Owner has spent $253,072 (average of $2,433 / month) and has a net worth of $171,606 on an initial investment of $61,959

---

Renter has spent $275,634 (average of $2,650 / month) and has a net worth of $534,251 on an initial investment of $288,100
