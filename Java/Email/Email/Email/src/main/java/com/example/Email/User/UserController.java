package com.example.Email.User;

import java.net.HttpURLConnection;
import java.util.List;

import org.attoparser.dom.Document;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/user")
@CrossOrigin("*")
public class UserController {
    @Autowired
    UserService service;

    // @GetMapping
    // public ResponseEntity<List<UserModel>> getUsers() {
    // return
    // ResponseEntity.status(HttpURLConnection.HTTP_OK).body(service.getUsers());
    // }

    @GetMapping
    public Document home() {
        return null;
    }

    @PostMapping
    ResponseEntity<String> addUser(String email) {
        System.out.println(email);
        // return
        // ResponseEntity.status(HttpURLConnection.HTTP_OK).body(service.add(user));
        return ResponseEntity.ok().body(email);
    }
}
