import moment from "moment";

export type SearchOptions = {
  destination: string;
  departureFrom: string;
  dateFrom: Date;
  dateTo: Date;
  adultsNumber: number;
  childrenTo3Number: number;
  childrenTo10Number: number;
  childrenTo18Number: number;
};

const defaultDateFrom = moment(new Date()).add(2, "days").toDate();
const defaultDateTo = moment(defaultDateFrom).add(7, "days").toDate();

export const exampleSearchOptions: SearchOptions = {
  destination: "Zanzibar",
  departureFrom: "Gdansk",
  dateFrom: defaultDateFrom,
  dateTo: defaultDateTo,
  adultsNumber: 2,
  childrenTo3Number: 0,
  childrenTo10Number: 0,
  childrenTo18Number: 0,
};
