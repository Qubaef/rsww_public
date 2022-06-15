export type HotelItem = {
  name: string;
  description: string;
  location: string;
  dateFrom: Date;
  dateTo: Date;
  stars: number;
  priceFrom: number;
}

export const exampleHotelItem1: HotelItem = {
  name: "Super hotel",
  description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam aliquet ex vitae enim sodales vehicula. Quisque quis nisl elit. Proin vitae mauris tincidunt neque varius efficitur at non dolor. Etiam a pulvinar erat. Praesent gravida velit sed nisl sagittis, et auctor ligula vestibulum. Sed at elementum tellus. Sed consequat pellentesque accumsan. Maecenas interdum urna in massa suscipit iaculis. In dictum lorem eget massa malesuada, quis molestie nulla venenatis.",
  location: "Dominikana, Santiago De Los Caballeros",
  dateFrom: new Date(),
  dateTo: new Date(),
  stars: 3,
  priceFrom: 1500.50
}

export const exampleHotelItem2: HotelItem = {
  name: "Extra hotel",
  description: "Ut viverra nulla sapien, vitae rutrum urna tristique at. Donec pulvinar luctus lorem, non blandit arcu vulputate quis. Suspendisse potenti. Morbi vitae malesuada urna, at vehicula justo. Praesent facilisis posuere massa sit amet venenatis. Aenean sed nisl quis velit mollis volutpat. Integer egestas id libero a finibus. Donec augue sapien, porta semper dui ut, porttitor iaculis diam. Phasellus varius hendrerit elit, quis semper libero sodales fringilla. Aenean sed mauris sagittis dolor pulvinar condimentum.",
  location: "Grecja, Zakynthos, Tsilivi",
  dateFrom: new Date(),
  dateTo: new Date(),
  stars: 4,
  priceFrom: 2500.99
}
