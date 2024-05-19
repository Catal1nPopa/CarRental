export class Inspection{
    carNumber: string;
    dateTime: Date;
    advanceInspection: boolean;

    constructor( carNumber: string, dateTime: Date, advanceInspection: boolean)
    {
        this.carNumber = carNumber;
        this.dateTime = dateTime;
        this.advanceInspection = advanceInspection;
    }
}