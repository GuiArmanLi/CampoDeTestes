package com.example.thymeleaf.mangas;

import java.util.UUID;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.servlet.ModelAndView;
import org.springframework.stereotype.Controller;

@Controller
@RequestMapping("/mangas")
public class MangaController {

    @Autowired
    MangaService service;

    @GetMapping
    public ModelAndView getHome() {
        return service.getHome();
    }

    @PostMapping
    public String register(MangaModel manga) {
        return service.register(manga);
    }

    @GetMapping("/{id}")
    public ModelAndView getByName(@PathVariable UUID id) {
        return service.getById(id);
    }

}
