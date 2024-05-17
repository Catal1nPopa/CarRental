export class Client{
    id: number;
    name: string;
    registerDateTime: Date;
    phoneNumber: string;
    rentalCars: number;

    constructor(id: number, name: string,registerDateTime: Date,phoneNumber: string, rentalCars: number)
    {
        this.id = id;
        this.name = name;
        this.registerDateTime = registerDateTime;
        this.phoneNumber = phoneNumber;
        this.rentalCars = rentalCars;
    }
}