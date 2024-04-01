package com.example.Anime.anime;

import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import java.util.List;

@RestController
@RequestMapping("/anime")
class AnimeController {
    @Autowired
    AnimeService service;

    @GetMapping
    public ResponseEntity<List<AnimeModel>> findAll() {
        return service.findAll();
    }

    @GetMapping("/{title}")
    public ResponseEntity<AnimeModel> findById(@PathVariable String title) {
        return service.findByTitle(title);
    }

    @PostMapping
    public ResponseEntity<AnimeModel> save(@RequestBody AnimeModel newAnime) {
        return service.save(newAnime);
    }

    @PutMapping("/title")
    public ResponseEntity<AnimeModel> upDate(@PathVariable String title, @RequestBody AnimeModel updatedAnime) {
        return service.upDate(title, updatedAnime);
    }

    @DeleteMapping("/{title}")
    public ResponseEntity<AnimeModel> delete(@PathVariable String title) {
        return service.delete(title);
    }
}