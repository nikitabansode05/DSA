package com.dsa.array;

import java.util.Random;

public class Farm{

    private Climate  [][] greenhouseClimate =new Climate[2] [3];

    public Farm() {
        // Create a new Climate object for each element in the 2D array
        for (int i = 0; i < greenhouseClimate.length; i++) {
            for (int j = 0; j < greenhouseClimate[i].length; j++) {
                greenhouseClimate[i][j] = new Climate(); // assuming Climate has a default constructor
            }
        }
    }

  
       // Capture random climate data for each cell
    public void CaptureCurrentClimate() {
        Random rand = new Random();
        for (int i = 0; i <  greenhouseClimate.length; i++) {
            for (int j = 0; j <greenhouseClimate[i].length; j++) {

                float temperature = 15 + rand.nextFloat() * 20;      // 15–35 °C
                float humidity = 30 + rand.nextFloat() * 50;         // 30–80 %
                float lightIntensity = 200 + rand.nextFloat() * 800; // 200–1000 lux
                float co2 = 300 + rand.nextFloat() * 400;            // 300–700 ppm
                float soilMoisture = 20 + rand.nextFloat() * 60;     // 20–80 %

                greenhouseClimate[i][j].setClimate(
                    temperature, humidity, lightIntensity, co2, soilMoisture
                );
            }
        }
    }

    // Display all greenhouse climates
    public void displayClimate() {
        for (int i = 0; i < greenhouseClimate.length; i++) {
            for (int j = 0; j < greenhouseClimate[i].length; j++) {
                System.out.println("Greenhouse [" + i + "][" + j + "] ");
                greenhouseClimate[i][j].printdata();

            }
        }
    }

}