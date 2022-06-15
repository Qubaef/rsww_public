# Project documentation

## PRICE Calc
price = (transportPriceTo + TransportPriceFrom + HotelPrice + MealPrice) * discount

HotelPrice = Suma z Dla każdego pokoju HotelBasePrice * RoomModifier
transportPrice = (2 - availableSeats/allSeats)*liczba osób
discount = max(0, 10 - liczba dni do odjazdu)*0.025
MealPrice depends on meal type:
* NoMeals = 0
* Breakfast(25,132)
* BreakfastAndDinner(50,264)
* ThreeMeals(100,396)
* AllInclusive(150,512)

## Api gateway
### Offer
* Get
* List-locations
* is-available
* book
* purchase
### Order
* Get
* Get-destination-preferences
* Get-detailed-preferences

### User
* Login
* GetId
* logout

## Event list
### Transport - read
* GetTransportOffers
* IsTransportOfferAvailable
* GetLocations
### Transport - write
* ReserveTransport
* CancelTransport

### Hotel - read
* GetHotelOffers
* GetHotelById
* IsHotelOfferAvailable

### Hotel - write
* ReserveHotel
* CancelHotel

### Offer generator
* GetOffers
* IsOfferAvailable

### Order manager
* BookOrder - SAGA
* PurchaseOrder - SAGA

## Saga definition
### Order
BookOrder
* ReserveRoom / CancelHotel | HotelManager | (Pierwotna/kompensacyjna)
* ReserveTransport / CancelTransport | TransportManager | (Pierwotna/kompensacyjna)
* ReserveTransport / CancelTransport | TransportManager | (Pierwotna/kompensacyjna)
* CreateOrder | OrderManager | Zwrotna
* PerformPayment | PaymantManager | Przestawna
* UpdateOrder | Zwrotna

![image](https://user-images.githubusercontent.com/53475125/167516347-35af2a5b-7066-4ec4-a117-63b88b8db69e.png)

