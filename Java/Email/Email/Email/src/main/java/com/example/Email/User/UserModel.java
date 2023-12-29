package com.example.Email.User;

import java.util.UUID;

public class UserModel {
    private UUID id;
    private String name;
    private String email;
    private String password;

    public UserModel() {
        this.id = UUID.randomUUID();
    }

    public UserModel(String email, String password) {
        this.id = UUID.randomUUID();
        this.email = email;
        this.password = password;
    }

    public UserModel(String name, String email, String password) {
        this.id = UUID.randomUUID();
        this.name = name;
        this.email = email;
        this.password = password;
    }

    public UUID getId() {
        return id;
    }

    public void setId(UUID id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    @Override
    public String toString() {
        return "UserModel [id=" + id + ", name=" + name + ", email=" + email + ", password=" + password + "]";
    }
}