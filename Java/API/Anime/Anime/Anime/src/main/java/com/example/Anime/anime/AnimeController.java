package com.example.Anime.anime;

import org.springframework.web.bind.annotation.RestController;

import java.util.List;
import java.util.UUID;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/anime")
class AnimeController {
    @Autowired
    AnimeService service;

    @GetMapping
    public ResponseEntity<List<AnimeModel>> findAll() {
        return service.findAll();
    }

    // @GetMapping("{title}")
    // public ResponseEntity<AnimeModel> findById(@PathVariable String title) {
    // return
    // ResponseEntity.status(HttpStatus.ACCEPTED).body(service.findByTitle(title));
    // }

    @PostMapping
    public ResponseEntity<AnimeModel> save(@RequestBody AnimeModel newAnime) {
        return service.save(newAnime);
    }

    // @PutMapping()
    // public ResponseEntity<AnimeModel> upDate(@PathVariable UUID id, @RequestBody
    // AnimeModel updatedAnime) {
    // return service.upDate(updatedAnime);
    // }

    @DeleteMapping
    public ResponseEntity<AnimeModel> delete(UUID id) {
        return service.delete(id);
    }
}