package com.example.Email.User;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserService {
    @Autowired
    UserDB users;

    public List<UserModel> getUsers() {
        return users.getUsers();
    }

    public String add(UserModel user) {
        for (UserModel i : users.getUsers()) {
            if (user.getEmail().equalsIgnoreCase(i.getEmail())) {
                return null;
            }
        }

        System.out.println(user.getEmail());
        System.out.println(user.getPassword());

        users.add(user);
        return "user";
    }
}
