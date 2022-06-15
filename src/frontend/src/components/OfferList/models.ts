export enum RoomSize {
  Small = "Small", 
  Medium = "Medium", 
  Large = "Large",
  Apartment = "Apartment", 
  Studio = "Studio"
}

export enum TransportType {
  Own = "Own",
  Train = "Train",
  Bus = "Bus",
  Plane = "Plane"
}

export enum FoodBoardType {
  Full = "Full",
  Half = "Half",
  None = "None",
}

export type Room = {
  id: number; //TODO: only for vue list rendering, wrap it to other type later
  size: RoomSize;
  peopleNumber: number;
};

export type OfferItem = {
  id: string;
  departureFrom: string;
  dateFrom: Date;
  dateTo: Date;
  numberOfDays: number;
  rooms: Room[];
  transportType: TransportType;
  foodBoardType: FoodBoardType;
}

export const exampleOfferItem1 = (id: string) => ({
  id,
  departureFrom: "Opole",
  dateFrom: new Date(),
  dateTo: new Date(),
  numberOfDays: 7,
  rooms: [
    { id: 1, size: RoomSize.Apartment, peopleNumber: 2 },
    { id: 2, size: RoomSize.Medium, peopleNumber: 2 },
  ],
  transportType: TransportType.Plane,
  foodBoardType: FoodBoardType.Full,
});

export const exampleOfferItem2 = (id: string) => ({
  id,
  departureFrom: "Opole",
  dateFrom: new Date(),
  dateTo: new Date(),
  numberOfDays: 14,
  rooms: [
    { id: 1, size: RoomSize.Small, peopleNumber: 1 },
    { id: 2, size: RoomSize.Large, peopleNumber: 1 },
  ],
  transportType: TransportType.Own,
  foodBoardType: FoodBoardType.None,
});
