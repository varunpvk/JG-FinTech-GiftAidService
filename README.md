# FinTech-GiftAidService
FinTech is an imaginary NGO that raises funds through a public funding program called GiftAidService.

GiftAidService is a hosted webapplication, where donors can visit the azure web app and donate money.

As a token of appreciation, GiftAidService calculates the GiftAid for the donated amount and returns a token of giftAid amount based on the following calculation.

The calculation for gift aid is `[Donation Amount] * ( [TaxRate] / (100 - [TaxRate]) )`.

Following are the various endpoints exposed by GiftAidService:

## Donors
* `[Post] /api/donors` - Register a Donor
* `[Get] /api/token` - Retrieve a bearer token

## GiftAid
* `[Get] /api/giftaid` - Get the amount of gift aid reclaimable for donation amount
* `[PUT] /api/donor/add` - Registers the donor details
* `[Get] /api/donor/get` - Finds a donor by ID
    #### Note: This endpoint has a security vulnerability and is a potential source of sql injection. 

