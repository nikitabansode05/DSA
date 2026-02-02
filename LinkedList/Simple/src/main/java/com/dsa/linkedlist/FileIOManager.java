package com.dsa.linkedlist;

import java.io.FileOutputStream;
import java.io.ObjectOutputStream;
import java.io.FileInputStream;
import java.io.ObjectInputStream;

public class FileIOManager {
    
    public void serialize(LinkedList list,String filename){
        
        try {
            FileOutputStream fileOutputStream=new FileOutputStream(filename);
            ObjectOutputStream objectStream=new ObjectOutputStream(fileOutputStream);

            objectStream.writeObject(list);
            System.out.println("List saved to file");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public LinkedList deserialize(String filename){
        LinkedList list=new LinkedList();
        try{
            FileInputStream fileOutputStream=new FileInputStream(filename);
            ObjectInputStream objectStream=new ObjectInputStream(fileOutputStream);

            list=(LinkedList)objectStream.readObject();
            System.out.println("List retrived to file");
        }catch(Exception e){
            e.printStackTrace();
        }
        return null;
    }
}
