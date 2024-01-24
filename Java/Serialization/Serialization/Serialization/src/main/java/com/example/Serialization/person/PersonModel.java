package com.example.Serialization.person;

import java.io.Serializable;

public class PersonModel implements Serializable {
    private static final long serialVersionUID = 1L;

    private String name;
    private int age;
    transient int height;
    static String country = "ITALY";

    public static long getSerialversionuid() {
        return serialVersionUID;
    }

    public static String getCountry() {
        return country;
    }

    public static void setCountry(String country) {
        PersonModel.country = country;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }

}
