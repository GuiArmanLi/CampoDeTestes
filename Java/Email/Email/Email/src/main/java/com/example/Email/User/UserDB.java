package com.example.Email.User;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Repository;

@Repository
public class UserDB {
    List<UserModel> users = new ArrayList<>();

    public UserDB() {
    }

    public List<UserModel> getUsers() {
        return users;
    }

    public void add(UserModel user) {
        users.add(user);
    }

}
