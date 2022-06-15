import axios, { AxiosResponse } from "axios";
import Qs from "qs";

const myAxios = axios.create({
  paramsSerializer: (params) => Qs.stringify(params, { arrayFormat: "repeat" }),
});

export type OffersGetResuest = {
  From: string;
  To: string;
  DepartDate: string;
  ReturnDate: string;
  MinAdultsCount: number;
  MinChildrenLT3Count: number;
  MinChildrenLT10Count: number;
  MinChildrenLT18Count: number;
  TransportTypes: number[];
};

export type OfferRoomCounts = {
  small: number;
  medium: number;
  large: number;
  apartment: number;
  studio: number;
};

export type HotelResp = {
  hotelId: number;
  from: string;
  to: string;
  price: number;
  offerRoomCounts: OfferRoomCounts;
};

export type TransportResp = {
  transportId: number;
  dateTime: string;
  from: string;
  to: string;
  price: number;
  allSeats: number;
  transportType: number;
};

export type MealOffer = {
  type: number;
  price: number;
};

export type OfferResp = {
  hotel: HotelResp;
  transportTo: TransportResp;
  transportBack: TransportResp;
  mealOffer: MealOffer;
  basePirce: number;
  discount: number;
  finalPrice: number;
  msg: string;
  hotelMsg: string;
  hotelCounter: number;
  transportToMsg: string;
  transportToCounter: number;
  transportBackMsg: string;
  transportBackCounter: number;
  isAvailable: boolean;
};

export type OfferRestToReply = {
  hotel: HotelResp;
  transportTo: TransportResp;
  transportBack: TransportResp;
  mealOffer: MealOffer;
  basePirce: number;
  discount: number;
  finalPrice: number;
};

export type HotelDataResp = {
  id: string;
  name: string;
  city: string;
  description: string;
  stars: number;
  basePrice: number;
  roomCounts: OfferRoomCounts;
  msg: string;
};

export type FullOfferResp = {
  offer: OfferResp;
  hotelData: HotelDataResp;
};

export function searchOffers(
  req: OffersGetResuest
): Promise<AxiosResponse<FullOfferResp[]>> {
  return myAxios.get("http://localhost:82/offer/get", {
    params: req,
  });
}

export type BookResp = {
  orderId: string;
  success: boolean;
  guid: string;
};

export type PurchaseReq = {
  orderId: string;
  cardNumber: string;
};

const config = {
  withCredentials: true,
};

export function bookOffer(offer: OfferResp): Promise<AxiosResponse<BookResp>> {
  return myAxios.post("http://localhost:82/offer/book", offer, config);
}

export function purchaseOffer(req: PurchaseReq): Promise<boolean> {
  return myAxios
    .post("http://localhost:82/offer/purchase", req, config)
    .then((res) => {
      return res.data;
    })
    .catch((err) => {
      console.log(err);
      return false;
    });
}

export type SimpleHotelResp = {
  hotelId: number;
  from: string;
  to: string;
  price: number;
};

export type ReservationResp = {
  id: number;
  hotelOffer: SimpleHotelResp;
};

export type SimpleTransportResp = {
  to: string;
};

export type OrderResp = {
  id: string;
  isPaid: boolean;
  reservation: ReservationResp;
  transportTo: SimpleTransportResp;
  finalPrice: number;
};

export function getOrders(): Promise<AxiosResponse<OrderResp[]>> {
  return myAxios.get("http://localhost:82/orders/get", config);
}

export function getOrderPrefs() {
  return myAxios.get("http://localhost:82/orders/get-preferences", config);
}

export function getRefreshOffer(req: OfferRestToReply) {
  return myAxios.post("http://localhost:82/offer/refresh-offer", req, config);
}

export function getLocations(): Promise<AxiosResponse<string[]>> {
  return myAxios.get("http://localhost:82/offer/list-locations", config);
}
