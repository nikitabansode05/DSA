package com.dsa.array;

public class Climate {
    
    private float temperature;
    private float humidity;
    private float lightIntensity;
    private float co2;
    private float soilMoisture;
    private int rows=2;
    private int columns=5;

    public Climate(){
        this.temperature=0;
        this.humidity=0;
        this.lightIntensity=0;
        this.co2=0;
        this.soilMoisture=0;
    }

    public void setClimate(float temperature, float humidity, float lightIntensity, float co2, float soilMoisture) {
        this.temperature = temperature;
        this.humidity = humidity;
        this.lightIntensity = lightIntensity;
        this.co2 = co2;
        this.soilMoisture = soilMoisture;
    }

    public void printdata(){       
                System.out.println("Temperature : "+temperature+"`C");
                System.out.println("Humidity : "+humidity+"%");
                System.out.println("Light Intensity : "+lightIntensity+"lux");
                System.out.println("CO2 : "+co2+"ppm");
                System.out.println("Soil Moisture : "+soilMoisture+"%");
                System.out.println("***************************************************");
        
    }
}
