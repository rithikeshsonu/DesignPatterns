using Composition_LooseCoupling;

Car petrolCar = new Car(new PetrolEngine());
Car electricCar = new Car(new ElectricEngine());
petrolCar.Drive();
electricCar.Drive();