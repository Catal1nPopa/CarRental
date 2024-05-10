export class RentModel{
    CustomerId: number;
    rentalDays: number;
    idCar: number;
    vehicleTypes: string;

    constructor(CustomerId: number, rentalDays: number,idCar: number,vehicleTypes: string)
        {
            this.CustomerId = CustomerId;
            this.rentalDays = rentalDays;
            this.idCar = idCar;
            this.vehicleTypes = vehicleTypes;
        }
}