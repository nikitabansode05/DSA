package com.dsa.array;

public class Greenhouse {
    private float temperature;
    private float humidity;
    private float lightIntensity;
    private float co2;
    private float soilMoisture;

    private int rows=2;
    private int columns=5;

    private Greenhouse[][] farm;

    Greenhouse(){
        this.temperature=20;
        this.humidity=100;
        this.lightIntensity=10;
        this.co2=30;
        this.soilMoisture=50;
        this.rows=2;
        this.columns=5;
    }

    public void initializeData(){
        // rows=2;
        // columns=5;
        for(int r=0;r<rows;r++){
            for(int c=0;c<columns;c++){
                farm[r][c].temperature=20;
                farm[r][c].humidity=100;
                farm[r][c].lightIntensity=70;
                farm[r][c].co2=2;
                farm[r][c].soilMoisture=20;
            }
        }
    }

    public void printdata(){
        System.out.println("*********************************************");
        System.out.println("Displaying the data of each greenhouse");
        System.out.println("*********************************************");

        for(int r=0;r<rows;r++){
            for(int c=0;c<columns;c++){
                System.out.println("Data of Greenhouse : [ "+r+"]"+"["+c+"]");
                System.out.println("Temperature : "+temperature+"`C");
                System.out.println("Humidity : "+humidity+"%");
                System.out.println("Light Intensity : "+lightIntensity+"lux");
                System.out.println("CO2 : "+co2+"ppm");
                System.out.println("Soil Moisture : "+soilMoisture+"%");
                System.out.println("***************************************************");
            }
        }
    }
}
