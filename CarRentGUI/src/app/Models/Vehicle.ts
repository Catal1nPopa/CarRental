export class Vehicle {
    id: number;
    brand: string;
    carNumber: string;
    model: string;
    year: number;
    distance: number;
    photo: string;
    price: number;
    enginePower: number;
    electricPower!: number;
    batteryCapacity!: number;
    vehicleType: string;

    constructor(
        id: number,
        brand: string,
        carNumber: string,
        model: string,
        year: number,
        distance: number,
        photo: string,
        price: number,
        enginePower: number,
        electricPower: number,
        batteryCapacity: number,
        vehicleType: string
    ) {
        this.id = id;
        this.brand = brand;
        this.carNumber = carNumber;
        this.model = model;
        this.year = year;
        this.distance = distance;
        this.photo = photo;
        this.price = price;
        this.enginePower = enginePower;
        this.electricPower = electricPower;
        this.batteryCapacity = batteryCapacity;
        this.vehicleType = vehicleType;
    }
}
